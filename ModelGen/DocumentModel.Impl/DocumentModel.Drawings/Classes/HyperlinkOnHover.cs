namespace DocumentModel.Drawings;

/// <summary>
/// Defines the HyperlinkOnHover Class.
/// </summary>
public class HyperlinkOnHoverImpl: DocumentModel.Drawings.HyperlinkTypeImpl, HyperlinkOnHover
{
  public new DocumentFormat.OpenXml.Drawing.HyperlinkOnHover? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.HyperlinkOnHover?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public HyperlinkOnHoverImpl(): base() {}
  
  public HyperlinkOnHoverImpl(DocumentFormat.OpenXml.Drawing.HyperlinkOnHover openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  public new DocumentModel.Drawings.EmbeddedWavAudioFileType? HyperlinkSound
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public new DocumentModel.Drawings.HyperlinkExtensionList? HyperlinkExtensionList
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
