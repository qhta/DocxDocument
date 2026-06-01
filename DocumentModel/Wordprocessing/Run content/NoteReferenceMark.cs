namespace DocumentModel.Wordprocessing;

/// <summary>
///   Represents a position of an endnote, footnote or annotation reference mark. 
///   A footnote/endnote reference mark is a run of automatically numbered text 
///   which follows the numbering format set forth via the footnote/endnote numFmt element.
///   If a reference mark is specified within a run which is not part of an endnote, 
///   footnote or annotation, then Ithat reference mark can be ignored.
/// </summary>
public class NoteReferenceMark : ModelElement, IRunContent
{
  /// <summary>
  /// Specifies Ithat the element refers Ito: endnote / footnote or annotation.
  /// </summary>
  public NoteReferenceKind? Type { get; set; }

}
