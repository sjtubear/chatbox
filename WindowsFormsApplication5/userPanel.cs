using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication5;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace WindowsFormsApplication5
{
    public partial class userPanel : Form
    {

        public Formmain myMain;
        DateTime dtNow = DateTime.Now;
        private userinfo usrf = null;
        public userPanel(Formmain fatherForm,string userName)
        {
            InitializeComponent();
            myMain = fatherForm;
            this.Name = userName;
            this.Text = userName;
            this.label3.Text = "I am " + userName;
        }

        public  void showMessasge(string temp)
        {
            try
            {
                string[] spliter = temp.Split('\n');
               // this.textChat.ForeColor = System.Drawing.Color.SeaGreen;
                foreach (string li in spliter)
                {
                    textChat.AppendText(li + "\n");
                }
                this.Show();
              //  this.textChat.ForeColor = System.Drawing.Color.White;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void userPanel_Load(object sender, EventArgs e)
        {
            string tempname = this.Name + ".cfg";
            if(File.Exists(tempname))
            {
                using (FileStream fs = new FileStream(tempname,FileMode.Open))
                {
                    IFormatter ft = new BinaryFormatter();
                    usrf = ft.Deserialize(fs) as userinfo;
                    string[] split = usrf.chatHist.Split('\n');
            //        this.textChat.ForeColor = System.Drawing.Color.Gray;
                    foreach(string tempx in split)
                    {
                        this.textChat.AppendText(tempx+"\n");
                    }
                    this.textChat.AppendText("-----------History above---------\n");
            //this.textChat.ForeColor = System.Drawing.Color.White;
                }
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textChat_TextChanged(object sender, EventArgs e)
        {

        }

        public void RefreshComboBox()
        {
            var its = comboBox1.Items;
            if(its.Count == myMain.userCount())
            {
                return;
            }
            foreach( var node in myMain.users)
            {
                if(its.Contains(node.userName) == false)
                {
                    comboBox1.Items.Add(node.userName);
                }
            }
        }

        private void butSend_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem == null)
            {
                MessageBox.Show("Please select someone~");
                return;
            }
            if (comboBox1.SelectedItem.ToString() == this.Name)
            {
                MessageBox.Show("Please don't send message to yourself!");
                return;
            }
            if(messageBox.Text == "")
            {
                MessageBox.Show("You should say something~");
                return;
            }
            string reciver = comboBox1.SelectedItem.ToString();
            dtNow = DateTime.Now;
            string message =this.Name + "  ( " + dtNow.ToString() + ") : \n " + messageBox.Text;
            textChat.AppendText("I said to "+ reciver+ " ( " + dtNow.ToString() +") : \n" );
            textChat.AppendText("  " + messageBox.Text + "\n");
            myMain.messager(message, reciver);
            messageBox.Text = "";
        }

        private void userPanel_FormClosing(object sender, FormClosingEventArgs e)
        {
            usrf = new userinfo();
            usrf.chatHist = textChat.Text;
            string tempname = this.Name+".cfg";
            using( FileStream fs = new FileStream(tempname,FileMode.Create))
            {
                IFormatter ft = new BinaryFormatter();
                ft.Serialize(fs, usrf);
            }
        }

        private void messageBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
