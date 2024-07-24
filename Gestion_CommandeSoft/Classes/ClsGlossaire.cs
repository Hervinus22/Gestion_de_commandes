using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using Guna.UI2.WinForms;
namespace Gestion_CommandeSoft.Classes

{
    class ClsGlossiaire
    {
        public static ClsGlossiaire _instance = null;
        SqlConnection con = null;
        SqlCommand cmd = null;
        SqlDataAdapter dt = null;
        SqlDataReader dr = null;
        Clsconnexion cnx = null;
        DataSet ds = null;
        public static string imgLon = "";
        SqlParameter sp = null;
        public static ClsGlossiaire Getinstance()
        {
            if (_instance == null)
                _instance = new ClsGlossiaire();
            return _instance;
        }

        public void innitialiseconnect()
        {
            try
            {
                cnx = new Clsconnexion();
                cnx.GetconnectionString();
                con = new SqlConnection(cnx.GetconnectionString());
            }
            catch (Exception e)
            {
                MessageBox.Show("L'un de vos fichiers de configuration est incorrect !" + e.Message);
            }
        }

        public void Appel(Panel pan, Control ctrl)
        {
            pan.Controls.Clear();
            pan.Controls.Add(ctrl);
            pan.Show();
        }

        public void Supprimer(string nomTable, string nomChamp, int id)
        {
            try
            {
                innitialiseconnect();
                con.Open();
                cmd = new SqlCommand("DELETE FROM " + nomTable + " WHERE  " + nomChamp + "=@Id", con);
                cmd.Parameters.AddWithValue("@Id", id);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Supression reussi!!", "Message");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
                cmd.Dispose();
            }
        }
        public DataTable GetTable(string nomTable)
        {
            innitialiseconnect();
            if (!con.State.ToString().Trim().ToLower().Equals("open")) con.Open();
            cmd = new SqlCommand("SELECT * FROM " + nomTable + "", con);
            dt = null;
            dt = new SqlDataAdapter(cmd);
            ds = new DataSet();

            dt.Fill(ds);
            con.Close();
            return ds.Tables[0];
        }
        public void chargementComboBox(ComboBox cmb, string nomChamp, string nomTable)
        {
            innitialiseconnect();
            if (!con.State.ToString().Trim().ToLower().Equals("open")) con.Open();
            using (IDbCommand cmd = con.CreateCommand())
            {
                cmd.CommandText = @"select distinct " + nomChamp + " from " + nomTable + "";

                IDataReader rd = cmd.ExecuteReader();

                while (rd.Read())
                {
                    string de = rd[nomChamp].ToString();
                    cmb.Items.Add(de);
                }
                rd.Close();
                rd.Dispose();
                cmd.Dispose();
            }
        }
        public string GetID(String champ, String table, String champcondition1, String valeur1)
        {
            string _id = string.Empty;

            innitialiseconnect();
            if (!con.State.ToString().Trim().ToLower().Equals("open")) con.Open();
            try
            {
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandText = "SELECT DISTINCT " + champ + " FROM " + table + " WHERE " + champcondition1 + " = @valeur1";
                cmd.Parameters.Add(new SqlParameter("@valeur1", SqlDbType.NVarChar)).Value = valeur1;
                SqlDataReader dr = null;
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                    while (dr.Read())
                        _id = dr.GetFieldValue<object>(0).ToString();
                cmd.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
            return _id.ToString();
        }
        private static void setParameter(SqlCommand cmd, string name, DbType type, int length, object paramValue)
        {
            IDbDataParameter a = cmd.CreateParameter();
            a.ParameterName = name;
            a.Size = length;
            a.DbType = type;

            if (paramValue == null)
            {
                if (!a.IsNullable)
                {
                    a.DbType = DbType.String;
                }
                a.Value = DBNull.Value;
            }
            else
                a.Value = paramValue;
            cmd.Parameters.Add(a);
        }
        public DataTable recherche_Infromation(string NomTable, string Nom, string Postnom, string Prenom, string recherche)
        {
            innitialiseconnect();
            if (!con.State.ToString().ToLower().Equals("open")) con.Open();
            cmd = new SqlCommand("select * from " + NomTable + " WHERE " + Nom + " LIKE '%" + recherche + "%' or " + Postnom + " LIKE '%" + recherche + "%' or " + Prenom + " LIKE '%" + recherche + "%' ", con);
            dt = null;
            dt = new SqlDataAdapter(cmd);
            ds = new DataSet();
            dt.Fill(ds);
            con.Close();
            return ds.Tables[0];
        }
        public DataSet get_Report_X(string nomTable, string nomchamp, int valchamp)
        {
            DataSet dst;
            try
            {
                innitialiseconnect();
                if (!con.State.ToString().ToLower().Equals("open")) con.Open();
                cmd = new SqlCommand("SELECT * FROM " + nomTable + " WHERE " + nomchamp + "=@valchamp", con);
                cmd.Parameters.AddWithValue("@valchamp", valchamp);
                dt = new SqlDataAdapter(cmd);
                dst = new DataSet();
                dt.Fill(dst, nomTable);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                dt.Dispose(); 
               con.Close();
            }
            return dst;
        }
        public DataSet get_Report_X2(string nomTable, string nomchamp, string valchamp)
        {
            DataSet dst;
            try
            {
                innitialiseconnect();
                if (!con.State.ToString().ToLower().Equals("open")) con.Open();
                cmd = new SqlCommand("SELECT * FROM " + nomTable + " WHERE " + nomchamp + "=@valchamp", con);
                cmd.Parameters.AddWithValue("@valchamp", valchamp);
                dt = new SqlDataAdapter(cmd);
                dst = new DataSet();
                dt.Fill(dst, nomTable);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                dt.Dispose();
                con.Close();
            }
            return dst;
        }
        public DataSet get_Report_Trier(string nomTable, string nomchamp, DateTime val1, DateTime val2)
        {
            DataSet dst;
            try
            {
                innitialiseconnect();
                if (!con.State.ToString().ToLower().Equals("open")) con.Open();
                cmd = new SqlCommand("SELECT * FROM " + nomTable + " WHERE " + nomchamp + " between @date1 and @date2 ", con);
                setParameter(cmd, "@date1", DbType.DateTime, 30, val1);
                setParameter(cmd, "@date2", DbType.DateTime, 30, val2);
                dt = new SqlDataAdapter(cmd);
                dst = new DataSet();
                dt.Fill(dst, nomTable);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                dt.Dispose();
                con.Close();
            }
            return dst;
        }

        public DataSet get_Report_S(string nomTable, string idTable)
        {
            DataSet dst;
            try
            {
                innitialiseconnect();
                if (!con.State.ToString().ToLower().Equals("open")) con.Open();
                cmd = new SqlCommand("SELECT * FROM " + nomTable + " ORDER BY " + idTable + "", con);
                dt = new SqlDataAdapter(cmd);
                dst = new DataSet();
                dt.Fill(dst, nomTable);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                dt.Dispose();
                con.Close();
            }
            return dst;
        }
        public DataSet get_Report_S2(string nomTable)
        {
            DataSet dst;
            try
            {
                innitialiseconnect();
                if (!con.State.ToString().ToLower().Equals("open")) con.Open();
                cmd = new SqlCommand("SELECT * FROM " + nomTable + "", con);
                dt = new SqlDataAdapter(cmd);
                dst = new DataSet();
                dt.Fill(dst, nomTable);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                dt.Dispose();
                con.Close();
            }
            return dst;
        }
        public void backup(string bd, string disk)
        {
            try
            {
                innitialiseconnect();
                con.Open();
                cmd = new SqlCommand("backup database " + bd + " to disk='" + disk + "GestionCommande_Soft.bak'", con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Sauvegarde reussi avec succes !!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                cmd.Dispose();
                con.Close();
            }
        }
        public DataTable ChargerTable(String table)
        {
            DataTable dTable = new DataTable();

            try
            {
                innitialiseconnect();
                if (!con.State.ToString().Trim().ToLower().Equals("open")) con.Open();

                SqlCommand cmd = con.CreateCommand();

                cmd.CommandText = "SELECT * FROM " + table + "";
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dTable);
            }
            catch (Exception exc)
            {
                throw new Exception(exc.Message);
            }
            finally
            {
                con.Close();
            }
            return dTable;
        }
        public DataTable ChargerTable(String table, String champcondition, String valeur)
        {
            DataTable dTable = new DataTable();

            try
            {
                innitialiseconnect();
                if (!con.State.ToString().Trim().ToLower().Equals("open")) con.Open();

                SqlCommand cmd = con.CreateCommand();

                cmd.CommandText = "SELECT * FROM " + table + " WHERE " + champcondition + " = @champcondition";

                cmd.Parameters.Add(new SqlParameter("@champcondition", SqlDbType.NVarChar)).Value = valeur;

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dTable);
            }
            catch (Exception exc)
            {
                throw new Exception(exc.Message);
            }
            finally
            {
                con.Close();
            }
            return dTable;
        }
        public void chargementINT(int lb, string rqt, int t)
        {

            try
            {
                innitialiseconnect();
                con.Open();
                cmd.CommandText = rqt;
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    lb = Convert.ToInt32(dr[t]);
                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("erreur" + ex);
            }
        }
        public void chargementLabel(Label lab, string rqt)
        {

            try
            {
                innitialiseconnect();
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandText = rqt;
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    lab.Text = dr[0].ToString();
                }
                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void chargementCombo(ComboBox cmb, string rqt)
        {
            innitialiseconnect();

            try
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmb.Items.Clear();
                cmd.CommandText = rqt;
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    cmb.Items.Add(dr[0].ToString());
                }
                con.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void EXEC_UNIVERSELLE_PICTURE(string name, string param, string message)
        {


            try
            {
                innitialiseconnect();
                con.Open();
                if (!con.State.ToString().Trim().ToLower().Equals("open")) con.Open();
                Byte[] img;
                FileStream fs = new FileStream(imgLon, FileMode.Open, FileAccess.Read);
                BinaryReader br = new BinaryReader(fs);
                img = br.ReadBytes(Convert.ToInt32(fs.Length));
                SqlCommand cmd = con.CreateCommand();
                cmd.Parameters.Clear();
                cmd.CommandText = "EXEC " + name + " " + param;
                cmd.Parameters.Add(new SqlParameter("@IMAGE", img));
                cmd.ExecuteNonQuery();
                MessageBox.Show("" + message, "Enregistrement Reussi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();
        }
        public void CHOISIR_IMAGE(Guna.UI2.WinForms.Guna2PictureBox picture)
        {

            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "JPG Files(*.jpg)|*.jpg|GIF Files(*.gif)|*.gif|All Files(*.*)|*.*";
            dlg.Title = "Selectionner une image";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                imgLon = dlg.FileName.ToString();
                picture.ImageLocation = imgLon;
            }
        }
        public void EXEC_UNIVERSELLE(string name, string param, string message)
        {
            try
            {

                innitialiseconnect();
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.Parameters.Clear();
                cmd.CommandText = "EXEC " + name + " " + param;
                cmd.ExecuteNonQuery();
                MessageBox.Show("" + message, "Reussi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            catch (Exception ex)
            {
                MessageBox.Show("ERREUR" + ex.Message);
            }
            con.Close();
        }
        public void GET_PHOTO(string RQT, PictureBox picemp, int row)
        {

            try
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandText = RQT + "";
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    byte[] img = (byte[])(dr[row]);
                    if (img == null)
                        picemp.Image = null;
                    else
                    {
                        MemoryStream ms = new MemoryStream(img);
                        picemp.Image = System.Drawing.Image.FromStream(ms);
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void testLogin(string nom, string pass)
        {
            try
            {
                innitialiseconnect();
                con.Open();
                cmd = new SqlCommand("SELECT username, pass from tlogin where username=@username and pass=@pass", con);
                cmd.Parameters.AddWithValue("@username", nom);
                cmd.Parameters.AddWithValue("@pass", pass);

                //SqlDataReader dr = null;
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    frmHome H = new frmHome();
                    H.Show();

                }
                else
                {
                    MessageBox.Show("Mot de passe ou nom d'utilisateur incorrect !!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Login l = new Login();
                    l.Show();
                }
                dr.Close();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        public void chargementTableau(DataGridView dg, String rqt, String suite)
        {
            Console.WriteLine(rqt);
            try
            {
                innitialiseconnect();
                con.Open();
                cmd = con.CreateCommand();
                SqlDataAdapter da = new SqlDataAdapter(rqt + " " + suite, con);
                DataSet dset = new DataSet();
                da.Fill(dset, "TEleve");
                dg.DataSource = dset.Tables[0];

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();
        }

        public DataSet get_Report_Z(string colonnes, string nomTable, string refh)
        {
            DataSet dst;
            try
            {
                if (!con.State.ToString().ToLower().Equals("open")) con.Open();
                cmd = new SqlCommand("SELECT  " + colonnes + " FROM " + nomTable + "" + refh, con);
                dt = new SqlDataAdapter(cmd);
                dst = new DataSet();
                dt.Fill(dst, nomTable);
                Console.WriteLine("SELECT  " + colonnes + " FROM " + nomTable + "" + refh);
            }
            catch (Exception ex)
            {
                MessageBox.Show("SELECT  " + colonnes + " FROM " + nomTable + "" + refh);
                throw new Exception(ex.Message);
            }
            finally
            {
                dt.Dispose();
                con.Close();
            }
            return dst;
        }

        public void MINDATE(Guna2DateTimePicker date)
        {

            try
            {
                con.Open();
                cmd.CommandText = "SELECT DAY(GETDATE()),MONTH (GETDATE()),YEAR(GETDATE())";
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    date.MinDate = new System.DateTime(Convert.ToInt32(dr[2].ToString()), Convert.ToInt32(dr[1].ToString()), Convert.ToInt32(dr[0].ToString()), 0, 0, 0, 0);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();
        }
    }
}
/*
    public void chargerBox2(String col1, String col2, String table, ComboBox c)
    {
        try
        {
            innitialiseconnect();
            con.Open();
            cmd = new SqlCommand("select " + col1 + " as " + col2 + "  from " + table + "", con);
            rs = ps.executeQuery();
            if (dr.Read())
            {
                c.ControlAdded(ds.GetType[(col2)]);
            }
        }
        catch (Exception e)
        {
            MessageBox.Show("erreur" + e);
        }
        finally
        {

            cmd.Dispose();
            con.Close();
        }
    }
}

}

*/

