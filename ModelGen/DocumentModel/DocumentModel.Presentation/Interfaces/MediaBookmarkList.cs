namespace DocumentModel.Presentation;

/// <summary>
/// Defines the MediaBookmarkList Class.
/// </summary>
public interface MediaBookmarkList // : DocumentModel.BaseTypes.ModelElement
{
  public Collection<MediaBookmark>? MediaBookmarks { get ; set; }
  
}
