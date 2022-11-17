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
        [Route("QueryHistory")]
        public async Task<IActionResult> GetAsync(int Page, int Row, int? KontinjenId, int? DaerahId)
        {
            var QueryResults = new List<QueryResult>();
            int Offset = (Page - 1) * Row;
            
                string commandtext = "EXEC QueryHistoryDesc " + Offset + ", " + Row;
            //    string commandtext = "EXEC QueryUser " + Offset + ", " + Row;

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
            connectionMISDB.Close();
            return Ok(QueryResults);
        }
    }
}