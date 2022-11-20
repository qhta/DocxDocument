namespace DocumentModel.Office2013.Excel;

/// <summary>
/// Defines the PivotValueCell Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Office2013.Excel.IXstring))]
[ChildElementInfo(typeof(DocumentModel.Office2013.Excel.IPivotValueCellExtra))]
public class PivotValueCell: IPivotValueCell
{
  /// <summary>
  /// i, this property is only available in Office 2013 and later.
  /// </summary>
  public uint? Item
  {
    get;
    set;
  }
  
  /// <summary>
  /// t, this property is only available in Office 2013 and later.
  /// </summary>
  public SXVCellType? Text
  {
    get;
    set;
  }
  
  /// <summary>
  /// Xstring.
  /// </summary>
  public DocumentModel.Office2013.Excel.IXstring? Xstring
  {
    get;
    set;
  }
  
  /// <summary>
  /// PivotValueCellExtra.
  /// </summary>
  public IPivotValueCellExtra? PivotValueCellExtra
  {
    get;
    set;
  }
  
}
