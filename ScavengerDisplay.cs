using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Virulence.Objects;

namespace Virulence;
public class ScavengerDisplay
{
    private List<Scavenger[]> ScavengerDisplayList = new();

    private int _pageNumber = 1;
    public int PageNumber
    {
        get => _pageNumber;
        set
        {
            if (value < 1)
            {
                _pageNumber = 1;
                return;
            }
            if (value > ScavengerDisplayList.Count)
            {
                _pageNumber = ScavengerDisplayList.Count;
                return;
            }

            _pageNumber = value;
        }
    }
    public int MaxPageNumber => ScavengerDisplayList.Count;
    public bool Changed = true;
    public bool NeedsUpdate = true;

    public void UpdateScavengers(List<Scavenger> scavengers)
    {
        ScavengerDisplayList.Clear();
        ScavengerDisplayList.AddRange(scavengers.Chunk(6));
        if (ScavengerDisplayList.Count == 0) ScavengerDisplayList.Add(Array.Empty<Scavenger>());
        NeedsUpdate = false;
        Changed = true;
    }

    public string[] GetScavengerNames()
    {
        Changed = false;
        return ScavengerDisplayList[_pageNumber - 1].Select(x => x.Name).ToArray();
    }

    public void NextPage()
    {
        PageNumber++;
        Changed = true;
    }

    public void PreviousPage()
    {
        PageNumber--;
        Changed = true;
    }
}
