namespace DocumentModel.Drawings;

/// <summary>
/// Defines the PlotSurface Class.
/// </summary>
public interface PlotSurface
{
  /// <summary>
  /// ShapeProperties.
  /// </summary>
  public ShapeProperties6? ShapeProperties { get ; set; }
  
  /// <summary>
  /// ExtensionList.
  /// </summary>
  public ExtensionList2? ExtensionList { get ; set; }
  
}
