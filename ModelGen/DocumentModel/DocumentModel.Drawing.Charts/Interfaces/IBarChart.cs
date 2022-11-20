namespace DocumentModel.Drawing.Charts;

/// <summary>
/// Bar Charts.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Drawing.Charts.IBarChartExtensionList))]
[ChildElementInfo(typeof(DocumentModel.Drawing.Charts.IBarDirection))]
[ChildElementInfo(typeof(DocumentModel.Drawing.Charts.IBarGrouping))]
[ChildElementInfo(typeof(DocumentModel.Drawing.Charts.IBarChartSeries))]
[ChildElementInfo(typeof(DocumentModel.Drawing.Charts.IVaryColors))]
[ChildElementInfo(typeof(DocumentModel.Drawing.Charts.ISeriesLines))]
[ChildElementInfo(typeof(DocumentModel.Drawing.Charts.IDataLabels))]
[ChildElementInfo(typeof(DocumentModel.Drawing.Charts.IGapWidth))]
[ChildElementInfo(typeof(DocumentModel.Drawing.Charts.IOverlap))]
[ChildElementInfo(typeof(DocumentModel.Drawing.Charts.IAxisId))]
public interface IBarChart // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  /// <summary>
  /// Bar Direction.
  /// </summary>
  public IBarDirection? BarDirection { get ; set; }
  
  /// <summary>
  /// Bar Grouping.
  /// </summary>
  public IBarGrouping? BarGrouping { get ; set; }
  
  /// <summary>
  /// VaryColors.
  /// </summary>
  public IVaryColors? VaryColors { get ; set; }
  
}
