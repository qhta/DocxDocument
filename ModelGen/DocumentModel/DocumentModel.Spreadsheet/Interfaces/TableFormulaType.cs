namespace DocumentModel.Spreadsheet;

/// <summary>
/// Defines the TableFormulaType Class.
/// </summary>
public interface TableFormulaType // : System.String
{
  /// <summary>
  /// Array
  /// </summary>
  public Boolean? Array { get ; set; }
  
  /// <summary>
  /// space
  /// </summary>
  public DocumentModel.SpaceProcessingMode? Space { get ; set; }
  
}
