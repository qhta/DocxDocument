namespace DocumentModel.Drawings;

/// <summary>
/// Defines the HyperlinkOnMouseOver Class.
/// </summary>
public interface HyperlinkOnMouseOver
{
  public DocumentModel.Drawings.EmbeddedWavAudioFileType? HyperlinkSound { get ; set; }
  
  public DocumentModel.Drawings.HyperlinkExtensionList? HyperlinkExtensionList { get ; set; }
  
}
