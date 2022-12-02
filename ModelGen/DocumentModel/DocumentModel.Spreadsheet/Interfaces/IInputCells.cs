namespace DocumentModel.Spreadsheet;

/// <summary>
/// Input Cells.
/// </summary>
public interface IInputCells // : DocumentModel.ITypedOpenXmlLeafElement
{
  /// <summary>
  /// Reference
  /// </summary>
  public String? CellReference { get ; set; }
  
  /// <summary>
  /// Deleted
  /// </summary>
  public Boolean? Deleted { get ; set; }
  
  /// <summary>
  /// Undone
  /// </summary>
  public Boolean? Undone { get ; set; }
  
  /// <summary>
  /// Value
  /// </summary>
  public String? Val { get ; set; }
  
  /// <summary>
  /// Number Format Id
  /// </summary>
  public UInt32? NumberFormatId { get ; set; }
  
}
