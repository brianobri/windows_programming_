using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Reflection;

//Brian O'Briskie 
//HW2
namespace hw2
{
    public partial class Form1 : Form
    {
     
        //global variables
        Assembly a;
        string dllName;     // used in listBox1_SelectedIndexChanged

        int dllinit = 0;    // used in listBox1_SelectedIndexChanged and button1_Click
        string file;
        bool simplecontinue = false;
        bool complexcontinue = false;
        Button addButton;
        Button subButton;
        Button mulButton;
        Button divButton;
        TextBox TB1;
        TextBox TB2;
        TextBox TB3;

        Button addCButton;
        Button subCButton;
        Button mulCButton;
        Button divCButton;
        TextBox TBC1;
        TextBox TBC2;
        TextBox TBC3;
        TextBox TBC4;
        TextBox TBC5;
        TextBox TBC6;



        public Form1()
        {
            InitializeComponent();
            Text = "Calculator";
        }




        private void loadDllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // find path of dll
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            DialogResult result = openFileDialog1.ShowDialog();
            file = openFileDialog1.FileName;
            richTextBox1.Text = file;

            // load the dll
            a = Assembly.LoadFrom(file);

            // shows types and methods in the dll in the richtextbox1
            foreach (Type t in a.GetTypes())
            {
                richTextBox1.Text += "\n " + t.Name;
                foreach (MethodInfo method in t.GetMethods())
                {
                    richTextBox1.Text += "\n " + method.ToString();
                }
                richTextBox1.Text += "\n ";
            }
            dllinit = 1; //opened a dll - useful in prevention of button creation
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }



        private void button1_Click(object sender, EventArgs e)
        {
            // simple calc add calculate buttons and input text boxes
            if (dllinit == 1)
            {
                // for each checked box for simple calc check if the box was selected
                foreach (Object c in checkedListBox1.CheckedItems) 
                {
                    if (checkedListBox1.GetItemCheckState(checkedListBox1.Items.IndexOf(c)) == CheckState.Checked)
                    {
                       

                        // add simple calculating buttons
                        if (c.ToString() == "add")
                        {
                            addButton = new Button();
                            addButton.Location = new Point(180, 130);
                            addButton.Size = new Size(50, 24);
                            addButton.Text = "Add";
                            addButton.Click += new EventHandler(this.add_click);
                            Controls.Add(addButton);
                        }

                        if (c.ToString() == "sub")
                        {
                            subButton = new Button();
                            subButton.Location = new Point(230, 130);
                            subButton.Size = new Size(50, 24);
                            subButton.Text = "Sub";
                            subButton.Click += new EventHandler(this.sub_click);
                            Controls.Add(subButton);
                        }

                        if (c.ToString() == "mul")
                        {
                            mulButton = new Button();
                            mulButton.Location = new Point(280, 130);
                            mulButton.Size = new Size(50, 24);
                            mulButton.Text = "Mul";
                            mulButton.Click += new EventHandler(this.mul_click);
                            Controls.Add(mulButton);
                        }

                        if (c.ToString() == "div")
                        {
                            divButton = new Button();
                            divButton.Location = new Point(330, 130);
                            divButton.Size = new Size(50, 24);
                            divButton.Text = "Div";
                            divButton.Click += new EventHandler(this.div_click);
                            Controls.Add(divButton);
                        }

                        simplecontinue = true;
                    }

                }
                if (simplecontinue)
                {
                    // add input boxes for simple calc
                    TB1 = new TextBox();
                    TB1.Location = new Point(180, 160);
                    TB1.Size = new Size(96, 24);
                    Controls.Add(TB1);

                    TB2 = new TextBox();
                    TB2.Location = new Point(180, 185);
                    TB2.Size = new Size(96, 24);
                    Controls.Add(TB2);
                }

            }


            // complex calc add calculate buttons and input text boxes
            if (dllinit == 1)
            {
                // for each checked box for complex calc check if the box was selected
                foreach (Object c in checkedListBox2.CheckedItems)
                {
                    if (checkedListBox2.GetItemCheckState(checkedListBox2.Items.IndexOf(c)) == CheckState.Checked)
                    {
                      

                        // add complex calculating buttons
                        if (c.ToString() == "add complex")
                        {
                            
                            addButton = new Button();
                            addButton.Location = new Point(180, 230);
                            addButton.Size = new Size(50, 24);
                            addButton.Text = "Add";
                            addButton.Click += new EventHandler(this.addC_click);
                            Controls.Add(addButton);
                        }

                        if (c.ToString() == "sub complex")
                        {
                            subButton = new Button();
                            subButton.Location = new Point(230, 230);
                            subButton.Size = new Size(50, 24);
                            subButton.Text = "Sub";
                            subButton.Click += new EventHandler(this.subC_click);
                            Controls.Add(subButton);
                        }

                        if (c.ToString() == "mul complex")
                        {
                            mulButton = new Button();
                            mulButton.Location = new Point(280, 230);
                            mulButton.Size = new Size(50, 24);
                            mulButton.Text = "Mul";
                            mulButton.Click += new EventHandler(this.mulC_click);
                            Controls.Add(mulButton);
                        }

                        if (c.ToString() == "div complex")
                        {
                            divButton = new Button();
                            divButton.Location = new Point(330, 230);
                            divButton.Size = new Size(50, 24);
                            divButton.Text = "Div";
                            divButton.Click += new EventHandler(this.divC_click);
                            Controls.Add(divButton);
                        }
                        complexcontinue = true;


                    }
                }

                if (complexcontinue)
                {
                    // add input boxes for complex calc
                    TBC1 = new TextBox();
                    TBC1.Location = new Point(180, 260);
                    TBC1.Size = new Size(96, 24);
                    Controls.Add(TBC1);

                    TBC2 = new TextBox();
                    TBC2.Location = new Point(180, 285);
                    TBC2.Size = new Size(96, 24);
                    Controls.Add(TBC2);

                    TBC3 = new TextBox();
                    TBC3.Location = new Point(280, 260);
                    TBC3.Size = new Size(96, 24);
                    Controls.Add(TBC3);

                    TBC4 = new TextBox();
                    TBC4.Location = new Point(280, 285);
                    TBC4.Size = new Size(96, 24);
                    Controls.Add(TBC4);
                }

            }

    
        }

