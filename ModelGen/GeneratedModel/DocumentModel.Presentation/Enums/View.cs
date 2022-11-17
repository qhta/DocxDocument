namespace DocumentModel.Presentation;

public enum View
{

  [XmlEnum("sldView")]
  SlideView,

  [XmlEnum("sldMasterView")]
  SlideMasterView,

  [XmlEnum("notesView")]
  NotesView,

  [XmlEnum("handoutView")]
  HandoutView,

  [XmlEnum("notesMasterView")]
  NotesMasterView,

  [XmlEnum("outlineView")]
  OutlineView,

  [XmlEnum("sldSorterView")]
  SlideSorterView,

  [XmlEnum("sldThumbnailView")]
  SlideThumbnailView,
}
