 
using System; 


 
					 


 
public class Legolas 


 
{ 


 
	public static void Main() 


 
	{ 


 
		int arrows = 3; 


 
		int enemies = 4; 


 
		 


 
		Console.WriteLine("Legolas faces 4 enemies"); 


 
		 


 
		for(int numberOfArrows = 1; numberOfArrows <= 3; numberOfArrows++) { 


 
			 


 
			arrows--; 


 
			enemies--; 


 
			 


 
			Console.WriteLine("Legolas kills one enemy"); 


 
			 


 
			Console.WriteLine("There are " + enemies + " enemies left"); 


 
		} 


 
		 


 
		if(enemies == 0) { 


 
			Console.WriteLine("Legolas lives"); 


 
		}else { 


 
			Console.WriteLine("Legolas dies"); 


 
		} 


 
	} 


 
} 