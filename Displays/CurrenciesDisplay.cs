using BreakEternity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Virulence.Objects;

namespace Virulence;
public class CurrenciesDisplay
{
    private Dictionary<string, BigDouble> CurrenciesList = new();

    public bool Changed = true;
    public bool NeedsUpdate = true;

    public void UpdateCurrencies(Dictionary<string, BigDouble> scavengers)
    {
        NeedsUpdate = false;
        CurrenciesList.Clear();
        foreach (KeyValuePair<String, BigDouble> kvp in scavengers)
        {
            CurrenciesList.Add(kvp.Key, kvp.Value);
        }
        Changed = true;
    }

    public string GetCurrenciesText()
    {
        Changed = false;
        StringBuilder sb = new();
        foreach (KeyValuePair<String, BigDouble> kvp in CurrenciesList)
        {
            sb.AppendLine($"{kvp.Key}: {kvp.Value}{Environment.NewLine}");
        }
        return sb.ToString();
    }

}
