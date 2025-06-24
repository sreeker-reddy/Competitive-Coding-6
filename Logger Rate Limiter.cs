/*
  Time complexity: O(1) Amortized
  Space complexity: O(n)

  Code ran successfully on Leetcode: Yes

*/

public class Pair
{
    public string message;
    public int timestamp;

    public Pair(string message, int timestamp)
    {
        this.message = message;
        this.timestamp = timestamp;
    }
}

public class Logger {
    private LinkedList<Pair> msgQueue;
    private HashSet<string> msgSet;

    public Logger() {
        msgQueue = new();
        msgSet = new();
    }
    
    public bool ShouldPrintMessage(int timestamp, string message) {
        while(msgQueue.Count>0)
        {
            Pair head = msgQueue.Last.Value;
            if(timestamp-head.timestamp>=10)
            {
                msgQueue.Remove(head);
                msgSet.Remove(head.message);
            }
            else
                break;
        }

        if(!msgSet.Contains(message))
        {
            Pair temp = new Pair(message, timestamp);
            msgQueue.AddFirst(temp);
            msgSet.Add(message);
            return true;
        }
        return false;
    }
}

/**
 * Your Logger object will be instantiated and called as such:
 * Logger obj = new Logger();
 * bool param_1 = obj.ShouldPrintMessage(timestamp,message);
 */
