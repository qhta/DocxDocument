namespace DocumentModel.Drawings;
/// <summary>
///   Represents a hyperlink action that is triggered when a drawing object is clicked, including optional sound and extension data.
/// </summary>
[OpenXmlType(typeof(DXD.HyperlinkOnClick))]
public partial class HyperlinkOnClick : ModelElement<DXD.HyperlinkOnClick>, IExtendableHyperlinkElement
{
 /// <summary>
 ///   Embedded sound to play when the hyperlink is activated.
 /// </summary>
 [OpenXmlProperty(nameof(DXD.HyperlinkOnClick.HyperlinkSound))]
 public EmbeddedWavAudioFileType? HyperlinkSound { get => _HyperlinkSound; set => UpdateField(ref _HyperlinkSound, value, nameof(HyperlinkSound)); }

 private EmbeddedWavAudioFileType? _HyperlinkSound;
 [OpenXmlProperty(nameof(DXD.HyperlinkOnClick.HyperlinkExtensionList))]
 public HyperlinkExtensionList? HyperlinkExtensionList { get => _HyperlinkExtensionList; set => UpdateField(ref _HyperlinkExtensionList, value, nameof(HyperlinkExtensionList)); }

 private HyperlinkExtensionList? _HyperlinkExtensionList;
}