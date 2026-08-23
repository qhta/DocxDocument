namespace DocumentModel;

public partial class EffectiveColor : IColor
{
  /// <summary>
  /// Value of the color as RGB uint.
  /// </summary>
  [NotMapped]
  [XmlIgnore]
  [JsonIgnore]
  public UInt32 ARGB
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


  /// <summary>
  /// Gets or sets the RGB components of the color as a tuple of double values between 0 and 1.
  /// </summary>
  [XmlIgnore]
  [JsonIgnore]
  [NotMapped]
  public (double R, double G, double B, double A) RGBAComponents
  {
    get => (this.RedFactor, this.GreenFactor, this.BlueFactor, this.AlphaFactor);
    set
    {
      this.RedFactor = value.R;
      this.GreenFactor = value.G;
      this.BlueFactor = value.B;
      this.AlphaFactor = value.A;
    }
  }

  /// <summary>
  /// Gets or sets the HSL components of the color as a tuple of double values between 0 and 1.
  /// </summary>
  [XmlIgnore]
  [JsonIgnore]
  [NotMapped]
  public (double H, double S, double L, double A) HSLAComponents
  {
    get
    {
      var (H, S, L) = DMD.Hsl2Rgb.ToHSL(RedFactor, GreenFactor, BlueFactor);
      return (H, S, L, AlphaFactor);
    }
    set
    {
      var (R, G, B) = DMD.Hsl2Rgb.FromHSL(value.H, value.S, value.L);
      this.RedFactor = R;
      this.GreenFactor = G;
      this.BlueFactor = B;
      this.AlphaFactor = value.A;
    }
  }

}
