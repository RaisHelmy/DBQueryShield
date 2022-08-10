using DBQuery.Model;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.IO;
using System.IO.Pipelines;
using System.Text.Json.Nodes;
using System.Text.Json;
using System.ComponentModel;
using System;
using Microsoft.AspNetCore.Hosting.Server;
using Microsoft.Extensions.Options;

namespace DBQuery.Controllers
{
    //[Authorize]
    [ApiController]
    [Route("[controller]")]
    [Produces("application/json")]
    public class DBQueryController : Controller
    {
        [HttpGet]
        public async Task<IActionResult> GetAsync(string Query)
        {
            string resultDBQuery_Asal =
@"{
    ""Status"": ""tiadaZ"",
    ""QueryStartTime"": """",
    ""QueryEndTime"": """",
    ""JPN"":
        [
            {
                ""ResultStatus"": ""tiada"",
                ""Nama"": """",
                ""No.Kad Pengenalan"": """",
                ""No.Kad Pengenalan Lama"": """",
                ""Tarikh Lahir"": """",
                ""Jantina"": """",
                ""Agama"": """",
                ""Bangsa / Keturunan"": """",
                ""Alamat Tetap"": """",
                ""Alamat Surat-menyurat"": """",
                ""Tarikh Kematian"": """",
                ""Status Kediaman"": """",
                ""Kewarganegaraan"": """",
                ""Alamat e-mel"": """",
                ""No.Telefon"": """",
                ""type"": ""JPN"",
                ""Photo"": """",
                ""QueryStartTime"": """",
                ""QueryEndTime"": """",
                ""TypeDescription"": ""JPN""
            }
        ],
    
    ""JPJIC"":
        [
            {
                ""ResultStatus"": ""tiada"",
                ""No.Kenderaan"": """",
                ""Model"": """",
                ""Tarikh Model"": """",
                ""type"": ""JPJIC"",
                ""QueryStartTime"": """",
                ""QueryEndTime"": """",
                ""TypeDescription"": ""JPJIC""
            }
        ],
    ""JPJ"":
        [
            {
                ""ResultStatus"": ""tiada"",
                ""Nama"": """",
                ""No KP/Paspot"": """",
                ""Kategori"": """",
                ""Alamat"": """",
                ""No Pendaftaran Kenderaan"": """",
                ""No Pendaftaran Lama"": """",
                ""No Chasis"": """",
                ""Jenis Badan"": """",
                ""No Enjin"": """",
                ""Kuasa Enjin"": """",
                ""Model"": """",
                ""Tahun Keluaran Model"": """",
                ""Warna"": """",
                ""Status"": """",
                ""Kod Kegunaan"": """",
                ""Tarikh Daftar"": """",
                ""Buatan"": """",
                ""No LKM"": """",
                ""Tempoh LKM"": """",
                ""Syarikat Insurans"": """",
                ""No Polisi"": """",
                ""Tempoh Insurans"": """",
                ""type"": ""JPJ"",
                ""QueryStartTime"": """",
                ""QueryEndTime"": """",
                ""TypeDescription"": ""JPJ""
            }
        ],
    ""JIM"":
        [
            {
                ""ResultStatus"": ""tiada"",
                ""No Dokumen"": """",
                ""Tarikh Mula Passport"": """",
                ""Sebab Batal"": """",
                ""No Rujukan Pemilik"": """",
                ""Cawangan Mengeluar"": """",
                ""Sebab Sah"": """",
                ""Status Rekod"": """",
                ""Jenis Dokumen"": """",
                ""No Siri Dokumen Terdahulu"": """",
                ""No Siri Dokumen"": """",
                ""No Dokumen Terdahulu"": """",
                ""Tarikh Tamat Passport"": """",
                ""Cawangan Memohon"": """",
                ""Tarikh Lahir"": """",
                ""No Pengenalan Semasa"": """",
                ""Nama"": """",
                ""Jantina"": """",
                ""Nama Dicetak"": """",
                ""type"": ""JIM"",
                ""QueryStartTime"": """",
                ""QueryEndTime"": """",
                ""TypeDescription"": ""JIM""
            }
        ],
    ""OrangHilang"":
        [
            {
                ""ResultStatus"": ""tiada"",
                ""Nama"": """",
                ""Jantina"": """",
                ""Agama"": """",
                ""Bangsa"": """",
                ""No Laporan"": """",
                ""No.Kad Pengenalan"": """",
                ""Kontigen"": """",
                ""Tarikh Laporan"": """",
                ""Status"": """",
                ""Gambar"": """",
                ""Balai Polis"": """",
                ""type"": ""OrangHilang"",
                ""QueryStartTime"": """",
                ""QueryEndTime"": """",
                ""TypeDescription"": ""Orang Hilang""
            }
        ],
    ""Saman"":
        [
            {
                ""ResultStatus"": ""tiada"",
                ""No.Kenderaan"": """",
                ""Nama"": """",
                ""No.Kad Pengenalan"": """",
                ""Tarikh Saman"": """",
                ""Masa Saman"": """",
                ""No.Saman"": """",
                ""Daerah"": """",
                ""Kesalahan 1"": """",
                ""Kesalahan 2"": """",
                ""Kesalahan 3"": """",
                ""Tempat Kesalahan"": """",
                ""Kompaun"": """",
                ""Waran"": """",
                ""type"": ""Saman"",
                ""QueryStartTime"": """",
                ""QueryEndTime"": """",
                ""TypeDescription"": ""Saman""
            }
        ],
    ""OrangDikehendaki "":
        [
            {
                ""ResultStatus"": ""tiada"",
                ""Nama"": """",
                ""Jantina"": """",
                ""Agama"": """",
                ""No.Laporan"": """",
                ""IPD"": """",
                ""Kontinjen"": """",
                ""Tarikh Laporan"": """",
                ""Akta Kesalahan"": """",
                ""Status"": """",
                ""Photo"": """",
                ""PhotoHex"": """",
                ""No.Kad Pengenalan"": """",
                ""Pegawai Penyiasat"": """",
                ""No.Polis"": """",
                ""Tarikh Report"": """",
                ""type"": ""OrangDkhd"",
                ""QueryStartTime"": """",
                ""QueryEndTime"": """",
                ""TypeDescription"": ""Orang Dikehendaki""
            }
        ],
    ""KenderaanHilang "":
        [
            {
                ""ResultStatus"": ""tiada"",
                ""No.Laporan"": """",
                ""Balai"": """",
                ""Kontigen"": """",
                ""Tarikh Laporan"": """",
                ""Jenis"": """",
                ""Model/Tahun Buatan"": """",
                ""Warna"": """",
                ""Pegawai Penyiasat"": """",
                ""No.Polis"": """",
                ""No Pendaftaran Kenderaan"": """",
                ""No Chasis"": """",
                ""No Enjin"": """",
                ""Recovery Indicator"": """",
                ""Recovery Report No"": """",
                ""Interim"": """",
                ""Kenderaan Dicuri Di Malaysia"": """",
                ""type"": ""KenderaanHilang"",
                ""QueryStartTime"": """",
                ""QueryEndTime"": """",
                ""TypeDescription"": ""KenderaanHilang""
            }
        ],
    ""Personel "":
        [
            {
                ""ResultStatus"": ""tiada"",
                ""Name"": """",
                ""No.Polis"": """",
                ""No.Kad Pengenalan"": """",
                ""Jantina"": """",
                ""Agama"": """",
                ""Bangsa/Keturunan"": """",
                ""Pangkat Hakiki"": """",
                ""Jawatan"": """",
                ""Cawangan"": """",
                ""Balai"": """",
                ""Daerah"": """",
                ""Kontigen"": """",
                ""Status"": """",
                ""type"": ""Personal"",
                ""QueryStartTime"": """",
                ""QueryEndTime"": """",
                ""TypeDescription"": ""Personal""
            }
        ],
        ""Types"": []
}
"; // tempNode.ToJsonString()}" == "[]" 
            JsonNode resultDBQuery = JsonNode.Parse(resultDBQuery_Asal)!;
            /*
            JsonNode tempNode = resultDBQuery!["Status"]!;
            resultDBQuery["Status"] = "ada";
            tempNode = resultDBQuery!["QueryStartTime"]!;
            tempNode = resultDBQuery["JPN"][0]["ResultStatus"];
            bool a = String.IsNullOrEmpty(tempNode.ToString()); */

