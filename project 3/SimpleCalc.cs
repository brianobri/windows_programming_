using System;
//Brian O'Briskie 
//HW project 3 SimpleCalc.cs

interface iSimpleCalc 
{ 
	float add (float f1, float f2); 
	float subtract (float f1, float f2);
	float multiply (float f1, float f2);
	float divide (float f1, float f2); 
}



public class SimpleCalc : iSimpleCalc
{	

    public float add (float a, float b)
    {	
        return a+b;
    }

    public float subtract (float a, float b)
    {
        return a-b;
    }

    public float multiply (float a, float b)
    {
        return a*b;
    }

    public float divide (float a, float b)
    {
        return a/b;
    }
}