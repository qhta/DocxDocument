namespace DocumentModel.Drawing.Charts;

/// <summary>
/// Defines the ChartSpaceExtension Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Office2013.Drawing.Chart.IPivotSource))]
[ChildElementInfo(typeof(DocumentModel.Office2010.Drawing.Charts.IPivotOptions))]
[ChildElementInfo(typeof(DocumentModel.Office2010.Drawing.Charts.ISketchOptions))]
public interface IChartSpaceExtension // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  /// <summary>
  /// URI
  /// </summary>
  public string? Uri { get ; set; }
  
}
