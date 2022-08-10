using Newtonsoft.Json;
using System.Text.Json.Serialization;

namespace DBQuery.Model
{
    public class DBQuery
    {
        public string? Name { get; set; }
        public string? Password { get; set; }
        public string? Query { get; set; }
        public string[]? servicesParam { get; set; }
        public string? Results { get; set; }
    }

    public class Result
    {
        [JsonPropertyName("Nama")]
        public string? Nama;

        [JsonPropertyName("No.Kad Pengenalan")]
        public string? NoKadPengenalan;

        [JsonPropertyName("No.Kad Pengenalan Lama")]
        public string? NoKadPengenalanLama;

        [JsonPropertyName("Tarikh Lahir")]
        public string? TarikhLahir;

        [JsonPropertyName("Jantina")]
        public string? Jantina;

        [JsonPropertyName("Agama")]
        public string? Agama;

        [JsonPropertyName("Bangsa/Keturunan")]
        public string? BangsaKeturunan;

        [JsonPropertyName("Alamat Tetap")]
        public string? AlamatTetap;

        [JsonPropertyName("Alamat Surat-menyurat")]
        public string? AlamatSuratMenyurat;

        [JsonPropertyName("Tarikh Kematian")]
        public string? TarikhKematian;

        [JsonPropertyName("Status Kediaman")]
        public string? StatusKediaman;

        [JsonPropertyName("Kewarganegaraan")]
        public string? Kewarganegaraan;

        [JsonPropertyName("Alamat e-mel")]
        public string? AlamatEMel;

        [JsonPropertyName("No. Telefon")]
        public string? NoTelefon;

        [JsonPropertyName("type")]
        public string? Type;

        [JsonPropertyName("Photo")]
        public string? Photo;

        [JsonPropertyName("QueryStartTime")]
        public string? QueryStartTime;

        [JsonPropertyName("QueryEndTime")]
        public string? QueryEndTime;

        [JsonPropertyName("TypeDescription")]
        public string? TypeDescription;
    }

    public class Rootza
    {
        [JsonPropertyName("QueryStartTime")]
        public string? QueryStartTime;

        [JsonPropertyName("QueryEndTime")]
        public string? QueryEndTime;

        [JsonPropertyName("Results")]
        public List<Result>? Results;

        [JsonPropertyName("Types")]
        public List<object>? Types;
    }

    // Root myDeserializedClass = JsonSerializer.Deserialize<Root>(myJsonResponse);
    public class JIM
    {
        [JsonPropertyName("ResultStatus")]
        public string? ResultStatus;

        [JsonPropertyName("No Dokumen")]
        public string? NoDokumen;

        [JsonPropertyName("Tarikh Mula Passport")]
        public string? TarikhMulaPassport;

        [JsonPropertyName("Sebab Batal")]
        public string? SebabBatal;

        [JsonPropertyName("No Rujukan Pemilik")]
        public string? NoRujukanPemilik;

        [JsonPropertyName("Cawangan Mengeluar")]
        public string? CawanganMengeluar;

        [JsonPropertyName("Sebab Sah")]
        public string? SebabSah;

        [JsonPropertyName("Status Rekod")]
        public string? StatusRekod;

        [JsonPropertyName("Jenis Dokumen")]
        public string? JenisDokumen;

        [JsonPropertyName("No Siri Dokumen Terdahulu")]
        public string? NoSiriDokumenTerdahulu;

        [JsonPropertyName("No Siri Dokumen")]
        public string? NoSiriDokumen;

        [JsonPropertyName("No Dokumen Terdahulu")]
        public string? NoDokumenTerdahulu;

        [JsonPropertyName("Tarikh Tamat Passport")]
        public string? TarikhTamatPassport;

        [JsonPropertyName("Cawangan Memohon")]
        public string? CawanganMemohon;

        [JsonPropertyName("Tarikh Lahir")]
        public string? TarikhLahir;

        [JsonPropertyName("No Pengenalan Semasa")]
        public string? NoPengenalanSemasa;

        [JsonPropertyName("Nama")]
        public string? Nama;

        [JsonPropertyName("Jantina")]
        public string? Jantina;

        [JsonPropertyName("Nama Dicetak")]
        public string? NamaDicetak;

        [JsonPropertyName("type")]
        public string? Type;

        [JsonPropertyName("QueryStartTime")]
        public string? QueryStartTime;

        [JsonPropertyName("QueryEndTime")]
        public string? QueryEndTime;

