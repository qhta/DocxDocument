namespace DocumentModel.Office2010.PowerPoint;

/// <summary>
/// Defines the MediaBookmarkList Class.
/// </summary>
public interface IMediaBookmarkList // : DocumentModel.ITypedOpenXmlCompositeElement
{
  public System.Collections.ObjectModel.Collection<DocumentModel.Office2010.PowerPoint.IMediaBookmark>? MediaBookmarks { get ; set; }
  
}
