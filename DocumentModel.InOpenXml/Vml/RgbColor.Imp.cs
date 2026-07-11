namespace DocumentModel.Vml;

public partial class RgbColor : IColor
{
  /// <summary>
  /// Value of the color as RGB uint.
  /// </summary>
  [NotMapped]
  [XmlIgnore]
  [JsonIgnore]
  public UInt32 ARGB { get => this.Value is null ? (uint)PresetColors.Auto : (UInt32)this.Value! ^ 0xFF000000; set => this.Value = (value ^ 0xFF000000); }

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
  /// The value is between 0 and 1, where 0 represents no alpha and 1 represents full alpha (255 in RGB).
  /// This is derived from the ARGB value, where the alpha component is extracted and converted to a percentage.
  /// Setting this property will update the ARGB value accordingly, modifying only the alpha component while preserving the red, green, and blue components.  
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
  public (double R, double G, double B, double A) RGBAComponents
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

  string? IColor.Name { get => null; set { } }

}
