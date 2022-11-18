namespace DocumentModel.Presentation;

/// <summary>
/// List of View Types
/// </summary>
public enum View
{
  /// <summary>
  /// Normal Slide View.
  /// </summary>
  [XmlEnum("sldView")]
  SlideView,
  
  /// <summary>
  /// Slide Master View.
  /// </summary>
  [XmlEnum("sldMasterView")]
  SlideMasterView,
  
  /// <summary>
  /// Notes View.
  /// </summary>
  [XmlEnum("notesView")]
  NotesView,
  
  /// <summary>
  /// Handout View.
  /// </summary>
  [XmlEnum("handoutView")]
  HandoutView,
  
  /// <summary>
  /// Notes Master View.
  /// </summary>
  [XmlEnum("notesMasterView")]
  NotesMasterView,
  
  /// <summary>
  /// Outline View.
  /// </summary>
  [XmlEnum("outlineView")]
  OutlineView,
  
  /// <summary>
  /// Slide Sorter View.
  /// </summary>
  [XmlEnum("sldSorterView")]
  SlideSorterView,
  
  /// <summary>
  /// Slide Thumbnail View.
  /// </summary>
  [XmlEnum("sldThumbnailView")]
  SlideThumbnailView,
  
}
