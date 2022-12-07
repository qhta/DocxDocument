namespace DocumentModel.Drawings;

/// <summary>
/// Defines the ChartSpaceExtension Class.
/// </summary>
public interface ChartSpaceExtension
{
  public PivotOptions? PivotOptions { get ; set; }
  
  public SketchOptions? SketchOptions { get ; set; }
  
  public PivotSource2? PivotSource { get ; set; }
  
}
