namespace DocumentModel.Office2013.Excel;

/// <summary>
/// Defines the QueryTable Class.
/// </summary>
public class QueryTable: IQueryTable
{
  /// <summary>
  /// clipped, this property is only available in Office 2013 and later.
  /// </summary>
  public bool? Clipped
  {
    get;
    set;
  }
  
  /// <summary>
  /// sourceDataName, this property is only available in Office 2013 and later.
  /// </summary>
  public string? SourceDataName
  {
    get;
    set;
  }
  
  /// <summary>
  /// drillThrough, this property is only available in Office 2013 and later.
  /// </summary>
  public bool? DrillThrough
  {
    get;
    set;
  }
  
}
