using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AddressBook
{
    public partial class Form1 : Form
    {
        private StreamReader inFile;
        private StreamWriter outFile;


        public Form1()
        {
            
            InitializeComponent();
            
        }

        


        

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Created by ME!\nByron Buyck\nAKA\n毕容谦" +
                "\n2016");
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                openBox.ShowDialog();
                inFile = new StreamReader(openBox.FileName);
                lblMessage.Text = "File Name: " + openBox.FileName;
                readFile();
                inFile.Close();


            }
            catch (Exception ex)
            {
                lblMessage.Text = ex.Message;
            }
        }

        private void readFile()
        {
            string data = inFile.ReadLine();

            while (data != null)
            {
                txtInfo.Text += data + "\r\n";
                data = inFile.ReadLine();
                

            }
        }

        private void btnClr_Click(object sender, EventArgs e)
        {

            
            txtInfo.Text = "";
            textBox1.Text = "";
            textBox3.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
            textBox8.Text = "";
            lblMessage.Text = "";
            label8.Text = "";

        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            Addresses User = new Addresses(textBox1.Text, textBox3.Text, textBox5.Text, textBox6.Text, textBox7.Text, textBox8.Text);
            
            
            

            try
            {
                saveBox.ShowDialog();
                outFile = new StreamWriter(saveBox.FileName, true);
                outFile.WriteLine(User.ToString());
                outFile.Close();
            }
            catch (Exception ex)
            {
                lblMessage.Text = ex.Message;

            }

            label8.Text = "Document Saved As: " + saveBox.FileName;
            txtInfo.Text = "";
            textBox1.Text = "";
            textBox3.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
            textBox8.Text = "";
            //lblMessage.Text = "";
            //label8.Text = "";


        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

            


        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtInfo_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void menuExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
