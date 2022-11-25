namespace DocumentModel.Office2010.Excel;

/// <summary>
/// Defines the Slicer Class.
/// </summary>
public interface ISlicer // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// name, this property is only available in Office 2010 and later.
  /// </summary>
  public System.String? Name { get ; set; }
  
  /// <summary>
  /// cache, this property is only available in Office 2010 and later.
  /// </summary>
  public System.String? Cache { get ; set; }
  
  /// <summary>
  /// caption, this property is only available in Office 2010 and later.
  /// </summary>
  public System.String? Caption { get ; set; }
  
  /// <summary>
  /// startItem, this property is only available in Office 2010 and later.
  /// </summary>
  public System.UInt32? StartItem { get ; set; }
  
  /// <summary>
  /// columnCount, this property is only available in Office 2010 and later.
  /// </summary>
  public System.UInt32? ColumnCount { get ; set; }
  
  /// <summary>
  /// showCaption, this property is only available in Office 2010 and later.
  /// </summary>
  public System.Boolean? ShowCaption { get ; set; }
  
  /// <summary>
  /// level, this property is only available in Office 2010 and later.
  /// </summary>
  public System.UInt32? Level { get ; set; }
  
  /// <summary>
  /// style, this property is only available in Office 2010 and later.
  /// </summary>
  public System.String? Style { get ; set; }
  
  /// <summary>
  /// lockedPosition, this property is only available in Office 2010 and later.
  /// </summary>
  public System.Boolean? LockedPosition { get ; set; }
  
  /// <summary>
  /// rowHeight, this property is only available in Office 2010 and later.
  /// </summary>
  public System.UInt32? RowHeight { get ; set; }
  
  /// <summary>
  /// ExtensionList.
  /// </summary>
  public DocumentModel.BaseTypes.ModelElement? ExtensionList { get ; set; }
  
}
