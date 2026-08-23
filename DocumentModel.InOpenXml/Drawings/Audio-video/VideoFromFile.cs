namespace DocumentModel.Drawings;

/// <summary>
///   Represents a video sourced from a file, including a reference to the linked relationship.
/// </summary>
[OpenXmlType(typeof(DXD.VideoFromFile))]
[DataContract]
[XmlRoot("VideoFromFile", Namespace = "DocumentModel.Drawings")]
public partial class VideoFromFile: ModelElement<DXD.VideoFromFile>, IExtendableElement
{
  /// <summary>
  ///   Relationship ID that links to the video file.
  /// </summary>
  [OpenXmlProperty(nameof(DXD.VideoFromFile.Link))]
  public string? Link
  {
    get => _Link ??= GetProperty<string?>(GetUpdatableElement()?.Link);
    set => UpdateField(ref _Link, value, nameof(Link));
  }

  private string? _Link;

  /// <summary>
  /// List of extension elements.
  /// </summary>
  [OpenXmlProperty(nameof(DXD.VideoFromFile.ExtensionList))]
  public ExtensionList? ExtensionList
  {
    get => _ExtensionList ??= GetProperty<ExtensionList?>(GetUpdatableElement()?.ExtensionList);
    set => UpdateField(ref _ExtensionList, value, nameof(ExtensionList));
  }

  private ExtensionList? _ExtensionList;
}