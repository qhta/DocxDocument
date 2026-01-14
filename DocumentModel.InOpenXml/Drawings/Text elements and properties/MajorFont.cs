namespace DocumentModel.Drawings;

/// <summary>
///   Represents the major font settings for a font scheme, including definitions for Latin, East Asian, complex scripts, and supplemental fonts.
/// </summary>
public interface MajorFont : IExtendableElement
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

  /// <summary>
  ///   Collection of supplemental fonts for additional language support.
  /// </summary>
  public SupplementalFonts? SupplementalFonts { get; set; }
}