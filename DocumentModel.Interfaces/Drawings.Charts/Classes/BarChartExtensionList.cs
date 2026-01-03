namespace DocumentModel.Drawings.Charts;

/// <summary>
///   Defines the BarChartExtensionList Class.
/// </summary>
public interface BarChartExtensionList: IModelElement
{
  public Collection<BarChartExtension>? BarChartExtensions { get; set; }
}