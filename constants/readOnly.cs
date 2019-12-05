using System; 
  
public class readOnlyIllustration { 
  
    // readonly variables 
    public const int myvar1=0; 
    public readonly int myvar2; //default
  
    public readOnlyIllustration(int a, int b) 
    {   
		//Before modified by constructor
        Console.WriteLine("Value of myvar1 :"+ myvar1 +"  Value of myvar2 :"+ myvar2); 
       
		//myvar1 = a;  //compilation error
        myvar2 = b; 
		Console.WriteLine("Value of myvar1 :"+ myvar1 +"  Value of myvar2 :"+ myvar2); 
		
		//Can be changed once set
		//myvar1 = a+2;  //compilation error 
		myvar2 = b+2; 
		Console.WriteLine("Value of myvar1 :"+ myvar1 +"  Value of myvar2 :"+ myvar2); 
		
    } 
  
    // Main method 
    public static void Main() 
    { 
        readOnlyIllustration obj1 = new readOnlyIllustration(10, 20); 
    } 
} 