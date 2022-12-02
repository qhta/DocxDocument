namespace DocumentModel.Drawing;

/// <summary>
/// Defines the HyperlinkOnClick Class.
/// </summary>
public interface IHyperlinkOnClick // : DocumentModel.Drawing.IHyperlinkType
{
  public IEmbeddedWavAudioFileType? HyperlinkSound { get ; set; }
  
  public IHyperlinkExtensionList? HyperlinkExtensionList { get ; set; }
  
}
