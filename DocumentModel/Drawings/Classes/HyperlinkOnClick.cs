namespace DocumentModel.Drawings;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Defines the HyperlinkOnClick Class.
/// </summary>
public class HyperlinkOnClick: ModelElement
{
  public EmbeddedWavAudioFileType? HyperlinkSound { get; set; }

  public HyperlinkExtensionList? HyperlinkExtensionList { get; set; }
}