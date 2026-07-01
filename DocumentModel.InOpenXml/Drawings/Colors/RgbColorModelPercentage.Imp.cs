namespace DocumentModel.Drawings;

public partial class RgbColorModelPercentage : IColor
{
  /// <summary>
  /// Value of the color as RGB uint.
  /// </summary>
  [NotMapped]
  [XmlIgnore]
  [JsonIgnore]
  public override UInt32? RGB
  {
    get => (UInt32)(((R * 255 / 100000) << 16) | ((G * 255 / 100000) << 8) | (B * 255 / 100000));
    set
    {
      if (value is null)
      {
        _Red = null;
        _Green = null;
        _Blue = null;
        return;
      }

      R = (Int32)System.Math.Round(((value.Value >> 16) & 0xFF) * 100000.0 / 255.0);
      G = (Int32)System.Math.Round(((value.Value >> 8) & 0xFF) * 100000.0 / 255.0);
      B = (Int32)System.Math.Round((value.Value & 0xFF) * 100000.0 / 255.0);
    }
  }

}
