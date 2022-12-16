namespace DocumentModel.Drawings.Charts;

/// <summary>
/// Defines the ChartSpaceExtension Class.
/// </summary>
public interface ChartSpaceExtension
{
  /// <summary>
  /// URI
  /// </summary>
  public String? Uri { get ; set; }
  
  public DocumentModel.Drawings.Charts.PivotOptions? PivotOptions { get ; set; }
  
  public DocumentModel.Drawings.Charts.SketchOptions? SketchOptions { get ; set; }
  
  public DocumentModel.Drawings.Charts.PivotSource3? PivotSource { get ; set; }
  
}
