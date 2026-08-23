namespace DocumentModel.Drawings;

/// <summary>
///   Represents a hyperlink action in DrawingML that is triggered when a drawing object is hovered over, supporting optional embedded sound and extension data.
///   Enables interactive behaviors and multimedia feedback for shapes and images in Office documents when the mouse pointer is over the object.
/// </summary>
[OpenXmlType(typeof(DXD.HyperlinkOnHover))]
[DataContract]
[XmlRoot("HyperlinkOnHover", Namespace = "DocumentModel.Drawings")]
public partial class HyperlinkOnHover : ModelElement<DXD.HyperlinkOnHover>, IExtendableHyperlinkElement
{
  /// <summary>
  ///   Embedded sound to play when the hyperlink is activated on hover, providing audio feedback for interactive elements.
  /// </summary>
  [OpenXmlProperty(nameof(DXD.HyperlinkOnHover.HyperlinkSound))]
  public EmbeddedWavAudioFileType? HyperlinkSound
  {
    get => _HyperlinkSound ??= GetProperty<EmbeddedWavAudioFileType?>(GetUpdatableElement()?.HyperlinkSound);
    set => UpdateField(ref _HyperlinkSound, value, nameof(HyperlinkSound));
  }
  private EmbeddedWavAudioFileType? _HyperlinkSound;

  /// <summary>
  ///   List of extension elements for the hover hyperlink, supporting extensibility and application-specific hyperlink data.
  /// </summary>
  [OpenXmlProperty(nameof(DXD.HyperlinkOnHover.HyperlinkExtensionList))]
  public HyperlinkExtensionList? HyperlinkExtensionList
  {
    get => _HyperlinkExtensionList ??=
      GetProperty<HyperlinkExtensionList?>(GetUpdatableElement()?.HyperlinkExtensionList);
    set => UpdateField(ref _HyperlinkExtensionList, value, nameof(HyperlinkExtensionList));
  }
  private HyperlinkExtensionList? _HyperlinkExtensionList;
}