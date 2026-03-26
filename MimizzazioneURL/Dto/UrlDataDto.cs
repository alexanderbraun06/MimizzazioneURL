using System.ComponentModel.DataAnnotations;

namespace MimizzazioneURL.Dto
{
    public class UrlDataDto
    {
        [Key]
        public int UrlDataId { get; set; }
        public Guid PromotionId { get; set; }
        public string MinifiedCode { get; set; }
        public int ClickCount { get; set; }
    }
}
