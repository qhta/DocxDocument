namespace DocumentModel.Wordprocessing;

public partial class Color : IColor
{
  /// <summary>
  /// Gets or sets the RGB+ value represented by this property.
  /// </summary>
  UInt32 IColor.ARGB { get => ((this.Value ?? (UInt32)PresetColors.Auto) ^ 0xFF000000); set => this.Value = value ^ 0xFF000000; }

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
      var argb = (this.Value ?? (UInt32)PresetColors.Auto) ^ 0xFF000000;
      double R = ((argb >> 16) & 0xFF) / 255.0;
      double G = ((argb >> 8) & 0xFF) / 255.0;
      double B = ((argb & 0xFF) / 255.0);
      double A = ((argb >> 24) & 0xFF) / 255.0;
      return (R, G, B, A);
    }
    set
    {
      byte R = (byte)(value.R * 255);
      byte G = (byte)(value.G * 255);
      byte B = (byte)(value.B * 255);
      byte A = (byte)(value.A * 255);
      this.Value = (UInt32)((A << 24) | (R << 16) | (G << 8) | B);
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

  /// <summary>
  /// Gets or sets the name of the color represented by this property.
  /// It may be used to specify a color by name, such as "red", "blue", etc. The actual interpretation of the name depends on the context in which it is used and may be mapped to a specific RGB value or theme color.
  /// </summary>
  string? IColor.Name
  {
    get
    {
      if (this.ThemeColor is not null)
        return this.ThemeColor.ToString();
      if (this.Value is not null)
      {
        var presetColorField = typeof(PresetColors).GetFields(BindingFlags.Public | BindingFlags.Static).FirstOrDefault(f => f.GetValue(null)?.Equals(this.Value.Value) == true);
        return presetColorField?.Name;
      }

      return null;
    }

    set
    {
      if (value is null)
        this.ThemeColor = null;
      if (Enum.TryParse<DMD.SchemeColors>(this.Value.ToString(), out var themeColor))
        this.ThemeColor = themeColor;
      if (Enum.TryParse<PresetColors>(this.Value.ToString(), out var presetColor))
        this.Value = (UInt32)presetColor;
      throw new ArgumentException($"The provided color name '{value}' is not recognized as a valid theme color or preset color.");
    }
  }

}
