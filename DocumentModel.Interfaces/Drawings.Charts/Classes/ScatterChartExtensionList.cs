namespace DocumentModel.Drawings.Charts;

/// <summary>
///   Defines the ScatterChartExtensionList Class.
/// </summary>
public interface ScatterChartExtensionList: IModelElement
{
  public Collection<ScatterChartExtension>? ScatterChartExtensions { get; set; }
}