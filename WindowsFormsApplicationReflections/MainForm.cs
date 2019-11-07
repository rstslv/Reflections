using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;
using System.IO;

namespace WindowsFormsApplicationReflections
{
    public partial class MainForm : Form
    {
        Assembly asm;
        Type[] types;
        MethodInfo[] methodInfoArray;
        int libId;
        int typeId;
        int methodId;
        ParameterInfo[] parameterInfo;
        MethodInfo[] methods;

        public MainForm()
        {
            InitializeComponent();
        }
        private void Libs_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            string path = Application.StartupPath;
            string[] libFiles = Directory.GetFiles(path, "*.dll");
            Libs.DataSource = libFiles;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            asm = Assembly.LoadFile(Libs.SelectedItem.ToString());
            types = asm.GetTypes();
            Classes.DataSource = types;
            libId = Libs.Items.IndexOf(Libs.SelectedItem);
        }

        private void Classes_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Methods_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Parameters_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            typeId = Classes.Items.IndexOf(Classes.SelectedItem);
            methods = types[typeId].GetMethods();
            Methods.DataSource = methods;

            methodInfoArray = types[typeId].GetMethods();
            methodId = Methods.SelectedIndex;

            parameterInfo = methodInfoArray[methodId].GetParameters();
            Parameters.DataSource = parameterInfo;
            
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

            parameterInfo = methodInfoArray[methodId].GetParameters();
            Parameters.DataSource = parameterInfo;

            methodId = Methods.Items.IndexOf(Methods.SelectedItem);
            textBox1.Text = String.Format("Enter {0} here", parameterInfo[0].ParameterType);
            textBox2.Text = String.Format("Enter {0} here", parameterInfo[1].ParameterType);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            object classInstance = Activator.CreateInstance(types[typeId], null);
            object result = null;
            object[] myParams = new object[] { Convert.ChangeType(textBox1.Text, parameterInfo[0].ParameterType), Convert.ChangeType(textBox2.Text, parameterInfo[1].ParameterType) };
            
            result = methodInfoArray[methodId].Invoke(classInstance, myParams);
            textBox3.Text = Convert.ToString(result);
        }
    }
}
