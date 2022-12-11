namespace DocumentModel.Drawings;

/// <summary>
/// Defines the HyperlinkOnMouseOver Class.
/// </summary>
public class HyperlinkOnMouseOverImpl: DocumentModel.Drawings.HyperlinkTypeImpl, HyperlinkOnMouseOver
{
  public new DocumentFormat.OpenXml.Drawing.HyperlinkOnMouseOver? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.HyperlinkOnMouseOver?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public HyperlinkOnMouseOverImpl(): base() {}
  
  public HyperlinkOnMouseOverImpl(DocumentFormat.OpenXml.Drawing.HyperlinkOnMouseOver openXmlElement): base(openXmlElement)
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
