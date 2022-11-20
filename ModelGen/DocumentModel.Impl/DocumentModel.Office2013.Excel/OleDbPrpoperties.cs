namespace DocumentModel.Office2013.Excel;

/// <summary>
/// Defines the OleDbPrpoperties Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Office2013.Excel.IDbCommand))]
[ChildElementInfo(typeof(DocumentModel.Office2013.Excel.IDbTables))]
public class OleDbPrpoperties: IOleDbPrpoperties
{
  /// <summary>
  /// connection, this property is only available in Office 2013 and later.
  /// </summary>
  public string? Connection
  {
    get;
    set;
  }
  
  /// <summary>
  /// DbTables.
  /// </summary>
  public IDbTables? DbTables
  {
    get;
    set;
  }
  
  /// <summary>
  /// DbCommand.
  /// </summary>
  public IDbCommand? DbCommand
  {
    get;
    set;
  }
  
}
