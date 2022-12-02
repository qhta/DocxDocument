namespace DocumentModel.Presentation;

/// <summary>
/// Defines the MediaBookmarkList Class.
/// </summary>
public interface IMediaBookmarkList // : DocumentModel.ITypedOpenXmlCompositeElement
{
  public Collection<IMediaBookmark>? MediaBookmarks { get ; set; }
  
}
