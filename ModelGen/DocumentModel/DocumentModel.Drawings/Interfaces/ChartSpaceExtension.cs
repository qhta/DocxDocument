namespace DocumentModel.Drawings;

/// <summary>
/// Defines the ChartSpaceExtension Class.
/// </summary>
public interface ChartSpaceExtension
{
  /// <summary>
  /// URI
  /// </summary>
  public String? Uri { get ; set; }
  
  public PivotOptions? PivotOptions { get ; set; }
  
  public SketchOptions? SketchOptions { get ; set; }
  
  public PivotSource? PivotSource { get ; set; }
  
}
