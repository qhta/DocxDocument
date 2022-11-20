namespace DocumentModel.Drawing.Charts;

/// <summary>
/// Defines the LineChartExtension Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Office2013.Drawing.Chart.IFilteredLineSeriesExtension))]
public class LineChartExtension: ILineChartExtension
{
  /// <summary>
  /// URI
  /// </summary>
  public string? Uri
  {
    get;
    set;
  }
  
}
