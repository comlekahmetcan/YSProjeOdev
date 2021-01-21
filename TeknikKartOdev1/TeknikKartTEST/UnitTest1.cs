using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.ComponentModel;
using System;
using System.Data;
using System.Data.SqlClient;

namespace TeknikKartTEST
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void veriTabanıKontrol()
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-R1JGFU3\\SQLEXPRESS;Initial Catalog=TeknikKart;Integrated Security=True");
            SqlDataAdapter da;
            DataSet ds;
            da = new SqlDataAdapter("Select * From Users", con);
            ds = new DataSet();
            con.Open();
            da.Fill(ds, "UserName");
            con.Close();
        }
        [TestMethod]
        public void veriEkleme()
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-R1JGFU3\\SQLEXPRESS;Initial Catalog=TeknikKart;Integrated Security=True");
            SqlDataAdapter da;
            DataSet ds;
            da = new SqlDataAdapter("INSERT INTO Users (UserName) VALUES ('Can' )", con);
            ds = new DataSet();
            con.Open();
            da.Fill(ds, "UserName");
            con.Close();
        }
    }
}