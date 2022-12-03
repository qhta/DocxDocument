namespace DocumentModel.Spreadsheet.Drawings;

/// <summary>
/// Client Data.
/// </summary>
public interface ClientData // : System.Boolean
{
  /// <summary>
  /// Locks With Sheet Flag
  /// </summary>
  public Boolean? LockWithSheet { get ; set; }
  
  /// <summary>
  /// Prints With Sheet Flag
  /// </summary>
  public Boolean? PrintWithSheet { get ; set; }
  
}
