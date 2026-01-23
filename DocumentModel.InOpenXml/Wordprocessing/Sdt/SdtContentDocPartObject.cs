namespace DocumentModel.Wordprocessing;
/// <summary>
/// Represents the configuration for a document part object content control in a structured document tag (SDT) in a Wordprocessing document.
/// This class provides properties for filtering document parts by gallery and category, and for indicating built-in document parts, enabling advanced customization and management of document part selection in SDTs.
/// </summary>
public partial class SdtContentDocPartObject : ModelElement<DXW.SdtContentDocPartObject>
{
    /// <summary>
    /// Document part gallery filter, specifying the gallery to filter document parts.
    /// </summary>
    public string? DocPartGallery { get => _DocPartGallery; set => UpdateField(ref _DocPartGallery, value, nameof(DocPartGallery)); }

    private string? _DocPartGallery;
    /// <summary>
    /// Document part category filter, specifying the category to filter document parts.
    /// </summary>
    public string? DocPartCategory { get; set; }
    /// <summary>
    /// Indicates whether the document part is built-in and unique.
    /// </summary>
    public bool? DocPartUnique { get; set; }
}