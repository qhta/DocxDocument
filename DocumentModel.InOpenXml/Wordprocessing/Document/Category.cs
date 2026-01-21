namespace DocumentModel.Wordprocessing;
/// <summary>
/// Represents entry categorization for document parts in a WordprocessingML document.
/// This interface provides properties for the category name and associated gallery, enabling advanced organization and classification of document entries for templates, building blocks, and other reusable content.
/// </summary>
public partial class Category : ModelElement<DXW.Category>
{
  /// <summary>
  /// Name of the category associated with the entry.
  /// </summary>
  public string? Name { get; set; }
  /// <summary>
  /// Gallery associated with the entry, specifying the type of document part gallery.
  /// </summary>
  public DocPartGalleryKind? Gallery { get; set; }
}