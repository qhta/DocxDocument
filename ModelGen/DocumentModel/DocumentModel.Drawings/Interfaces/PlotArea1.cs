namespace DocumentModel.Drawings;

/// <summary>
/// Defines the PlotArea Class.
/// </summary>
public interface PlotArea1
{
  /// <summary>
  /// PlotAreaRegion.
  /// </summary>
  public PlotAreaRegion? PlotAreaRegion { get ; set; }
  
  public Collection<Axis>? Axises { get ; set; }
  
  public ShapeProperties8? ShapeProperties { get ; set; }
  
  public ExtensionList2? ExtensionList { get ; set; }
  
}
