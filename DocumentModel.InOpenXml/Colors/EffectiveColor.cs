using System.Diagnostics.CodeAnalysis;

namespace DocumentModel;
/// <summary>
/// Represents an RGB color as a result of color transformations applied to a base color.
/// </summary>
[DataContract]
public partial class EffectiveColor : ModelElement
{
  /// <summary>
  /// Default constructor initializes the EffectiveColor to white (100% red, 100% green, 100% blue, 100% alpha).
  /// </summary>
  public EffectiveColor()
  {
    Red = new Percentage(100); Green = new Percentage(100); Blue = new Percentage(100);
  }

  /// <summary>
  /// RGBA constructor initializes the EffectiveColor with specified red, green, blue, and alpha percentage values.
  /// </summary>
  /// <param name="red">The red component as a percentage.</param>
  /// <param name="green">The green component as a percentage.</param>
  /// <param name="blue">The blue component as a percentage.</param>
  /// <param name="alpha">The alpha component as a percentage.</param>
  public EffectiveColor(Percentage red, Percentage green, Percentage blue, Percentage alpha)
  {
    Red = red;
    Green = green;
    Blue = blue;
    AlphaFactor = alpha;
  }

  /// <summary>
  /// HSLA constructor initializes the EffectiveColor with specified hue, saturation, luminance, and alpha percentage values.
  /// </summary>
  /// <param name="hue">The hue component as a degree value.</param>
  /// <param name="saturation">The saturation component as a percentage.</param>
  /// <param name="luminance">The luminance component as a percentage.</param>
  /// <param name="alpha">The alpha component as a percentage.</param>
  public EffectiveColor(Degrees hue, Percentage saturation, Percentage luminance, Percentage alpha)
  {
    HSLAComponents = (hue / 360.0, saturation, luminance, alpha);
  }

  /// <summary>
  /// Red component as a percentage value.
  /// </summary>
  /// <remarks>
  /// Specifies the amount of red in the color where 0 is no red and 100% is maximum red.
  /// This is equivalent to RGB values 0-255, but expressed as a percentage for easier calculations.
  /// </remarks>
  public Percentage Red { get; set; }

  /// <summary>
  /// Green component as a percentage value.
  /// </summary>
  /// <remarks>
  /// Specifies the amount of green in the color where 0 is no green and 100%0 is maximum green.
  /// This is equivalent to RGB values 0-255, but expressed as a percentage for easier calculations.
  /// </remarks>
  public Percentage Green { get; set; }

  /// <summary>
  /// Blue component as a percentage value.
  /// </summary>
  /// <remarks>
  /// Specifies the amount of blue in the color where 0 is no blue and 100% is maximum blue.
  /// This is equivalent to RGB values 0-255, but expressed as a percentage for easier calculations.
  /// </remarks>
  public Percentage Blue { get; set; }

  /// <summary>
  /// Alpha component as a percentage value.
  /// </summary>
  /// <remarks>
  /// Specifies the amount of alpha (opacity) in the color where 0 is fully transparent and 100% is fully opaque.
  /// This is equivalent to RGBA values 0-255, but expressed as a percentage for easier calculations.
  /// </remarks>
  public Percentage? Alpha { get; set; }



  /// <summary>
  /// Gets or sets the red component of the color as a double value between 0 and 1.
  /// </summary>
  [XmlIgnore]
  [JsonIgnore]
  [NotMapped]
  public double RedFactor
  {
    get => Red.AsDouble();
    set => Red = new Percentage(value);
  }

  /// <summary>
  /// Gets or sets the green component of the color as a double value between 0 and 1.
  /// </summary>
  [XmlIgnore]
  [JsonIgnore]
  [NotMapped]
  public double GreenFactor
  {
    get => Green.AsDouble();
    set => Green = new Percentage(value);
  }


  /// <summary>
  /// Gets or sets the blue component of the color as a double value between 0 and 1.
  /// </summary>
  [XmlIgnore]
  [JsonIgnore]
  [NotMapped]
  public double BlueFactor
  {
    get => Blue.AsDouble();
    set => Blue = new Percentage(value);
  }

  /// <summary>
  /// Gets or sets the alpha component of the color as a double value between 0 and 1.
  /// </summary>
  [XmlIgnore]
  [JsonIgnore]
  [NotMapped]
  public double AlphaFactor
  {
    get => Alpha?.AsDouble() ?? 1.0;
    set
    {
      if (value == 1.0)
        Alpha = null;
      else
        Alpha = new Percentage(value);
    }
  }
}