namespace DBQuery.Model
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("QueryResult")]
    public class QueryResult
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string Id { get; set; }
        public string QueryId { get; set; }
        public string UserId { get; set; }
        public string PersonalId { get; set; }
        public string Name { get; set; }
        public string Rank { get; set; }
        public string KontigenId { get; set; }
        public string NamaKontinjen { get; set; }
        public string DaerahId { get; set; }
        public string NamaDaerah { get; set; }
        public string GroupId { get; set; }
        public string NameGroup { get; set; }
        public string IsAccountDisabled { get; set; }
        public string Query { get; set; }
        public string QueryStartTime { get; set; }
        public string QueryEndTime { get; set; }
        public string Result { get; set; }
        public string Type { get; set; }
    }
    [Table("User")]
    public class User
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }
        public string? description { get; set; }
    }
}