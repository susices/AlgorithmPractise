// See https://aka.ms/new-console-template for more information

using AlgorithmPractise.LeetCode;

Console.WriteLine("Hello, World!");
// 声明一个二维数组 [[2,1,1],[1,1,0],[0,1,1]]
int[][] grid = new int[3][];
grid[0] = new int[3] {2, 1, 1};
grid[1] = new int[3] {1, 1, 0};
grid[2] = new int[3] {0, 1, 1};
var result =  new LeetCodeQ994().OrangesRotting(grid);
Console.WriteLine(result);