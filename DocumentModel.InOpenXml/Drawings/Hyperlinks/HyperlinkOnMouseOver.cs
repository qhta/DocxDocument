namespace DocumentModel.Drawings;
/// <summary>
///   Represents a hyperlink action in DrawingML that is triggered when a drawing object is hovered over with the mouse, supporting optional embedded sound and extension data.
///   Enables interactive behaviors and multimedia feedback for shapes and images in Office documents.
/// </summary>
[OpenXmlType(typeof(DXD.HyperlinkOnMouseOver))]
public partial class HyperlinkOnMouseOver : ModelElement<DXD.HyperlinkOnMouseOver>, IExtendableHyperlinkElement
{
  /// <summary>
  ///   Embedded sound to play when the hyperlink is activated on mouse over, providing audio feedback for interactive elements.
  /// </summary>
  [OpenXmlProperty(nameof(DXD.HyperlinkOnMouseOver.HyperlinkSound))]
  public EmbeddedWavAudioFileType? HyperlinkSound { get => _HyperlinkSound; set => UpdateField(ref _HyperlinkSound, value, nameof(HyperlinkSound)); }

  private EmbeddedWavAudioFileType? _HyperlinkSound;

  /// <summary>
  ///   List of extension elements for the mouse-over hyperlink, supporting extensibility and application-specific hyperlink data.
  /// </summary>
  [OpenXmlProperty(nameof(DXD.HyperlinkOnMouseOver.HyperlinkExtensionList))]
  public HyperlinkExtensionList? HyperlinkExtensionList { get => _HyperlinkExtensionList; set => UpdateField(ref _HyperlinkExtensionList, value, nameof(HyperlinkExtensionList)); }

  private HyperlinkExtensionList? _HyperlinkExtensionList;
}
