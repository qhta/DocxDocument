namespace DocumentModel.Drawings;

/// <summary>
///   Future extensions..
/// </summary>
public interface HyperlinkExtensionList: IModelElement
{
  public Collection<HyperlinkExtension>? HyperlinkExtensions { get; set; }
}