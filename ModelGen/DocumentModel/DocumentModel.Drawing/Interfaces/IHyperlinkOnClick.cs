namespace DocumentModel.Drawing;

/// <summary>
/// Defines the HyperlinkOnClick Class.
/// </summary>
public interface IHyperlinkOnClick // : DocumentModel.Drawing.IHyperlinkType
{
  public DocumentModel.Drawing.IEmbeddedWavAudioFileType? HyperlinkSound { get ; set; }
  
  public DocumentModel.Drawing.IHyperlinkExtensionList? HyperlinkExtensionList { get ; set; }
  
}
