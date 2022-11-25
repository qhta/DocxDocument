namespace DocumentModel.Spreadsheet;

/// <summary>
/// Defines the MarkerType Class.
/// </summary>
public interface IMarkerType // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Column).
  /// </summary>
  public DocumentModel.BaseTypes.ModelElement? ColumnId { get ; set; }
  
  /// <summary>
  /// Column Offset.
  /// </summary>
  public DocumentModel.BaseTypes.ModelElement? ColumnOffset { get ; set; }
  
  /// <summary>
  /// Row.
  /// </summary>
  public DocumentModel.BaseTypes.ModelElement? RowId { get ; set; }
  
  /// <summary>
  /// Row Offset.
  /// </summary>
  public DocumentModel.BaseTypes.ModelElement? RowOffset { get ; set; }
  
}
