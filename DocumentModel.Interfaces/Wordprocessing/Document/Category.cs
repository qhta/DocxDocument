namespace DocumentModel.Wordprocessing;

/// <summary>
///   Entry Categorization.
/// </summary>
public class Category: ModelElement
{
  /// <summary>
  ///   Category Associated With Entry.
  /// </summary>
  public string? Name { get; set; }
  /// <summary>
  ///   Gallery Associated With Entry.
  /// </summary>
  public DocPartGalleryKind? Gallery { get; set; }
}