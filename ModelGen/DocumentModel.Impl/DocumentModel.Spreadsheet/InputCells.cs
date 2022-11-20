namespace DocumentModel.Spreadsheet;

/// <summary>
/// Input Cells.
/// </summary>
public class InputCells: IInputCells
{
  /// <summary>
  /// Reference
  /// </summary>
  public string? CellReference
  {
    get;
    set;
  }
  
  /// <summary>
  /// Deleted
  /// </summary>
  public bool? Deleted
  {
    get;
    set;
  }
  
  /// <summary>
  /// Undone
  /// </summary>
  public bool? Undone
  {
    get;
    set;
  }
  
  /// <summary>
  /// Value
  /// </summary>
  public string? Val
  {
    get;
    set;
  }
  
  /// <summary>
  /// Number Format Id
  /// </summary>
  public uint? NumberFormatId
  {
    get;
    set;
  }
  
}
