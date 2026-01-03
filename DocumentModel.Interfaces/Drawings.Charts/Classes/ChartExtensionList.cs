namespace DocumentModel.Drawings.Charts;

/// <summary>
///   Extensibility container.
/// </summary>
public interface ChartExtensionList: IModelElement
{
  public Collection<DataDisplayOptions16>? DataDisplayOptions16s { get; set; }
}