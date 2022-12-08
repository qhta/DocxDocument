namespace DocumentModel.Drawings;

/// <summary>
/// Defines the HyperlinkOnHover Class.
/// </summary>
public interface HyperlinkOnHover
{
  public EmbeddedWavAudioFileType? HyperlinkSound { get ; set; }
  
  public HyperlinkExtensionList? HyperlinkExtensionList { get ; set; }
  
}
