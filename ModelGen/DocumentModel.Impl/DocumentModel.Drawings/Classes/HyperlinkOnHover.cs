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
  
  public override EmbeddedWavAudioFileType? HyperlinkSound
  {
    get;
    set;
  }
  
  public override HyperlinkExtensionList? HyperlinkExtensionList
  {
    get;
    set;
  }
  
}
