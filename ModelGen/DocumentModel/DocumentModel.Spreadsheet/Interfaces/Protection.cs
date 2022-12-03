namespace DocumentModel.Spreadsheet;

/// <summary>
/// Protection.
/// </summary>
public interface Protection // : System.Boolean
{
  /// <summary>
  /// Cell Locked
  /// </summary>
  public Boolean? Locked { get ; set; }
  
  /// <summary>
  /// Hidden Cell
  /// </summary>
  public Boolean? Hidden { get ; set; }
  
}
