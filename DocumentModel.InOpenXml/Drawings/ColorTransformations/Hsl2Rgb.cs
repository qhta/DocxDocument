namespace DocumentModel.Drawings;

// Source - https://stackoverflow.com/q/4793729
// Posted by Mervin, modified by community. See post 'Timeline' for change history
// Retrieved 2026-06-26, License - CC BY-SA 2.5
using Math = System.Math;

/// <summary>
/// Provides methods for converting colors between the HSL (Hue, Saturation, Luminance) and RGB (Red, Green, Blue) color models.
/// </summary>
public static class Hsl2Rgb
{
  /// <summary>
  /// Converts an RGB color to an HSL color.
  /// </summary>
  /// <param name="R">Red component of the color, represented as a decimal value between 0 and 1</param>
  /// <param name="G">Green component of the color, represented as a decimal value between 0 and 1</param>
  /// <param name="B">Blue component of the color, represented as a decimal value between 0 and 1</param>
  /// <returns>The corresponding HSL components as a tuple of decimal values between 0 and 1.</returns>
  public static (double H, double S, double L) ToHSL(double R, double G, double B)
  {
    var hsl = HSLColor.FromRGB((Byte)(R * 255), (Byte)(G * 255), (Byte)(B * 255));
    return ((double)hsl.H, (double)hsl.S, (double)hsl.L);
  }

  /// <summary>
  /// Converts an HSL color to an RGB color.
  /// </summary>
  /// <param name="H">Hue component of the color, represented as a decimal value between 0 and 1</param>
  /// <param name="S">Saturation component of the color, represented as a decimal value between 0 and 1</param>
  /// <param name="L">Luminance component of the color, represented as a decimal value between 0 and 1</param>
  /// <returns>The corresponding RGB components as a tuple of decimal values between 0 and 1.</returns>
  public static (double R, double G, double B) FromHSL(double H, double S, double L)
  {
    var rgb = new HSLColor((decimal)H, (decimal)S, (decimal)L).ToRGB();
    return ((double)rgb.R / 255.0, (double)rgb.G / 255.0, (double)rgb.B / 255.0);
  }
}

/// <summary>
/// Represents a color in the RGB color model with red, green, and blue components in bytes
/// </summary>
public class RgbColor
{
  /// <summary>
  /// Red component of the color, represented as a byte value between 0 and 255
  /// </summary>
  public Byte R;
  /// <summary>
  /// Green component of the color, represented as a byte value between 0 and 255
  /// </summary>
  public Byte G;
  /// <summary>
  /// Blue component of the color, represented as a byte value between 0 and 255
  /// </summary>
  public Byte B;

  /// <summary>
  /// Initializes a new instance of the RgbColor class with specified red, green, and blue values.
  /// </summary>
  /// <param name="R">The red component of the color.</param>
  /// <param name="G">The green component of the color.</param>
  /// <param name="B">The blue component of the color.</param>
  public RgbColor(Byte R, Byte G, Byte B)
  {
    this.R = R;
    this.G = G;
    this.B = B;
  }
}

/// <summary>
/// Represents a color in the HSL (Hue, Saturation, Luminance) color model with hue, saturation, and luminance components as decimals
/// </summary>
public class HSLColor
{
  /// <summary>
  /// Hue component of the color, represented as a decimal value between 0 and 1
  /// </summary>
  public decimal H;
  /// <summary>
  /// Saturation component of the color, represented as a decimal value between 0 and 1
  /// </summary>
  public decimal S;
  /// <summary>
  /// Luminance component of the color, represented as a decimal value between 0 and 1
  /// </summary>  
  public decimal L;

  /// <summary>
  /// Initializes a new instance of the HSLColor class with specified hue, saturation, and luminance values.
  /// </summary>
  /// <param name="H">The hue component of the color.</param>
  /// <param name="S">The saturation component of the color.</param>
  /// <param name="L">The luminance component of the color.</param>
  public HSLColor(decimal H, decimal S, decimal L)
  {
    this.H = H;
    this.S = S;
    this.L = L;
  }

