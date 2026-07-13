namespace DocumentModel.Wordprocessing;

public partial class WordColor : IColor, INamedColor, ITransformableColor
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
  string? INamedColor.Name
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

      return _Name;
    }

    set
    {
      if (value is not null)
      {
        if (Enum.TryParse<DMD.SchemeColors>(value, out var themeColor))
          this.ThemeColor = themeColor;
        if (Enum.TryParse<PresetColors>(value, out var presetColor))
          this.Value = (uint)presetColor ^ 0xFF000000;
      }
      _Name = value;
    }
  }

  private string? _Name;

  double? ITransformableColor.Tint
  {
    get => this.Tint?.AsDouble();
    set
    {
      if (value!=null)
        this.Tint = value.Value;
    }
  }

  double? ITransformableColor.Shade
  {
    get => this.Shade?.AsDouble();
    set
    {
      if (value!=null)
        this.Shade = value.Value;
    }
  }
  IColor ITransformableColor.GetEffectiveColor()
  {
    IColor result = this;
    if (Tint is not null)
      result = new DMD.Tint { Value = Tint.Value }.Transform(result);
    if (Shade is not null)
      result = new DMD.Shade { Value = Shade.Value }.Transform(result);
    return result;
  }

  IEnumerable<IColorTransformation> ITransformableColor.GetTransformations()
  {
    var transformations = new List<IColorTransformation>();
    if (Tint is not null)
      transformations.Add(new DMD.Tint { Value = Tint.Value });
    if (Shade is not null)
      transformations.Add(new DMD.Shade { Value = Shade.Value });
    return transformations;
  }
}