        //SIMPLE CALC calculate functions
        void add_click(object sender, EventArgs e)
        {
            // create output text box and add it
            TB3 = new TextBox();
            TB3.Location = new Point(300, 160);
            TB3.Size = new Size(96, 24);
            Controls.Add(TB3);

            // read in the 2 input boxes
            string inputOne = TB1.Text;
            string inputTwo = TB2.Text;
            int intOne = int.Parse(inputOne);
            int intTwo = int.Parse(inputTwo);

            // use reflection to calculate
            Type classtype = a.GetType("SimpleCalc");
            Object obj = Activator.CreateInstance(classtype);
            MethodInfo myMethodInfo = classtype.GetMethod("add");
            object[] mParam = new object[] { intOne, intTwo };
            int intOut = (int)myMethodInfo.Invoke(obj, mParam);

            // output to the output text box
            TB3.Text += intOut.ToString();
        }

        void sub_click(object sender, EventArgs e)
        {
            // create output text box and add it
            TB3 = new TextBox();
            TB3.Location = new Point(300, 160);
            TB3.Size = new Size(96, 24);
            Controls.Add(TB3);

            // read in the 2 input boxes
            string inputOne = TB1.Text;
            string inputTwo = TB2.Text;
            int intOne = int.Parse(inputOne);
            int intTwo = int.Parse(inputTwo);

            // use reflection to calculate
            Type classtype = a.GetType("SimpleCalc");
            Object obj = Activator.CreateInstance(classtype);
            MethodInfo myMethodInfo = classtype.GetMethod("sub");
            object[] mParam = new object[] { intOne, intTwo };
            int intOut = (int)myMethodInfo.Invoke(obj, mParam);

            // output to the output text box
            TB3.Text += intOut.ToString();
        }