        [JsonPropertyName("TypeDescription")]
        public string? TypeDescription;
    }

    public class JPJ
    {
        [JsonPropertyName("ResultStatus")]
        public string? ResultStatus;

        [JsonPropertyName("Nama")]
        public string? Nama;

        [JsonPropertyName("No KP/Paspot")]
        public string? NoKPPaspot;

        [JsonPropertyName("Kategori")]
        public string? Kategori;

        [JsonPropertyName("Alamat")]
        public string? Alamat;

        [JsonPropertyName("No Pendaftaran Kenderaan")]
        public string? NoPendaftaranKenderaan;

        [JsonPropertyName("No Pendaftaran Lama")]
        public string? NoPendaftaranLama;

        [JsonPropertyName("No Chasis")]
        public string? NoChasis;

        [JsonPropertyName("Jenis Badan")]
        public string? JenisBadan;

        [JsonPropertyName("No Enjin")]
        public string? NoEnjin;

        [JsonPropertyName("Kuasa Enjin")]
        public string? KuasaEnjin;

        [JsonPropertyName("Model")]
        public string? Model;

        [JsonPropertyName("Tahun Keluaran Model")]
        public string? TahunKeluaranModel;

        [JsonPropertyName("Warna")]
        public string? Warna;

        [JsonPropertyName("Status")]
        public string? Status;

        [JsonPropertyName("Kod Kegunaan")]
        public string? KodKegunaan;

        [JsonPropertyName("Tarikh Daftar")]
        public string? TarikhDaftar;

        [JsonPropertyName("Buatan")]
        public string? Buatan;

        [JsonPropertyName("No LKM")]
        public string? NoLKM;

        [JsonPropertyName("Tempoh LKM")]
        public string? TempohLKM;

        [JsonPropertyName("Syarikat Insurans")]
        public string? SyarikatInsurans;

        [JsonPropertyName("No Polisi")]
        public string? NoPolisi;

        [JsonPropertyName("Tempoh Insurans")]
        public string? TempohInsurans;

        [JsonPropertyName("type")]
        public string? Type;

        [JsonPropertyName("QueryStartTime")]
        public string? QueryStartTime;

        [JsonPropertyName("QueryEndTime")]
        public string? QueryEndTime;

        [JsonPropertyName("TypeDescription")]
        public string? TypeDescription;
    }

    public class JPJIC
    {
        [JsonPropertyName("ResultStatus")]
        public string? ResultStatus;

        [JsonPropertyName("No.Kenderaan")]
        public string? NoKenderaan;

        [JsonPropertyName("Model")]
        public string? Model;

        [JsonPropertyName("Tarikh Model")]
        public string? TarikhModel;

        [JsonPropertyName("type")]
        public string? Type;

        [JsonPropertyName("QueryStartTime")]
        public string? QueryStartTime;

        [JsonPropertyName("QueryEndTime")]
        public string? QueryEndTime;

        [JsonPropertyName("TypeDescription")]
        public string? TypeDescription;
    }

    public class JPN
    {
        [JsonPropertyName("ResultStatus")]
        public string? ResultStatus;

        [JsonPropertyName("Nama")]
        public string? Nama;

        [JsonPropertyName("No.Kad Pengenalan")]
        public string? NoKadPengenalan;

        [JsonPropertyName("No.Kad Pengenalan Lama")]
        public string? NoKadPengenalanLama;

        [JsonPropertyName("Tarikh Lahir")]
        public string? TarikhLahir;

        [JsonPropertyName("Jantina")]
        public string? Jantina;

        [JsonPropertyName("Agama")]
        public string? Agama;

        [JsonPropertyName("Bangsa/Keturunan")]
        public string? BangsaKeturunan;

        [JsonPropertyName("Alamat Tetap")]
        public string? AlamatTetap;

        [JsonPropertyName("Alamat Surat-menyurat")]
        public string? AlamatSuratMenyurat;

        [JsonPropertyName("Tarikh Kematian")]
        public string? TarikhKematian;

        [JsonPropertyName("Status Kediaman")]
        public string? StatusKediaman;

        [JsonPropertyName("Kewarganegaraan")]
        public string? Kewarganegaraan;

        [JsonPropertyName("Alamat e-mel")]
        public string? AlamatEMel;

        [JsonPropertyName("No. Telefon")]
        public string? NoTelefon;

        [JsonPropertyName("type")]
        public string? Type;

        [JsonPropertyName("Photo")]
        public string? Photo;

        [JsonPropertyName("QueryStartTime")]
        public string? QueryStartTime;

