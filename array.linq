<Query Kind="Program" />

void Main()
{
	string[] students = new string[4];
	for(int i=0;i<4;i++)
	{
	   Console.WriteLine("enter the value of "+i+"element of the array");
	   string name=Console.ReadLine();
	   students[i]=name;
	}
	for(int i=0;i<4;i++)
	{
	   Console.WriteLine(" the value of "+i+"element of the array :"+ students[i]);
	   
	}
	int []marks={1,2,3,4};//decleration with initialization
	for(int i=0;i<4;i++)
	{
	   Console.WriteLine(" the value of "+i+"element of the array :"+ marks[i]);
	   
	}
	
}

// You can define other methods, fields, classes and namespaces here