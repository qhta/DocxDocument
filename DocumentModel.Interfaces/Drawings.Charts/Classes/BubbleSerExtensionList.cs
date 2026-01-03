namespace DocumentModel.Drawings.Charts;

/// <summary>
///   Defines the BubbleSerExtensionList Class.
/// </summary>
public interface BubbleSerExtensionList: IModelElement
{
  public Collection<BubbleSerExtension>? BubbleSerExtensions { get; set; }
}