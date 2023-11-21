using Npgsql;
using System.Text;

namespace Virulence.Database;
public class DatabaseHandler : IDisposable
{
    public enum WhereClauseComparison
    {
        Unknown = 0,
        Equals,
        NotEquals,
        Greater,
        Less,
        GreaterOrEqual,
        LessOrEqual,
    }
    public enum WhereClauseCombiner
    {
        None = 0,
        And,
        Or
    }

    private const string _connectionString = "Server=localhost;Port=5432;User Id=postgres;Password=3bubDr@K4W6*pvQQDCYj@@kQ;Database=Virulence;";
    private readonly NpgsqlConnection _db;
    public NpgsqlConnection DB => _db;

    private int _rowsAffectedLastQuery;
    public int RowsAffectedLastQuery => _rowsAffectedLastQuery;

    public DatabaseHandler()
    {
        _db = new NpgsqlConnection(_connectionString);
        _db.Open();
    }

    public List<object[]> ExecuteQuery(string query)
    {
        if (string.IsNullOrWhiteSpace(query)) return null;

        NpgsqlCommand command = new()
        {
            Connection = _db,
            CommandText = query
        };

        try
        {
            NpgsqlDataReader dataReader = command.ExecuteReader();
            List<object[]> rows = new();
            while (dataReader.Read())
            {
                object[] row = new object[dataReader.FieldCount];
                dataReader.GetValues(row);
                rows.Add(row);
            }
            dataReader.Close();

            return rows;
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex);
            return null;
        }
    }

    public bool ExecuteVoidQuery(string query)
    {
        if (string.IsNullOrWhiteSpace(query)) return false;

        NpgsqlCommand command = new()
        {
            Connection = _db,
            CommandText = query
        };
        try 
        {
            _rowsAffectedLastQuery = command.ExecuteNonQuery();
            return true;
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex);
            return false;
        }
    }

    public List<object[]> Get(string tableName, List<string> columns = null, List<(string column, string value, WhereClauseComparison compare, WhereClauseCombiner combine)> where = null, string customWhere = "")
    {
        if (string.IsNullOrWhiteSpace(tableName)) return null;

        columns ??= new();
        where ??= new();

        StringBuilder commandText = new("SELECT");

        if (columns.Any())
        {
            commandText.Append(' ')
                       .Append(string.Join(", ", columns))
                       .Append(' ');
        }
        else
        {
            commandText.Append(' ')
                       .Append('*')
                       .Append(' ');
        }

        commandText.Append("FROM")
                   .Append(' ')
                   .Append(tableName);

        if (where.Any())
        {
            commandText.Append(ConstructWhere(where));
        }
        else if (!string.IsNullOrWhiteSpace(customWhere))
        {
            commandText.Append(' ')
                       .Append(customWhere);
        }
        commandText.Append(';');

        return ExecuteQuery(commandText.ToString());
    }

    public bool Insert(string tableName, List<string> columns = null, List<string> values = null)
    {
        if (string.IsNullOrWhiteSpace(tableName)) return false;
        if (values?.Any() ?? false) return false;
        columns ??= new();
        if (columns.Any() && columns.Count != values.Count) return false;

        StringBuilder commandText = new("INSERT INTO");

        commandText.Append(' ')
                   .Append(tableName);

        if (columns.Any())
        {
            commandText.Append(' ')
                       .Append('(')
                       .Append(string.Join(", ", columns))
                       .Append(')');
        }

        commandText.Append(' ')
                   .Append("VALUES")
                   .Append(' ')
                   .Append('(')
                   .Append(string.Join(", ", values))
                   .Append(')')
                   .Append(';');

        return ExecuteVoidQuery(commandText.ToString());
    }

    public bool Update(string tableName, List<string> columns = null, List<string> values = null, List<(string column, string value, WhereClauseComparison compare, WhereClauseCombiner combine)> where = null, string customWhere = "")
    {
        if (string.IsNullOrWhiteSpace(tableName)) return false;
        if (values?.Any() ?? false) return false;
        if (columns?.Any() ?? false) return false;
        if (columns.Any() && columns.Count != values.Count) return false;

        StringBuilder commandText = new("UPDATE");

        commandText.Append(' ')
                   .Append(tableName);

        commandText.Append(' ')
                   .Append("SET")
                   .Append(' ');

        for (int i = 0; i < columns.Count; i++)
        {
            commandText.Append(string.Format("{0} = {1}", columns[i], values[i]));
        }
                   
        if (where.Any())
        {
            commandText.Append(ConstructWhere(where));
        }
        else if (!string.IsNullOrWhiteSpace(customWhere))
        {
            commandText.Append(' ')
                       .Append(customWhere);
        }

        commandText.Append(';');

        return ExecuteVoidQuery(commandText.ToString());
    }

    public bool Delete(string tableName, List<(string column, string value, WhereClauseComparison compare, WhereClauseCombiner combine)> where = null, string customWhere = "")
    {
        if (string.IsNullOrWhiteSpace(tableName)) return false;

        where ??= new();

        StringBuilder commandText = new("DELETE FROM");

        commandText.Append(' ')
                   .Append(tableName);

        if (where.Any())
        {
            commandText.Append(ConstructWhere(where));
        }
        else if (!string.IsNullOrWhiteSpace(customWhere))
        {
            commandText.Append(' ')
                       .Append(customWhere);
        }
        commandText.Append(';');

        return ExecuteVoidQuery(commandText.ToString());
    }

    private string ConstructWhere(List<(string column, string value, WhereClauseComparison compare, WhereClauseCombiner combine)> where)
    {
        StringBuilder whereBuilder = new StringBuilder();
        for (int i = 0; i < where.Count; i++)
        {
            if (i == 0)
            {
                whereBuilder.Append(' ')
                           .Append("WHERE")
                           .Append(' ');
            }
            (string column, string value, WhereClauseComparison compare, WhereClauseCombiner combine) = where[i];

            whereBuilder.Append(column)
                       .Append(' ');

            whereBuilder.Append(compare switch
            {
                WhereClauseComparison.Unknown => throw new NotImplementedException("Where clause cannot be Unknown!"),
                WhereClauseComparison.Equals => '=',
                WhereClauseComparison.NotEquals => "<>",
                WhereClauseComparison.Greater => '>',
                WhereClauseComparison.Less => '<',
                WhereClauseComparison.GreaterOrEqual => "<=",
                WhereClauseComparison.LessOrEqual => ">=",
                _ => throw new NotImplementedException("How even??"),
            });

            whereBuilder.Append(' ')
                       .Append(value)
                       .Append(' ');

            if (i < where.Count - 1 && combine == WhereClauseCombiner.None) combine = WhereClauseCombiner.And;

            whereBuilder.Append(combine switch
            {
                WhereClauseCombiner.None => "",
                WhereClauseCombiner.And => "AND",
                WhereClauseCombiner.Or => "OR",
                _ => throw new NotImplementedException("How even??"),
            });

            whereBuilder.Append(' ');
        }

        return whereBuilder.ToString();
    }

    protected virtual void Dispose(Boolean disposing)
    {
        _db.Close();
        if (disposing)
        {
            // TODO: dispose managed state (managed objects)
            _db.Dispose();
        }

        // TODO: free unmanaged resources (unmanaged objects) and override finalizer
        // TODO: set large fields to null
    }

    ~DatabaseHandler()
    {
        // Do not change this code. Put cleanup code in 'Dispose(bool disposing)' method
        Dispose(disposing: false);
    }

    public void Dispose()
    {
        // Do not change this code. Put cleanup code in 'Dispose(bool disposing)' method
        Dispose(disposing: true);
        GC.SuppressFinalize(this);
    }
}
