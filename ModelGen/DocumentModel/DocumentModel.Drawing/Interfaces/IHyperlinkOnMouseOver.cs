namespace DocumentModel.Drawing;

/// <summary>
/// Defines the HyperlinkOnMouseOver Class.
/// </summary>
public interface IHyperlinkOnMouseOver // : DocumentModel.Drawing.IHyperlinkType
{
  public IEmbeddedWavAudioFileType? HyperlinkSound { get ; set; }
  
  public IHyperlinkExtensionList? HyperlinkExtensionList { get ; set; }
  
}
