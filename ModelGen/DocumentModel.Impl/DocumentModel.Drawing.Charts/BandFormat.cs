namespace DocumentModel.Drawing.Charts;

/// <summary>
/// Band Format.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Drawing.Charts.IChartShapeProperties))]
[ChildElementInfo(typeof(DocumentModel.Drawing.Charts.IIndex))]
public class BandFormat: IBandFormat
{
  /// <summary>
  /// Index.
  /// </summary>
  public IIndex? Index
  {
    get;
    set;
  }
  
  /// <summary>
  /// ChartShapeProperties.
  /// </summary>
  public IChartShapeProperties? ChartShapeProperties
  {
    get;
    set;
  }
  
}
