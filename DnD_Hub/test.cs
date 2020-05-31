using System.Collections.Generic;

public class Solution
{
    public int fresh = 0;
    //Establish queue for BFS
    public Queue<int[]> rottedOranges = new Queue<int[]>();
    public int OrangesRotting(int[][] grid)
    {
        //Check to make sure the evaluation is valid
        if (grid == null || grid.Length == 0)
            return -1;

        //Initialize variables - don't want to waste time constantly rechecking these
        int rows = grid.Length;
        int columns = grid[0].Length;

        //Scan through array and "categorize" oranges
        for (int i = 0; i < rows; i++) //rows
        {
            for (int j = 0; j < columns; j++) //columns
            {
                if (grid[i][j] == 1) //Count total fresh oranges
                    fresh++;
                else if (grid[i][j] == 2) //Check rotten oranges
                    rottedOranges.Enqueue(new int[] { i, j }); //Add them to the queue to evaluate
            }
        }

        int minutes = 0; //start with minutes = 0

        while (fresh > 0) //While there are remaining fresh oranges to check
        {
            int rottedQueue = rottedOranges.Count; //check how many rotten oranges are in the queue
            minutes++; //increment minute
            if (rottedQueue == 0 && fresh > 0) //If there are still fresh oranges, but no more rotten, return -1
                return -1;
            while (rottedQueue > 0) //While there are rotten oranges to BFS
            {
                rottedQueue--; //Reduce the queue timere
                var coord = rottedOranges.Dequeue(); //Get the orange out of the queue
                var x = coord[0];
                var y = coord[1];
                //Check 4 surrounding directions
                CheckNearby(x + 1, y, grid);
                CheckNearby(x - 1, y, grid);
                CheckNearby(x, y + 1, grid);
                CheckNearby(x, y - 1, grid);
            }
        }
        return minutes;

    }

    public void CheckNearby(int x, int y, int[][] grid)
    {
        if (x >= 0 && y >= 0 && y < grid[0].Length && x < grid.Length && grid[x][y] == 1) //If the coordinate is valid, i.e. in the gris
        {
            if (grid[x][y] == 1) //If fresh, make it rotten
            {
                grid[x][y] = 2;
                rottedOranges.Enqueue(new int[] { x, y }); //Add a new orange to check
                fresh--; //One less fresh orange 
            }
        }
    }
}

