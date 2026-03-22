namespace DocumentModel.Drawings;
/// <summary>
///   Represents a hyperlink action in DrawingML that is triggered when a drawing object is clicked, supporting optional embedded sound and extension data.
///   Enables interactive behaviors and multimedia feedback for shapes and images in Office documents when the object is clicked.
/// </summary>
[OpenXmlType(typeof(DXD.HyperlinkOnClick))]
public partial class HyperlinkOnClick : ModelElement<DXD.HyperlinkOnClick>, IExtendableHyperlinkElement
{
  /// <summary>
  ///   Embedded sound to play when the hyperlink is activated by a click, providing audio feedback for interactive elements.
  /// </summary>
  [OpenXmlProperty(nameof(DXD.HyperlinkOnClick.HyperlinkSound))]
  public EmbeddedWavAudioFileType? HyperlinkSound { get => _HyperlinkSound; set => UpdateField(ref _HyperlinkSound, value, nameof(HyperlinkSound)); }
  private EmbeddedWavAudioFileType? _HyperlinkSound;
  /// <summary>
  ///   List of extension elements for the click hyperlink, supporting extensibility and application-specific hyperlink data.
  /// </summary>
  [OpenXmlProperty(nameof(DXD.HyperlinkOnClick.HyperlinkExtensionList))]
  public HyperlinkExtensionList? HyperlinkExtensionList { get => _HyperlinkExtensionList; set => UpdateField(ref _HyperlinkExtensionList, value, nameof(HyperlinkExtensionList)); }
  private HyperlinkExtensionList? _HyperlinkExtensionList;
}
