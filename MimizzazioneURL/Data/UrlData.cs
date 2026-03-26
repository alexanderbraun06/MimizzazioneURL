using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Migrations.Operations;
using Microsoft.EntityFrameworkCore.Scaffolding.Metadata;
using System.ComponentModel.DataAnnotations;
using System.Data;

namespace MimizzazioneURL.Data
{
    public class UrlData
    {
        [Key]
        public int UrlDataId { get; set; }
        public int PromotionId { get; set; }
        public string UrlText { get; set; }
        public string MinifiedCode { get; set; }
        public int ClickCount { get; set; }

    }
}
