using DBQuery.Model;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.IO;
using System.IO.Pipelines;
using System.Text.Json.Nodes;
using System.Text.Json;
using System.ComponentModel;
using System;
using Microsoft.AspNetCore.Hosting.Server;
using Microsoft.Extensions.Options;
using System.Linq.Expressions;

namespace DBQuery.Controllers
{


    //[Authorize]
    [ApiController]
    [Route("[controller]")]
    [Produces("application/json")]
    public class DBQueryController : Controller
    {
        string[] arrayUser = { "G12345@test01", "G12346@test02", "G12347@test03" };

        [HttpGet]
        [Route("testUser")]
        public async Task<IActionResult> GetAsync2(string User)
        {
            
            bool testUser = Array.Exists(arrayUser, element => element == User);
            Console.WriteLine(testUser);
            return Ok(testUser);

        }

        [HttpGet]
        [Route("Checkstatus")]
        public async Task<IActionResult> GetAsync2()
        {
            string status =
@"[
  {
    ""Type"": ""JPN"",
    ""TypeDescription"": ""JPN"",
    ""Status"": true
  },
  {
    ""Type"": ""JPJ"",
    ""TypeDescription"": ""JPJ"",
    ""Status"": true
  },
  {
    ""Type"": ""JPJIC"",
    ""TypeDescription"": ""JPJ(IC)"",
    ""Status"": true
  },
  {
    ""Type"": ""OrangHilang"",
    ""TypeDescription"": ""Orang Hilang"",
    ""Status"": true
  },
  {
    ""Type"": ""KenderaanHilang"",
    ""TypeDescription"": ""Kenderaan Hilang"",
    ""Status"": true
  },
  {
    ""Type"": ""Personal"",
    ""TypeDescription"": ""Personal"",
    ""Status"": true
  },
  {
    ""Type"": ""Saman"",
    ""TypeDescription"": ""Saman"",
    ""Status"": false
  },
  {
    ""Type"": ""OrangDkhd"",
    ""TypeDescription"": ""Orang Dikehendaki"",
    ""Status"": true
  },
  {
    ""Type"": ""JIM"",
    ""TypeDescription"": ""JIM"",
    ""Status"": false
  }
]
";
            return Ok(JsonNode.Parse(status)!);

        }

