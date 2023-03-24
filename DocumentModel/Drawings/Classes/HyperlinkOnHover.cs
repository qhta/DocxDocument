namespace DocumentModel.Drawings;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Defines the HyperlinkOnHover Class.
/// </summary>
public class HyperlinkOnHover: ModelElement
{
  public EmbeddedWavAudioFileType? HyperlinkSound { get; set; }

  public HyperlinkExtensionList? HyperlinkExtensionList { get; set; }
}