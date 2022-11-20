namespace DocumentModel.Spreadsheet;

/// <summary>
/// Comment Text.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Spreadsheet.IPhoneticProperties))]
[ChildElementInfo(typeof(DocumentModel.Spreadsheet.IPhoneticRun))]
[ChildElementInfo(typeof(DocumentModel.Spreadsheet.IRun))]
[ChildElementInfo(typeof(DocumentModel.Spreadsheet.IText))]
public interface ICommentText // : DocumentFormat.OpenXml.Spreadsheet.RstType
{
  /// <summary>
  /// Text.
  /// </summary>
  public DocumentModel.Spreadsheet.IText? Text { get ; set; }
  
}
