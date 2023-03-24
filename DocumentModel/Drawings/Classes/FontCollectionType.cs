namespace DocumentModel.Drawings;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Defines the FontCollectionType Class.
/// </summary>
public class FontCollectionType: ModelElement
{
  /// <summary>
  ///   Latin Font.
  /// </summary>
  public TextFontType? LatinFont { get; set; }

  /// <summary>
  ///   East Asian Font.
  /// </summary>
  public TextFontType? EastAsianFont { get; set; }

  /// <summary>
  ///   Complex Script Font.
  /// </summary>
  public TextFontType? ComplexScriptFont { get; set; }
}