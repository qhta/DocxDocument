namespace DocumentModel.Drawings;

public abstract partial class DrawingsColorBase<T> : IColor
{
  /// <summary>
  /// Value of the color as RGB uint.
  /// </summary>
  [NotMapped] 
  [XmlIgnore] 
  [JsonIgnore]
  public abstract UInt32? RGB { get; set; }

  /// <summary>
  /// Red component of the color as percentage value.
  /// The value is between 0 and 1, where 0 represents no red and 1 represents full red (255 in RGB).
  /// This is derived from the RGB+ value, where the red component is extracted and converted to a percentage.
  /// Setting this property will update the RGB+ value accordingly, modifying only the red component while preserving the green and blue components.
  /// </summary>
  [NotMapped]
  [XmlIgnore]
  [JsonIgnore]
  public virtual double? Red
  {
    get => ((this.RGB >> 16) & 0xFF) / 255.0;
    set
    {
      if (value is null)
        return;
      var red = (UInt32)System.Math.Round((double)value * 255.0);
      this.RGB = (UInt32)(this.RGB ?? 0) & 0x00FFFF | (red << 16);
    }
  }

  /// <summary>
  /// Green component of the color as percentage value.
  /// The value is between 0 and 1, where 0 represents no green and 1 represents full green (255 in RGB).
  /// This is derived from the RGB+ value, where the green component is extracted and converted to a percentage.
  /// Setting this property will update the RGB+ value accordingly, modifying only the green component while preserving the red and blue components.
  /// </summary>
  [NotMapped]
  [XmlIgnore]
  [JsonIgnore]
  public virtual double? Green
  {
    get => ((this.RGB >> 8) & 0xFF) / 255.0;
    set
    {
      if (value is null)
        return;
      var green = (UInt32)System.Math.Round((double)value * 255.0);
      this.RGB = (UInt32)(this.RGB ?? 0) & 0xFF00FF | (green << 8);
    }
  }

  /// <summary>
  /// Blue component of the color as percentage value.
  /// The value is between 0 and 1, where 0 represents no blue and 1 represents full blue (255 in RGB).
  /// This is derived from the RGB+ value, where the blue component is extracted and converted to a percentage.
  /// Setting this property will update the RGB+ value accordingly, modifying only the blue component while preserving the red and green components.
  /// </summary>
  [NotMapped]
  [XmlIgnore]
  [JsonIgnore]
  public virtual double? Blue
  {
    get => (this.RGB & 0xFF) / 255.0;
    set
    {
      if (value is null)
        return;
      var blue = (UInt32)System.Math.Round((double)value * 255.0);
      this.RGB = (UInt32)(this.RGB ?? 0) & 0xFFFF00 | blue;
    }
  }

  /// <summary>
  /// Gets or sets the RGB components of the color as a tuple of double values between 0 and 1.
  /// </summary>
  [XmlIgnore]
  [JsonIgnore]
  [NotMapped]
  public virtual (double R, double G, double B) RGBComponents
  {
    get => (this.Red ?? 0, this.Green ?? 0, this.Blue ?? 0);
    set
    {
      this.Red = value.R;
      this.Green = value.G;
      this.Blue = value.B;
    }
  }

  /// <summary>
  /// Gets or sets the HSL components of the color as a tuple of double values between 0 and 1.
  /// </summary>
  [XmlIgnore]
  [JsonIgnore]
  [NotMapped]
  public virtual (double H, double S, double L) HSLComponents
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

  /// <summary>
  /// Name of the color. It may be used to specify a color by name, such as "Red", "Blue", etc
  /// or a scheme color name like "Accent1", "Accent2", etc.
  /// If the color is not found in the PresetColors enumeration, the exception is raised.
  /// </summary>
  [XmlIgnore]
  [JsonIgnore]
  [NotMapped]
  public virtual string? Name
  {
    get
    {

      var presetColorField = typeof(PresetColors).GetFields(BindingFlags.Public | BindingFlags.Static).FirstOrDefault(f => f.GetValue(null)?.Equals(this.RGB) == true);
      return presetColorField?.Name;
    }

    set
    {
      if (value is null)
        return;
      if (Enum.TryParse<PresetColors>(value, out var presetColor))
      {
        this.RGB = (UInt32)presetColor;
        return;
      }

      throw new ArgumentException($"The provided color name '{value}' is not recognized as a valid theme color or preset color.");
    }
  }
}
