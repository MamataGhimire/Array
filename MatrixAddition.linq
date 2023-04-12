<Query Kind="Program" />

void Main()
{
	int [][] matrix1 ={new int[]{2,1},
	                   new int[]{5,1}};
    int [][] matrix2 ={new int[]{1,7},
	                   new int[]{1,8}};

	for(int i=0;i<2;i++)
	{
	  for(int j=0;j<2;j++)
	  {
	    int sum=matrix1[i][j]+matrix2[i][j];
		Console.Write(sum);
	  }
	  Console.WriteLine("");
	}
	
	
	
}

// You can define other methods, fields, classes and namespaces here