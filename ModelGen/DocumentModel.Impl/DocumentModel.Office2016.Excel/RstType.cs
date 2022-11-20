namespace DocumentModel.Office2016.Excel;

/// <summary>
/// Defines the RstType Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Spreadsheet.IPhoneticProperties))]
[ChildElementInfo(typeof(DocumentModel.Spreadsheet.IPhoneticRun))]
[ChildElementInfo(typeof(DocumentModel.Spreadsheet.IRun))]
[ChildElementInfo(typeof(DocumentModel.Spreadsheet.IText))]
public class RstType: IRstType
{
  /// <summary>
  /// Text.
  /// </summary>
  public DocumentModel.Spreadsheet.IText? Text
  {
    get;
    set;
  }
  
}
