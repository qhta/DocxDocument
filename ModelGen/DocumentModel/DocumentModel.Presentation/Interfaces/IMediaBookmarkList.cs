namespace DocumentModel.Presentation;

/// <summary>
/// Defines the MediaBookmarkList Class.
/// </summary>
public interface IMediaBookmarkList // : DocumentModel.ITypedOpenXmlCompositeElement
{
  public System.Collections.ObjectModel.Collection<DocumentModel.Presentation.IMediaBookmark>? MediaBookmarks { get ; set; }
  
}
