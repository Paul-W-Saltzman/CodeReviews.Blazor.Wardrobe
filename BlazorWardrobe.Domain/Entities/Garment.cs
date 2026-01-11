using BlazorWardrobe.Domain.Enums;
using System.ComponentModel.DataAnnotations;

namespace BlazorWardrobe.Domain.Entities
{
    public class Garment
    {
        public int Id { get; set; }

        [EnumDataType(typeof(GarmentType),ErrorMessage = "Please Select a Garement Type")]
        public GarmentType GarmentType { get; set; }
        public BodyZone BodyZone { get; set; }

        [EnumDataType(typeof(Color), ErrorMessage = "Please Select a Garement Color")]
        public Color Color { get; set; }

        [StringLength(100)]
        public string? Brand { get; set; }
        [EnumDataType(typeof(Season), ErrorMessage = "Please Select a Season")]
        public Season Season { get; set; }
        public DateOnly LastWornDate { get; set; }
        public int WearCount { get; set; }
        public bool IsFavorite { get; set; }
        public byte[] image { get; set; } = Array.Empty<byte>();

    }
}
