namespace DocumentModel.Drawings;
    
/// <summary>
/// Represents a theme color definition that combines a name with a Color2Type value.
/// Theme colors are part of a document's color scheme and can be referenced throughout 
/// the document by name (e.g., "Accent1Color", "Dark1Color", "Hyperlink").
/// </summary>
public interface ThemeColor: Color2Type, NamedObject, IEquatable<ThemeColor>
{
  /// <summary>
  /// The name identifier for this theme color (e.g., "Accent1Color", "Dark1Color").
  /// </summary>
  public string? Name { get; set; }

  /// <summary>
  /// The actual color value, which can be an RGB color, HSL color, system color, or preset color.
  /// </summary>
  public Color2Type? Value { get; set; }

}