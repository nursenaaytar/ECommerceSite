namespace ECommerceSite.Models
{
    public class OrderViewModel
    {
        public int? SqId { get; set; }
        public string? Creater { get; set; }

        public DateTime CreatedDate { get; set; }
        public string? Modifier { get; set; }
        public DateTime ModifiedDate { get; set; }
    }
}
