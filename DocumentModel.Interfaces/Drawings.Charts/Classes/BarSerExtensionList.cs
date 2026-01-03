namespace DocumentModel.Drawings.Charts;

/// <summary>
///   Defines the BarSerExtensionList Class.
/// </summary>
public interface BarSerExtensionList: IModelElement
{
  public Collection<BarSerExtension>? BarSerExtensions { get; set; }
}