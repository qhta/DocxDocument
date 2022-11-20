namespace DocumentModel.Drawing.Charts;

/// <summary>
/// Defines the PieChartExtension Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Office2013.Drawing.Chart.IFilteredPieSeries))]
public class PieChartExtension: IPieChartExtension
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
