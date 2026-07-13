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
    get => (((UInt32)(Alpha.AsDouble() * 255) << 24) | (((UInt32)(Red.AsDouble() * 255)) << 16) | (((UInt32)(Green.AsDouble() * 255) << 8)) | ((UInt32)(Blue.AsDouble() * 255)));
    set
    {
      Red = new Percentage(((value >> 16) & 0xFF) / 255.0);
      Green = new Percentage(((value >> 8) & 0xFF) / 255.0);
      Blue = new Percentage((value & 0xFF) / 255.0);
      Alpha = new Percentage(((value >> 24) & 0xFF) / 255.0);
    }
  }


  /// <summary>
  /// Gets or sets the RGB components of the color as a tuple of double values between 0 and 1.
  /// </summary>
  [XmlIgnore]
  [JsonIgnore]
  [NotMapped]
  public virtual (double R, double G, double B, double A) RGBAComponents
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
  public virtual (double H, double S, double L, double A) HSLAComponents
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
