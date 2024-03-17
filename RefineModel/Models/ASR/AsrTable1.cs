using RefineModels.Models;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace RefineModels.Models.ASR
{
    public class AsrTable1 : AsrBase

    {




        [Display(Name = "التقطير")]
        public string? Table1Distillation { get; set; }

        [Display(Name = "الانتاج")]
        public string? Table1Production { get; set; }

        [Display(Name = "الرصيج")]
        public int? Table1Balance { get; set; }

        [Display(Name = "الاستلامات")]
        public int? Table1Receipts { get; set; }
        //   [Key]
        //   public int Id { get; set; }

        //   [DisplayName("الخام")] // Customize the display name for RawName
        //   public string? RawName { get; set; }  
        //// Customize the display name for RawName

        //       [DisplayName("وحدة التقطير 1")]
        //   public int? UnitOneProduction { get; set; }

        //   [DisplayName("وحدة التقطير 2")]
        //   public int? UnitTwoProduction { get; set; }

        //   [DisplayName("وحدة التقطير 3")]
        //   public int? UnitThreeProduction { get; set; }

        //   [DisplayName("وحدة التقطير 4")]
        //   public int? UnitFourProduction { get; set; }

        //   [DisplayName("الرصيد")]
        //   public int? Balance { get; set; }

        //   [DisplayName("الاستلامات")]
        //   public int? Receipts { get; set; }

        //public int? Id { get; set; }
        //public string? Name { get; set; }
        //public int? Price { get; set; }
        //public int? Age { get; set; }
        //public int? Salary { get; set; }

    }
}
