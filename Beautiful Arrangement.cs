/*
  Time complexity: O(k) where k is the number of permutations that are beautiful arrangements
  Space complexity: O(n)

  Code ran successfully on Leetcode: Yes
*/

public class Solution {
    int count;
    public int CountArrangement(int n) { //n=2
        count = 0;
        bool[] visited = new bool[n+1]; //bool[3]
        helper(visited,n,1);
        return count;
    }

    private void helper(bool[] visited, int n, int running)
    {
        //base
        if(running>n) //1<2
        {
            count++; //count = 1,2
            return;
        }
        //logic
        for(int i=1;i<=n;i++)
        {
            if(!visited[i] && (i%running==0 || running%i==0))
            {
                visited[i]=true;
                helper(visited,n,running+1); //helper(visited,2,2) 
                visited[i]=false;
            }
        }
    }
}
