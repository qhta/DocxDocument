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
    get => (UInt32)((Alpha *255 / 100 << 24) | ((Red * 255 / 100) << 16) | ((Green * 255 / 100) << 8) | (Blue * 255 / 100));
    set
    {
      Red = (Int32)System.Math.Round(((value >> 16) & 0xFF) * 100.0 / 255.0);
      Green = (Int32)System.Math.Round(((value >> 8) & 0xFF) * 100.0 / 255.0);
      Blue = (Int32)System.Math.Round((value & 0xFF) * 100.0 / 255.0);
      Alpha = (Int32)System.Math.Round(((value >> 24) & 0xFF) * 100.0 / 255.0);
    }
  }

}
