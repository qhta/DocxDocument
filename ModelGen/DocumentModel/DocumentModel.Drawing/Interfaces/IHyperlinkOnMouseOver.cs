namespace DocumentModel.Drawing;

/// <summary>
/// Defines the HyperlinkOnMouseOver Class.
/// </summary>
public interface IHyperlinkOnMouseOver // : DocumentModel.Drawing.IHyperlinkType
{
  public DocumentModel.Drawing.IEmbeddedWavAudioFileType? HyperlinkSound { get ; set; }
  
  public DocumentModel.Drawing.IHyperlinkExtensionList? HyperlinkExtensionList { get ; set; }
  
}
