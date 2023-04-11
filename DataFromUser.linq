<Query Kind="Program" />

void Main()
{   
    Console.WriteLine("no.of row");
	int row=Convert.ToInt32(Console.ReadLine());
	Console.WriteLine("no.of column");
	int column=Convert.ToInt32(Console.ReadLine());
	int [,] num =new int [row,column];
	
	input(num, row,column);
	output(num, row,column);
	
	
	
	
	
}

 //You can define other methods, fields, classes and namespaces here
  void input(int [,] num,int row,int column)
 {
Console.WriteLine("enter your element for the array");
	for(int i=0;i<row ;i++)
	{
	   for (int j=0;j<column;j++)
	   {
	      int element=Convert.ToInt32(Console.ReadLine());
		  num[i,j]=element;
	   }
	}
	    
 }
 
 void output(int [,] num,int row,int column)
 {
    for(int i=0;i<row ;i++)
	{
	   for (int j=0;j<column;j++)
	   {
	      int element=Convert.ToInt32(Console.ReadLine());
		  num[i,j]=element;
	   }
	}
	
 }
 
 
 
	
	
	
	