using BlazorWardrobe.Domain.Enums;
using System.ComponentModel.DataAnnotations;

namespace BlazorWardrobe.Domain.Entities
{
    public class Garment
    {
        public int Id { get; set; }

        [EnumDataType(typeof(GarmentType),ErrorMessage = "Please Select a Garement Type")]
        public GarmentType GarmentType { get; set; } = GarmentType.Other;
        public BodyZone BodyZone { get; set; } = BodyZone.Other;

        [EnumDataType(typeof(Color), ErrorMessage = "Please Select a Garement Color")]
        public Color Color { get; set; } = Color.Other;

        [StringLength(100)]
        public string Brand { get; set; } = string.Empty;

        [EnumDataType(typeof(Season), ErrorMessage = "Please Select a Season")]
        public Season Season { get; set; } = Season.NoSeason;
        public DateOnly LastWornDate { get; set; } = new DateOnly(1900, 1, 1);
        public int WearCount { get; set; } = 0;
        public bool IsFavorite { get; set; } = false;
        public byte[] Image { get; set; } = Array.Empty<byte>();

    }
}
