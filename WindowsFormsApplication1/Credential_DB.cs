using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Windows.Forms;
using System.Data;

namespace WindowsFormsApplication1
{
    class Credential_DB
    {
        public string name
        {
            get;
            set;
        }
        public string city
        {
            get;
            set;
        }
        public string UserName
        {
            get;
            set;
        }
        public string Password
        {
            get;
            set;
        }
        public string UserType
        {
            get;
            set;
        }
        public bool Authenticate(Credential_DB cDB)
        {
            string query = String.Format("select * from Credential where username = '{0}' and password = '{1}' and usertype ='{2}'", cDB.UserName, cDB.Password, cDB.UserType);
            Business_Logic BL = new Business_Logic();
            OleDbDataReader rec = BL.SelectQuery(query);
            if(rec.Read())
            {
                return true;
            }
            else{
                return false;
            }
        }
            public void createnewuser(Credential_DB cDB)
            {
                string query = String.Format("Insert into Credential Values('{0}','{1}','{2}','{3}','{4}')", cDB.UserName, cDB.Password, cDB.UserType,cDB.name, cDB.city);
                Business_Logic BL= new Business_Logic();
                BL.NonQuery(query);
            }
            public void changemypassword(Credential_DB cDB)
            {
                string query = String.Format("UPDATE [credential] SET [password] = '{0}' where [username] = '{1}' and [usertype] = '{2}'", cDB.Password, cDB.UserName, cDB.UserType);
                Business_Logic BL = new Business_Logic();
                BL.NonQuery(query);
            }
            public void fillcombobox(ComboBox CB)
            {
             //   ComboBox CB = new ComboBox();
                string  query="Select username from credential where usertype = 'user'";
                Business_Logic BL=new Business_Logic();
                OleDbDataReader rec =BL.SelectQuery(query);
                while(rec.Read())
                {
                    CB.Items.Add(rec[0].ToString());
                }
             //   return CB;
            }
            public void deleteuser(Credential_DB cDB)
            {
                string query = String.Format("delete from credential where username = '{0}'", cDB.UserName);
                Business_Logic BL = new Business_Logic();
                BL.NonQuery(query);
            }
            public void FillGrid(DataGridView GV)
            {
                string query = "select * from credential";
                Business_Logic BL = new Business_Logic();
                DataSet ds = BL.Adapter(query);
                GV.DataSource = ds.Tables[0];           //adapter return dataset
            }
                
    }
}
