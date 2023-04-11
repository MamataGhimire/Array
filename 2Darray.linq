<Query Kind="Program" />

void Main()
{   
	int [,]num={{1,2,3},{5,6,7},{9,1,5},{1,4,3},{6,7,8}};//decleration with initialization

   for (int i=0;i<num.GetLength(0);i++)
    {
      for (int j=0;j<num.GetLength(1);j++)
	   {
	     Console.Write(num[i,j]);
	   }
	 Console.WriteLine();
   }
   
   //	foreach (int i in num)
   //{
   //  Console.WriteLine(i);
   //

    string[,]name=new string[2,2];
	
   for(int i=0;i<2;i++)
	{
	  for(int j=0;j<2;j++)
	   {
		 Console.WriteLine("name");
		 string names=Console.ReadLine();
		 name[i,j]=names;
		}
	 }
	  
   for (int i=0;i<name.GetLength(0);i++)
    {
     for (int j=0;j<name.GetLength(1);j++)
	  {
	    Console.Write(name[i,j]+"  ");
	  }
	 Console.WriteLine();
    }


}


// You can define other methods, fields, classes and namespaces here