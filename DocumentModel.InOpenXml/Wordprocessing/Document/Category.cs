namespace DocumentModel.Wordprocessing;
/// <summary>
/// Represents entry categorization for document parts in a WordprocessingML document.
/// This class provides properties for the category name and associated gallery, enabling advanced organization and classification of document entries for templates, building blocks, and other reusable content.
/// </summary>
public partial class Category : ModelElement<DXW.Category>
{
    /// <summary>
    /// Name of the category associated with the entry.
    /// </summary>
    public string? Name { get => _Name; set => UpdateField(ref _Name, value, nameof(Name)); }

    private string? _Name;
    /// <summary>
    /// Gallery associated with the entry, specifying the type of document part gallery.
    /// </summary>
    public DocPartGalleryKind? Gallery { get => _Gallery; set => UpdateField(ref _Gallery, value, nameof(Gallery)); }

    private DocPartGalleryKind? _Gallery;
}