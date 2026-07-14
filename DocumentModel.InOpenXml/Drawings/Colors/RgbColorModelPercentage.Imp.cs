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
    get => (((UInt32)(AlphaFactor * 255) << 24) | (((UInt32)(RedFactor * 255)) << 16) | (((UInt32)(GreenFactor * 255) << 8)) | ((UInt32)(BlueFactor * 255)));
    set
    {
      RedFactor = ((value >> 16) & 0xFF) / 255.0;
      GreenFactor = ((value >> 8) & 0xFF) / 255.0;
      BlueFactor = (value & 0xFF) / 255.0;
      AlphaFactor = ((value >> 24) & 0xFF) / 255.0;
    }
  }

}
