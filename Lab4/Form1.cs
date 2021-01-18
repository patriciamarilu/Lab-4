//Grading ID: R5665
//CIS 199-01. Lab4. Due: February 16,2020
//This program calculates if the student is accepted ir rejected through GPA and score. Keeps count on how many are accepted and rejected
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int AcceptCount = 0; //running total of accepts
        int RejectCount = 0; //running total of rejects
        private void calculatebtn_Click(object sender, EventArgs e)
        {

            float GPA; //represents the GPA value input
            uint score; //represents the score value input
            if (float.TryParse(GPAtextbox.Text, out GPA)) //tested expression for GPA
            {
                if (uint.TryParse(scoretextbox.Text, out score)) //tested expression for score
                {
                    if (GPA >= 3.0 && score >= 60 || GPA < 3.0 && score >= 80) //if GPA>=3.0 and score>=60 OR if GPA <3.0 and score >=80
                    {
                        MessageBox.Show("Accept"); //message box will apprear with Accept
                        AcceptCount +=1; //keeps count of how many students have been accepted
                        acceptcount.Text = AcceptCount.ToString(); //shows how many students have been accepted
                    }
                    else
                    {
                        MessageBox.Show("Reject"); //message box will appear with Reject
                        RejectCount +=1; //keeps count of how many students have been rejected
                        rejectcount.Text = RejectCount.ToString(); //shows how many students have been rejected
                    }  
                }
                else
                    MessageBox.Show("Enter valid score"); //message box will appear if you don't put a valid number in score 
            }
            else
                MessageBox.Show("Enter valid GPA"); //message box will appear if you don't put a valid number in score

        }
    }
}
