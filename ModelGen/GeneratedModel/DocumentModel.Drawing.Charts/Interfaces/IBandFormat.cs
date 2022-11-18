namespace DocumentModel.Drawing.Charts;

/// <summary>
/// Band Format.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Drawing.Charts.IChartShapeProperties))]
[ChildElementInfo(typeof(DocumentModel.Drawing.Charts.IIndex))]
public interface IBandFormat // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  /// <summary>
  /// Index.
  /// </summary>
  public IIndex? Index { get ; set; }
  
  /// <summary>
  /// ChartShapeProperties.
  /// </summary>
  public IChartShapeProperties? ChartShapeProperties { get ; set; }
  
}
