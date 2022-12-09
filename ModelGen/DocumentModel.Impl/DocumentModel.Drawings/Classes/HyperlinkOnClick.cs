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
