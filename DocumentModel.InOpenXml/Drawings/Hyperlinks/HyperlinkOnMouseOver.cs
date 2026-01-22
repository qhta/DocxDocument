namespace DocumentModel.Drawings;
/// <summary>
///   Represents a hyperlink action that is triggered when a drawing object is hovered over with the mouse, including optional sound data.
/// </summary>
public partial class HyperlinkOnMouseOver : ModelElement<DXD.HyperlinkOnMouseOver>, IExtendableHyperlinkElement
{
    /// <summary>
    ///   Embedded sound to play when the hyperlink is activated on mouse over.
    /// </summary>
    public EmbeddedWavAudioFileType? HyperlinkSound { get => _HyperlinkSound; set => UpdateField(ref _HyperlinkSound, value, nameof(HyperlinkSound)); }

    private EmbeddedWavAudioFileType? _HyperlinkSound;
    public HyperlinkExtensionList? HyperlinkExtensionList { get; set; }
}