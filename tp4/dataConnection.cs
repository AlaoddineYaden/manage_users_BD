using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace tp4
{
    class DataConnection
    {
        static string chaine = @"Data Source=ALAE\SQLEXPRESS;Initial Catalog=tp4;Integrated Security=True";
        static SqlConnection cnx = new SqlConnection(chaine);
        static SqlCommand cmd = new SqlCommand();
        static SqlDataAdapter adapter = new SqlDataAdapter(cmd);
        /// <summary>
        /// chercher tous les information associe avec le Id entrer
        /// </summary>
        /// <param name="Id">identifiant d'un personne</param>
        /// <returns>une tabeau des informations </returns>
        public DataTable searchItems(String Id)
        {
            DataTable dt = new DataTable("Personne");
            try
            {
                cnx.Open();
                cmd.Connection = cnx;
                cmd.CommandText = "select * From Persons where Id = " + Id + ";";
                int rows = cmd.ExecuteNonQuery();
                adapter.Fill(dt);
               
            }
            catch (Exception ex)
            {

            }
            finally
            {
                cnx.Close();
            }

            return dt;
        }
        /// <summary>
        /// il nous donne un tableau des id 
        /// </summary>
        /// <returns>retourn un tableau qui contieant tous les id </returns>
        public DataTable selectId()
        {
            DataTable dt = new DataTable("Personne");
            try
            {
                cnx.Open();
                cmd.Connection = cnx;
                cmd.CommandText = "select Id From Persons;";
                int rows = cmd.ExecuteNonQuery();
                adapter.Fill(dt);
            }
            catch (Exception ex)
            {

            }
            finally
            {
                cnx.Close();
            }

            return dt;
        }
        /// <summary>
        /// pour afficher la table personne dans le grid view
        /// </summary>
        /// <returns>retourn un tableau</returns>
        public DataTable afficher()
        {
            DataTable dt = new DataTable();
            try
            {
                cnx.Open();
                cmd.Connection = cnx;
                cmd.CommandText = "select * From Persons;";
                int rows = cmd.ExecuteNonQuery();
                adapter.Fill(dt);
            }
            catch (Exception ex)
            {

            }
            finally
            {
                cnx.Close();
            }
            return dt;
        }
        /// <summary>
        /// pour in inserer une ligne au tableau
        /// </summary>
        /// <param name="txt1"></param>
        /// <param name="txt2"></param>
        /// <returns>nous retourne true si l'ajout est fais avec succee sinon il retourne false</returns>
        public bool ajouter(String txt1, String txt2)
        {
            bool isSuccess = false;
            try
            {
                cnx.Open();
                cmd.Connection = cnx;
                cmd.CommandText = "insert into Persons values('" + txt1 + "','" + txt2 + "') ";
                int rows = cmd.ExecuteNonQuery();
                if (rows > 0)
                {
                    isSuccess = true;
                }
                else
                {
                    isSuccess = false;
                }
            }
            catch (Exception ex)
            {

            }
            finally
            {
                cnx.Close();
            }
            return isSuccess;
            
        }
        /// <summary>
        /// nous permet de modifier une ligne sur la table
        /// </summary>
        /// <param name="Id"></param>
        /// <param name="txt1"></param>
        /// <param name="txt2"></param>
        /// <returns></returns>
        public bool modifier(String Id,String txt1, String txt2)
        {
            bool isSuccess = false;
            try
            {
                cnx.Open();
                cmd.Connection = cnx;
                cmd.CommandText = "UPDATE Persons SET Nom = '" + txt1 + "', Prenom = '" + txt2 + "' WHERE Id = "+Id+";";
                int rows = cmd.ExecuteNonQuery();
                if (rows > 0)
                {
                    isSuccess = true;
                }
                else
                {
                    isSuccess = false;
                }
            }
            catch (Exception ex)
            {

            }
            finally
            {
                cnx.Close();
            }
            return isSuccess;

        }
        /// <summary>
        /// pour supprimer une ligne du taleau
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        public bool supprimer(String Id)
        {
            bool isSuccess = false;
            try
            {
                cnx.Open();
                cmd.Connection = cnx;
                cmd.CommandText = "DELETE FROM Persons WHERE Id = " + Id + "; ";
                int rows = cmd.ExecuteNonQuery();
                if (rows > 0)
                {
                    isSuccess = true;
                }
                else
                {
                    isSuccess = false;
                }
            }
            catch (Exception ex)
            {

            }
            finally
            {
                cnx.Close();
            }
            return isSuccess;

        }
    }
}
