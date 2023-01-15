namespace DocumentModel.Wordprocessing;

/// <summary>
///   Entry Categorization.
/// </summary>
public class Category
{
  /// <summary>
  ///   Category Associated With Entry.
  /// </summary>
  public String? Name { get; set; }

  /// <summary>
  ///   Gallery Associated With Entry.
  /// </summary>
  public DocPartGalleryKind? Gallery { get; set; }
}