namespace DocumentModel.Spreadsheet;

/// <summary>
/// PivotChart Format.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Spreadsheet.IPivotArea))]
public class ChartFormat: IChartFormat
{
  /// <summary>
  /// Chart Index
  /// </summary>
  public uint? Chart
  {
    get;
    set;
  }
  
  /// <summary>
  /// Pivot Format Id
  /// </summary>
  public uint? Format
  {
    get;
    set;
  }
  
  /// <summary>
  /// Series Format
  /// </summary>
  public bool? Series
  {
    get;
    set;
  }
  
  /// <summary>
  /// Pivot Table Location Rule.
  /// </summary>
  public DocumentModel.Spreadsheet.IPivotArea? PivotArea
  {
    get;
    set;
  }
  
}
