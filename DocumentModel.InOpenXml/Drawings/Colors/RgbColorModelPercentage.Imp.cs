namespace DocumentModel.Drawings;

public partial class RgbColorModelPercentage : IColor
{
  /// <summary>
  /// Value of the color as RGB uint.
  /// </summary>
  [NotMapped]
  [XmlIgnore]
  [JsonIgnore]
  public override UInt32 ARGB
  {
    get => (((UInt32)(Alpha.AsDouble() * 255) << 24) | (((UInt32)(Red.AsDouble() * 255)) << 16) | (((UInt32)(Green.AsDouble() * 255) << 8)) | ((UInt32)(Blue.AsDouble() * 255)));
    set
    {
      Red = new Percentage(((value >> 16) & 0xFF) / 255.0);
      Green = new Percentage(((value >> 8) & 0xFF) / 255.0);
      Blue = new Percentage((value & 0xFF) / 255.0);
      Alpha = new Percentage(((value >> 24) & 0xFF) / 255.0);
    }
  }

}
