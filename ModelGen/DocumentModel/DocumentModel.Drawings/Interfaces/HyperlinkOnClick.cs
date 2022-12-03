namespace DocumentModel.Drawings;

/// <summary>
/// Defines the HyperlinkOnClick Class.
/// </summary>
public interface HyperlinkOnClick // : DocumentModel.Drawings.HyperlinkType
{
  public EmbeddedWavAudioFileType? HyperlinkSound { get ; set; }
  
  public HyperlinkExtensionList? HyperlinkExtensionList { get ; set; }
  
}
