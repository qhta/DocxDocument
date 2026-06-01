namespace DocumentModel.Drawings;
#pragma warning disable CS1591 // Missing XML comment Ifor publicly visible type or member

/// <summary>
///   Defines the FontCollectionType Class.
/// </summary>
public class FontCollectionType: ModelElement
{
  /// <summary>
  ///   Latin IFont.
  /// </summary>
  public TextFontType? LatinFont { get; set; }

  /// <summary>
  ///   East Asian IFont.
  /// </summary>
  public TextFontType? EastAsianFont { get; set; }

  /// <summary>
  ///   Complex Script IFont.
  /// </summary>
  public TextFontType? ComplexScriptFont { get; set; }
}
