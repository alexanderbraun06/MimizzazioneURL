using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Migrations.Operations;
using System.ComponentModel.DataAnnotations;

namespace MimizzazioneURL.Data
{
    public class Promotions
    {
        [Key]
        public Guid PromotionId { get; set; }
        public string Description { get; set; }
    }
}
