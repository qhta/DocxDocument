namespace DocumentModel.Drawings;
/// <summary>
///   Represents a video sourced from a file, including a reference to the linked relationship.
/// </summary>
public partial class VideoFromFile : ModelElement<DXD.VideoFromFile>, IExtendableElement
{
    /// <summary>
    ///   Relationship ID that links to the video file.
    /// </summary>
    [OpenXmlProperty(nameof(DXD.VideoFromFile.Link))]
    public string? Link { get => _Link; set => UpdateField(ref _Link, value, nameof(Link)); }

    private string? _Link;
    /// <summary>
    /// List of extension elements.
    /// </summary>
    [OpenXmlProperty(nameof(DXD.VideoFromFile.ExtensionList))]
    public ExtensionList? ExtensionList { get => _ExtensionList; set => UpdateField(ref _ExtensionList, value, nameof(ExtensionList)); }

    private ExtensionList? _ExtensionList;
}