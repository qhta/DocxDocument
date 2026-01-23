namespace DocumentModel.Drawings;

public abstract class SchemeFont<T>: ModelElement<T>, IExtendableElement where T : DX.OpenXmlElement
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

  /// <summary>
  /// List of extension properties for the scheme font, used for extensibility scenarios.
  /// </summary>
  public ExtensionList? ExtensionList { get; set; }
}