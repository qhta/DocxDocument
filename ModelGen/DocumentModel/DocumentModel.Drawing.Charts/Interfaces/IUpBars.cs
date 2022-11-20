namespace DocumentModel.Drawing.Charts;

/// <summary>
/// Up Bars.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Drawing.Charts.IChartShapeProperties))]
public interface IUpBars // : DocumentFormat.OpenXml.Drawing.Charts.UpDownBarType
{
  /// <summary>
  /// ChartShapeProperties.
  /// </summary>
  public IChartShapeProperties? ChartShapeProperties { get ; set; }
  
}
