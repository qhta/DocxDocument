namespace DocumentModel.Drawings;

/// <summary>
/// Defines the HyperlinkOnHover Class.
/// </summary>
public interface HyperlinkOnHover // : DocumentModel.Drawings.HyperlinkType
{
  public EmbeddedWavAudioFileType? HyperlinkSound { get ; set; }
  
  public HyperlinkExtensionList? HyperlinkExtensionList { get ; set; }
  
}
