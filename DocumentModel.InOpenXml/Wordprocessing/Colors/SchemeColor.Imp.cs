namespace DocumentModel.Wordprocessing;

public partial class SchemeColor : IColor, ITintableColor
{
  /// <summary>
  /// Value of the color as RGB uint.
  /// </summary>
  [NotMapped]
  [XmlIgnore]
  [JsonIgnore]
  public UInt32 ARGB
  {
    get
    {
      if (_RGB != null)
        return _RGB.Value;
      if (this.Index is null)
        return (uint)PresetColors.Auto;
      var ColorScheme = ParentDocument?.Theme?.ThemeElements?.ColorScheme?.GetColor(this.Index.Value);
      return (ColorScheme as DMD.ISchemeBaseColor)?.ARGB ?? (uint)PresetColors.Auto;
    }

    set => _RGB = value;
  }
  private UInt32? _RGB;

  /// <summary>
  /// Name of the color. It may be used to specify a color by name, such as "Accent1", "Accent2", etc.
  /// If the color is not found in the SchemeColors enumeration, the exception is raised.
  /// </summary>
  string? IColor.Name
  {
    get
    {
      var schemeColorField = typeof(DMD.SchemeColors).GetFields(BindingFlags.Public | BindingFlags.Static).FirstOrDefault(f => f.GetValue(null)?.Equals(this.ARGB ^ 0xFF000000) == true);
      return schemeColorField?.Name;
    }

    set
    {
      if (value is null)
        return;
      if (Enum.TryParse<DMD.SchemeColors>(value, out var schemeColor))
      {
        this.Index = schemeColor;
        return;
      }

      throw new ArgumentException($"The provided color name '{value}' is not recognized as a valid scheme color.");
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
  public (double H, double S, double L, double A) HSLAComponents
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

  double? ITintableColor.Tint
  {
    get => this.Tint?.AsDouble();
    set
    {
      if (value != null)
        this.Tint = value.Value;
    }
  }

  double? ITintableColor.Shade
  {
    get => this.Shade?.AsDouble();
    set
    {
      if (value != null)
        this.Shade = value.Value;
    }
  }
}
