namespace DocumentModel.Spreadsheet;

/// <summary>
/// Defines the StylesheetExtension Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Office2010.Excel.IDifferentialFormats))]
[ChildElementInfo(typeof(DocumentModel.Office2013.Excel.IDifferentialFormats))]
[ChildElementInfo(typeof(DocumentModel.Office2010.Excel.ISlicerStyles))]
[ChildElementInfo(typeof(DocumentModel.Office2013.Excel.ITimelineStyles))]
public class StylesheetExtension: IStylesheetExtension
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
