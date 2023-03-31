namespace DocumentModel.Wordprocessing;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Represents a position of an endnote, footnote or annotation reference mark. 
///   A footnote/endnote reference mark is a run of automatically numbered text which follows the numbering format 
///   set forth via the footnote/endnote numFmt element.
///   If a reference mark is specified within a run which is not part of an endnote, footnote or annotation, 
///   then that reference mark can be ignored.
/// </summary>
public class NoteReferenceMark : ModelElement, IRunElement
{
  /// <summary>
  /// Annotation, endnote or footnote.
  /// </summary>
   public NoteReferenceKind? Type { get; set;}

}