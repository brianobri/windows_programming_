using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Reflection;

public partial class proj2 : System.Web.UI.Page
{
    Assembly assem;

    protected void Page_Load(object sender, EventArgs e)
    {
        assem = Assembly.LoadFrom("Calc.dll");
    }

    protected void Button1_Click(object sender, EventArgs e)
    {

       List<string> selectedValues = CheckBoxList1.Items.Cast<ListItem>()
          .Where(li => li.Selected)
          .Select(li => li.Value)
          .ToList();

       if (selectedValues.Contains("add"))
       {
           adds.Visible = true;
       }

       if (selectedValues.Contains("sub"))
       {
          subs.Visible = true;
       }

       if (selectedValues.Contains("mult"))
       {
           mults.Visible = true;
       }

       if (selectedValues.Contains("divide"))
       {
          divs.Visible = true;
       }

       if (CheckBoxList1.SelectedIndex >= 0)
       {
           AddSimpleControls();
       }

       List<string> selectedValues2 = CheckBoxList2.Items.Cast<ListItem>()
       .Where(li => li.Selected)
       .Select(li => li.Value)
       .ToList();

       if (selectedValues2.Contains("addcomp"))
       {
            addComp.Visible = true;
       }

       if (selectedValues2.Contains("subcomp"))
       {
            subComp.Visible = true;
        }

       if (selectedValues2.Contains("multcomp"))
       {
            multComp.Visible = true;
        }

       if (selectedValues2.Contains("divcomp"))
       {
            divComp.Visible = true;
        }

       if (CheckBoxList2.SelectedIndex >= 0)
       {
           AddComplexControls();
       }


   }



   public void AddSimpleControls()
   {
       TextBox1.Visible = true;
       TextBox2.Visible = true;
       TextBox3.Visible = true;
    }

    public void AddComplexControls()
    {

        TextBox4.Visible = true;
        TextBox5.Visible = true;
        TextBox6.Visible = true;
        TextBox7.Visible = true;
        TextBox8.Visible = true;
        TextBox9.Visible = true;

    }




    protected void adds_Click(object sender, EventArgs e)
    {
        string x, y;
        float a, b;
        x = TextBox1.Text;
        y = TextBox2.Text;
        a = float.Parse(x);
        b = float.Parse(y);

        Type classtype = assem.GetType("SimpleCalc");
        Object obj = Activator.CreateInstance(classtype);
        MethodInfo myMethodInfo = classtype.GetMethod("add");
        object[] mParam = new object[] { a, b };
        float flOut = (float)myMethodInfo.Invoke(obj, mParam);

        //c = a + b;
        TextBox3.Text = flOut.ToString();
    }

    protected void subs_Click(object sender, EventArgs e)
    {
        string x, y;
        float a, b, c;
        x = TextBox1.Text;
        y = TextBox2.Text;
        a = float.Parse(x);
        b = float.Parse(y);

        Type classtype = assem.GetType("SimpleCalc");
        Object obj = Activator.CreateInstance(classtype);
        MethodInfo myMethodInfo = classtype.GetMethod("subtract");
        object[] mParam = new object[] { a, b };
        float flOut = (float)myMethodInfo.Invoke(obj, mParam);

        // c = a - b;
        TextBox3.Text = flOut.ToString();
    }

    protected void mults_Click(object sender, EventArgs e)
    {
        string x, y;
        float a, b, c;
        x = TextBox1.Text;
        y = TextBox2.Text;
        a = float.Parse(x);
        b = float.Parse(y);

        Type classtype = assem.GetType("SimpleCalc");
        Object obj = Activator.CreateInstance(classtype);
        MethodInfo myMethodInfo = classtype.GetMethod("multiply");
        object[] mParam = new object[] { a, b };
        float flOut = (float)myMethodInfo.Invoke(obj, mParam);
        //c = a * b;
        TextBox3.Text = flOut.ToString();
    }

    protected void divs_Click(object sender, EventArgs e)
    {
        string x, y;
        float a, b, c;
        x = TextBox1.Text;
        y = TextBox2.Text;
        a = float.Parse(x);
        b = float.Parse(y);

        Type classtype = assem.GetType("SimpleCalc");
        Object obj = Activator.CreateInstance(classtype);
        MethodInfo myMethodInfo = classtype.GetMethod("divide");
        object[] mParam = new object[] { a, b };
        float flOut = (float)myMethodInfo.Invoke(obj, mParam);
        //c = a / b;
        TextBox3.Text = flOut.ToString();
    }

