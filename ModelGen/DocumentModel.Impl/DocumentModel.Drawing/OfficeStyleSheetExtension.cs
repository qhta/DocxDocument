namespace DocumentModel.Drawing;

/// <summary>
/// Defines the OfficeStyleSheetExtension Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Office2013.Theme.IThemeFamily))]
public class OfficeStyleSheetExtension: IOfficeStyleSheetExtension
{
  /// <summary>
  /// URI
  /// </summary>
  public string? Uri
  {
    get;
    set;
  }
  
}
