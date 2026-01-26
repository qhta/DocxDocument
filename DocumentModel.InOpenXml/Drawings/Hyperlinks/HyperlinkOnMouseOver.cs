namespace DocumentModel.Drawings;
/// <summary>
///   Represents a hyperlink action that is triggered when a drawing object is hovered over with the mouse, including optional sound data.
/// </summary>
[OpenXmlType(typeof(DXD.HyperlinkOnMouseOver))]
public partial class HyperlinkOnMouseOver : ModelElement<DXD.HyperlinkOnMouseOver>, IExtendableHyperlinkElement
{
 /// <summary>
 ///   Embedded sound to play when the hyperlink is activated on mouse over.
 /// </summary>
 [OpenXmlProperty(nameof(DXD.HyperlinkOnMouseOver.HyperlinkSound))]
 [OpenXmlElement(typeof(DXD.HyperlinkOnMouseOver))]
 public EmbeddedWavAudioFileType? HyperlinkSound { get => _HyperlinkSound; set => UpdateField(ref _HyperlinkSound, value, nameof(HyperlinkSound)); }

 private EmbeddedWavAudioFileType? _HyperlinkSound;
 [OpenXmlProperty(nameof(DXD.HyperlinkOnMouseOver.HyperlinkExtensionList))]
 [OpenXmlElement(typeof(DXD.HyperlinkOnMouseOver))]
 public HyperlinkExtensionList? HyperlinkExtensionList { get => _HyperlinkExtensionList; set => UpdateField(ref _HyperlinkExtensionList, value, nameof(HyperlinkExtensionList)); }

 private HyperlinkExtensionList? _HyperlinkExtensionList;
}