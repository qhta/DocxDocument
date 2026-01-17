namespace DocumentModel.Drawings;

/// <summary>
///   Represents a collection of font settings for different writing systems, including Latin, East Asian, and complex scripts.
/// </summary>
public class FontCollectionType: ModelElement<DXD.FontCollectionType>
{
  /// <summary>
  ///   Font settings for Latin text.
  /// </summary>
  public TextFontType? LatinFont { get; set; }

  /// <summary>
  ///   Font settings for East Asian text.
  /// </summary>
  public TextFontType? EastAsianFont { get; set; }

  /// <summary>
  ///   Font settings for complex script text.
  /// </summary>
  public TextFontType? ComplexScriptFont { get; set; }
}