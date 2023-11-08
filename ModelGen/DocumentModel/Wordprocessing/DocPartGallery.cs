namespace DocumentModel.Wordprocessing;


/// <summary>
///   This element specifies the gallery of document parts that shall be used as the filter when determining the possible choices of document parts that are displayed for insertion into the nearest ancestor structured document tag. A document part gallery is a classification of document parts, which might then be subdivided into categories.. The gallery which shall be used is stored in this element's val attribute.
/// </summary>
public partial class DocPartGallery: ModelElement<DXW.DocPartGallery>
{
  public DocPartGallery(): base(){ }
  
  public DocPartGallery(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public DocPartGallery(DXW.DocPartGallery openXmlElement): base(openXmlElement) { }
  
}
