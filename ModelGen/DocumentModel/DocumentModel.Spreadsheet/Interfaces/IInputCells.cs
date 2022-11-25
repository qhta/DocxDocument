namespace DocumentModel.Spreadsheet;

/// <summary>
/// Input Cells.
/// </summary>
public interface IInputCells // : DocumentModel.ITypedOpenXmlLeafElement
{
  /// <summary>
  /// Reference
  /// </summary>
  public System.String? CellReference { get ; set; }
  
  /// <summary>
  /// Deleted
  /// </summary>
  public System.Boolean? Deleted { get ; set; }
  
  /// <summary>
  /// Undone
  /// </summary>
  public System.Boolean? Undone { get ; set; }
  
  /// <summary>
  /// Value
  /// </summary>
  public System.String? Val { get ; set; }
  
  /// <summary>
  /// Number Format Id
  /// </summary>
  public System.UInt32? NumberFormatId { get ; set; }
  
}
