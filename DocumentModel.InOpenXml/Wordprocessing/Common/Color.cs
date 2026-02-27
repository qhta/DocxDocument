namespace DocumentModel.Wordprocessing;
/// <summary>
/// Represents a color definition for use in WordprocessingML documents.
/// This class extends <see cref = "AbstractColor"/> and is used to specify color values for document elements such as borders, shading, and text, enabling advanced formatting and visual customization.
/// </summary>
[OpenXmlType(typeof(DXW.Color))]
public partial class Color : AbstractColor<DXW.Color>
{
  /// <summary>
  /// Initializes a new instance of the Color class.
  /// </summary>
  public Color() : base()
  {
  }

  /// <summary>
  /// Initializes a new instance of the Color class using the specified hexadecimal color string.
  /// </summary>
  /// <remarks>The hexColor parameter can be null, in which case the Color instance will be initialized with a
  /// null value.</remarks>
  /// <param name = "hexColor">The hexadecimal color string to initialize the Color instance. It should be in the format 'RRGGBB'.</param>
  public Color(string hexColor)
  {
    Val = hexColor;
  }

  /// <summary>
  /// <para>Run Content Color</para>
  /// <para>Represents the following attribute in the schema: w:val</para>
  /// </summary>
  /// <remarks>
  /// xmlns:w=http://schemas.openxmlformats.org/wordprocessingml/2006/main
  /// </remarks>
  [OpenXmlProperty(nameof(DXW.Color.Val))]
  public HexRgb? Val { get; set; }

  /// <summary>
  /// <para>Run Content Theme Color</para>
  /// <para>Represents the following attribute in the schema: w:themeColor</para>
  /// </summary>
  /// <remarks>
  /// xmlns:w=http://schemas.openxmlformats.org/wordprocessingml/2006/main
  /// </remarks>
  [OpenXmlProperty(nameof(DXW.Color.ThemeColor))]
  public ThemeColors? ThemeColor { get; set; }

  /// <summary>
  /// <para>Run Content Theme Color Tint</para>
  /// <para>Represents the following attribute in the schema: w:themeTint</para>
  /// </summary>
  /// <remarks>
  /// xmlns:w=http://schemas.openxmlformats.org/wordprocessingml/2006/main
  /// </remarks>
  [OpenXmlProperty(nameof(DXW.Color.ThemeTint))]
  public Byte? ThemeTint { get; set; }

  /// <summary>
  /// <para>Run Content Theme Color Shade</para>
  /// <para>Represents the following attribute in the schema: w:themeShade</para>
  /// </summary>
  /// <remarks>
  /// xmlns:w=http://schemas.openxmlformats.org/wordprocessingml/2006/main
  /// </remarks>
  [OpenXmlProperty(nameof(DXW.Color.ThemeShade))]
  public Byte? ThemeShade { get; set; }

  public override string? ToString()
  {
    if (Val is not null)
      return Val.ToString();
    if (ThemeColor is not null)
      return ThemeColor.ToString() + (ThemeTint is not null ? $" Tint:{ThemeTint}" : "") + (ThemeShade is not null ? $" Shade:{ThemeShade}" : "");
    return base.ToString();
  }
}