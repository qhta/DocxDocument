namespace DocumentModel.Drawings;

/// <summary>
///   Defines the OfficeStyleSheetExtension Class.
/// </summary>
public class OfficeStyleSheetExtension: ModelElement
{
  /// <summary>
  ///   URI
  /// </summary>
  public String? Uri { get; set; }

  public ThemeFamily? ThemeFamily { get; set; }
}