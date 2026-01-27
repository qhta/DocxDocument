namespace DocumentModel.Drawings;
/// <summary>
///   Represents a hyperlink action that is triggered when a drawing object is hovered over, including optional sound and extension data.
/// </summary>
[OpenXmlType(typeof(DXD.HyperlinkOnHover))]
public partial class HyperlinkOnHover : ModelElement<DXD.HyperlinkOnHover>, IExtendableHyperlinkElement
{
 /// <summary>
 ///   Embedded sound to play when the hyperlink is activated on hover.
 /// </summary>
 [OpenXmlProperty(nameof(DXD.HyperlinkOnHover.HyperlinkSound))]
 public EmbeddedWavAudioFileType? HyperlinkSound { get => _HyperlinkSound; set => UpdateField(ref _HyperlinkSound, value, nameof(HyperlinkSound)); }

 private EmbeddedWavAudioFileType? _HyperlinkSound;
 [OpenXmlProperty(nameof(DXD.HyperlinkOnHover.HyperlinkExtensionList))]
 public HyperlinkExtensionList? HyperlinkExtensionList { get => _HyperlinkExtensionList; set => UpdateField(ref _HyperlinkExtensionList, value, nameof(HyperlinkExtensionList)); }

 private HyperlinkExtensionList? _HyperlinkExtensionList;
}