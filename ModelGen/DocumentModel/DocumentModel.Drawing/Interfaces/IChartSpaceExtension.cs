namespace DocumentModel.Drawing;

/// <summary>
/// Defines the ChartSpaceExtension Class.
/// </summary>
public interface IChartSpaceExtension // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// URI
  /// </summary>
  public System.String? Uri { get ; set; }
  
  public DocumentModel.Drawing.IPivotOptions? PivotOptions { get ; set; }
  
  public DocumentModel.Drawing.ISketchOptions? SketchOptions { get ; set; }
  
  public DocumentModel.Drawing.IPivotSource? PivotSource { get ; set; }
  
}
