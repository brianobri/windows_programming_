using System;
//Brian O'Briskie 
//HW project 3 ComplexCalc.cs 


interface iComplexCalc 
{
	cFloat add (cFloat c1, cFloat c2); 
	cFloat subtract (cFloat c1, cFloat c2); 
	cFloat multiply (cFloat c1, cFloat c2); 
	cFloat divide (cFloat c1, cFloat c2);
}


public class ComplexCalc : iComplexCalc
{


    public cFloat add(cFloat a, cFloat b)
    {
            float real, imag;
            real = a.getReal() + b.getReal();
            imag = a.getImg() + b.getImg();
            cFloat c = new cFloat(real, imag);
            return c;

    }

    public cFloat subtract (cFloat a, cFloat b)
    {
            float real, imag;
            real = a.getReal() - b.getReal();
            imag = a.getImg() - b.getImg();
            cFloat c = new cFloat(real, imag);
            return c;
    }

    public cFloat multiply (cFloat a, cFloat b)
    {
            float real, imag;
            real = a.getReal() * b.getReal();
            imag = a.getImg() * b.getImg();
            cFloat c = new cFloat(real, imag);
            return c;
    }

    public cFloat divide (cFloat a, cFloat b)
    {
            float real, imag;
            real = a.getReal() / b.getReal();
            imag = a.getImg() / b.getImg();
            cFloat c = new cFloat(real, imag);
            return c;
    }

}


public class cFloat 
{
	float real;
	float img;

	public cFloat(float r, float i)
	{
		real = r; img = i;
	}

	public float getReal()
	{
		return real;
	}

	public void setReal (float r) 
	{
		real = r;
	}

	public float getImg() 
	{
		return img;
	}

	public void setImg (float i)
	{
		img = i;
	}
}
