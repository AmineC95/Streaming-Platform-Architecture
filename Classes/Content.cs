using Backend_Plateform_Streaming.Enums;
using System.Net.Mime;

namespace Backend_Plateform_Streaming.Classes
{
    //Content represente un film une série une émission ou autre (documentaire, animé ...)
    public class Content
    {
        public int Id { get; set; }
        public ContentTypes ContentType { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public int Episode { get; set; }
        public int Season { get; set; }
        public int Evaluation { get; set; }//systeme de notation sur 5 etoiles
        public Categories? Categories { get; set; }

    }
}
