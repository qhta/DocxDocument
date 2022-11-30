namespace DocumentModel.Drawing;

/// <summary>
/// Defines the HyperlinkOnHover Class.
/// </summary>
public interface IHyperlinkOnHover // : DocumentModel.Drawing.IHyperlinkType
{
  public DocumentModel.Drawing.IEmbeddedWavAudioFileType? HyperlinkSound { get ; set; }
  
  public DocumentModel.Drawing.IHyperlinkExtensionList? HyperlinkExtensionList { get ; set; }
  
}
