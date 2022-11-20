namespace DocumentModel.Office2013.Excel;

/// <summary>
/// Defines the DbTable Class.
/// </summary>
public class DbTable: IDbTable
{
  /// <summary>
  /// name, this property is only available in Office 2013 and later.
  /// </summary>
  public string? Name
  {
    get;
    set;
  }
  
}
