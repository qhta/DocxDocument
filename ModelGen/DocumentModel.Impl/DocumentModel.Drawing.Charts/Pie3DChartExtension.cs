namespace DocumentModel.Drawing.Charts;

/// <summary>
/// Defines the Pie3DChartExtension Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Office2013.Drawing.Chart.IFilteredPieSeries))]
public class Pie3DChartExtension: IPie3DChartExtension
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
