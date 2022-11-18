namespace DocumentModel.Drawing.Charts;

/// <summary>
/// Line Charts.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Drawing.Charts.IVaryColors))]
[ChildElementInfo(typeof(DocumentModel.Drawing.Charts.IShowMarker))]
[ChildElementInfo(typeof(DocumentModel.Drawing.Charts.ISmooth))]
[ChildElementInfo(typeof(DocumentModel.Drawing.Charts.IDropLines))]
[ChildElementInfo(typeof(DocumentModel.Drawing.Charts.IHighLowLines))]
[ChildElementInfo(typeof(DocumentModel.Drawing.Charts.IDataLabels))]
[ChildElementInfo(typeof(DocumentModel.Drawing.Charts.IGrouping))]
[ChildElementInfo(typeof(DocumentModel.Drawing.Charts.ILineChartExtensionList))]
[ChildElementInfo(typeof(DocumentModel.Drawing.Charts.ILineChartSeries))]
[ChildElementInfo(typeof(DocumentModel.Drawing.Charts.IAxisId))]
[ChildElementInfo(typeof(DocumentModel.Drawing.Charts.IUpDownBars))]
public interface ILineChart // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  /// <summary>
  /// Grouping.
  /// </summary>
  public IGrouping? Grouping { get ; set; }
  
  /// <summary>
  /// VaryColors.
  /// </summary>
  public IVaryColors? VaryColors { get ; set; }
  
}
