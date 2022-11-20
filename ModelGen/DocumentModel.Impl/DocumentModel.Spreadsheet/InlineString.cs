namespace DocumentModel.Spreadsheet;

/// <summary>
/// Rich Text Inline.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Spreadsheet.IPhoneticProperties))]
[ChildElementInfo(typeof(DocumentModel.Spreadsheet.IPhoneticRun))]
[ChildElementInfo(typeof(DocumentModel.Spreadsheet.IRun))]
[ChildElementInfo(typeof(DocumentModel.Spreadsheet.IText))]
public class InlineString: IInlineString
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