    protected void addComp_Click(object sender, EventArgs e)
    {
        string x, y, q, w;

        x = TextBox4.Text;
        y = TextBox5.Text;
        q = TextBox7.Text;
        w = TextBox8.Text;

        object[] newobj = new object[2];
        newobj[0] = new cFloat(Convert.ToSingle(x), Convert.ToSingle(y));
        newobj[1] = new cFloat(Convert.ToSingle(q), Convert.ToSingle(w));

        Type classtype = assem.GetType("ComplexCalc");
        Object obj = Activator.CreateInstance(classtype);
        MethodInfo myMethodInfo = classtype.GetMethod("add");
        object[] mParam = new object[] { newobj[0], newobj[1] };
        cFloat flOut = (cFloat)myMethodInfo.Invoke(obj, mParam);

        float realfl = flOut.getReal();
        float imfl = flOut.getImg();
        TextBox6.Text = realfl.ToString();
        TextBox9.Text = imfl.ToString();
 
    }

    protected void subComp_Click(object sender, EventArgs e)
    {
        string x, y, q, w;

        x = TextBox4.Text;
        y = TextBox5.Text;
        q = TextBox7.Text;
        w = TextBox8.Text;

        object[] newobj = new object[2];
        newobj[0] = new cFloat(Convert.ToSingle(x), Convert.ToSingle(y));
        newobj[1] = new cFloat(Convert.ToSingle(q), Convert.ToSingle(w));

        Type classtype = assem.GetType("ComplexCalc");
        Object obj = Activator.CreateInstance(classtype);
        MethodInfo myMethodInfo = classtype.GetMethod("subtract");
        object[] mParam = new object[] { newobj[0], newobj[1] };
        cFloat flOut = (cFloat)myMethodInfo.Invoke(obj, mParam);

        float realfl = flOut.getReal();
        float imfl = flOut.getImg();
        TextBox6.Text = realfl.ToString();
        TextBox9.Text = imfl.ToString();
    }

    protected void multComp_Click(object sender, EventArgs e)
    {
        string x, y, q, w;

        x = TextBox4.Text;
        y = TextBox5.Text;
        q = TextBox7.Text;
        w = TextBox8.Text;

        object[] newobj = new object[2];
        newobj[0] = new cFloat(Convert.ToSingle(x), Convert.ToSingle(y));
        newobj[1] = new cFloat(Convert.ToSingle(q), Convert.ToSingle(w));

        Type classtype = assem.GetType("ComplexCalc");
        Object obj = Activator.CreateInstance(classtype);
        MethodInfo myMethodInfo = classtype.GetMethod("multiply");
        object[] mParam = new object[] { newobj[0], newobj[1] };
        cFloat flOut = (cFloat)myMethodInfo.Invoke(obj, mParam);

        float realfl = flOut.getReal();
        float imfl = flOut.getImg();
        TextBox6.Text = realfl.ToString();
        TextBox9.Text = imfl.ToString();
    }

    protected void divComp_Click(object sender, EventArgs e)
    {
        string x, y, q, w;

        x = TextBox4.Text;
        y = TextBox5.Text;
        q = TextBox7.Text;
        w = TextBox8.Text;

        object[] newobj = new object[2];
        newobj[0] = new cFloat(Convert.ToSingle(x), Convert.ToSingle(y));
        newobj[1] = new cFloat(Convert.ToSingle(q), Convert.ToSingle(w));

        Type classtype = assem.GetType("ComplexCalc");
        Object obj = Activator.CreateInstance(classtype);
        MethodInfo myMethodInfo = classtype.GetMethod("divide");
        object[] mParam = new object[] { newobj[0], newobj[1] };
        cFloat flOut = (cFloat)myMethodInfo.Invoke(obj, mParam);

        float realfl = flOut.getReal();
        float imfl = flOut.getImg();
        TextBox6.Text = realfl.ToString();
        TextBox9.Text = imfl.ToString();
    }
}



