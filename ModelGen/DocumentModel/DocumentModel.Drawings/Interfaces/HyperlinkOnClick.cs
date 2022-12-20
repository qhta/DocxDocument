namespace DocumentModel.Drawings;

/// <summary>
/// Defines the HyperlinkOnClick Class.
/// </summary>
public partial interface HyperlinkOnClick
{
  public DocumentModel.Drawings.EmbeddedWavAudioFileType? HyperlinkSound { get; set; }
  
  public DocumentModel.Drawings.HyperlinkExtensionList? HyperlinkExtensionList { get; set; }
  
}
