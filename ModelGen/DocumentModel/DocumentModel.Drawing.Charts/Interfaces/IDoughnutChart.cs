namespace DocumentModel.Drawing.Charts;

/// <summary>
/// Doughnut Charts.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Drawing.Charts.IVaryColors))]
[ChildElementInfo(typeof(DocumentModel.Drawing.Charts.IDataLabels))]
[ChildElementInfo(typeof(DocumentModel.Drawing.Charts.IExtensionList))]
[ChildElementInfo(typeof(DocumentModel.Drawing.Charts.IFirstSliceAngle))]
[ChildElementInfo(typeof(DocumentModel.Drawing.Charts.IHoleSize))]
[ChildElementInfo(typeof(DocumentModel.Drawing.Charts.IPieChartSeries))]
public interface IDoughnutChart // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  /// <summary>
  /// VaryColors.
  /// </summary>
  public IVaryColors? VaryColors { get ; set; }
  
}
