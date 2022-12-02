namespace DocumentModel.Drawing;

/// <summary>
/// Defines the HyperlinkOnHover Class.
/// </summary>
public interface IHyperlinkOnHover // : DocumentModel.Drawing.IHyperlinkType
{
  public IEmbeddedWavAudioFileType? HyperlinkSound { get ; set; }
  
  public IHyperlinkExtensionList? HyperlinkExtensionList { get ; set; }
  
}
