namespace DocumentModel.Drawing.Charts;

/// <summary>
/// 3D Bar Charts.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Drawing.Charts.IBar3DChartExtensionList))]
[ChildElementInfo(typeof(DocumentModel.Drawing.Charts.IBarDirection))]
[ChildElementInfo(typeof(DocumentModel.Drawing.Charts.IBarGrouping))]
[ChildElementInfo(typeof(DocumentModel.Drawing.Charts.IBarChartSeries))]
[ChildElementInfo(typeof(DocumentModel.Drawing.Charts.IVaryColors))]
[ChildElementInfo(typeof(DocumentModel.Drawing.Charts.IDataLabels))]
[ChildElementInfo(typeof(DocumentModel.Drawing.Charts.IGapWidth))]
[ChildElementInfo(typeof(DocumentModel.Drawing.Charts.IGapDepth))]
[ChildElementInfo(typeof(DocumentModel.Drawing.Charts.IShape))]
[ChildElementInfo(typeof(DocumentModel.Drawing.Charts.IAxisId))]
public interface IBar3DChart // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
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
