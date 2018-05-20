using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MvcMovie.Models;
using System.Text.RegularExpressions;
using Npgsql;
using NpgsqlTypes;
using System.Data;

namespace MvcMovie.Controllers
{
    public class CompanyController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            var connString = @"Server=localhost;Port=5432;User Id=dokyou3;Password=hide110;Database=postgres";

            using (var con = new NpgsqlConnection(connString))
            {
                con.Open();

                NpgsqlTransaction t = con.BeginTransaction();

                // Specify command StoredProcedure
                NpgsqlCommand cmd = new NpgsqlCommand("test.test01", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("v_name", "松");
                cmd.Parameters.AddWithValue("v_birthday_from", DBNull.Value);
                cmd.Parameters.AddWithValue("v_birthday_to", DBNull.Value);
                cmd.Parameters.AddWithValue("v_address", DBNull.Value);

                try
                {
                    // Execute procedure and obtain a result set
                    NpgsqlDataReader dr = cmd.ExecuteReader();

                    while (dr.Read())
                    {
                        Console.WriteLine("value : {0},", dr["name"]);
                    }
                }
                catch (Exception ex)
                {
                    throw ex;
                }

            }
            return View();
        }

    }
}