namespace DocumentModel.Drawings;

/// <summary>
/// Defines the BubbleSerExtensionList Class.
/// </summary>
public class BubbleSerExtensionListImpl: ModelElementImpl, BubbleSerExtensionList
{
  public DocumentFormat.OpenXml.Drawing.Charts.BubbleSerExtensionList? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.Charts.BubbleSerExtensionList?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public Collection<BubbleSerExtension>? BubbleSerExtensions
  {
    get;
    set;
  }
  
}
