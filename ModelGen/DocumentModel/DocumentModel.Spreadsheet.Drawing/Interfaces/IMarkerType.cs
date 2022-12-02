namespace DocumentModel.Spreadsheet.Drawing;

/// <summary>
/// Defines the MarkerType Class.
/// </summary>
public interface IMarkerType // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Column).
  /// </summary>
  public System.String? ColumnId { get ; set; }
  
  /// <summary>
  /// Column Offset.
  /// </summary>
  public System.String? ColumnOffset { get ; set; }
  
  /// <summary>
  /// Row.
  /// </summary>
  public System.String? RowId { get ; set; }
  
  /// <summary>
  /// Row Offset.
  /// </summary>
  public System.String? RowOffset { get ; set; }
  
}
