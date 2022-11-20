namespace DocumentModel.Office2010.Excel;

/// <summary>
/// Defines the Slicer Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Office2010.Excel.IExtensionList))]
public class Slicer: ISlicer
{
  /// <summary>
  /// name, this property is only available in Office 2010 and later.
  /// </summary>
  public string? Name
  {
    get;
    set;
  }
  
  /// <summary>
  /// cache, this property is only available in Office 2010 and later.
  /// </summary>
  public string? Cache
  {
    get;
    set;
  }
  
  /// <summary>
  /// caption, this property is only available in Office 2010 and later.
  /// </summary>
  public string? Caption
  {
    get;
    set;
  }
  
  /// <summary>
  /// startItem, this property is only available in Office 2010 and later.
  /// </summary>
  public uint? StartItem
  {
    get;
    set;
  }
  
  /// <summary>
  /// columnCount, this property is only available in Office 2010 and later.
  /// </summary>
  public uint? ColumnCount
  {
    get;
    set;
  }
  
  /// <summary>
  /// showCaption, this property is only available in Office 2010 and later.
  /// </summary>
  public bool? ShowCaption
  {
    get;
    set;
  }
  
  /// <summary>
  /// level, this property is only available in Office 2010 and later.
  /// </summary>
  public uint? Level
  {
    get;
    set;
  }
  
  /// <summary>
  /// style, this property is only available in Office 2010 and later.
  /// </summary>
  public string? Style
  {
    get;
    set;
  }
  
  /// <summary>
  /// lockedPosition, this property is only available in Office 2010 and later.
  /// </summary>
  public bool? LockedPosition
  {
    get;
    set;
  }
  
  /// <summary>
  /// rowHeight, this property is only available in Office 2010 and later.
  /// </summary>
  public uint? RowHeight
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
