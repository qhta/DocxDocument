namespace DocumentModel.Wordprocessing;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///  Represents a footnote, endnote or annotation reference. 
///  A footnote/endnote reference is a run of automatically numbered text which references a particular footnote/endnote within the parent document, 
///  and inherits the footnote/endnote reference mark's numbering.
///  If an footnote/endnote reference is specified within a footnote or endnote, then the document shall be considered non-conformant.
/// </summary>
public class NoteReference: ModelElement, IRunContent
{
  /// <summary>
  /// Specifies, what class is a target of this reference.
  /// </summary>
   public NoteReferenceKind Kind { get; set; }

  /// <summary>
  ///   Suppress Footnote/Endnote Reference Mark
  /// </summary>
  public Boolean? CustomMarkFollows { get; set; }

  /// <summary>
  ///   Footnote/Endnote ID Reference
  /// </summary>
  public Int64? Id { get; set; }
}