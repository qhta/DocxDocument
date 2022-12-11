namespace DocumentModel.Drawings;

/// <summary>
/// Defines the HyperlinkOnClick Class.
/// </summary>
public class HyperlinkOnClickImpl: DocumentModel.Drawings.HyperlinkTypeImpl, HyperlinkOnClick
{
  public new DocumentFormat.OpenXml.Drawing.HyperlinkOnClick? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.HyperlinkOnClick?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public HyperlinkOnClickImpl(): base() {}
  
  public HyperlinkOnClickImpl(DocumentFormat.OpenXml.Drawing.HyperlinkOnClick openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  public new EmbeddedWavAudioFileType? HyperlinkSound
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public new HyperlinkExtensionList? HyperlinkExtensionList
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
