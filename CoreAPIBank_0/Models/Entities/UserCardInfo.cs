namespace CoreAPIBank_0.Models.Entities
{
    public class UserCardInfo : BaseEntity
    {
        public string CardUserName { get; set; }
        public string CardNumber { get; set; }
        public string CVC { get; set; }
        public int ExpiryYear { get; set; }
        public int ExpiryMonth { get; set; }
        public decimal CardLimit { get; set; }
        public decimal Balance { get; set; } //Bakiye

    }
}