        [JsonPropertyName("QueryEndTime")]
        public string? QueryEndTime;

        [JsonPropertyName("TypeDescription")]
        public string? TypeDescription;
    }

    public class KenderaanHilang
    {
        [JsonPropertyName("ResultStatus")]
        public string? ResultStatus;

        [JsonPropertyName("No.Laporan")]
        public string? NoLaporan;

        [JsonPropertyName("Balai")]
        public string? Balai;

        [JsonPropertyName("Kontigen")]
        public string? Kontigen;

        [JsonPropertyName("Tarikh Laporan")]
        public string? TarikhLaporan;

        [JsonPropertyName("Jenis")]
        public string? Jenis;

        [JsonPropertyName("Model/Tahun Buatan")]
        public string? ModelTahunBuatan;

        [JsonPropertyName("Warna")]
        public string? Warna;

        [JsonPropertyName("Pegawai Penyiasat")]
        public string? PegawaiPenyiasat;

        [JsonPropertyName("No.Polis")]
        public string? NoPolis;

        [JsonPropertyName("No Pendaftaran Kenderaan")]
        public string? NoPendaftaranKenderaan;

        [JsonPropertyName("No Chasis")]
        public string? NoChasis;

        [JsonPropertyName("No Enjin")]
        public string? NoEnjin;

        [JsonPropertyName("Recovery Indicator")]
        public string? RecoveryIndicator;

        [JsonPropertyName("Recovery Report No")]
        public string? RecoveryReportNo;

        [JsonPropertyName("Interim")]
        public string? Interim;

        [JsonPropertyName("Kenderaan Dicuri Di Malaysia")]
        public string? KenderaanDicuriDiMalaysia;

        [JsonPropertyName("type")]
        public string? Type;

        [JsonPropertyName("QueryStartTime")]
        public string? QueryStartTime;

        [JsonPropertyName("QueryEndTime")]
        public string? QueryEndTime;

        [JsonPropertyName("TypeDescription")]
        public string? TypeDescription;
    }

    public class OrangDikehendaki
    {
        [JsonPropertyName("ResultStatus")]
        public string? ResultStatus;

        [JsonPropertyName("Nama")]
        public string? Nama;

        [JsonPropertyName("Jantina")]
        public string? Jantina;

        [JsonPropertyName("Agama")]
        public string? Agama;

        [JsonPropertyName("No.Laporan")]
        public string? NoLaporan;

        [JsonPropertyName("IPD")]
        public string? IPD;

        [JsonPropertyName("Kontinjen")]
        public string? Kontinjen;

        [JsonPropertyName("Tarikh Laporan")]
        public string? TarikhLaporan;

        [JsonPropertyName("Akta Kesalahan")]
        public string? AktaKesalahan;

        [JsonPropertyName("Status")]
        public string? Status;

        [JsonPropertyName("Photo")]
        public string? Photo;

        [JsonPropertyName("PhotoHex")]
        public string? PhotoHex;

        [JsonPropertyName("No.Kad Pengenalan")]
        public string? NoKadPengenalan;

        [JsonPropertyName("Pegawai Penyiasat")]
        public string? PegawaiPenyiasat;

        [JsonPropertyName("No.Polis")]
        public string? NoPolis;

        [JsonPropertyName("Tarikh Report")]
        public DateTime? TarikhReport;

        [JsonPropertyName("type")]
        public string? Type;

        [JsonPropertyName("QueryStartTime")]
        public string? QueryStartTime;

        [JsonPropertyName("QueryEndTime")]
        public string? QueryEndTime;

        [JsonPropertyName("TypeDescription")]
        public string? TypeDescription;
    }

    public class OrangHilang
    {
        [JsonPropertyName("ResultStatus")]
        public string? ResultStatus;

        [JsonPropertyName("Nama")]
        public string? Nama;

        [JsonPropertyName("Jantina")]
        public string? Jantina;

        [JsonPropertyName("Agama")]
        public string? Agama;

        [JsonPropertyName("Bangsa")]
        public string? Bangsa;

        [JsonPropertyName("No Laporan")]
        public string? NoLaporan;

        [JsonPropertyName("No.Kad Pengenalan")]
        public string? NoKadPengenalan;

        [JsonPropertyName("Kontigen")]
        public string? Kontigen;

        [JsonPropertyName("Tarikh Laporan")]
        public string? TarikhLaporan;

        [JsonPropertyName("Status")]
        public string? Status;

        [JsonPropertyName("Gambar")]
        public string? Gambar;

