namespace DBQuery.Model
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    public class MISDB
    {

    }

    [Table("Action")]
    public class Action
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }
        public string? description { get; set; }
    }
    [Table("ActionMonitor")]
    public class ActionMonitor
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }
        public Guid QueryUserId { get; set; }
        public string QueryUserKontigenId { get; set; }
        public string QueryUserDaerahId { get; set; }
        public string QueryParam { get; set; }
        public string QueryType { get; set; }
        public DateTime QueryDate { get; set; }
        public int ActionId { get; set; }
        public string? ReportNo { get; set; }
        public string? ReportDate { get; set; }
        public string? Description { get; set; }
    }
    [Table("Daerah")]
    public class Daerah
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }
        public string? description { get; set; }
    }
    [Table("Group")]
    public class Group
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }
        public string? description { get; set; }
    }
    [Table("Kontinjen")]
    public class Kontinjen
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }
        public string? description { get; set; }
    }
    [Table("Print")]
    public class Print
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }
        public string? description { get; set; }
    }
    [Table("Query")]
    public class Query
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }
        public string? description { get; set; }
    }
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
    [Table("Service")]
    public class Service
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }
        public string? description { get; set; }
    }
    [Table("ServiceConfig")]
    public class ServiceConfig
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }
        public string? description { get; set; }
    }
    [Table("ServiceGroupAccess")]
    public class ServiceGroupAccess
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }
        public string? description { get; set; }
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