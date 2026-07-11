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
      var s = Clamp01(Saturation);
      var l = Clamp01(Luminance);
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
      var a = (UInt32)System.Math.Round(Alpha * 255.0);
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
      Hue = h;
      Saturation = Clamp01(s);
      Luminance = Clamp01(l);
      Alpha = Clamp01(a);
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
    get { var (r, g, b) = Hsl2Rgb.FromHSL(Hue / 360.0, Saturation , Luminance ); return (r, g, b, Alpha); }
    set
    {
      var (h, s, l) = Hsl2Rgb.ToHSL(value.R, value.G, value.B);
      this.Hue = h * 360.0;
      this.Saturation = s;
      this.Luminance = l;
      this.Alpha = value.A;
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
    get => (Hue / 360.0, Saturation , Luminance , Alpha );
    set
    {
      Hue = value.H * 360.0;
      Saturation = value.S ;
      Luminance = value.L ;
      Alpha = value.A;
    }
  }
}
