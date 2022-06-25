namespace arrays
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public class MyClass
        {
            private string _name;
            
            public MyClass(string aName)
            {
                _name = aName;
            }

            public string Name
            {
                get { return _name; }
                set { _name = value; }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] myArray = new string[] { "one", "two", "three" };
            string[] myArray2;
            myArray2 = new string[3] { "four", "five", "six" };
            string[] myArray3 = { "seven", "eight", "nine" };
            MyClass[] myObjectArray = new MyClass[3];
            //loop0
            for (int i = 0; i <=2; i++)
            {
                textBox0.Text += myArray[i] + ". ";
            }
            //loop1
            for(int i = 0; i <=2; i++)
            {
                myObjectArray[i] = new MyClass("Object #" + i + ". ");
            }
            //loop2
            for (int i = 0; i <=myArray.Length - 1; i++)
            {
                textBox1.Text = textBox1.Text + myArray[i] + ". ";
            }
            //loop3
            for ( int i = myArray2.GetLowerBound(0); i <= myArray2.GetUpperBound(0); i++)
            {
                textBox2.Text = textBox2.Text + myArray2[i] + ". ";
            }
            //loop4
            for (int i = 0; i <= myObjectArray.GetUpperBound(0); i++)
            {
                textBox3.Text = textBox3.Text + myObjectArray[i].Name;
            }
            //loop5
            foreach(MyClass myob in myObjectArray)
            {
                textBox4.Text = textBox4.Text + myob.Name;
            }
        }
    }


}