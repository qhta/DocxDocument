namespace DocumentModel.Wordprocessing;

/// <summary>
///   Entry Categorization.
/// </summary>
public interface Category:
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