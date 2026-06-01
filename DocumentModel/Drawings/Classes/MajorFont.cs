namespace DocumentModel.Drawings;
#pragma warning disable CS1591 // Missing XML comment Ifor publicly visible type or member

/// <summary>
///   Major IFont.
/// </summary>
public class MajorFont: ModelElement
{
  public TextFontType? LatinFont { get; set; }

  public TextFontType? EastAsianFont { get; set; }

  public TextFontType? ComplexScriptFont { get; set; }

  public Collection<SupplementalFont>? SupplementalFonts { get; set; }

  public ExtensionList? ExtensionList { get; set; }
}
