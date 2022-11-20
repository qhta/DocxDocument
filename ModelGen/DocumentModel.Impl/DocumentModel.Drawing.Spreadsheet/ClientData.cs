namespace DocumentModel.Drawing.Spreadsheet;

/// <summary>
/// Client Data.
/// </summary>
public class ClientData: IClientData
{
  /// <summary>
  /// Locks With Sheet Flag
  /// </summary>
  public bool? LockWithSheet
  {
    get;
    set;
  }
  
  /// <summary>
  /// Prints With Sheet Flag
  /// </summary>
  public bool? PrintWithSheet
  {
    get;
    set;
  }
  
}
