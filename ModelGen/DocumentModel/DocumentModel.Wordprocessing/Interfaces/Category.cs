namespace DocumentModel.Wordprocessing;

/// <summary>
/// Entry Categorization.
/// </summary>
public interface Category
{
  /// <summary>
  /// Category Associated With Entry.
  /// </summary>
  public String? Name { get ; set; }
  
  /// <summary>
  /// Gallery Associated With Entry.
  /// </summary>
  public DocumentModel.Wordprocessing.DocPartGalleryKind? Gallery { get ; set; }
  
}
