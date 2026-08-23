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
      var h = Hue.NormalizeHue();
      var s = Saturation.Clamp01();
      var l = Luminance.Clamp01();
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
      var a = (UInt32)System.Math.Round(AlphaFactor * 255.0);
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
      Hue = h.NormalizeHue();
      Saturation = s.Clamp01();
      Luminance = l.Clamp01();
      AlphaFactor = a.Clamp01();
    }
  }

  /// <summary>
  /// Conversion to/from RGB components.
  /// </summary>
  [NotMapped]
  [XmlIgnore]
  [JsonIgnore]
  public override (double R, double G, double B, double A) RGBAComponents
  {
    get
    {
      (double R, double G, double B) rgb = Hsl2Rgb.FromHSL((Hue / 360.0).Clamp01(), Saturation.Clamp01(), Luminance.Clamp01());
      rgb.R = rgb.R.Clamp01();
      rgb.G = rgb.G.Clamp01();
      rgb.B = rgb.B.Clamp01();
      return (rgb.R, rgb.G, rgb.B, AlphaFactor);
    }
    set
    {
      var (h, s, l) = Hsl2Rgb.ToHSL(value.R, value.G, value.B);
      this.Hue = (h * 360.0).NormalizeHue();
      this.Saturation = s;
      this.Luminance = l;
      this.AlphaFactor = value.A;
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
    get => (Hue / 360.0, Saturation, Luminance, AlphaFactor);
    set
    {
      Hue = value.H * 360.0;
      Saturation = value.S;
      Luminance = value.L;
      AlphaFactor = value.A;
    }
  }
}
