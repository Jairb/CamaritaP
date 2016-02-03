using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    class ProceduresHelper
    {
        public static void execSPCreate(string sp)
        {
            using (SqlConnection conn = Connection.GetDBConnection())
            {
                try
                {
                    conn.Open();
                    SqlCommand cmdCreate = new SqlCommand(sp, conn);
                    cmdCreate.ExecuteNonQuery();
                    conn.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                }
            }
        }

        public static bool execSPCreateTrue(string sp)
        {
            using (SqlConnection conn = Connection.GetDBConnection())
            {
                try
                {
                    conn.Open();
                    SqlCommand cmdCreate = new SqlCommand(sp, conn);
                    cmdCreate.ExecuteNonQuery();
                    conn.Close();
                    return true;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                    return false;
                }
            }
        }

        public static void execSPUpdate(string sp)
        {
            using (SqlConnection conn = Connection.GetDBConnection())
            {
                try
                {
                    SqlCommand cmdUpdate = new SqlCommand(sp, conn);
                    cmdUpdate.ExecuteNonQuery();
                    conn.Close();
                    //Console.WriteLine("El elemento ha sido modificado");
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                }
            }
        }
        public static void execSPDelete(string sp)
        {
            using (SqlConnection conn = Connection.GetDBConnection())
            {
                try
                {
                    SqlCommand cmdUpdate = new SqlCommand(sp, conn);
                    cmdUpdate.ExecuteNonQuery();
                    conn.Close();
                    //Console.WriteLine("El elemento ha sido eliminado");
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                }
            }
        }

        public static DataTable execSPRead(string sp)
        {
            DataTable dt = new DataTable();
            using (SqlConnection conn = Connection.GetDBConnection())
            {
                try
                {
                    SqlCommand cmd = new SqlCommand(sp, conn);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dt);
                    conn.Close();
                }
                catch(Exception ex)
                {
                    ex.ToString();
                }

                return dt;
            }

        }

      /*  public static bool execSPLogin(string sp)
        {
            bool login = false;
            using (SqlConnection conn = Connection.GetDBConnection())
            {
                try
                {
                    SqlCommand cmdLogin = new SqlCommand(sp, conn);
                    SqlDataReader myReader = cmdLogin.ExecuteReader();
                    while (myReader.Read())
                    {
                        if (myReader.GetValue(0).ToString().Equals("1"))
                        {
                            login = true;
                        }
                        break;
                    }
                    conn.Close();
                    if (login)
                    {
                        Console.WriteLine("Bienvenido");
                    }
                    else
                    {
                        Console.WriteLine("Verifica tus datos");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                }
            }
            return login;
        }*/
    }
}
