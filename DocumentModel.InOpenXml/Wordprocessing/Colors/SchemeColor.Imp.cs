namespace DocumentModel.Wordprocessing;

public partial class SchemeColor : IColor
{
  /// <summary>
  /// Value of the color as RGB uint.
  /// </summary>
  [NotMapped]
  [XmlIgnore]
  [JsonIgnore]
  public UInt32? RGB
  {
    get
    {
      if (_RGB != null)
        return _RGB;
      if (this.Index is null)
        return null;
      var ColorScheme = ParentDocument?.Theme?.ThemeElements?.ColorScheme?.GetColor(this.Index.Value);
      return (ColorScheme as DMD.ISchemeBaseColor)?.RGB;
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
      if (this.RGB is not null)
      {
        var schemeColorField = typeof(DMD.SchemeColors).GetFields(BindingFlags.Public | BindingFlags.Static).FirstOrDefault(f => f.GetValue(null)?.Equals(this.RGB.Value) == true);
        return schemeColorField?.Name;
      }

      return null;
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
  public (double R, double G, double B) RGBComponents
  {
    get
    {
      double Red = (((RGB ?? 0) >> 16) & 0xFF) / 255.0;
      double Green = (((RGB ?? 0) >> 8) & 0xFF) / 255.0;
      double Blue = (((RGB ?? 0) & 0xFF) / 255.0);
      return (Red, Green, Blue);
    }
    set
    {
      byte R = (byte)(value.R * 255);
      byte G = (byte)(value.G * 255);
      byte B = (byte)(value.B * 255);
      this.RGB = (UInt32)((R << 16) | (G << 8) | B);
    }
  }

  /// <summary>
  /// Gets or sets the HSL components of the color as a tuple of double values between 0 and 1.
  /// </summary>
  [XmlIgnore]
  [JsonIgnore]
  [NotMapped]
  public (double H, double S, double L) HSLComponents
  {
    get
    {
      var (R, G, B) = this.RGBComponents;
      var (H, S, L) = DMD.Hsl2Rgb.ToHSL(R, G, B);
      return (H, S, L);
    }
    set
    {
      var (R, G, B) = DMD.Hsl2Rgb.FromHSL(value.H, value.S, value.L);
      this.RGBComponents = (R, G, B);
    }
  }

}
