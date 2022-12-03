namespace DocumentModel.Spreadsheet;

/// <summary>
/// Defines the Slicer Class.
/// </summary>
public interface Slicer // : DocumentModel.BaseTypes.ModelElement
{
  /// <summary>
  /// name, this property is only available in Office 2010 and later.
  /// </summary>
  public String? Name { get ; set; }
  
  /// <summary>
  /// cache, this property is only available in Office 2010 and later.
  /// </summary>
  public String? Cache { get ; set; }
  
  /// <summary>
  /// caption, this property is only available in Office 2010 and later.
  /// </summary>
  public String? Caption { get ; set; }
  
  /// <summary>
  /// startItem, this property is only available in Office 2010 and later.
  /// </summary>
  public UInt32? StartItem { get ; set; }
  
  /// <summary>
  /// columnCount, this property is only available in Office 2010 and later.
  /// </summary>
  public UInt32? ColumnCount { get ; set; }
  
  /// <summary>
  /// showCaption, this property is only available in Office 2010 and later.
  /// </summary>
  public Boolean? ShowCaption { get ; set; }
  
  /// <summary>
  /// level, this property is only available in Office 2010 and later.
  /// </summary>
  public UInt32? Level { get ; set; }
  
  /// <summary>
  /// style, this property is only available in Office 2010 and later.
  /// </summary>
  public String? Style { get ; set; }
  
  /// <summary>
  /// lockedPosition, this property is only available in Office 2010 and later.
  /// </summary>
  public Boolean? LockedPosition { get ; set; }
  
  /// <summary>
  /// rowHeight, this property is only available in Office 2010 and later.
  /// </summary>
  public UInt32? RowHeight { get ; set; }
  
  /// <summary>
  /// ExtensionList.
  /// </summary>
  public ExtensionList? ExtensionList { get ; set; }
  
}
