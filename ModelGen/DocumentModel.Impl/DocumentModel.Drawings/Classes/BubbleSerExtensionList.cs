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
  
  public BubbleSerExtensionListImpl(): base() {}
  
  public BubbleSerExtensionListImpl(DocumentFormat.OpenXml.Drawing.Charts.BubbleSerExtensionList openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  public Collection<BubbleSerExtension>? BubbleSerExtensions
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
