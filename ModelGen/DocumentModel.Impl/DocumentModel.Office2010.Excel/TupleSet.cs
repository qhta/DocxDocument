namespace DocumentModel.Office2010.Excel;

/// <summary>
/// Defines the TupleSet Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Office2010.Excel.ITupleSetHeaders))]
[ChildElementInfo(typeof(DocumentModel.Office2010.Excel.ITupleSetRows))]
public class TupleSet: ITupleSet
{
  /// <summary>
  /// rowCount, this property is only available in Office 2010 and later.
  /// </summary>
  public uint? RowCount
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
  /// TupleSetHeaders.
  /// </summary>
  public ITupleSetHeaders? TupleSetHeaders
  {
    get;
    set;
  }
  
  /// <summary>
  /// TupleSetRows.
  /// </summary>
  public ITupleSetRows? TupleSetRows
  {
    get;
    set;
  }
  
}