        [JsonPropertyName("Balai Polis")]
        public string? BalaiPolis;

        [JsonPropertyName("type")]
        public string? Type;

        [JsonPropertyName("QueryStartTime")]
        public string? QueryStartTime;

        [JsonPropertyName("QueryEndTime")]
        public string? QueryEndTime;

        [JsonPropertyName("TypeDescription")]
        public string? TypeDescription;
    }

    public class Personel
    {
        [JsonPropertyName("ResultStatus")]
        public string? ResultStatus;

        [JsonPropertyName("Name")]
        public string? Name;

        [JsonPropertyName("No.Polis")]
        public string? NoPolis;

        [JsonPropertyName("No.Kad Pengenalan")]
        public string? NoKadPengenalan;

        [JsonPropertyName("Jantina")]
        public string? Jantina;

        [JsonPropertyName("Agama")]
        public string? Agama;

        [JsonPropertyName("Bangsa/Keturunan")]
        public string? BangsaKeturunan;

        [JsonPropertyName("Pangkat Hakiki")]
        public string? PangkatHakiki;

        [JsonPropertyName("Jawatan")]
        public string? Jawatan;

        [JsonPropertyName("Cawangan")]
        public string? Cawangan;

        [JsonPropertyName("Balai")]
        public string? Balai;

        [JsonPropertyName("Daerah")]
        public string? Daerah;

        [JsonPropertyName("Kontigen")]
        public string? Kontigen;

        [JsonPropertyName("Status")]
        public string? Status;

        [JsonPropertyName("type")]
        public string? Type;

        [JsonPropertyName("QueryStartTime")]
        public string? QueryStartTime;

        [JsonPropertyName("QueryEndTime")]
        public string? QueryEndTime;

        [JsonPropertyName("TypeDescription")]
        public string? TypeDescription;
    }

    public class Root
    {
        [JsonPropertyName("Status")]
        public string? Status;

        [JsonPropertyName("QueryStartTime")]
        public string? QueryStartTime;

        [JsonPropertyName("QueryEndTime")]
        public string? QueryEndTime;

        [JsonPropertyName("JPN")]
        public List<JPN>? JPN;

        [JsonPropertyName("JPJIC")]
        public List<JPJIC>? JPJIC;

        [JsonPropertyName("JPJ")]
        public List<JPJ>? JPJ;

        [JsonPropertyName("JIM")]
        public List<JIM>? JIM;

        [JsonPropertyName("OrangHilang")]
        public List<OrangHilang>? OrangHilang;

        [JsonPropertyName("Saman")]
        public List<Saman>? Saman;

        [JsonPropertyName("OrangDikehendaki")]
        public List<OrangDikehendaki>? OrangDikehendaki;

        [JsonPropertyName("KenderaanHilang")]
        public List<KenderaanHilang>? KenderaanHilang;

        [JsonPropertyName("Personel")]
        public List<Personel>? Personel;

        [JsonPropertyName("Types")]
        public List<object>? Types;
    }

    public class Saman
    {
        [JsonPropertyName("ResultStatus")]
        public string? ResultStatus;

        [JsonPropertyName("No.Kenderaan")]
        public string? NoKenderaan;

        [JsonPropertyName("Nama")]
        public string? Nama;

        [JsonPropertyName("No.Kad Pengenalan")]
        public string? NoKadPengenalan;

        [JsonPropertyName("Tarikh Saman")]
        public string? TarikhSaman;

        [JsonPropertyName("Masa Saman")]
        public string? MasaSaman;

        [JsonPropertyName("No.Saman")]
        public string? NoSaman;

        [JsonPropertyName("Daerah")]
        public string? Daerah;

        [JsonPropertyName("Kesalahan 1")]
        public string? Kesalahan1;

        [JsonPropertyName("Kesalahan 2")]
        public string? Kesalahan2;

        [JsonPropertyName("Kesalahan 3")]
        public string? Kesalahan3;

        [JsonPropertyName("Tempat Kesalahan")]
        public string? TempatKesalahan;

        [JsonPropertyName("Kompaun")]
        public string? Kompaun;

        [JsonPropertyName("Waran")]
        public string? Waran;

        [JsonPropertyName("type")]
        public string? Type;

        [JsonPropertyName("QueryStartTime")]
        public string? QueryStartTime;

        [JsonPropertyName("QueryEndTime")]
        public string? QueryEndTime;

        [JsonPropertyName("TypeDescription")]
        public string? TypeDescription;
    }

}
