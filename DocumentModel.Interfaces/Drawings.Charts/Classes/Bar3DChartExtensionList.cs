namespace DocumentModel.Drawings.Charts;

/// <summary>
///   Defines the Bar3DChartExtensionList Class.
/// </summary>
public interface Bar3DChartExtensionList: IModelElement
{
  public Collection<Bar3DChartExtension>? Bar3DChartExtensions { get; set; }
}