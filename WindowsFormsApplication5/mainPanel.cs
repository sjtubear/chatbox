using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace WindowsFormsApplication5
{
    [Serializable]
    public struct userNode
    {
        public int id;
        public string userName;

        public userNode(int i,string st)
        {
            id = i;
            userName = st;
        }
    }
    public partial class Formmain : Form
    {

        public List<userNode> users = new List<userNode>();

        List<userPanel> userL = new List<userPanel>();
        private mainWinInfo saveInfo = null;
        int userId = 0;
        public Formmain()
        {
            InitializeComponent();
        }

        public void messager(string message,string userName)
        
        {
            foreach( userPanel temp in userL)
            {
                if (temp.Name == userName)
                {
                    temp.showMessasge(message);
                }
            }
                
        }

        public int userCount()
        {
            return userL.Count;
        }

        private void butCreat_Click(object sender, EventArgs e)
        {
            if (this.textUserName.Text == "")
                MessageBox.Show("Please input the user name before create user!");
            else
            {
                //if not empty ,new user and added into userL
                userPanel newUser = new userPanel(this, textUserName.Text);
                userNode tempNode = new userNode(userId, textUserName.Text);
                users.Add(tempNode);
                userId++;
                userL.Add(newUser);
                userList.AppendText(textUserName.Text + "\n");
                newUser.Show();
                //clear the textBox
                textUserName.Text = "";
                foreach(var P in userL)
                {
                    P.RefreshComboBox();
                }
            }
        }

        private void Formmain_Load(object sender, EventArgs e)
        {
            try
            {
               if(File.Exists("mainStatus.cfg"))
               {
                   using (FileStream fs = new FileStream("mainStatus.cfg",FileMode.Open))
                   {
                       IFormatter ft = new BinaryFormatter();
                       saveInfo = ft.Deserialize(fs) as mainWinInfo;
                       this.users = saveInfo.savedNodes;
                       foreach(userNode temp in users)
                       {
                           userPanel newP = new userPanel(this, temp.userName);
                           userL.Add(newP);
                           userId++;
                           userList.AppendText(temp.userName + "\n");
                           newP.Show();
                           foreach (var P in userL)
                           {
                               P.RefreshComboBox();
                           }
                       }
                   }
               }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        
        private void Formmain_FormClosing(object sender, FormClosingEventArgs e)
        {
            saveInfo = new mainWinInfo();
            saveInfo.savedNodes = this.users;
            
  
            using (FileStream fs = new FileStream("mainStatus.cfg", FileMode.Create))
            {

                IFormatter ft = new BinaryFormatter();
                ft.Serialize(fs,saveInfo);
            }

            foreach(var panel in userL)
            {
                panel.Close();
            }
        }
    }
}
