namespace DocumentModel;
/// <summary>
/// Represents an RGB color as a result of color transformations applied to a base color.
/// </summary>
[DataContract]
public partial class EffectiveColor : ModelElement
{

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
  public Percentage Alpha { get; set; }



  /// <summary>
  /// Gets or sets the red component of the color as a double value between 0 and 1.
  /// </summary>
  public double RedFactor
  {
    get => Red.AsDouble();
    set => Red = new Percentage(value);
  }

  /// <summary>
  /// Gets or sets the green component of the color as a double value between 0 and 1.
  /// </summary>
  public double GreenFactor
  {
    get => Green.AsDouble();
    set => Green = new Percentage(value);
  }


  /// <summary>
  /// Gets or sets the blue component of the color as a double value between 0 and 1.
  /// </summary>
  public double BlueFactor
  {
    get => Blue.AsDouble();
    set => Blue = new Percentage(value);
  }

  /// <summary>
  /// Gets or sets the alpha component of the color as a double value between 0 and 1.
  /// </summary>
  public double AlphaFactor
  {
    get => Alpha.AsDouble();
    set => Alpha = new Percentage(value);
  }
}