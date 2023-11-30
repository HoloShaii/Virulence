using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Virulence;
public class GameLog
{
    private List<string> GameLogList = new()
    {
        "Good to see you, we are dealing with a viral outbreak of enormous proportions... It's up to you to build up a force of people to protect as many citizens as you can manage. We don't even know the extent to which this virus has destroyed civilization, but from what we've seen locally, it doesn't look good..."
    };

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
            if (value > GameLogList.Count)
            {
                _pageNumber = GameLogList.Count;
                return;
            }

            _pageNumber = value;
        }
    }
    public int MaxPageNumber => GameLogList.Count;
    public bool Changed = true;

    public void LogText(string line) => GameLogList.Add(line);
    public string GetLogText()
    {
        Changed = false;
        return GameLogList[_pageNumber - 1];
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