        [HttpGet]
        public async Task<IActionResult> GetAsync(string Query)
        {
            Query = Query.ToLower();
            string resultDBQuery_Asal =
@"{
    ""Status"": ""ada"",
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
                ""Agama"": ""-"",
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
                ""Results"": """"
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
    ""OrangDikehendaki"":
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
    ""KenderaanHilang"":
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
    ""Personel"":
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
            JsonNode resultDBQuery0 = JsonNode.Parse(resultDBQuery_Asal)!;
            /*
            JsonNode tempNode = resultDBQuery!["Status"]!;
            resultDBQuery["Status"] = "ada";
            tempNode = resultDBQuery!["QueryStartTime"]!;
            tempNode = resultDBQuery["JPN"][0]["ResultStatus"];
            bool a = String.IsNullOrEmpty(tempNode.ToString()); */

            //Dapatkan data daripada DBQuery
            //var servicesParam = new string[] { "saman", "jim" };
            // BAHAYA!!!!!!! "kenderaanhilang" jpjic // JAAANGANNN GUNA NI : SAMAN 
            string[] servicesParam = { "jpn", "jpj", "orangdkhd", "oranghilang", "kenderaanhilang", "personal", "jpjic" }; //, "oranghilang", "kenderaanhilang", "personal", "jim" }; //, "jpjic", "jpj", "orangdkhd", "oranghilang", "kenderaanhilang", "kenderaanhilang", "personal", "saman", "jim" };
            //var servicesParam = new string[] { "jpn" };
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

            /*
            using var client = new HttpClient();
            //client.Timeout = TimeSpan.FromMinutes(0.5);
            client.DefaultRequestHeaders.Add("servicesParam", "jpn");
                client.DefaultRequestHeaders.Add("searchParam", $"{Query}");
            //var res = await client.GetStreamAsync(url);
            var res = await client.GetStringAsync(url);
            JsonNode resultDBQuery_proses = JsonNode.Parse(res)!;
            //resultDBQuery_proses!["Results"]!.ToJsonString;
            */

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

            //resultDBQuery_proses!["Results"]!

            //Converter Hex to Base64
            /*
            string strInput = "FFD8FFE000104A46494600010200000100010000FFDB0043002117191D1915211D1B1D25232128325336322E2E3266494D3C53796A7F7D776A74728596BFA2858DB5907274A6E3A8B5C6CCD6D8D681A0EBFCE9D0FABFD2D6CEFFDB004301232525322C3262363662CE897489CECECECECECECECECECECECECECECECECECECECECECECECECECECECECECECECECECECECECECECECECECECECECECECECECECEFFC000110800C8009603012200021101031101FFC4001F0000010501010101010100000000000000000102030405060708090A0BFFC400B5100002010303020403050504040000017D01020300041105122131410613516107227114328191A1082342B1C11552D1F02433627282090A161718191A25262728292A3435363738393A434445464748494A535455565758595A636465666768696A737475767778797A838485868788898A92939495969798999AA2A3A4A5A6A7A8A9AAB2B3B4B5B6B7B8B9BAC2C3C4C5C6C7C8C9CAD2D3D4D5D6D7D8D9DAE1E2E3E4E5E6E7E8E9EAF1F2F3F4F5F6F7F8F9FAFFC4001F0100030101010101010101010000000000000102030405060708090A0BFFC400B51100020102040403040705040400010277000102031104052131061241510761711322328108144291A1B1C109233352F0156272D10A162434E125F11718191A262728292A35363738393A434445464748494A535455565758595A636465666768696A737475767778797A82838485868788898A92939495969798999AA2A3A4A5A6A7A8A9AAB2B3B4B5B6B7B8B9BAC2C3C4C5C6C7C8C9CAD2D3D4D5D6D7D8D9DAE2E3E4E5E6E7E8E9EAF2F3F4F5F6F7F8F9FAFFDA000C03010002110311003F00DFA28A2800A28A2800A28A2800A28A2800A28A2800A28A2800A28A2800A28A2800A28A2800A28A2800A28A2800A28A2800A28A82E2E12DA23248700741EB40129200C9354E6D4EDA2246FDE7FD919AC8BED424B93B7EEC79C802A9134EC266D7F6E0FF009E07FEFBFF00EB5452EB721CF971AAFD4E6B268CD006B26B920C092253EEA6AFDBEA76D3E06ED8C7B3715CD8C1E29391401D88208C83914EAE5ACEFE5B56F94EE5FEE9AE86D6E52EA20E9F88EE0D219628A28A0028A28A0028A28A0028A28A0028A28A0063B0452C7A019AE72F6EDEEA424F0A3EEAFA7BFD6AF6B170722043818CB63BFA564E29A10C3DF9A69A908A51096FBA2802139A77F3AB1F662BF5A6F94D8E05171D88467F1A523E82A6099E830698F1B01C9A41621AB16774F6D28743C771EB507AD25311D75BCE971109233C1A96B0F459F6CC613C87E47D6B7690C28A28A0028A28A0028A28A0029A485193D053AABDEE4DA4A17AED3D28039F9E432CAF2127E6351819ED41EBC1AB11C7BA80B11C7164D68431851D39A891706AC21A86CD1217CB069DE4A91D29D9F414EED81525D884C4B8E05549611B7A55E66A81CE69A62B192C98E0D3315A0F1E4E6ABBC7B4568999344504862951D7AA9CD7568C1D430E8466B9235D2698DBAC623E991FAD364A2E5145148614514500145145001556FDC259CC7FD9C7E756AB37589505B7959F9988E28030CD5E8BEE8AA71AEF702AD3CC23CAAF2686344E2AC22F15981E76FBA314AB3DC27BFD4543572D33542D3F1C555B7BA665F9C0CD58330C1C54D8B031E6A09531514F3C9D11B18AABFBF73D58D509B2C1F4A8A61F21E2A322E10FCC334E593CCF94F06990D950F6ADFD21C35820FEE920FE7FFD7AC29576B9AD5D1265DB2444FCD9DC2AC8EA6C5145148028A28A0028A28A004AC6D5622D331EF80456CD52D490188377E450331AD472DED536D54058D25A8C293EF53ED06931A455796631EF8F0067EEF7A7C11978DE491B073F2A9E09F5AB013E87EA29D923DFF0A9BA2ECC853E561CE54F4AB87023AA8796A9DB84A4522BB0279F7C545389A37FDCBC8EA57B7183569339E29F86F5228135729EF99426E6F3323E6E3A53CA0621BBD4FE593C9E6984629DC56295C8F9C55FD3600B246476E6AA5C2E4AD6A69EA724FB555CCCD0A28A298828A28A0028A28A002AB5E2EEB66F6AB34C9398D80E7834018710C023DEAC260D44DFEB5BDE9F137352CB893ECA6B8C0A786E0D45364A13506C32300B54F2AFC82A057453C54D24A9B3AD3110A101EAC8C1AABF2C8404FBD9A9CE539CD2D811230E2AB49DEA52F5039C9A771322C6664F6AD5B31F213EF8ACD88132E6B5E01FBA5CFD6ACC592D14514C414514500145145001451450050BDB750A655E0F715401C1AD9993CC8993D4562E4E79EB498D128738029FE6678C543DBDE984C8A7E5C5458DAE4FB327A53BCA5FEED575331FE2C5498948C1905161A64A004E45219B9C5566F35470F42ABB72C79F6A2C2B92BB71C5371EB476C5216A68965FB181193CC65C9CE067D2AF5456C9E5C08A7A81CFD6A5AB32168A28A0028A28A0028A28A0028A28A004AC7D42130CC580F95F9AD9AA97AD12DBB095946410A09EA7B50064A373CD4BDAAA6706ACC4C0F5C54346A9922B63DE97CC73FC14DC73D69E0903AD2B968427D462901E29B924D364600502635DB1D2A6B084CD364FDD5E4E6A916C9E2AFE9B3C713B248DB5A4FBB9E01C55232933628A28AA2428A28A0028A28A0028A28A0028A28A0082E665B781E57E8BDBD6B9896E249EE96490E5B774EC07A0AD5D6AE2368562470CDBB24039E3FCE2B147FAD5A00B84669016434AB9A791C54DCB4872CE3BD3CCC31D454200E2976A6380335258A6E003C726A225A43E829C463A0A720E2988685DA2A1BA3F2AFD6AC9E2AADC1E07AE69A25A36F48BA6B8B728E72F1F049EE3B569572FA75E0B39CBB025180071DBDF15D041730DC2868A457FA1E7F2AA20B145145001451450014C2C1572C703D49AC29F5A9DF889163F73C9FF000ACF9A692639964673EE68B01BD73AC5B4476C7999BFD9E9F9D63DDEA33DCE4336C4FEE2F19FA9EF5573E94847A5315C504018A33D0FA5345039EB4017626C80454EBCD67C5218DBDAAF46D9E41E2B368D62C76DE7A51B4FA53BAD15258C229E381C5262949C0A6808DCD5295B739F41DEA5B8971F2A9E6AB741571329317BD1D391D69A0F34B9E715466685A6AB3C036BFEF93D09E47E35AB6FAADB4C305FCA6F47E3F5AE6C7A519F5A2C33B1565650548607B8E6973EC7F2AE3D1D909D8ECBFEE9C53FCD93FE7AC9FF007D52B05C8A8ED494531051477A28013BD069693B5030152C52988FFB3E951500D1605A1AF110E9907229C4565C333C2D943F51D41AD186EE2907CC761F46ACDC4DA32BEE3803556EA609F22E37FF002A75CDE81948793DDBD2A87BE7269A88A520EFC9CD3492697BFA527E1566428A297145020A28A28002693345140C5A28A281076A4A5ED4940C5A0F1D28A0D020A434B48681A133E98A4E9EA4520A77F0D00275C528348BDA81400EA41C914B48BD4500C7D252D25020CD0292945001F951F95251401FFFD99074000000002C00000000000000";
            string? base64input = null;
            var bytes = new byte[strInput.Length / 2];
            for (var i = 0; i < bytes.Length; i++){
                bytes[i] = Convert.ToByte(strInput.Substring(i * 2, 2), 16);
            }
            string? base64input = Convert.ToBase64String(bytes);
            */
            JsonNode? resultDBQuery_proses = null;
            //string? tempStr = null;

            /*
            using var client = new HttpClient();
            //client.Timeout = TimeSpan.FromMinutes(0.5);
            client.DefaultRequestHeaders.Add("servicesParam", "jpn");
            client.DefaultRequestHeaders.Add("searchParam", $"{Query}");
            //var res = await client.GetStreamAsync(url);
            var res = await client.GetStringAsync(url);
            resultDBQuery_proses = JsonNode.Parse(res)!;
            //resultDBQuery_proses!["Results"]!.ToJsonString;
            //tempNode = resultDBQuery_proses["Results"][0]["Nama"];
            //resultDBQuery["JPN"][0]["Nama"] = tempNode;
            //string temp = resultDBQuery_proses["Results"].ToJsonString();//.ToJsonString();

            if (resultDBQuery0["Types"].ToString() != resultDBQuery_proses["Results"].ToString()) { 
                resultDBQuery["Status"] = "ada";
            resultDBQuery["QueryStartTime"] = resultDBQuery_proses["Results"][0]["QueryStartTime"].ToString();
            resultDBQuery["JPN"][0]["ResultStatus"] = "ada";
            resultDBQuery["JPN"][0]["Nama"] = resultDBQuery_proses["Results"][0]["Nama"].ToString();
            resultDBQuery["JPN"][0]["No.Kad Pengenalan"] = resultDBQuery_proses["Results"][0]["No.Kad Pengenalan"].ToString();
            resultDBQuery["JPN"][0]["No.Kad Pengenalan Lama"] = resultDBQuery_proses["Results"][0]["No.Kad Pengenalan Lama"].ToString();
            resultDBQuery["JPN"][0]["Tarikh Lahir"] = resultDBQuery_proses["Results"][0]["Tarikh Lahir"].ToString();
            resultDBQuery["JPN"][0]["Jantina"] = resultDBQuery_proses["Results"][0]["Jantina"].ToString();
            resultDBQuery["JPN"][0]["Agama"] = resultDBQuery_proses["Results"][0]["Agama"].ToString();
            resultDBQuery["JPN"][0]["Bangsa/Keturunan"] = resultDBQuery_proses["Results"][0]["Bangsa/Keturunan"].ToString();
            resultDBQuery["JPN"][0]["Alamat Tetap"] = resultDBQuery_proses["Results"][0]["Alamat Tetap"].ToString();
            resultDBQuery["JPN"][0]["Alamat Surat-menyurat"] = resultDBQuery_proses["Results"][0]["Alamat Surat-menyurat"].ToString();
            resultDBQuery["JPN"][0]["Tarikh Kematian"] = resultDBQuery_proses["Results"][0]["Tarikh Kematian"].ToString();
            resultDBQuery["JPN"][0]["Status Kediaman"] = resultDBQuery_proses["Results"][0]["Status Kediaman"].ToString();
            resultDBQuery["JPN"][0]["Kewarganegaraan"] = resultDBQuery_proses["Results"][0]["Kewarganegaraan"].ToString();
            resultDBQuery["JPN"][0]["Alamat e-mel"] = resultDBQuery_proses["Results"][0]["Alamat e-mel"].ToString();
            resultDBQuery["JPN"][0]["No. Telefon"] = resultDBQuery_proses["Results"][0]["No. Telefon"].ToString();
            resultDBQuery["JPN"][0]["QueryStartTime"] = resultDBQuery_proses["Results"][0]["QueryStartTime"].ToString();
            resultDBQuery["JPN"][0]["QueryEndTime"] = resultDBQuery_proses["Results"][0]["QueryEndTime"].ToString();
            //resultDBQuery["JPN"][0]["Nama"] = resultDBQuery_proses["Results"][0]["Nama"].ToString();
            string strInput = resultDBQuery_proses["Results"][0]["Photo"].ToString();
            var bytes = new byte[strInput.Length / 2];
            for (var i = 0; i < bytes.Length; i++)
            {
                bytes[i] = Convert.ToByte(strInput.Substring(i * 2, 2), 16);
            }
            string? base64input = Convert.ToBase64String(bytes);
            resultDBQuery["JPN"][0]["Photo"] = base64input;
            }
            */
            JsonNode? tempspresponse = null;
            foreach (var sp in servicesParam)
            {
                using var client = new HttpClient();
                //client.Timeout = TimeSpan.FromMinutes(0.5);
                client.DefaultRequestHeaders.Add("servicesParam", $"{sp}");
                client.DefaultRequestHeaders.Add("searchParam", $"{Query}");
                //var res = await client.GetStreamAsync(url);
                var res = await client.GetStringAsync(url);
                resultDBQuery_proses = JsonNode.Parse(res)!;
                //resultDBQuery_proses!["Results"]!.ToJsonString;
                //tempNode = resultDBQuery_proses["Results"][0]["Nama"];
                //resultDBQuery["JPN"][0]["Nama"] = tempNode;
                if (sp == "personal")
                {
                    tempspresponse = resultDBQuery_proses;
                }

                if (resultDBQuery0["Types"].ToString() != resultDBQuery_proses["Results"].ToString())
                {
                    switch (sp)
                    {
                        case "jpn":
                            resultDBQuery["Status"] = "ada";
                            resultDBQuery["QueryStartTime"] = resultDBQuery_proses["Results"][0]["QueryStartTime"].ToString();
                            resultDBQuery["JPN"][0]["ResultStatus"] = "ada";
                            resultDBQuery["JPN"][0]["Nama"] = resultDBQuery_proses["Results"][0]["Nama"].ToString();
                            resultDBQuery["JPN"][0]["No.Kad Pengenalan"] = resultDBQuery_proses["Results"][0]["No.Kad Pengenalan"].ToString();
                            resultDBQuery["JPN"][0]["No.Kad Pengenalan Lama"] = resultDBQuery_proses["Results"][0]["No.Kad Pengenalan Lama"].ToString();
                            resultDBQuery["JPN"][0]["Tarikh Lahir"] = resultDBQuery_proses["Results"][0]["Tarikh Lahir"].ToString();
                            resultDBQuery["JPN"][0]["Jantina"] = resultDBQuery_proses["Results"][0]["Jantina"].ToString();
                            resultDBQuery["JPN"][0]["Agama"] = resultDBQuery_proses["Results"][0]["Agama"]?.ToString();
                            //if(resultDBQuery_proses["Results"][0]["Agama"].ToString() == null){
                            /*if (Array.Exists(resultDBQuery_proses["Results"][0].ToJsonString(), element => element == "Agama")) { 
                                resultDBQuery["JPN"][0]["Agama"] = resultDBQuery_proses["Results"][0]["Agama"].ToString();
                            };*/
                            resultDBQuery["JPN"][0]["Bangsa/Keturunan"] = resultDBQuery_proses["Results"][0]["Bangsa/Keturunan"].ToString();
                            resultDBQuery["JPN"][0]["Alamat Tetap"] = resultDBQuery_proses["Results"][0]["Alamat Tetap"].ToString();
                            resultDBQuery["JPN"][0]["Alamat Surat-menyurat"] = resultDBQuery_proses["Results"][0]["Alamat Surat-menyurat"].ToString();
                            resultDBQuery["JPN"][0]["Tarikh Kematian"] = resultDBQuery_proses["Results"][0]["Tarikh Kematian"].ToString();
                            resultDBQuery["JPN"][0]["Status Kediaman"] = resultDBQuery_proses["Results"][0]["Status Kediaman"].ToString();
                            resultDBQuery["JPN"][0]["Kewarganegaraan"] = resultDBQuery_proses["Results"][0]["Kewarganegaraan"].ToString();
                            resultDBQuery["JPN"][0]["Alamat e-mel"] = resultDBQuery_proses["Results"][0]["Alamat e-mel"].ToString();
                            resultDBQuery["JPN"][0]["No. Telefon"] = resultDBQuery_proses["Results"][0]["No. Telefon"].ToString();
                            resultDBQuery["JPN"][0]["QueryStartTime"] = resultDBQuery_proses["Results"][0]["QueryStartTime"].ToString();
                            resultDBQuery["JPN"][0]["QueryEndTime"] = resultDBQuery_proses["Results"][0]["QueryEndTime"].ToString();
                            //resultDBQuery["JPN"][0]["Nama"] = resultDBQuery_proses["Results"][0]["Nama"].ToString();
                            string strInput = resultDBQuery_proses["Results"][0]["Photo"].ToString();
                            var bytes = new byte[strInput.Length / 2];
                            for (var i = 0; i < bytes.Length; i++)
                            {
                                bytes[i] = Convert.ToByte(strInput.Substring(i * 2, 2), 16);
                            }
                            string? base64input = Convert.ToBase64String(bytes);
                            resultDBQuery["JPN"][0]["Photo"] = base64input;
                            break;
                        case "jpjic":
                            resultDBQuery["Status"] = "ada";
                            resultDBQuery["JPJIC"][0]["ResultStatus"] = "ada";
                            //JsonNode? weatherForecast = 
                            resultDBQuery["JPJIC"][0]["Results"] = JsonSerializer.Deserialize<JsonNode>(resultDBQuery_proses["Results"].ToJsonString());
                            


                            /*resultDBQuery["JPJIC"][0]["Nama"] = resultDBQuery_proses["Results"][0]["Nama"].ToString();
                            resultDBQuery["JPJIC"][0]["No.Kenderaan"] = resultDBQuery_proses["Results"][0]["No.Kenderaan"].ToString();
                            resultDBQuery["JPJIC"][0]["Model"] = resultDBQuery_proses["Results"][0]["Model"].ToString();
                            resultDBQuery["JPJIC"][0]["Tarikh Model"] = resultDBQuery_proses["Results"][0]["Tarikh Model"].ToString();
                            resultDBQuery["JPJIC"][0]["QueryStartTime"] = resultDBQuery_proses["Results"][0]["QueryStartTime"].ToString();
                            resultDBQuery["JPJIC"][0]["QueryEndTime"] = resultDBQuery_proses["Results"][0]["QueryEndTime"].ToString();*/
                            break;
                        case "jpj":
                            resultDBQuery["JPJ"][0]["ResultStatus"] = "ada";
                            resultDBQuery["JPJ"][0]["Nama"] = resultDBQuery_proses["Results"][0]["Nama"].ToString();
                            resultDBQuery["JPJ"][0]["No KP/Paspot"] = resultDBQuery_proses["Results"][0]["No KP/Paspot"].ToString();
                            resultDBQuery["JPJ"][0]["Kategori"] = resultDBQuery_proses["Results"][0]["Kategori"].ToString();
                            resultDBQuery["JPJ"][0]["Alamat"] = resultDBQuery_proses["Results"][0]["Alamat"].ToString();
                            resultDBQuery["JPJ"][0]["No Pendaftaran Lama"] = resultDBQuery_proses["Results"][0]["No Pendaftaran Kenderaan"].ToString();
                            resultDBQuery["JPJ"][0]["No Chasis"] = resultDBQuery_proses["Results"][0]["No Chasis"].ToString();
                            resultDBQuery["JPJ"][0]["Jenis Badan"] = resultDBQuery_proses["Results"][0]["Jenis Badan"].ToString();
                            resultDBQuery["JPJ"][0]["No Enjin"] = resultDBQuery_proses["Results"][0]["No Enjin"].ToString();
                            resultDBQuery["JPJ"][0]["Kuasa Enjin"] = resultDBQuery_proses["Results"][0]["Kuasa Enjin"].ToString();
                            resultDBQuery["JPJ"][0]["Model"] = resultDBQuery_proses["Results"][0]["Model"].ToString();
                            resultDBQuery["JPJ"][0]["Tahun Keluaran Model"] = resultDBQuery_proses["Results"][0]["Tahun Keluaran Model"].ToString();
                            resultDBQuery["JPJ"][0]["Warna"] = resultDBQuery_proses["Results"][0]["Warna"].ToString();
                            resultDBQuery["JPJ"][0]["Status"] = resultDBQuery_proses["Results"][0]["Status"].ToString();
                            resultDBQuery["JPJ"][0]["Kod Kegunaan"] = resultDBQuery_proses["Results"][0]["Kod Kegunaan"].ToString();
                            resultDBQuery["JPJ"][0]["Tarikh Daftar"] = resultDBQuery_proses["Results"][0]["Tarikh Daftar"].ToString();
                            resultDBQuery["JPJ"][0]["No LKM"] = resultDBQuery_proses["Results"][0]["No LKM"].ToString();
                            resultDBQuery["JPJ"][0]["Tempoh LKM"] = resultDBQuery_proses["Results"][0]["Tempoh LKM"].ToString();
                            resultDBQuery["JPJ"][0]["Syarikat Insurans"] = resultDBQuery_proses["Results"][0]["Syarikat Insurans"].ToString();
                            resultDBQuery["JPJ"][0]["No Polisi"] = resultDBQuery_proses["Results"][0]["No Polisi"].ToString();
                            resultDBQuery["JPJ"][0]["Tempoh Insurans"] = resultDBQuery_proses["Results"][0]["Tempoh Insurans"].ToString();
                            resultDBQuery["JPJ"][0]["QueryStartTime"] = resultDBQuery_proses["Results"][0]["QueryStartTime"].ToString();
                            resultDBQuery["JPJ"][0]["QueryEndTime"] = resultDBQuery_proses["Results"][0]["QueryEndTime"].ToString();
                            break;
                        case "orangdkhd": 
                            resultDBQuery["OrangDikehendaki"][0]["ResultStatus"] = "ada";
                            resultDBQuery["OrangDikehendaki"][0]["Nama"] = resultDBQuery_proses["Results"][0]["Nama"].ToString();
                            resultDBQuery["OrangDikehendaki"][0]["Jantina"] = resultDBQuery_proses["Results"][0]["Jantina"].ToString();
                            resultDBQuery["OrangDikehendaki"][0]["Agama"] = resultDBQuery_proses["Results"][0]["Agama"].ToString();
                            resultDBQuery["OrangDikehendaki"][0]["No.Laporan"] = resultDBQuery_proses["Results"][0]["No.Laporan"].ToString();
                            resultDBQuery["OrangDikehendaki"][0]["IPD"] = resultDBQuery_proses["Results"][0]["IPD"].ToString();
                            resultDBQuery["OrangDikehendaki"][0]["Kontinjen"] = resultDBQuery_proses["Results"][0]["Kontinjen"].ToString();
                            resultDBQuery["OrangDikehendaki"][0]["Tarikh Laporan"] = resultDBQuery_proses["Results"][0]["Tarikh Laporan"].ToString();
                            resultDBQuery["OrangDikehendaki"][0]["Akta Kesalahan"] = resultDBQuery_proses["Results"][0]["Akta Kesalahan"].ToString();
                            resultDBQuery["OrangDikehendaki"][0]["Status"] = resultDBQuery_proses["Results"][0]["Status"].ToString();
                            resultDBQuery["OrangDikehendaki"][0]["Photo"] = resultDBQuery_proses["Results"][0]["Photo"].ToString();
                            resultDBQuery["OrangDikehendaki"][0]["No.Kad Pengenalan"] = resultDBQuery_proses["Results"][0]["No.Kad Pengenalan"].ToString();
                            resultDBQuery["OrangDikehendaki"][0]["Pegawai Penyiasat"] = resultDBQuery_proses["Results"][0]["Pegawai Penyiasat"].ToString();
                            resultDBQuery["OrangDikehendaki"][0]["No.Polis"] = resultDBQuery_proses["Results"][0]["No.Polis"].ToString();
                            resultDBQuery["OrangDikehendaki"][0]["Tarikh Report"] = resultDBQuery_proses["Results"][0]["Tarikh Report"].ToString();
                            resultDBQuery["OrangDikehendaki"][0]["QueryStartTime"] = resultDBQuery_proses["Results"][0]["QueryStartTime"].ToString();
                            resultDBQuery["OrangDikehendaki"][0]["QueryEndTime"] = resultDBQuery_proses["Results"][0]["QueryEndTime"].ToString();
                            //resultDBQuery["OrangDikehendaki"][0]["PhotoHex"] = resultDBQuery_proses["Results"][0]["PhotoHex"].ToString();
                            //string strInput = resultDBQuery_proses["Results"][0]["PhotoHex"].ToString();
                            if(resultDBQuery_proses["Results"][0]["Photo"].ToString() != "0"){
                                strInput = resultDBQuery_proses["Results"][0]["PhotoHex"].ToString();
                                //var bytes = new byte[strInput.Length / 2];
                                bytes = new byte[strInput.Length / 2];
                                for (var i = 0; i < bytes.Length; i++)
                                {
                                    bytes[i] = Convert.ToByte(strInput.Substring(i * 2, 2), 16);
                                }
                                //string? base64input = Convert.ToBase64String(bytes);
                                base64input = Convert.ToBase64String(bytes);
                                resultDBQuery["OrangDikehendaki"][0]["PhotoHex"] = base64input;
                            };
                            break;
                        case "oranghilang":
                            resultDBQuery["OrangHilang"][0]["ResultStatus"] = "ada";
                            resultDBQuery["OrangHilang"][0]["Nama"] = resultDBQuery_proses["Results"][0]["Nama"].ToString();
                            resultDBQuery["OrangHilang"][0]["Jantina"] = resultDBQuery_proses["Results"][0]["Jantina"].ToString();
                            resultDBQuery["OrangHilang"][0]["Agama"] = resultDBQuery_proses["Results"][0]["Agama"].ToString();
                            resultDBQuery["OrangHilang"][0]["Bangsa"] = resultDBQuery_proses["Results"][0]["Bangsa"].ToString();
                            resultDBQuery["OrangHilang"][0]["No Laporan"] = resultDBQuery_proses["Results"][0]["No Laporan"].ToString();
                            resultDBQuery["OrangHilang"][0]["No.Kad Pengenalan"] = resultDBQuery_proses["Results"][0]["No.Kad Pengenalan"].ToString();
                            resultDBQuery["OrangHilang"][0]["Kontigen"] = resultDBQuery_proses["Results"][0]["Kontigen"].ToString();
                            resultDBQuery["OrangHilang"][0]["Tarikh Laporan"] = resultDBQuery_proses["Results"][0]["Tarikh Laporan"].ToString();
                            resultDBQuery["OrangHilang"][0]["Status"] = resultDBQuery_proses["Results"][0]["Status"].ToString();
                            resultDBQuery["OrangHilang"][0]["Gambar"] = resultDBQuery_proses["Results"][0]["Gambar"].ToString();
                            resultDBQuery["OrangHilang"][0]["Balai Polis"] = resultDBQuery_proses["Results"][0]["Balai Polis"].ToString();
                            resultDBQuery["OrangHilang"][0]["QueryStartTime"] = resultDBQuery_proses["Results"][0]["QueryStartTime"].ToString();
                            resultDBQuery["OrangHilang"][0]["QueryEndTime"] = resultDBQuery_proses["Results"][0]["QueryEndTime"].ToString();
                            break;
                        case "kenderaanhilang":
                            resultDBQuery["KenderaanHilang"][0]["ResultStatus"] = "ada";
                            resultDBQuery["KenderaanHilang"][0]["No.Laporan"] = resultDBQuery_proses["Results"][0]["No.Laporan"].ToString();
                            resultDBQuery["KenderaanHilang"][0]["Balai"] = resultDBQuery_proses["Results"][0]["Balai"].ToString();
                            resultDBQuery["KenderaanHilang"][0]["Kontigen"] = resultDBQuery_proses["Results"][0]["Kontigen"].ToString();
                            resultDBQuery["KenderaanHilang"][0]["Tarikh Laporan"] = resultDBQuery_proses["Results"][0]["Tarikh Laporan"].ToString();
                            resultDBQuery["KenderaanHilang"][0]["Jenis"] = resultDBQuery_proses["Results"][0]["Jenis"].ToString();
                            resultDBQuery["KenderaanHilang"][0]["Model/Tahun Buatan"] = resultDBQuery_proses["Results"][0]["Model/Tahun Buatan"].ToString();
                            resultDBQuery["KenderaanHilang"][0]["Warna"] = resultDBQuery_proses["Results"][0]["Warna"].ToString();
                            resultDBQuery["KenderaanHilang"][0]["Pegawai Penyiasat"] = resultDBQuery_proses["Results"][0]["Pegawai Penyiasat"].ToString();
                            resultDBQuery["KenderaanHilang"][0]["No.Polis"] = resultDBQuery_proses["Results"][0]["No.Polis"].ToString();
                            resultDBQuery["KenderaanHilang"][0]["No Pendaftaran Kenderaan"] = resultDBQuery_proses["Results"][0]["No Pendaftaran Kenderaan"].ToString();
                            resultDBQuery["KenderaanHilang"][0]["No Chasis"] = resultDBQuery_proses["Results"][0]["No Chasis"].ToString();
                            resultDBQuery["KenderaanHilang"][0]["No Enjin"] = resultDBQuery_proses["Results"][0]["No Enjin"].ToString();
                            resultDBQuery["KenderaanHilang"][0]["Recovery Indicator"] = resultDBQuery_proses["Results"][0]["Recovery Indicator"].ToString();
                            resultDBQuery["KenderaanHilang"][0]["Recovery Report No"] = resultDBQuery_proses["Results"][0]["Recovery Report No"].ToString();
                            resultDBQuery["KenderaanHilang"][0]["Interim"] = resultDBQuery_proses["Results"][0]["Interim"].ToString();
                            resultDBQuery["KenderaanHilang"][0]["Kenderaan Dicuri Di Malaysia"] = resultDBQuery_proses["Results"][0]["Kenderaan Dicuri Di Malaysia"].ToString();
                            resultDBQuery["KenderaanHilang"][0]["QueryStartTime"] = resultDBQuery_proses["Results"][0]["QueryStartTime"].ToString();
                            resultDBQuery["KenderaanHilang"][0]["QueryEndTime"] = resultDBQuery_proses["Results"][0]["QueryEndTime"].ToString();
                            break;
                        case "personal":
                            resultDBQuery["Personel"][0]["ResultStatus"] = "ada";
                            resultDBQuery["Personel"][0]["Name"] = resultDBQuery_proses["Results"][0]["Name"].ToString();
                            resultDBQuery["Personel"][0]["No.Polis"] = resultDBQuery_proses["Results"][0]["No.Polis"].ToString();
                            resultDBQuery["Personel"][0]["No.Kad Pengenalan"] = resultDBQuery_proses["Results"][0]["No.Kad Pengenalan"].ToString();
                            resultDBQuery["Personel"][0]["Jantina"] = resultDBQuery_proses["Results"][0]["Jantina"].ToString();
                            resultDBQuery["Personel"][0]["Bangsa/Keturunan"] = resultDBQuery_proses["Results"][0]["Bangsa/Keturunan"].ToString();
                            resultDBQuery["Personel"][0]["Agama"] = resultDBQuery_proses["Results"][0]["Agama"].ToString();
                            resultDBQuery["Personel"][0]["Pangkat Hakiki"] = resultDBQuery_proses["Results"][0]["Pangkat Hakiki"].ToString();
                            resultDBQuery["Personel"][0]["Jawatan"] = resultDBQuery_proses["Results"][0]["Jawatan"].ToString();
                            resultDBQuery["Personel"][0]["Balai"] = resultDBQuery_proses["Results"][0]["Balai"].ToString();
                            resultDBQuery["Personel"][0]["Daerah"] = resultDBQuery_proses["Results"][0]["Daerah"].ToString();
                            resultDBQuery["Personel"][0]["Kontigen"] = resultDBQuery_proses["Results"][0]["Kontigen"].ToString();
                            resultDBQuery["Personel"][0]["Status"] = resultDBQuery_proses["Results"][0]["Status"].ToString();
                            resultDBQuery["Personel"][0]["QueryStartTime"] = resultDBQuery_proses["Results"][0]["QueryStartTime"].ToString();
                            resultDBQuery["Personel"][0]["QueryEndTime"] = resultDBQuery_proses["Results"][0]["QueryEndTime"].ToString();
                            break;
                        case "saman":
                            resultDBQuery["Saman"][0]["ResultStatus"] = "ada";
                            resultDBQuery["Saman"][0]["Nama"] = resultDBQuery_proses["Results"][0]["Nama"].ToString();
                            resultDBQuery["Saman"][0]["No.Kad Pengenalan"] = resultDBQuery_proses["Results"][0]["No.Kad Pengenalan"].ToString();
                            resultDBQuery["Saman"][0]["Tarikh Saman"] = resultDBQuery_proses["Results"][0]["Tarikh Saman"].ToString();
                            resultDBQuery["Saman"][0]["Masa Saman"] = resultDBQuery_proses["Results"][0]["Masa Saman"].ToString();
                            resultDBQuery["Saman"][0]["No.Saman"] = resultDBQuery_proses["Results"][0]["No.Saman"].ToString();
                            resultDBQuery["Saman"][0]["Daerah"] = resultDBQuery_proses["Results"][0]["Daerah"].ToString();
                            resultDBQuery["Saman"][0]["Kesalahan 1"] = resultDBQuery_proses["Results"][0]["Kesalahan 1"].ToString();
                            resultDBQuery["Saman"][0]["Kesalahan 2"] = resultDBQuery_proses["Results"][0]["Kesalahan 2"].ToString();
                            resultDBQuery["Saman"][0]["Kesalahan 3"] = resultDBQuery_proses["Results"][0]["Kesalahan 3"].ToString();
                            resultDBQuery["Saman"][0]["Tempat Kesalahan"] = resultDBQuery_proses["Results"][0]["Tempat Kesalahan"].ToString();
                            resultDBQuery["Saman"][0]["Kompaun"] = resultDBQuery_proses["Results"][0]["Kompaun"].ToString();
                            resultDBQuery["Saman"][0]["Waran"] = resultDBQuery_proses["Results"][0]["Waran"].ToString();
                            resultDBQuery["Saman"][0]["QueryStartTime"] = resultDBQuery_proses["Results"][0]["QueryStartTime"].ToString();
                            resultDBQuery["Saman"][0]["QueryEndTime"] = resultDBQuery_proses["Results"][0]["QueryEndTime"].ToString();
                            break;
                        case "jim":
                            resultDBQuery["Status"] = "ada";
                            resultDBQuery["JIM"][0]["ResultStatus"] = "ada";
                            resultDBQuery["JIM"][0]["No Dokumen"] = resultDBQuery_proses["Results"][0]["No Dokumen"].ToString();
                            resultDBQuery["JIM"][0]["Tarikh Mula Passport"] = resultDBQuery_proses["Results"][0]["Tarikh Mula Passport"].ToString();
                            resultDBQuery["JIM"][0]["Sebab Batal"] = resultDBQuery_proses["Results"][0]["Sebab Batal"].ToString();
                            resultDBQuery["JIM"][0]["No Rujukan Pemilik"] = resultDBQuery_proses["Results"][0]["No Rujukan Pemilik"].ToString();
                            resultDBQuery["JIM"][0]["Cawangan Mengeluar"] = resultDBQuery_proses["Results"][0]["Cawangan Mengeluar"].ToString();
                            resultDBQuery["JIM"][0]["Sebab Sah"] = resultDBQuery_proses["Results"][0]["Sebab Sah"].ToString();
                            resultDBQuery["JIM"][0]["Status Rekod"] = resultDBQuery_proses["Results"][0]["Status Rekod"].ToString();
                            resultDBQuery["JIM"][0]["Jenis Dokumen"] = resultDBQuery_proses["Results"][0]["Jenis Dokumen"].ToString();
                            resultDBQuery["JIM"][0]["No Siri Dokumen Terdahulu"] = resultDBQuery_proses["Results"][0]["No Siri Dokumen Terdahulu"].ToString();
                            resultDBQuery["JIM"][0]["No Siri Dokumen"] = resultDBQuery_proses["Results"][0]["No Siri Dokumen"].ToString();
                            resultDBQuery["JIM"][0]["No Dokumen Terdahulu"] = resultDBQuery_proses["Results"][0]["No Dokumen Terdahulu"].ToString();
                            resultDBQuery["JIM"][0]["Tarikh Tamat Passport"] = resultDBQuery_proses["Results"][0]["Tarikh Tamat Passport"].ToString();
                            resultDBQuery["JIM"][0]["Cawangan Memohon"] = resultDBQuery_proses["Results"][0]["Cawangan Memohon"].ToString();
                            resultDBQuery["JIM"][0]["Tarikh Lahir"] = resultDBQuery_proses["Results"][0]["Tarikh Lahir"].ToString();
                            resultDBQuery["JIM"][0]["No Pengenalan Semasa"] = resultDBQuery_proses["Results"][0]["No Pengenalan Semasa"].ToString();
                            resultDBQuery["JIM"][0]["Nama"] = resultDBQuery_proses["Results"][0]["Nama"].ToString();
                            resultDBQuery["JIM"][0]["Jantina"] = resultDBQuery_proses["Results"][0]["Jantina"].ToString();
                            resultDBQuery["JIM"][0]["Nama Dicetak"] = resultDBQuery_proses["Results"][0]["Nama Dicetak"].ToString();
                            resultDBQuery["JIM"][0]["QueryStartTime"] = resultDBQuery_proses["Results"][0]["QueryStartTime"].ToString();
                            resultDBQuery["JIM"][0]["QueryEndTime"] = resultDBQuery_proses["Results"][0]["QueryEndTime"].ToString();
                            break;
                        default:
                            break;
                    }
                }
            };

            return Ok(resultDBQuery);
        }
    }
}