using System.ComponentModel;
using Backend_Plateform_Streaming.Enums;

namespace Backend_Plateform_Streaming.Classes
{
    public class User
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Email { get; set; }
        public string? Password { get; set; }
        public List<FavoriteList>? FavoriteList{ get; set; }
        public UsersCreditCard? UserCardInformations{ get; set; }
        public Subscription Subscription { get; set; }
    }
}
