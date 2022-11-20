namespace DocumentModel.Drawing.Charts;

/// <summary>
/// Defines the Line3DChartExtension Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Office2013.Drawing.Chart.IFilteredLineSeriesExtension))]
public class Line3DChartExtension: ILine3DChartExtension
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
