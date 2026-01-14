namespace DocumentModel.Wordprocessing;

  /// <summary>
  /// Represents a footnote, endnote, or annotation reference in a text run in WordprocessingML documents.
  /// A note reference is a run of automatically numbered text referencing a specific footnote, endnote, or annotation within the parent document, inheriting the reference mark numbering. Note references within a footnote or endnote are non-conformant.
  /// </summary>
  public interface NoteReference : RunContent
  {
    
    /// <summary>
    /// Specifies which interface (footnote, endnote, or annotation) is the target of this reference.
    /// </summary>
    public NoteReferenceKind Kind { get; set; }
    
    /// <summary>
    /// Indicates whether the footnote or endnote reference mark is suppressed, allowing for custom marks to follow.
    /// </summary>
    public bool? CustomMarkFollows { get; set; }
    
    /// <summary>
    /// Identifier of the referenced footnote, endnote, or annotation.
    /// </summary>
    public long? Id { get; set; }
  }