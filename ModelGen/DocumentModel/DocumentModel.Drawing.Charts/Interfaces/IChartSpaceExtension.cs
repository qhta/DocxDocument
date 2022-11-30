namespace DocumentModel.Drawing.Charts;

/// <summary>
/// Defines the ChartSpaceExtension Class.
/// </summary>
public interface IChartSpaceExtension // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// URI
  /// </summary>
  public System.String? Uri { get ; set; }
  
  public DocumentModel.Office2010.Drawing.Charts.IPivotOptions? PivotOptions { get ; set; }
  
  public DocumentModel.Office2010.Drawing.Charts.ISketchOptions? SketchOptions { get ; set; }
  
  public DocumentModel.Office2013.Drawing.Chart.IPivotSource? PivotSource { get ; set; }
  
}
