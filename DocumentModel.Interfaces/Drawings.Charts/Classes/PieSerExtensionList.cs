namespace DocumentModel.Drawings.Charts;

/// <summary>
///   Defines the PieSerExtensionList Class.
/// </summary>
public interface PieSerExtensionList: IModelElement
{
  public Collection<PieSerExtension>? PieSerExtensions { get; set; }
}