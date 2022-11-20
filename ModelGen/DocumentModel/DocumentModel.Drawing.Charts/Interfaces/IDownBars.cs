namespace DocumentModel.Drawing.Charts;

/// <summary>
/// Down Bars.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Drawing.Charts.IChartShapeProperties))]
public interface IDownBars // : DocumentFormat.OpenXml.Drawing.Charts.UpDownBarType
{
  /// <summary>
  /// ChartShapeProperties.
  /// </summary>
  public IChartShapeProperties? ChartShapeProperties { get ; set; }
  
}
