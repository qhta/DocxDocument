namespace DocumentModel.Drawings.Charts;

/// <summary>
///   Defines the Area3DChartExtensionList Class.
/// </summary>
public interface Area3DChartExtensionList: IModelElement
{
  public Collection<Area3DChartExtension>? Area3DChartExtensions { get; set; }
}