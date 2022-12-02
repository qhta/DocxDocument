namespace DocumentModel.Spreadsheet;

/// <summary>
/// Defines the Location Class.
/// </summary>
public interface ILocation // : DocumentModel.ITypedOpenXmlLeafElement
{
  /// <summary>
  /// Reference
  /// </summary>
  public String? Reference { get ; set; }
  
  /// <summary>
  /// First Header Row
  /// </summary>
  public UInt32? FirstHeaderRow { get ; set; }
  
  /// <summary>
  /// PivotTable Data First Row
  /// </summary>
  public UInt32? FirstDataRow { get ; set; }
  
  /// <summary>
  /// First Data Column
  /// </summary>
  public UInt32? FirstDataColumn { get ; set; }
  
  /// <summary>
  /// Rows Per Page Count
  /// </summary>
  public UInt32? RowPageCount { get ; set; }
  
  /// <summary>
  /// Columns Per Page
  /// </summary>
  public UInt32? ColumnsPerPage { get ; set; }
  
}
