namespace DocumentModel.Drawings;

/// <summary>
/// Model of color representation used in drawing elements. This enumeration defines the various color models that can be used to specify colors in drawing elements, such as RGB hexadecimal, RGB percentage, HSL (Hue, Saturation, Luminance), scheme colors, preset colors, and system colors. Each color model represents a different way of defining and interpreting color values, allowing for flexibility in how colors are specified and used within the document model for drawings.
/// </summary>
[JsonConverter(typeof(JsonStringEnumConverter))]
public enum ColorModel
{
  /// <summary>
  /// RGB color model using hexadecimal notation. This model represents colors as a combination of red, green, and blue components, where each component is specified as a hexadecimal value (e.g., "FF0000" for red). The RGB hexadecimal color model allows for precise color specification and is commonly used in digital graphics and web design. In the context of drawing elements, this model enables the definition of colors using hex values, which can be easily interpreted and rendered by drawing applications.
  /// </summary>
  RGBHex,
  /// <summary>
  /// RGB color model using percentage notation. This model represents colors as a combination of red, green, and blue components, where each component is specified as a percentage value (e.g., "100%" for full intensity). The RGB percentage color model allows for relative color specification and is useful for scenarios where colors need to be defined in a scalable manner.
  /// </summary>
  RGBPercentage,
  /// <summary>
  /// HSL (Hue, Saturation, Luminance) color model. This model represents colors based on their hue, saturation, and luminance values, providing an intuitive way to adjust color properties. The HSL color model is often used in design and graphics applications for its ease of manipulating color attributes.
  /// </summary>
  HSL,
  /// <summary>
  /// Scheme color model. This model represents colors that are part of a predefined color scheme, allowing for consistent theming across documents and applications.
  /// </summary>
  Scheme,
  /// <summary>
  /// Preset color model. This model represents colors that are predefined and named, allowing for easy selection of common colors.
  /// </summary>
  Preset,
  /// <summary>
  /// System color model. This model represents colors that are defined by the operating system, allowing for dynamic adaptation to system themes and settings.
  /// </summary>  
  System,
}