namespace DocumentModel.Wordprocessing;

public partial class SchemeColor : IColor, INamedColor, ITintableColor
{
  /// <summary>
  /// Value of the color as RGB uint.
  /// </summary>
  [NotMapped]
  [XmlIgnore]
  [JsonIgnore]
  public override UInt32 ARGB
  {
    get
    {
      IColor? colorScheme = null;
      if (this.Index is not null)
        colorScheme = ParentDocument?.Theme?.ThemeElements?.ColorScheme?.GetColor(this.Index.Value);
      var argb = (colorScheme as IColor)?.ARGB ?? (uint)((uint?)LastColor ^ 0xFF000000 ?? (uint)PresetColors.Auto ^ 0xFF000000);
      //LastColor = argb ^ 0xFF000000;
      return argb;
    }

    set => LastColor = value ^ 0xFF000000;
  }

  /// <summary>
  /// Name of the color. It may be used to specify a color by name, such as "Accent1", "Accent2", etc.
  /// If the color is not found in the SchemeColors enumeration, the exception is raised.
  /// </summary>
  public string? Name
  {
    get
    {
      if (this.Index is not null)
        return this.Index.ToString();

      return _Name;
    }

    set
    {
      if (value is not null)
      {
        if (Enum.TryParse<DMD.SchemeColors>(value, out var schemeColor))
        {
          this.Index = schemeColor;
        }
      } 
      _Name = value;
    }
  }

  private string? _Name;

  /// <summary>
  /// Gets or sets the RGB components of the color as a tuple of double values between 0 and 1.
  /// </summary>
  [XmlIgnore]
  [JsonIgnore]
  [NotMapped]
  public override (double R, double G, double B, double A) RGBAComponents
  {
    get
    {
      double Red = (((ARGB >> 16) & 0xFF) / 255.0);
      double Green = (((ARGB >> 8) & 0xFF) / 255.0);
      double Blue = ((ARGB & 0xFF) / 255.0);
      double Alpha = (((ARGB >> 24) & 0xFF) / 255.0);
      return (Red, Green, Blue, Alpha);
    }
    set
    {
      byte R = (byte)(value.R * 255);
      byte G = (byte)(value.G * 255);
      byte B = (byte)(value.B * 255);
      byte A = (byte)(value.A * 255);
      this.ARGB = (UInt32)((A << 24) | (R << 16) | (G << 8) | B);
    }
  }

  /// <summary>
  /// Gets or sets the HSL components of the color as a tuple of double values between 0 and 1.
  /// </summary>
  [XmlIgnore]
  [JsonIgnore]
  [NotMapped]
  public override (double H, double S, double L, double A) HSLAComponents
  {
    get
    {
      var (R, G, B, A) = this.RGBAComponents;
      var (H, S, L) = DMD.Hsl2Rgb.ToHSL(R, G, B);
      return (H, S, L, A);
    }
    set
    {
      var (R, G, B) = DMD.Hsl2Rgb.FromHSL(value.H, value.S, value.L);
      this.RGBAComponents = (R, G, B, value.A);
    }
  }

}