        void mul_click(object sender, EventArgs e)
        {
            // create output text box and add it
            TB3 = new TextBox();
            TB3.Location = new Point(300, 160);
            TB3.Size = new Size(96, 24);
            Controls.Add(TB3);

            // read in the 2 input boxes
            string inputOne = TB1.Text;
            string inputTwo = TB2.Text;
            int intOne = int.Parse(inputOne);
            int intTwo = int.Parse(inputTwo);

            // use reflection to calculate
            Type classtype = a.GetType("SimpleCalc");
            Object obj = Activator.CreateInstance(classtype);
            MethodInfo myMethodInfo = classtype.GetMethod("mult");
            object[] mParam = new object[] { intOne, intTwo };
            int intOut = (int)myMethodInfo.Invoke(obj, mParam);

            // output to the output text box
            TB3.Text += intOut.ToString();
        }

        void div_click(object sender, EventArgs e)
        {
            // create output text box and add it
            TB3 = new TextBox();
            TB3.Location = new Point(300, 160);
            TB3.Size = new Size(96, 24);
            Controls.Add(TB3);

            // read in the 2 input boxes
            string inputOne = TB1.Text;
            string inputTwo = TB2.Text;
            int intOne = int.Parse(inputOne);
            int intTwo = int.Parse(inputTwo);

            // use reflection to calculate
            Type classtype = a.GetType("SimpleCalc");
            Object obj = Activator.CreateInstance(classtype);
            MethodInfo myMethodInfo = classtype.GetMethod("div");
            object[] mParam = new object[] { intOne, intTwo };
            double intOut = (double)myMethodInfo.Invoke(obj, mParam);

            // output to the output text box
            TB3.Text += intOut.ToString();
        }




        // COMPLEX CALC calculate functions
        void addC_click(object sender, EventArgs e)
        {
            // create output text boxs and add it
            TBC5 = new TextBox();
            TBC5.Location = new Point(400, 260);
            TBC5.Size = new Size(96, 24);
            Controls.Add(TBC5);

            TBC6 = new TextBox();
            TBC6.Location = new Point(400, 285);
            TBC6.Size = new Size(96, 24);
            Controls.Add(TBC6);

            // read in the 4 input boxes
            string inputOne = TBC1.Text;
            string inputTwo = TBC2.Text;
            string inputThree = TBC3.Text;
            string inputFour = TBC4.Text;
            int intOne = int.Parse(inputOne);
            int intTwo = int.Parse(inputTwo);
            int intThree = int.Parse(inputThree);
            int intFour = int.Parse(inputFour);

            // use reflection to calculate real
            Type classtype = a.GetType("ComplexCalc");
            Object obj = Activator.CreateInstance(classtype);
            MethodInfo myMethodInfo = classtype.GetMethod("addreal");
            object[] mParam = new object[] { intOne, intThree };
            int DOut = (int)myMethodInfo.Invoke(obj, mParam);

            // output real to the output text box
            TBC5.Text += "real : " + DOut.ToString();

            // use reflection to calculate im
            Type classtype2 = a.GetType("ComplexCalc");
            Object obj2 = Activator.CreateInstance(classtype2);
            MethodInfo myMethodInfo2 = classtype2.GetMethod("addim");
            object[] mParam2 = new object[] { intTwo, intFour };
            int DOut2 = (int)myMethodInfo.Invoke(obj2, mParam2);

            // output  im to the output text box
            TBC6.Text += "im : " + DOut2.ToString();
        }

        void subC_click(object sender, EventArgs e)
        {
            // create output text boxs and add it
            TBC5 = new TextBox();
            TBC5.Location = new Point(400, 260);
            TBC5.Size = new Size(96, 24);
            Controls.Add(TBC5);

            TBC6 = new TextBox();
            TBC6.Location = new Point(400, 285);
            TBC6.Size = new Size(96, 24);
            Controls.Add(TBC6);

            // read in the 4 input boxes
            string inputOne = TBC1.Text;
            string inputTwo = TBC2.Text;
            string inputThree = TBC3.Text;
            string inputFour = TBC4.Text;
            int intOne = int.Parse(inputOne);
            int intTwo = int.Parse(inputTwo);
            int intThree = int.Parse(inputThree);
            int intFour = int.Parse(inputFour);

            // use reflection to calculate real
            Type classtype = a.GetType("ComplexCalc");
            Object obj = Activator.CreateInstance(classtype);
            MethodInfo myMethodInfo = classtype.GetMethod("subreal");
            object[] mParam = new object[] { intOne, intThree };
            int DOut = (int)myMethodInfo.Invoke(obj, mParam);

            // output real to the output text box
            TBC5.Text += "real : " + DOut.ToString();

            // use reflection to calculate im
            Type classtype2 = a.GetType("ComplexCalc");
            Object obj2 = Activator.CreateInstance(classtype2);
            MethodInfo myMethodInfo2 = classtype2.GetMethod("subim");
            object[] mParam2 = new object[] { intTwo, intFour };
            int DOut2 = (int)myMethodInfo.Invoke(obj2, mParam2);

            // output im to the output text box
            TBC6.Text += "im : " + DOut2.ToString();
        }

