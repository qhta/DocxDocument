namespace DocumentModel.Drawing;

/// <summary>
/// Defines the ChartSpaceExtension Class.
/// </summary>
public interface IChartSpaceExtension // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// URI
  /// </summary>
  public String? Uri { get ; set; }
  
  public IPivotOptions? PivotOptions { get ; set; }
  
  public ISketchOptions? SketchOptions { get ; set; }
  
  public IPivotSource? PivotSource { get ; set; }
  
}
