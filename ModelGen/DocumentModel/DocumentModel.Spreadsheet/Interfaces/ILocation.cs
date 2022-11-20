namespace DocumentModel.Spreadsheet;

/// <summary>
/// Defines the Location Class.
/// </summary>
public interface ILocation // : DocumentFormat.OpenXml.TypedOpenXmlLeafElement
{
  /// <summary>
  /// Reference
  /// </summary>
  public string? Reference { get ; set; }
  
  /// <summary>
  /// First Header Row
  /// </summary>
  public uint? FirstHeaderRow { get ; set; }
  
  /// <summary>
  /// PivotTable Data First Row
  /// </summary>
  public uint? FirstDataRow { get ; set; }
  
  /// <summary>
  /// First Data Column
  /// </summary>
  public uint? FirstDataColumn { get ; set; }
  
  /// <summary>
  /// Rows Per Page Count
  /// </summary>
  public uint? RowPageCount { get ; set; }
  
  /// <summary>
  /// Columns Per Page
  /// </summary>
  public uint? ColumnsPerPage { get ; set; }
  
}
