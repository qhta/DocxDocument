namespace DocumentModel.Drawings;

/// <summary>
/// Defines the OfficeStyleSheetExtension Class.
/// </summary>
public interface OfficeStyleSheetExtension
{
  /// <summary>
  /// URI
  /// </summary>
  public String? Uri { get ; set; }
  
  public DocumentModel.ThemeFamily? ThemeFamily { get ; set; }
  
}
