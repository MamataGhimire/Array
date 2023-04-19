<Query Kind="Program" />

void Main()
{
	
  Console.WriteLine("enter the size of matrix1");
  int row1=Convert.ToInt32(Console.ReadLine());
  int column1=Convert.ToInt32(Console.ReadLine());


   Console.WriteLine("enter the size of matrix2");
  int row2=Convert.ToInt32(Console.ReadLine());
  int column2=Convert.ToInt32(Console.ReadLine());
  
  
  int [][]matrix1=new int [row1][];
  int [][]matrix2=new int [row2][];
   int [][]result=new int [row1][];
  
  if (column1!=row2)
  {
     Console.WriteLine("this matix cannot be multipled " );
  }
  
  
  else
  {
     Console.WriteLine("enter the elements of matrix1");
    for (int i=0;i<row1;i++)
	{ 
	 for(int j=0;j<column1;j++)
	 {
	 int element=Convert.ToInt32(Console.ReadLine());
	 
	 matrix1[i][j]=element;
	 }
    }
	
	
     Console.WriteLine("enter the elements of matrix2");
    for (int i=0;i<row2;i++)
	{ 
	 for(int j=0;j<column2;j++)
	 {
	 int element=Convert.ToInt32(Console.ReadLine());
	 matrix2[i][j]=element;
	 }
	 
	 for(int s=0;s<row1;s++)
	 {
	   for(int j=0;j<column2;j++)
	   {
	     int sum=0;
	      for(int h=0;h<column1;h++)
		  {
		    sum=sum+matrix1[i][h] *matrix2[h][j];
		  }
		  
		  result[i][j]=sum;
	   }
	 }
	 
	 for(int p=0;p<row1;p++)
	 {
	 for(int j=0;j<column2;j++)
	 {
	 Console.Write(result[i][j]);
	 }
	 Console.WriteLine("");
	 }
    }
}

}

// You can define other methods, fields, classes and namespaces here