namespace DocumentModel.Drawings.Charts;

/// <summary>
///   Defines the PieChartExtensionList Class.
/// </summary>
public interface PieChartExtensionList: IModelElement
{
  public Collection<PieChartExtension>? PieChartExtensions { get; set; }
}