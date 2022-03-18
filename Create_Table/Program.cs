﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Create_Table
{
    class Program
    {
        static void Main(string[] args)
        {
            new Program().CreateTable();
        }
        public void CreateTable()
        {
            SqlConnection con = null;
            try
            {
                con = new SqlConnection("data source=LAPTOP-DMUVDQOK\\WIRATAMA;database=ProdiTI;Integrated Security = TRUE ");
                con.Open();

                SqlCommand cm = new SqlCommand("create table Mahasiswa_Coba (NIM char(12) not null primary key, Nama varchar(50), Alamat varchar(255), Jenis_Kelamin char(1))", con);
                cm.ExecuteNonQuery();

                Console.WriteLine("Tabel Sukses Dibuat");
                Console.ReadKey();
            }
            catch (Exception e)
            {
                Console.WriteLine("Oops, Sepertinya ada yang salah. " + e);
            }
            finally
            {
                con.Close();
            }
        }
    }
}
