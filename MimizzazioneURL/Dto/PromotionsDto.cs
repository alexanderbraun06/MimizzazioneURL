using System.ComponentModel.DataAnnotations;

namespace MimizzazioneURL.Dto
{
    public class PromotionsDto
    {
        [Key]
        public Guid PromtionId { get; set; }
        
    }
}
