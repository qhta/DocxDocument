namespace DocumentModel.Spreadsheet;

/// <summary>
/// String Item.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Spreadsheet.IPhoneticProperties))]
[ChildElementInfo(typeof(DocumentModel.Spreadsheet.IPhoneticRun))]
[ChildElementInfo(typeof(DocumentModel.Spreadsheet.IRun))]
[ChildElementInfo(typeof(DocumentModel.Spreadsheet.IText))]
public class SharedStringItem: ISharedStringItem
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
