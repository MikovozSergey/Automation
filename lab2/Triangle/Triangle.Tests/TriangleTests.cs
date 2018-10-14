using System;

using NUnit.Framework;


namespace Triangle.Tests
{
    
			[TestFixture]
    
public class TriangleTests
{
       
			[TestCase(7, 7, 7, ExpectedResult = true)]
        
			[TestCase(6, 7, 7, ExpectedResult = true)]
        
			[TestCase(21, 23, 22, ExpectedResult = true)]
       
			[TestCase(1, 3, 10, ExpectedResult = true)]
        
			[TestCase(11, 10, 96, ExpectedResult = true)]
        
			[TestCase(2, 13, 5, ExpectedResult = true)]
        
			[TestCase(57, 10, 10, ExpectedResult = true)]
        
			[TestCase(2.312, 7.012, 10.056, ExpectedResult = true)]
       
public bool Triangle_InputNumbers_True(double a, double b, double c)
           
	 => Triangle.IsTriangle(a, b, c);

        
			[TestCase(5, 10, 15, ExpectedResult = false)]
       
			[TestCase(3, 2, 1, ExpectedResult = false)]
        
			[TestCase(2.5, 4.6, 12.3, ExpectedResult = false)]
       
			[TestCase(3, 8, 5, ExpectedResult = false)]
        
public bool Triangle_InputNumbers_False(double a, double b, double c)
           
			=> Triangle.IsTriangle(a, b, c);

        
			[TestCase(-3, 2, 3)]
        
			[TestCase(3, -2, 3)]
        
			[TestCase(3, 3, -3)]
        
public void Triangle_IncorrectNumbers_ThrowsArgumentException(double a, double b, double c)
                
	=> Assert.Throws<ArgumentException>(() => Triangle.IsTriangle(a, b, c));
    
			}

}
