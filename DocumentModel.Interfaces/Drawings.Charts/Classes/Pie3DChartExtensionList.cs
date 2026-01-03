namespace DocumentModel.Drawings.Charts;

/// <summary>
///   Defines the Pie3DChartExtensionList Class.
/// </summary>
public interface Pie3DChartExtensionList: IModelElement
{
  public Collection<Pie3DChartExtension>? Pie3DChartExtensions { get; set; }
}