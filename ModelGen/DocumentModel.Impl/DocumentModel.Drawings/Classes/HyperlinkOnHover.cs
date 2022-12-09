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
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public override HyperlinkExtensionList? HyperlinkExtensionList
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
