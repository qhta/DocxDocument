namespace DocumentModel.Drawings.Charts;

/// <summary>
///   Defines the Surface3DChartExtensionList Class.
/// </summary>
public interface Surface3DChartExtensionList: IModelElement
{
  public Collection<Surface3DChartExtension>? Surface3DChartExtensions { get; set; }
}