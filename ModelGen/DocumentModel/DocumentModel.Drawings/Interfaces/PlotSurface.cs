namespace DocumentModel.Drawings;

/// <summary>
/// Defines the PlotSurface Class.
/// </summary>
public interface PlotSurface
{
  /// <summary>
  /// ShapeProperties.
  /// </summary>
  public ShapeProperties? ShapeProperties { get ; set; }
  
  /// <summary>
  /// ExtensionList.
  /// </summary>
  public ExtensionList? ExtensionList { get ; set; }
  
}
