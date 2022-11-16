using DBQuery.Model;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json.Nodes;
using System.Text.Json;
//using Microsoft.Data.SqlClient;
using System.Net;
using System.Text;
using System.Data.SqlClient;
using System.Configuration;

namespace MISDB.Controllers
{
    //[Authorize]
    [ApiController]
    [Route("[controller]")]
    [Produces("application/json")]
    public class MISDBController : Controller
    {
        [HttpGet]
        [Route("UserList")]
        public async Task<IActionResult> GetAsync(int Page, int Row)
        {
            var QueryResults = new List<QueryResult>();
            //to get the connection string 
            //var _config = app.Services.GetRequiredService<IConfiguration>();
            //var connectionstring = _config.GetConnectionString("DefaultConnection");
            //build the sqlconnection and execute the sql command
            //using (SqlConnection conn = new SqlConnection(connectionstring))
            //{
            //conn.Open(); 
            int Offset = (Page - 1) * Row;  
                string commandtext = "EXEC QueryHistoryDesc @Offset=" + Offset + ", @Row=" + Row;
            
            SqlConnection connectionMISDB = new SqlConnection("Data Source=C4iBA-MISDB.c4i.rmp.gov.my,49254; Initial Catalog=DBQueryLogSAT; User Id=sa; Password=P@ssw0rd=c4i");
            connectionMISDB.Open();
            SqlCommand cmd = new SqlCommand(commandtext, connectionMISDB);


                var reader = cmd.ExecuteReader();
            
                while (reader.Read())
                {
                    var QueryResultsQ = new QueryResult()
                    {
                        Id = reader["Id"].ToString(),
                        QueryId = reader["QueryId"].ToString(),
                        UserId = reader["UserId"].ToString(),
                        PersonalId = reader["PersonalId"].ToString(),
                        Name = reader["Name"].ToString(),
                        Rank = reader["Rank"].ToString(),
                        KontigenId = reader["KontigenId"].ToString(),
                        NamaKontinjen = reader["NamaKontinjen"].ToString(),
                        DaerahId = reader["DaerahId"].ToString(),
                        NamaDaerah = reader["NamaDaerah"].ToString(),
                        GroupId = reader["GroupId"].ToString(),
                        NameGroup = reader["NameGroup"].ToString(),
                        IsAccountDisabled = reader["IsAccountDisabled"].ToString(),
                        Query = reader["Query"].ToString(),
                        QueryStartTime = reader["QueryStartTime"].ToString(),
                        QueryEndTime = reader["QueryEndTime"].ToString(),
                        Result = reader["Result"].ToString(),
                        Type = reader["Type"].ToString(),
                    };

                    QueryResults.Add(QueryResultsQ);
                }
            //}
            /*
            try
            {
                SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();

                builder.DataSource = "C4iBA-MISDB.c4i.rmp.gov.my\\MISDB";
                builder.UserID = "sa";
                builder.Password = "P@ssw0rd=c4i";
                builder.InitialCatalog = "DBQueryLogSAT";

                using (SqlConnection connection = new SqlConnection(builder.ConnectionString))
                {
                    Console.WriteLine("\nQuery data example:");
                    Console.WriteLine("=========================================\n");

                    connection.Open();

                    String sql = "SELECT TOP (1000) [Id]\r\n      ,[PersonalId]\r\n      ,[Name]\r\n      ,[KontigenId]\r\n      ,[DaerahId]\r\n      ,[GroupId]\r\n      ,[Disabled]\r\n      ,[Rank]\r\n  FROM [DBQueryLogSAT].[dbo].[User] FOR JSON;";

                }
            }
            catch (SqlException e)
            {
                Console.WriteLine(e.ToString());
            }
            Console.WriteLine("\nDone. Press enter.");
            Console.ReadLine();
            */
            connectionMISDB.Close();
            return Ok(QueryResults);
        }
    }
}