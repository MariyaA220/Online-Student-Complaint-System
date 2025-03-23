using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Configuration;
using System.Collections;
using System.Drawing;
using System.IO;


namespace Final_task
{   
  
    public class Myclass
    {
        public string clgname,branc ,studentname;
        SqlConnection con;
        SqlCommand cmd;
        public SqlDataReader dr;
        public string Insertclg(string collegeName, string collegeCode, string email, string principleName, string mobile, string password, string date)
      
        { 


        if (collegeName==""|| collegeCode==""|| principleName==""|| email==""|| mobile==""|| password==""|| date=="")
            {
                return "Fill Complete Form First";
            }
            else {

                string path = ConfigurationManager.AppSettings["dbcs"];
                      con = new SqlConnection(path);
                       con.Open();
                string query = "select * from CollegeReg where Collegecode = @Collegecode";
        cmd= new SqlCommand(query, con);
        cmd.Parameters.AddWithValue("Collegecode", collegeCode);

                dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    return "Duplicate College Code";

                }
                else
                {
                    dr.Close();

                    string query2 = "INSERT INTO CollegeReg  (Collegename, Collegecode, Email, Principle, Mobile, Password, Date) VALUES (@Collegename, @Collegecode, @Email, @Principle, @Mobile, @Password, @Date)";
                    cmd = new SqlCommand(query2, con);

                    cmd.Parameters.AddWithValue("Collegename", collegeName);
                    cmd.Parameters.AddWithValue("collegecode", collegeCode);
                    cmd.Parameters.AddWithValue("Principle", principleName);
                    cmd.Parameters.AddWithValue("Email", email);
                    cmd.Parameters.AddWithValue("Mobile", mobile);
                    cmd.Parameters.AddWithValue("Password", password);
                    cmd.Parameters.AddWithValue("Date", date);

                    cmd.ExecuteReader();

                    return "Record Save Successfully";

                }
}
        }


