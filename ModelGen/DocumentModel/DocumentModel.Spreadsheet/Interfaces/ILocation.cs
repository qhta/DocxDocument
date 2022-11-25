namespace DocumentModel.Spreadsheet;

/// <summary>
/// Defines the Location Class.
/// </summary>
public interface ILocation // : DocumentModel.ITypedOpenXmlLeafElement
{
  /// <summary>
  /// Reference
  /// </summary>
  public System.String? Reference { get ; set; }
  
  /// <summary>
  /// First Header Row
  /// </summary>
  public System.UInt32? FirstHeaderRow { get ; set; }
  
  /// <summary>
  /// PivotTable Data First Row
  /// </summary>
  public System.UInt32? FirstDataRow { get ; set; }
  
  /// <summary>
  /// First Data Column
  /// </summary>
  public System.UInt32? FirstDataColumn { get ; set; }
  
  /// <summary>
  /// Rows Per Page Count
  /// </summary>
  public System.UInt32? RowPageCount { get ; set; }
  
  /// <summary>
  /// Columns Per Page
  /// </summary>
  public System.UInt32? ColumnsPerPage { get ; set; }
  
}
