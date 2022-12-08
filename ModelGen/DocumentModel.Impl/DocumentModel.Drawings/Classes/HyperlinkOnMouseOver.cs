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
