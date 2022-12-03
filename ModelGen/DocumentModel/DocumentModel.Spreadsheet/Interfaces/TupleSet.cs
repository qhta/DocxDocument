namespace DocumentModel.Spreadsheet;

/// <summary>
/// Defines the TupleSet Class.
/// </summary>
public interface TupleSet // : DocumentModel.BaseTypes.ModelElement
{
  /// <summary>
  /// rowCount, this property is only available in Office 2010 and later.
  /// </summary>
  public UInt32? RowCount { get ; set; }
  
  /// <summary>
  /// columnCount, this property is only available in Office 2010 and later.
  /// </summary>
  public UInt32? ColumnCount { get ; set; }
  
  /// <summary>
  /// TupleSetHeaders.
  /// </summary>
  public TupleSetHeaders? TupleSetHeaders { get ; set; }
  
  /// <summary>
  /// TupleSetRows.
  /// </summary>
  public TupleSetRows? TupleSetRows { get ; set; }
  
}
