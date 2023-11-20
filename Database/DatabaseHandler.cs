using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    private NpgsqlConnection _db;
    public NpgsqlConnection DB { get => _db; }

    public DatabaseHandler()
    {
        _db = new NpgsqlConnection(_connectionString);
        _db.Open();
    }

    public List<object[]> Get(string tablename, List<string> columns = null, List<(string column, string value, WhereClauseComparison compare, WhereClauseCombiner combine)> where = null, string customWhere = "")
    {
        if (string.IsNullOrWhiteSpace(tablename)) return null;

        columns ??= new();
        where ??= new();

        StringBuilder commandText = new("SELECT");

        if (columns.Any())
        {
            commandText.Append(' ');
            commandText.Append(string.Join(", ", columns));
            commandText.Append(' ');
        }
        else
        {
            commandText.Append(" * ");
        }

        commandText.Append($"FROM {tablename}");

        if (where.Any())
        {
            for (int i = 0; i < where.Count; i++)
            {
                if (i == 0) commandText.Append(" WHERE ");
                (string column, string value, WhereClauseComparison compare, WhereClauseCombiner combine) = where[i];

                commandText.Append(column);
                commandText.Append(' ');

                commandText.Append(compare switch
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

                commandText.Append(' ');
                commandText.Append(value);
                commandText.Append(' ');

                if (i < where.Count - 1 && combine == WhereClauseCombiner.None) combine = WhereClauseCombiner.And;

                commandText.Append(combine switch
                {
                    WhereClauseCombiner.None => "",
                    WhereClauseCombiner.And => "AND",
                    WhereClauseCombiner.Or => "OR",
                    _ => throw new NotImplementedException("How even??"),
                });

                commandText.Append(' ');
            }
        }
        else if (!string.IsNullOrWhiteSpace(customWhere))
        {
            commandText.Append(' ');
            commandText.Append(customWhere);
        }
        commandText.Append(';');

        NpgsqlCommand command = new()
        {
            Connection = _db,
            CommandText = commandText.ToString()
        };

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