        void mulC_click(object sender, EventArgs e)
        {



            // create output text boxs and add it
            TBC5 = new TextBox();
            TBC5.Location = new Point(400, 260);
            TBC5.Size = new Size(96, 24);
            Controls.Add(TBC5);

            TBC6 = new TextBox();
            TBC6.Location = new Point(400, 285);
            TBC6.Size = new Size(96, 24);
            Controls.Add(TBC6);

            // read in the 4 input boxes
            string inputOne = TBC1.Text;
            string inputTwo = TBC2.Text;
            string inputThree = TBC3.Text;
            string inputFour = TBC4.Text;
            int intOne = int.Parse(inputOne);
            int intTwo = int.Parse(inputTwo);
            int intThree = int.Parse(inputThree);
            int intFour = int.Parse(inputFour);

            // use reflection to calculate real
            Type classtype = a.GetType("ComplexCalc");
            Object obj = Activator.CreateInstance(classtype);
            MethodInfo myMethodInfo = classtype.GetMethod("multreal");
            object[] mParam = new object[] { intOne, intThree };
            int DOut = (int)myMethodInfo.Invoke(obj, mParam);

            // output real to the output text box
            TBC5.Text += "real : " + DOut.ToString();

            // use reflection to calculate
            Type classtype2 = a.GetType("ComplexCalc");
            Object obj2 = Activator.CreateInstance(classtype2);
            MethodInfo myMethodInfo2 = classtype2.GetMethod("multim");
            object[] mParam2 = new object[] { intTwo, intFour };
            int DOut2 = (int)myMethodInfo.Invoke(obj2, mParam2);

            // output im to the output text box
            TBC6.Text += "im : " + DOut2.ToString();

        }

        void divC_click(object sender, EventArgs e)
        {
            // create output text boxs and add it
            TBC5 = new TextBox();
            TBC5.Location = new Point(400, 260);
            TBC5.Size = new Size(96, 24);
            Controls.Add(TBC5);

            TBC6 = new TextBox();
            TBC6.Location = new Point(400, 285);
            TBC6.Size = new Size(96, 24);
            Controls.Add(TBC6);

            // read in the 4 input boxes
            string inputOne = TBC1.Text;
            string inputTwo = TBC2.Text;
            string inputThree = TBC3.Text;
            string inputFour = TBC4.Text;
            double DoubleOne = double.Parse(inputOne);
            double DoubleTwo = double.Parse(inputTwo);
            double DoubleThree = double.Parse(inputThree);
            double DoubleFour = double.Parse(inputFour);

            // use reflection to calculate real
            Type classtype = a.GetType("ComplexCalc");
            Object obj = Activator.CreateInstance(classtype);
            MethodInfo myMethodInfo = classtype.GetMethod("divreal");
            object[] mParam = new object[] { DoubleOne, DoubleThree };
            double DOut = (double)myMethodInfo.Invoke(obj, mParam);

            // output real to the output text box
            TBC5.Text += "real : " + DOut.ToString();

            // use reflection to calculate im
            Type classtype2 = a.GetType("ComplexCalc");
            Object obj2 = Activator.CreateInstance(classtype2);
            MethodInfo myMethodInfo2 = classtype2.GetMethod("divim");
            object[] mParam2 = new object[] { DoubleTwo, DoubleFour };
            double DOut2 = (double)myMethodInfo.Invoke(obj2, mParam2);

            // output im to the output text box
            TBC6.Text += "im : " + DOut2.ToString();

        }



    }
}
