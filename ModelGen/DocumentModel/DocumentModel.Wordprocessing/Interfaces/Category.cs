namespace DocumentModel.Wordprocessing;

/// <summary>
/// Entry Categorization.
/// </summary>
public interface Category
{
  /// <summary>
  /// Gallery Associated With Entry.
  /// </summary>
  public DocPartGalleryKind? Gallery { get ; set; }
  
}
