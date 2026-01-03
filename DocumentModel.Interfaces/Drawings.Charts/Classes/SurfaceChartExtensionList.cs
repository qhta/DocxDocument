namespace DocumentModel.Drawings.Charts;

/// <summary>
///   Defines the SurfaceChartExtensionList Class.
/// </summary>
public interface SurfaceChartExtensionList: IModelElement
{
  public Collection<SurfaceChartExtension>? SurfaceChartExtensions { get; set; }
}