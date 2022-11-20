namespace DocumentModel.Spreadsheet;

/// <summary>
/// OLAP Measure Group.
/// </summary>
public class MeasureGroup: IMeasureGroup
{
  /// <summary>
  /// Measure Group Name
  /// </summary>
  public string? Name
  {
    get;
    set;
  }
  
  /// <summary>
  /// Measure Group Display Name
  /// </summary>
  public string? Caption
  {
    get;
    set;
  }
  
}
