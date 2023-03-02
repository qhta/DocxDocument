namespace DocumentModel.Drawings;

/// <summary>
///   Defines the OfficeStyleSheetExtension Class.
/// </summary>
public record OfficeStyleSheetExtension
{
  /// <summary>
  ///   URI
  /// </summary>
  public String? Uri { get; set; }

  public ThemeFamily? ThemeFamily { get; set; }
}