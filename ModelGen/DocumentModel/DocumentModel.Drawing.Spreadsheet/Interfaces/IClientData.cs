namespace DocumentModel.Drawing.Spreadsheet;

/// <summary>
/// Client Data.
/// </summary>
public interface IClientData // : DocumentModel.ITypedOpenXmlLeafElement
{
  /// <summary>
  /// Locks With Sheet Flag
  /// </summary>
  public System.Boolean? LockWithSheet { get ; set; }
  
  /// <summary>
  /// Prints With Sheet Flag
  /// </summary>
  public System.Boolean? PrintWithSheet { get ; set; }
  
}
