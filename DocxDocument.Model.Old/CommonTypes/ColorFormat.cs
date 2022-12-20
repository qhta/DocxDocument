namespace DocxDocument.Model;

public class ColorFormat
{
  /// <summary> 
  /// Returns or sets the name of the specified object.
  ///</summary> 
  public string? Name { get; set; }

  /// <summary> 
  /// Returns the shape color type.
  ///</summary> 
  public ColorType? Type { get; set; }

  /// <summary> 
  /// Returns or sets a value that represents the cyan component of a CMYK color.
  ///</summary> 
  public int? Cyan { get; set; }

  /// <summary> 
  /// Returns or sets a value that represents the magenta component of a CMYK color.
  ///</summary> 
  public int? Magenta { get; set; }

  /// <summary> 
  /// Returns or sets a value that represents the yellow component of a CMYK color.
  ///</summary> 
  public int? Yellow { get; set; }

  /// <summary> 
  /// Returns or sets a value that represents the black component of a CMYK color.
  ///</summary> 
  public int? Black { get; set; }

  /// <summary> 
  /// Returns or sets a value that represents the degree of saturation for a specified ink.
  ///</summary> 
  public float[]? Ink { get; set; }

  /// <summary> 
  /// Gets the brightness of a specified shape color.
  ///</summary> 
  public float? Brightness { get; set; }

  /// <summary> 
  /// Returns or sets a value that represents the lightening or darkening of a specified shape's color.
  ///</summary> 
  public float? TintAndShade { get; set; }

  /// <summary> 
  /// Returns or sets the red-green-blue (RGB) value of the specified color.
  ///</summary> 
  public Color? RGB { get; set; }

  /// <summary> 
  /// Returns or sets a value that represents the color in the applied color scheme that's associated with the specified object.
  ///</summary> 
  public int? SchemeColor { get; set; }

  /// <summary> 
  /// Returns or sets the theme color for a color format. Read/write.
  ///</summary> 
  public ThemeColorIndex? ObjectThemeColor { get; set; }

  /// <summary> 
  /// Returns or sets a value that indicates when creating separation plates for commercial printing, the specified shape is not printed on the separation plates where the ink level of the shape is set to 0 (zero).
  ///</summary> 
  public bool? OverPrint { get; set; }
}