        public string CLogin(string clgcode, string password)
        {
            if (clgcode == "" || password == "")
            {
                return "College Code And Password Required ";
            }
            else
            {
                string path = ConfigurationManager.AppSettings["dbcs"];
                con = new SqlConnection(path);
                con.Open();

                string query = "select * from CollegeReg where collegecode = @collegecode and password = @password";
                cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("collegecode", clgcode);
                cmd.Parameters.AddWithValue("password", password);

                dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    return "success";

                }
                else
                {
                    return "Invalid Login";
                }
            }


        }


        public string SLogin(string email, string password)
        {
            if (email == "" || password == "")
            {
                return "Fill Email and Password First";
            }
            else
            {
                string path = ConfigurationManager.AppSettings["dbcs"];
                con = new SqlConnection(path);
                con.Open();

                string query = "select * from StudentReg where email = @email and password = @pass";
                cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("email", email);
                cmd.Parameters.AddWithValue("pass", password);

                dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    return "success";

                }
                else
                {
                    return "Invalid Login";
                }
            }
        }

        public void Master(string Clgname)
        {
            string path = ConfigurationManager.AppSettings["dbcs"];
            con = new SqlConnection(path);
            con.Open();

            string query = "select * from CollegeReg where Collegecode =@collegename";
            cmd = new SqlCommand(query, con);

            cmd.Parameters.AddWithValue("collegename", Clgname);

            dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                clgname = dr["Collegename"].ToString();
            }
        }

        public void deptTable(string code)
        {
            string path = ConfigurationManager.AppSettings["dbcs"];
            con = new SqlConnection(path);
            con.Open();

            string query = "select * from Depdb where Collegecode =@collegecode";
            cmd = new SqlCommand(query, con);

            cmd.Parameters.AddWithValue("collegecode", code);

            dr = cmd.ExecuteReader();
        }




        public string deptment(string ClgName, string ClgCode, string dept)
        {
            if (dept == "")
            {
                return "Please Enter Department";
            }
            else
            {
                string path = ConfigurationManager.AppSettings["dbcs"];
                con = new SqlConnection(path);
                con.Open();

                string query = "select * from Depdb where Collegecode = @collegecode and Collegename = @collegename and Deptname = @deptname";
                cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("collegecode", ClgCode);
                cmd.Parameters.AddWithValue("collegename", ClgName);
                cmd.Parameters.AddWithValue("deptname", dept);

                dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    return "This Department Is Already Inserted";

                }
                else
                {
                    dr.Close();

                    string query2 = "insert into Depdb Values(@CName,@CC,@dept)";
                    cmd = new SqlCommand(query2, con);

                    cmd.Parameters.AddWithValue("CName", ClgName);
                    cmd.Parameters.AddWithValue("CC", ClgCode);
                    cmd.Parameters.AddWithValue("dept", dept);

                    cmd.ExecuteReader();

                    return "Record Save Successfull";

                }







            }

         
        }


        public void deptDelete(string CC, string dept)
        {
            string path = ConfigurationManager.AppSettings["dbcs"];
            con = new SqlConnection(path);
            con.Open();

            string query = "delete from Depdb where Collegecode = @collegecode and Deptname = @deptname";
            cmd = new SqlCommand(query, con);

            cmd.Parameters.AddWithValue("collegecode", CC);
            cmd.Parameters.AddWithValue("deptname", dept);

            cmd.ExecuteNonQuery();
        }



        public void branch(string CName)
        {
            string path = ConfigurationManager.AppSettings["dbcs"];
            con = new SqlConnection(path);
            con.Open();

            string query = "select Deptname from Depdb where CollegeName = @collegename";
            cmd = new SqlCommand(query, con);

            cmd.Parameters.AddWithValue("collegename", CName);

            dr = cmd.ExecuteReader();
        }



        public string deptsubmit(string cn, string cc, string un, string uid, string pass, string dn, string date)
        {
            if (cn == "" || cc == "" || un == "" || uid == "" || pass == "" || dn == "Select Department" || date == "")
            {
                return "Please Fill All The Details";
            }
            else
            {
                string path = ConfigurationManager.AppSettings["dbcs"];
                con = new SqlConnection(path);
                con.Open();

                string query = "select * from Depuser where collegecode = @collegecode and userid = @userid";
                cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("collegecode", cc);
                cmd.Parameters.AddWithValue("userid", uid);

                dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    return "Already Inserted This Faculty";

                }
                else
                {
                    dr.Close();

                    string query2 = "insert into Depuser values(@collegename,@collegecode,@username,@userid,@password,@deptname,@date)";
                    cmd = new SqlCommand(query2, con);
                    cmd.Parameters.AddWithValue("collegename", cn);
                    cmd.Parameters.AddWithValue("collegecode", cc);
                    cmd.Parameters.AddWithValue("deptname", dn);
                    cmd.Parameters.AddWithValue("username", un);
                    cmd.Parameters.AddWithValue("userid", uid);
                    cmd.Parameters.AddWithValue("password", pass);
                    cmd.Parameters.AddWithValue("date", date);

                    cmd.ExecuteReader();

                    return "Save Successfull";

                }
            }
        }

        public void deptUserTable(string CC)
        {
            string path = ConfigurationManager.AppSettings["dbcs"];
            con = new SqlConnection(path);
            con.Open();

            string query = "select * from Depuser where collegecode =@collegecode";
            cmd = new SqlCommand(query, con);

            cmd.Parameters.AddWithValue("collegecode", CC);

            dr = cmd.ExecuteReader();
        }



        public void deptUDelete(string cc, string Uid)
        {
            string path = ConfigurationManager.AppSettings["dbcs"];
            con = new SqlConnection(path);
            con.Open();


            string query = "delete from Depuser where collegecode = @collegecode and userid = @userid";
            cmd = new SqlCommand(query, con);

            cmd.Parameters.AddWithValue("collegecode", cc);
            cmd.Parameters.AddWithValue("userid", Uid);

            cmd.ExecuteNonQuery();
        }

        public void deptUseredit(string cc, string FN, string Uid, string pass)
        {
            string path = ConfigurationManager.AppSettings["dbcs"];
            con = new SqlConnection(path);
            con.Open();


            string query = "update Depuser set username=@username , password=@password where collegecode = @collegecode and userid = @uid";
            cmd = new SqlCommand(query, con);

            cmd.Parameters.AddWithValue("password", pass);
            cmd.Parameters.AddWithValue("username", FN);
            cmd.Parameters.AddWithValue("uid", Uid);
            cmd.Parameters.AddWithValue("collegecode", cc);

            cmd.ExecuteNonQuery();
        }


        public void deptUserTable2(string CC, string dept)
        {
            string path = ConfigurationManager.AppSettings["dbcs"];
            con = new SqlConnection(path);
            con.Open();

            string query = "select * from Depuser where collegecode =@collegecode and deptname = @deptname";
            cmd= new SqlCommand(query, con);

            cmd.Parameters.AddWithValue("collegecode", CC);
            cmd.Parameters.AddWithValue("deptname", dept);

            dr = cmd.ExecuteReader();
        }



        public void complaintTable2(string clg)
        {
            string path = ConfigurationManager.AppSettings["dbcs"];
            con = new SqlConnection(path);
            con.Open();

            string query = "select * from complaintdb where college =@college";
            cmd = new SqlCommand(query, con);

            cmd.Parameters.AddWithValue("college", clg);

            dr = cmd.ExecuteReader();
        }

        public void complaintTable3(string clg, string dept)
        {
            string path = ConfigurationManager.AppSettings["dbcs"];
            con = new SqlConnection(path);
            con.Open();

            string query = "select * from complaintdb where college =@clg and branch = @dept";
            cmd = new SqlCommand(query, con);

            cmd.Parameters.AddWithValue("clg", clg);
            cmd.Parameters.AddWithValue("dept", dept);

            dr = cmd.ExecuteReader();
        }



        public void complaintUpdate(string rb, string status, string clg, string dept)
        {
            string path = ConfigurationManager.AppSettings["dbcs"];
            con = new SqlConnection(path);
            con.Open();


            string query = "update complaintdb set status=@status , resolveby = @rb where college =@clg and branch = @dept";
            cmd = new SqlCommand(query, con);

            cmd.Parameters.AddWithValue("status", status);
            cmd.Parameters.AddWithValue("rb", rb);
            cmd.Parameters.AddWithValue("clg", clg);
            cmd.Parameters.AddWithValue("dept", dept);

            cmd.ExecuteNonQuery();
        }


        public void deptUser(string CName)
        {
            string path = ConfigurationManager.AppSettings["dbcs"];
            con = new SqlConnection(path);
            con.Open();

            string query = "select username from Depuser where collegename=@collegename";
            cmd = new SqlCommand(query, con);

            cmd.Parameters.AddWithValue("collegename", CName);

            dr = cmd.ExecuteReader();
        }


        public string complaintDelete(string msg, string ct)
        {
            string path = ConfigurationManager.AppSettings["dbcs"];
            con = new SqlConnection(path);
            con.Open();


            string query = "delete from complaintdb where message = @msg and complaintto = @ct";
            cmd = new SqlCommand(query, con);

            cmd.Parameters.AddWithValue("ct", ct);
            cmd.Parameters.AddWithValue("msg", msg);
           
            cmd.ExecuteNonQuery();
            return query;
        }














        public string newsSave(string cc, string cn, string title, string msg, string date)
        {
            if (cc == "" || cn == "" || title == "" || msg == "" || date == "")
            {
                return "Fill Complete Form First";
            }
            else
            {
                string path = ConfigurationManager.AppSettings["dbcs"];
                con = new SqlConnection(path);
                con.Open();

                string query = "select * from newsdb where collegecode = @CC and newstitle= @title";
                cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("CC", cc);
                cmd.Parameters.AddWithValue("title", title);

                dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    return "Duplicate Title";

                }
                else
                {
                    dr.Close();
                    string query2 = "insert into newsdb Values(@cc,@cn,@title,@msg,@date)";
                    cmd = new SqlCommand(query2, con);

                    cmd.Parameters.AddWithValue("cc", cc);
                    cmd.Parameters.AddWithValue("cn", cn);
                    cmd.Parameters.AddWithValue("title", title);
                    cmd.Parameters.AddWithValue("msg", msg);
                    cmd.Parameters.AddWithValue("date", date);

                    cmd.ExecuteReader();


                    return "Save Successfull";
                }
            }
        }

        public void newsTable(string CC)
        {
            string path = ConfigurationManager.AppSettings["dbcs"];
            con = new SqlConnection(path);
            con.Open();

            string query = "select * from newsdb where collegecode =@cc";
            cmd = new SqlCommand(query, con);

            cmd.Parameters.AddWithValue("cc", CC);

            dr = cmd.ExecuteReader();
        }

        public void newsDelete(string cc, string title)
        {
            string path = ConfigurationManager.AppSettings["dbcs"];
            con = new SqlConnection(path);
            con.Open();


            string query = "delete from newsdb where collegecode = @cc and newstitle = @title";
            cmd = new SqlCommand(query, con);

            cmd.Parameters.AddWithValue("cc", cc);
            cmd.Parameters.AddWithValue("title", title);

            cmd.ExecuteNonQuery();
        }

        public void newsUpdate(string cc, string title, string msg)
        {
            string path = ConfigurationManager.AppSettings["dbcs"];
            con = new SqlConnection(path);
            con.Open();


            string query = "update newsdb set message=@msg where collegecode = @cc and newstitle = @title";
            cmd = new SqlCommand(query, con);

            cmd.Parameters.AddWithValue("msg", msg);
            cmd.Parameters.AddWithValue("cc", cc);
            cmd.Parameters.AddWithValue("title", title);

            cmd.ExecuteNonQuery();
        }


        public string stuSave(string CName, string Name, string Branch, string Email, string Mobile, string Pass, string Date, string Sem)
        {
            if (CName == "Select College" || Name == "" || Branch == "Select Branch" || Email == "" || Mobile == "" || Sem == "" || Pass == "" || Date == "")
            {
                return "Fill Complete Form First";
            }
            else
            {
                string path = ConfigurationManager.AppSettings["dbcs"];
                con = new SqlConnection(path);
                con.Open();

                string query = "select * from StudentReg where email = @Email";
                cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("Email", Email);

                dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    return "Duplicate Email";
                }
                else
                {
                    dr.Close();

                    string query2 = "insert into StudentReg(name,college,email,branch ,mobile,password,date,semester) Values(@name,@clg,@email,@Branch,@Mobile,@Pass,@Date,@sem)";
                    cmd = new SqlCommand(query2, con);

                    cmd.Parameters.AddWithValue("name", Name);
                    cmd.Parameters.AddWithValue("clg", CName);
                    cmd.Parameters.AddWithValue("Branch", Branch);
                    cmd.Parameters.AddWithValue("Email", Email);
                    cmd.Parameters.AddWithValue("Mobile", Mobile);
                    cmd.Parameters.AddWithValue("Pass", Pass);
                    cmd.Parameters.AddWithValue("Date", Date);
                    cmd.Parameters.AddWithValue("sem", Sem);

                    cmd.ExecuteNonQuery();

                    return "Save Successfull";
                }

            }
        }

        public void clg()
        {
            string path = ConfigurationManager.AppSettings["dbcs"];
            con = new SqlConnection(path);
            con.Open();

            string query = "select Collegename from CollegeReg";
            cmd = new SqlCommand(query, con);

            dr = cmd.ExecuteReader();
        }


        //Retriving News for specific clg
        public string news(string clg)
        {
            try
            {
                string path = ConfigurationManager.AppSettings["dbcs"];
                con = new SqlConnection(path);
                con.Open();

                string query = "select message from newsdb where collegename = @CName";
                cmd = new SqlCommand(query, con);

                cmd.Parameters.AddWithValue("CName", clg);

                dr = cmd.ExecuteReader();

                return "";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public string stuInfo(string email)
        {
            try
            {
                string path = ConfigurationManager.AppSettings["dbcs"];
                con = new SqlConnection(path);
                con.Open();

                string query = "select * from StudentReg where email =@email";
                cmd = new SqlCommand(query, con);

                cmd.Parameters.AddWithValue("email", email);

                dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    clgname = dr["college"].ToString();
                    branc = dr["branch"].ToString();
                    studentname = dr["name"].ToString();
                }

                return "";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }

        }


        public string complaintSave(string cn, string sn, string email, string branch, string ct, string msg, string date)
        {
            try
            {

            }
            catch (Exception ex)
            {
                return ex.Message;
            }
            if (sn == "" || cn == "" || email == "" || branch == "" || ct == "Select" || msg == "" || date == "")
            {
                return "Fill Complete Form First";
            }
            else
            {
                string path = ConfigurationManager.AppSettings["dbcs"];
                con = new SqlConnection(path);
                con.Open();


                string query2 = "insert into complaintdb(studentname,college,branch,email,complaintto,message,date) Values(@sn,@cn,@branch,@email,@ct,@msg,@date)";
                cmd = new SqlCommand(query2, con);

                cmd.Parameters.AddWithValue("cn", cn);
                cmd.Parameters.AddWithValue("sn", sn);
                cmd.Parameters.AddWithValue("email", email);
                cmd.Parameters.AddWithValue("branch", branch);
                cmd.Parameters.AddWithValue("ct", ct);
                cmd.Parameters.AddWithValue("msg", msg);
                cmd.Parameters.AddWithValue("date", date);

                cmd.ExecuteReader();


                return "Save Successfull";
            }

        }


        public string complaintTable(string email)
        {
            try
            {
                string path = ConfigurationManager.AppSettings["dbcs"];
                con = new SqlConnection(path);
                con.Open();

                string query = "select * from complaintdb where email =@email";
                cmd = new SqlCommand(query, con);

                cmd.Parameters.AddWithValue("email", email);

                dr = cmd.ExecuteReader();

                return "";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }

        }

      
    }
}



