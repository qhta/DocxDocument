namespace DocumentModel.Drawings;
/// <summary>
/// Represents audio sourced from a file, including a linked relationship ID and optional extension data.
/// </summary>
public partial class AudioFromFile : ModelElement<DXD.AudioFromFile>, IExtendableElement
{
    /// <summary>
    /// Linked relationship ID that references the audio file.
    /// </summary>
    public string? Link { get => _Link; set => UpdateField(ref _Link, value, nameof(Link)); }

    private string? _Link;
    public ExtensionList? ExtensionList { get => _ExtensionList; set => UpdateField(ref _ExtensionList, value, nameof(ExtensionList)); }

    private ExtensionList? _ExtensionList;
}