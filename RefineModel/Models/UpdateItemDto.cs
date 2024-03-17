using System.ComponentModel;
using System.ComponentModel.DataAnnotations;



namespace RefineModels.Models
{
    public class UpdateItemDto
    {
        public int? Id { get; set; }
        public string? Field { get; set; }
        public string? Value { get; set; }
    }


}

