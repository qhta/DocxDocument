namespace DocumentModel.Drawings.Charts;

/// <summary>
///   Defines the AreaChartExtensionList Class.
/// </summary>
public interface AreaChartExtensionList: IModelElement
{
  public Collection<AreaChartExtension>? AreaChartExtensions { get; set; }
}