  /// <summary>
  /// Converts an RGB color to an HSL color.
  /// </summary>
  /// <param name="Clr">The RGB color to convert.</param>
  /// <returns>The corresponding HSL color.</returns>
  public static HSLColor FromRGB(RgbColor Clr)
  {
    return FromRGB(Clr.R, Clr.G, Clr.B);
  }

  /// <summary>
  /// Converts RGB values to an HSL color.
  /// </summary>
  /// <param name="R">The red component of the color.</param>
  /// <param name="G">The green component of the color.</param>
  /// <param name="B">The blue component of the color.</param>
  /// <returns>The corresponding HSL color.</returns>
  public static HSLColor FromRGB(Byte R, Byte G, Byte B)
  {
    decimal _R = ((decimal)R / 255m);
    decimal _G = ((decimal)G / 255m);
    decimal _B = ((decimal)B / 255m);

    decimal _Min = Math.Min(Math.Min(_R, _G), _B);
    decimal _Max = Math.Max(Math.Max(_R, _G), _B);
    decimal _Delta = _Max - _Min;

    decimal H = 0;
    decimal S = 0;
    decimal L = (decimal)((_Max + _Min) / 2.0m);

    if (_Delta != 0)
    {
      if (L < 0.5m)
      {
        S = (decimal)(_Delta / (_Max + _Min));
      }
      else
      {
        S = (decimal)(_Delta / (2.0m - _Max - _Min));
      }

      decimal _Delta_R = (decimal)(((_Max - _R) / 6.0m + (_Delta / 2.0m)) / _Delta);
      decimal _Delta_G = (decimal)(((_Max - _G) / 6.0m + (_Delta / 2.0m)) / _Delta);
      decimal _Delta_B = (decimal)(((_Max - _B) / 6.0m + (_Delta / 2.0m)) / _Delta);

      if (_R == _Max)
      {
        H = _Delta_B - _Delta_G;
      }
      else if (_G == _Max)
      {
        H = (1.0m / 3.0m) + _Delta_R - _Delta_B;
      }
      else if (_B == _Max)
      {
        H = (2.0m / 3.0m) + _Delta_G - _Delta_R;
      }

      if (H < 0) H += 1.0m;
      if (H > 1) H -= 1.0m;
    }

    return new HSLColor(H, S, L);
  }

  private decimal Hue_2_RGB(decimal v1, decimal v2, decimal vH)
  {
    if (vH < 0) vH += 1;
    if (vH > 1) vH -= 1;
    if ((6 * vH) < 1) return (v1 + (v2 - v1) * 6 * vH);
    if ((2 * vH) < 1) return (v2);
    if ((3 * vH) < 2) return (v1 + (v2 - v1) * ((2.0m / 3.0m) - vH) * 6);
    return (v1);
  }

  /// <summary>
  /// Converts the HSL color to an RGB color.
  /// </summary>
  /// <returns>The corresponding RGB color.</returns>
  public RgbColor ToRGB()
  {
    RgbColor Clr = new RgbColor(0, 0, 0);
    if (S == 0)
    {
      Clr.R = (Byte)(L * 255);
      Clr.G = (Byte)(L * 255);
      Clr.B = (Byte)(L * 255);
    }
    else
    {
      decimal var_2;
      if (L < 0.5m) var_2 = L * (1 + S);
      else var_2 = (L + S) - (S * L);

      decimal var_1 = 2 * L - var_2;

      Clr.R = (Byte)(255 * Hue_2_RGB(var_1, var_2, H + (1.0m / 3.0m)));
      Clr.G = (Byte)(255 * Hue_2_RGB(var_1, var_2, H));
      Clr.B = (Byte)(255 * Hue_2_RGB(var_1, var_2, H - (1.0m / 3.0m)));
    }

    return Clr;
  }
}
