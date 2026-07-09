namespace DocumentModel.Drawings;

public partial class HslColor : IColor
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
      var h = NormalizeHue(Hue);
      var s = Clamp01(Saturation / 100.0);
      var l = Clamp01(Luminance / 100.0);
      var c = (1.0 - System.Math.Abs(2.0 * l - 1.0)) * s;
      var x = c * (1.0 - System.Math.Abs((h / 60.0) % 2.0 - 1.0));
      var m = l - c / 2.0;
      var (r1, g1, b1) = h switch
      {
        < 60.0 => (c, x, 0.0),
        < 120.0 => (x, c, 0.0),
        < 180.0 => (0.0, c, x),
        < 240.0 => (0.0, x, c),
        < 300.0 => (x, 0.0, c),
        _ => (c, 0.0, x),
      };
      var r = (UInt32)System.Math.Round((r1 + m) * 255.0);
      var g = (UInt32)System.Math.Round((g1 + m) * 255.0);
      var b = (UInt32)System.Math.Round((b1 + m) * 255.0);
      var a = (UInt32)System.Math.Round(Alpha / 100.0 * 255.0);
      return (a << 24) | (r << 16) | (g << 8) | b;
    }

    set
    {
      var a = ((value >> 24) & 0xFF) / 255.0;
      var r = ((value >> 16) & 0xFF) / 255.0;
      var g = ((value >> 8) & 0xFF) / 255.0;
      var b = (value & 0xFF) / 255.0;
      var max = System.Math.Max(r, System.Math.Max(g, b));
      var min = System.Math.Min(r, System.Math.Min(g, b));
      var delta = max - min;
      var l = (max + min) / 2.0;
      var s = delta == 0.0 ? 0.0 : delta / (1.0 - System.Math.Abs(2.0 * l - 1.0));
      double h;
      if (delta == 0.0)
        h = 0.0;
      else if (max == r)
        h = 60.0 * (((g - b) / delta) % 6.0);
      else if (max == g)
        h = 60.0 * (((b - r) / delta) + 2.0);
      else
        h = 60.0 * (((r - g) / delta) + 4.0);
      h = NormalizeHue(h);
      Hue = (Int32)System.Math.Round(h);
      Saturation = (Int32)System.Math.Round(Clamp01(s) * 100.0);
      Luminance = (Int32)System.Math.Round(Clamp01(l) * 100.0);
      Alpha = (Int32)System.Math.Round(Clamp01(a) * 100.0);
    }
  }
  private static double Clamp01(double value) => value < 0.0 ? 0.0 : value > 1.0 ? 1.0 : value;
  private static double NormalizeHue(double hue)
  {
    hue %= 360.0;
    return hue < 0.0 ? hue + 360.0 : hue;
  }

  /// <summary>
  /// Conversion to/from RGB components.
  /// </summary>
  [NotMapped]
  [XmlIgnore]
  [JsonIgnore]
  public override (double R, double G, double B, double A) RGBAComponents
  {
    get { var (r, g, b) = Hsl2Rgb.FromHSL(Hue / 360.0, Saturation / 100.0, Luminance / 100.0); return (r, g, b, Alpha / 100.0); }
    set
    {
      var (h, s, l) = Hsl2Rgb.ToHSL(value.R, value.G, value.B);
      this.Hue = h * 360.0;
      this.Saturation = s * 100.0;
      this.Luminance = l * 100.0;
      this.Alpha = value.A * 100.0;
    }
  }

  /// <summary>
  /// Conversion to/from HSL components. Note that H is in range 0-1, and Hue is in range 0-360.
  /// </summary>
  [NotMapped]
  [XmlIgnore]
  [JsonIgnore]
  public override (double H, double S, double L, double A) HSLAComponents
  {
    get => (Hue / 360.0, Saturation / 100.0, Luminance / 100.0, Alpha / 100.0);
    set
    {
      Hue = value.H * 360.0;
      Saturation = value.S * 100.0;
      Luminance = value.L * 100.0;
      Alpha = value.A * 100.0;
    }
  }

  ///// <summary>
  ///// Red component of the color as percentage value.
  ///// The value is between 0 and 1, where 0 represents no red and 1 represents full red (255 in RGB).
  ///// This is derived from the RGB+ value, where the red component is extracted and converted to a percentage.
  ///// Setting this property will update the RGB+ value accordingly, modifying only the red component while preserving the green and blue components.
  ///// </summary>
  //[NotMapped]
  //[XmlIgnore]
  //[JsonIgnore]
  //public override double Red
  //{
  //  get => ((this.ARGB >> 16) & 0xFF) / 255.0;
  //  set
  //  {
  //    var red = (UInt32)System.Math.Round((double)value * 255.0);
  //    this.ARGB = (UInt32)(this.ARGB) & 0x00FFFF | (red << 16);
  //  }
  //}

  ///// <summary>
  ///// Green component of the color as percentage value.
  ///// The value is between 0 and 1, where 0 represents no green and 1 represents full green (255 in RGB).
  ///// This is derived from the RGB+ value, where the green component is extracted and converted to a percentage.
  ///// Setting this property will update the RGB+ value accordingly, modifying only the green component while preserving the red and blue components.
  ///// </summary>
  //[NotMapped]
  //[XmlIgnore]
  //[JsonIgnore]
  //public override double Green
  //{
  //  get => ((this.ARGB >> 8) & 0xFF) / 255.0;
  //  set
  //  {
  //    var green = (UInt32)System.Math.Round((double)value * 255.0);
  //    this.ARGB = (UInt32)(this.ARGB) & 0xFF00FF | (green << 8);
  //  }
  //}

  ///// <summary>
  ///// Blue component of the color as percentage value.
  ///// The value is between 0 and 1, where 0 represents no blue and 1 represents full blue (255 in RGB).
  ///// This is derived from the RGB+ value, where the blue component is extracted and converted to a percentage.
  ///// Setting this property will update the RGB+ value accordingly, modifying only the blue component while preserving the red and green components.
  ///// </summary>
  //[NotMapped]
  //[XmlIgnore]
  //[JsonIgnore]
  //public override double Blue
  //{
  //  get => (this.ARGB & 0xFF) / 255.0;
  //  set
  //  {

  //    var blue = (UInt32)System.Math.Round((double)value * 255.0);
  //    this.ARGB = (UInt32)(this.ARGB) & 0xFFFF00 | blue;
  //  }
  //}
}
