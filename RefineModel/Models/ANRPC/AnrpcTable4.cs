 
using RefineModels;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;




namespace RefineModels.Models.ANRPC
{
    public class AnrpcTable4 : AnrpcBase
    {








        //{ "ProductName", "اسم المنتج" },
        //{ "Products", "المنتجات" },
        //{ "Installments", "التدفيعات" },
        [Display(Name = "الخلط")]
        public string? AnrpcTable4Mixing { get; set; }

        [Display(Name = "بنزين 80")]
        public string? AnrpcTable4Gasoline80 { get; set; }

        [Display(Name = "بنزين 92")]
        public int? AnrpcTable4Gasoline92 { get; set; }

        [Display(Name = "بنزين 95")]
        public int? AnrpcTable4Gasoline95 { get; set; }

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
