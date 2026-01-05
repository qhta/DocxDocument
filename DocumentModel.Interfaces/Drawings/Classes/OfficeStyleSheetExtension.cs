namespace DocumentModel.Drawings;

/// <summary>
///   Defines the OfficeStyleSheetExtension interface.
/// </summary>
public interface OfficeStyleSheetExtension:
{
  /// <summary>
  ///   URI
  /// </summary>
  public string? Uri { get; set; }
  public ThemeFamily? ThemeFamily { get; set; }
}