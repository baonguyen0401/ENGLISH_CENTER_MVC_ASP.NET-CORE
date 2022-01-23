using Microsoft.Data.SqlClient;
using System.Data;


namespace ENGLISH_CENTER_MVC_ASP.NET_CORE.Models
{
    public class CheckLogin
    {
            SqlConnection con = new SqlConnection("Data Source=LAPTOP-HAHT29KJ;" +
                "Initial Catalog=DB_TrungTamNgoaiNgu;Persist Security Info=True;" +
                "User ID=DB_Bin0961;Password=B1nn002233..");
            public int Login_Nhanvien_Check(NhanvienAccount nv_account)
            {
                SqlCommand sqlCommand = new SqlCommand("staff_login", con);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.AddWithValue("@Staff_id", nv_account.UidNhanvienAccount);
                sqlCommand.Parameters.AddWithValue("@Staff_pwd", nv_account.PwdNhanvienAccount);
                SqlParameter parameter = new SqlParameter();
                parameter.ParameterName = "@Isvalid";
                parameter.SqlDbType = SqlDbType.Bit;
                parameter.Direction = ParameterDirection.Output;
                sqlCommand.Parameters.Add(parameter);
                con.Open();
                sqlCommand.ExecuteNonQuery();
                int ketqua_login_nv = Convert.ToInt32(parameter.Value);
                con.Close();
                return ketqua_login_nv;
            }
            public int Login_Giaovien_Check(TeacherAccount teacherAccount)
            {
                SqlCommand sqlCommand = new SqlCommand("teacher_login", con);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.AddWithValue("@Teacher_id", teacherAccount.UidTeacherAccount);
                sqlCommand.Parameters.AddWithValue("@Teacher_pwd", teacherAccount.PwdTeacherAccount);
                SqlParameter parameter = new SqlParameter();
                parameter.ParameterName = "@Isvalid";
                parameter.SqlDbType = SqlDbType.Bit;
                parameter.Direction = ParameterDirection.Output;
                sqlCommand.Parameters.Add(parameter);
                con.Open();
                sqlCommand.ExecuteNonQuery();
                int ketqua_login_gv = Convert.ToInt32(parameter.Value);
                con.Close();
                return ketqua_login_gv;
            }
            public int Login_Hocvien_Check(StudentAccount studentAccount)
            {
                SqlCommand sqlCommand = new SqlCommand("student_login", con);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.AddWithValue("@Student_id", studentAccount.UidStudentAccount);
                sqlCommand.Parameters.AddWithValue("@Student_pwd", studentAccount.PwdStudentAccount);
                SqlParameter parameter = new SqlParameter();
                parameter.ParameterName = "@Isvalid";
                parameter.SqlDbType = SqlDbType.Bit;
                parameter.Direction = ParameterDirection.Output;
                sqlCommand.Parameters.Add(parameter);
                con.Open();
                sqlCommand.ExecuteNonQuery();  
                int ketqua_login_hv = Convert.ToInt32(parameter.Value);
                con.Close();
                return ketqua_login_hv;
            }
        }
    }
