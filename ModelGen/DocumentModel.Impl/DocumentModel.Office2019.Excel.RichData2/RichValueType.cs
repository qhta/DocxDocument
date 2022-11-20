namespace DocumentModel.Office2019.Excel.RichData2;

/// <summary>
/// Defines the RichValueType Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Office2019.Excel.RichData2.IExtensionList))]
[ChildElementInfo(typeof(DocumentModel.Office2019.Excel.RichData2.IRichValueTypeKeyFlags))]
public class RichValueType: IRichValueType
{
  /// <summary>
  /// name, this property is only available in Office 2019 and later.
  /// </summary>
  public string? Name
  {
    get;
    set;
  }
  
  /// <summary>
  /// RichValueTypeKeyFlags.
  /// </summary>
  public IRichValueTypeKeyFlags? RichValueTypeKeyFlags
  {
    get;
    set;
  }
  
  /// <summary>
  /// ExtensionList.
  /// </summary>
  public DocumentModel.Office2019.Excel.RichData2.IExtensionList? ExtensionList
  {
    get;
    set;
  }
  
}