            //Dapatkan data daripada DBQuery
            var servicesParam = new string[] { "jpjic", "jpn", "jpj", "orangdkhd", "oranghilang", "kenderaanhilang", "personal", "saman", "jim" };
            //string? dbqueryresult = null;
            Console.WriteLine($"Receiving Userinfo: UserTest Querying for {Query}");
            string url = "http://10.32.8.204:3000";

            /*
            foreach (var param in servicesParam)
            {
                using var client = new HttpClient();
                client.DefaultRequestHeaders.Add("servicesParam", param);
                client.DefaultRequestHeaders.Add("searchParam", $"{Query}");
                var res = await client.GetStringAsync(url);
                dbqueryresult += res;
            }
            */
            
            
            using var client = new HttpClient();
            //client.Timeout = TimeSpan.FromMinutes(0.5);
            client.DefaultRequestHeaders.Add("servicesParam", "jpn");
                client.DefaultRequestHeaders.Add("searchParam", $"{Query}");
            //var res = await client.GetStreamAsync(url);
            var res = await client.GetStringAsync(url);
            JsonNode resultDBQuery_proses = JsonNode.Parse(res)!;
            //resultDBQuery_proses!["Results"]!.ToJsonString;


            //var options = new JsonSerializerOptions { WriteIndented = true }; 
            //Console.WriteLine(forecastNode!.ToJsonString(options)); //Print all Response
            //JsonNode temperatureNode = forecastNode!["QueryStartTime"]!; //Assign QueryStartTime value to JsonNode type variable
            //Console.WriteLine($"JSON={temperatureNode.ToJsonString()}"); //Print QueryStartTime value from JsonNode Variable > QueryStartTime is assignable in this case meaning all JsonNode is also Assignable
            //int QueryStartTime_ = (int)forecastNode!["QueryStartTime"]!; //Alternative to JsonNode above
            //Console.WriteLine($"Value={QueryStartTime_}");



            // Create a JsonNode DOM from a JSON string.
            //forecastNode is Json Output
            //resultDBQuery_proses!["Results"]!.ToJsonString
            //JsonNode tempNode = resultDBQuery_proses!["Results"]!; 
            //return Ok($"{tempNode.ToJsonString()}" == "[]");
            return Ok();
        }
    }
}
