<Query Kind="Program" />

void Main()
{
	List<List<int>>ValueAdd=new List<List<int>>();
	{
	   ValueAdd.Add(new List<int>{2,-3,-5});
	   ValueAdd.Add(new List<int>{6,-2,10});
	   ValueAdd.Add(new List<int>{4,1,1});
	}
	
	int Count=ValueAdd.Count;
	int LToR=0;
	
	  for(int i=0;i<Count;i++)
	  {
	    LToR=LToR+ValueAdd[i][i];
	  }
	 
	  
	int RToL=0;
	  for(int i=0;i<Count;i++)
	  {
	   RToL=RToL+ValueAdd[i][--Count];
	     
	  }
	    
	
	int sub=LToR-RToL;
	  if (sub<0)
	  {
	   Console.WriteLine(sub*(-1));
	  }
	  else
	  {
	    Console.WriteLine(sub);
	  }
}

// You can define other methods, fields, classes and namespaces here