namespace DocumentModel.Drawing;

/// <summary>
/// Table Properties.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Drawing.IBlipFill))]
[ChildElementInfo(typeof(DocumentModel.Drawing.IEffectDag))]
[ChildElementInfo(typeof(DocumentModel.Drawing.IEffectList))]
[ChildElementInfo(typeof(DocumentModel.Drawing.IGradientFill))]
[ChildElementInfo(typeof(DocumentModel.Drawing.IGroupFill))]
[ChildElementInfo(typeof(DocumentModel.Drawing.INoFill))]
[ChildElementInfo(typeof(DocumentModel.Drawing.IExtensionList))]
[ChildElementInfo(typeof(DocumentModel.Drawing.IPatternFill))]
[ChildElementInfo(typeof(DocumentModel.Drawing.ISolidFill))]
[ChildElementInfo(typeof(DocumentModel.Drawing.ITableStyle))]
[ChildElementInfo(typeof(DocumentModel.Drawing.ITableStyleId))]
public class TableProperties: ITableProperties
{
  /// <summary>
  /// Right-to-Left
  /// </summary>
  public bool? RightToLeft
  {
    get;
    set;
  }
  
  /// <summary>
  /// First Row
  /// </summary>
  public bool? FirstRow
  {
    get;
    set;
  }
  
  /// <summary>
  /// First Column
  /// </summary>
  public bool? FirstColumn
  {
    get;
    set;
  }
  
  /// <summary>
  /// Last Row
  /// </summary>
  public bool? LastRow
  {
    get;
    set;
  }
  
  /// <summary>
  /// Last Column
  /// </summary>
  public bool? LastColumn
  {
    get;
    set;
  }
  
  /// <summary>
  /// Banded Rows
  /// </summary>
  public bool? BandRow
  {
    get;
    set;
  }
  
  /// <summary>
  /// Banded Columns
  /// </summary>
  public bool? BandColumn
  {
    get;
    set;
  }
  
}
