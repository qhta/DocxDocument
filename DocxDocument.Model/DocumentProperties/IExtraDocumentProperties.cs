namespace DocxDocument.Model;

public interface IExtraDocumentProperties
{
  /// <summary> 
  /// A LongHexNumber element that specifies an arbitrary identifier for the context of the paragraph identifiers in the document.
  /// Values MUST be greater than 0 and less than 0x80000000.
  ///</summary> 
  public HexInt? DocumentId { get; set; }

  /// <summary> 
  /// Specifies a unique identifier for a set of documents derived from a common source.
  ///</summary> 
  public Guid? PersistentDocumentId { get; set; }

  /// <summary> 
  /// When true, specifies that the user was resolving conflicting edits when the document was saved.
  ///</summary> 
  public bool? ConflictMode { get; set; }

  /// <summary>
  /// List of all revisions
  /// </summary>
  public IRsIds? RsIds { get; set; }
}