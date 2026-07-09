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
    get => (UInt32)((A << 24) | ((R * 255 / 100000) << 16) | ((G * 255 / 100000) << 8) | (B * 255 / 100000));
    set
    {
      R = (Int32)System.Math.Round(((value >> 16) & 0xFF) * 100000.0 / 255.0);
      G = (Int32)System.Math.Round(((value >> 8) & 0xFF) * 100000.0 / 255.0);
      B = (Int32)System.Math.Round((value & 0xFF) * 100000.0 / 255.0);
      A = (Int32)System.Math.Round(((value >> 24) & 0xFF) * 100000.0 / 255.0);
    }
  }

}
