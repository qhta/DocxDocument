namespace DocumentModel.Wordprocessing;

public partial class RgbColorHex : IColor, ITintableColor, ITransformableColor
{
  /// <summary>
  /// Value of the cAolor as RGB uint.
  /// </summary>
  [NotMapped]
  [XmlIgnore]
  [JsonIgnore]
  public override UInt32 ARGB
  {
    get
    {
      var hexColor = this.Value;
      if (hexColor is not null) return ((UInt32)hexColor) ^ 0xFF000000;

      return (uint)PresetColors.Auto;
    }
    set => this.Value = (value ^ 0xFF000000);
  }

  /// <summary>
  /// Red component of the color as percentage value.
  /// The value is between 0 and 1, where 0 represents no red and 1 represents full red (255 in RGB).
  /// This is derived from the RGB+ value, where the red component is extracted and converted to a percentage.
  /// Setting this property will update the RGB+ value accordingly, modifying only the red component while preserving the green and blue components.
  /// </summary>
  [NotMapped]
  [XmlIgnore]
  [JsonIgnore]
  public double Red
  {
    get => ((this.ARGB >> 16) & 0xFF) / 255.0;
    set
    {
      var red = (UInt32)System.Math.Round((double)value * 255.0);
      this.ARGB = (UInt32)(this.ARGB) & 0x00FFFF | (red << 16);
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
  public double Green
  {
    get => ((this.ARGB >> 8) & 0xFF) / 255.0;
    set
    {
      var green = (UInt32)System.Math.Round((double)value * 255.0);
      this.ARGB = (UInt32)(this.ARGB) & 0xFF00FF | (green << 8);
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
  public double Blue
  {
    get => (this.ARGB & 0xFF) / 255.0;
    set
    {
      var blue = (UInt32)System.Math.Round((double)value * 255.0);
      this.ARGB = (UInt32)(this.ARGB) & 0xFFFF00 | blue;
    }
  }

  /// <summary>
  /// Alpha component of the color as percentage value.
  /// The value is between 0 and 1, where 0 represents no Alpha and 1 represents full Alpha (255 in RGB).
  /// This is derived from the ARGB value, where the Alpha component is extracted and converted to a percentage.
  /// Setting this property will update the ARGB value accordingly, modifying only the Alpha component while preserving the red and green components.
  /// </summary>
  [NotMapped]
  [XmlIgnore]
  [JsonIgnore]
  public double Alpha
  {
    get => ((this.ARGB >> 24) & 0xFF) / 255.0;
    set
    {
      var alpha = (UInt32)System.Math.Round((double)value * 255.0);
      this.ARGB = (UInt32)(this.ARGB) & 0x00FFFFFF | (alpha << 24);
    }
  }

  /// <summary>
  /// Gets or sets the RGB components of the color as a tuple of double values between 0 and 1.
  /// </summary>
  [XmlIgnore]
  [JsonIgnore]
  [NotMapped]
  public override (double R, double G, double B, double A) RGBAComponents
  {
    get => (this.Red, this.Green, this.Blue, this.Alpha);
    set
    {
      this.Red = value.R;
      this.Green = value.G;
      this.Blue = value.B;
      this.Alpha = value.A;
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


  /// <summary>
  /// Name of the color. It may be used to specify a color by name, such as "Red", "Blue", etc
  /// or a scheme color name like "Accent1", "Accent2", etc.
  /// If the color is not found in the PresetColors enumeration, the exception is raised.
  /// </summary>
  public string? Name
  {
    get
    {
      var presetColorField = typeof(PresetColors).GetFields(BindingFlags.Public | BindingFlags.Static)
        .FirstOrDefault(f => f.GetValue(null)?.Equals(this.ARGB ^ 0xFF000000) == true);
      return presetColorField?.Name;
    }
    set
    {
      if (value is null)
        return;

      if (Enum.TryParse<PresetColors>(value, out var presetColor))
      {
        this.ARGB = (UInt32)presetColor ^ 0xFF000000;
        return;
      }

      throw new ArgumentException(
        $"The provided color name '{value}' is not recognized as a valid theme color or preset color.");
    }
  }

}
