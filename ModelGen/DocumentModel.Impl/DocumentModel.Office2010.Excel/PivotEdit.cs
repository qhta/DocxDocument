namespace DocumentModel.Office2010.Excel;

/// <summary>
/// Defines the PivotEdit Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Office2010.Excel.IExtensionList))]
[ChildElementInfo(typeof(DocumentModel.Office2010.Excel.IPivotArea))]
[ChildElementInfo(typeof(DocumentModel.Office2010.Excel.IPivotUserEdit))]
[ChildElementInfo(typeof(DocumentModel.Office2010.Excel.ITupleItems))]
public class PivotEdit: IPivotEdit
{
  /// <summary>
  /// PivotUserEdit.
  /// </summary>
  public IPivotUserEdit? PivotUserEdit
  {
    get;
    set;
  }
  
  /// <summary>
  /// TupleItems.
  /// </summary>
  public ITupleItems? TupleItems
  {
    get;
    set;
  }
  
  /// <summary>
  /// PivotArea.
  /// </summary>
  public DocumentModel.Office2010.Excel.IPivotArea? PivotArea
  {
    get;
    set;
  }
  
  /// <summary>
  /// ExtensionList.
  /// </summary>
  public DocumentModel.Office2010.Excel.IExtensionList? ExtensionList
  {
    get;
    set;
  }
  
}
