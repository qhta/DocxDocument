namespace DocumentModel.Wordprocessing;

/// <summary>
/// Table Row.
/// </summary>
public interface ITableRow // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Revision Identifier for Table Row Glyph Formatting
  /// </summary>
  public DocumentModel.IHexBinaryValue? RsidTableRowMarkRevision { get ; set; }
  
  /// <summary>
  /// Revision Identifier for Table Row
  /// </summary>
  public DocumentModel.IHexBinaryValue? RsidTableRowAddition { get ; set; }
  
  /// <summary>
  /// Revision Identifier for Table Row Deletion
  /// </summary>
  public DocumentModel.IHexBinaryValue? RsidTableRowDeletion { get ; set; }
  
  /// <summary>
  /// Revision Identifier for Table Row Properties
  /// </summary>
  public DocumentModel.IHexBinaryValue? RsidTableRowProperties { get ; set; }
  
  /// <summary>
  /// paraId, this property is only available in Office 2010 and later.
  /// </summary>
  public DocumentModel.IHexBinaryValue? ParagraphId { get ; set; }
  
  /// <summary>
  /// textId, this property is only available in Office 2010 and later.
  /// </summary>
  public DocumentModel.IHexBinaryValue? TextId { get ; set; }
  
  /// <summary>
  /// Table-Level Property Exceptions.
  /// </summary>
  public ITablePropertyExceptions? TablePropertyExceptions { get ; set; }
  
  /// <summary>
  /// Table Row Properties.
  /// </summary>
  public ITableRowProperties? TableRowProperties { get ; set; }
  
  public Collection<ITableCell>? TableCells { get ; set; }
  
  public Collection<ICustomXmlCell>? CustomXmlCells { get ; set; }
  
  public Collection<ISdtCell>? SdtCells { get ; set; }
  
  public Collection<IProofError>? ProofErrors { get ; set; }
  
  public Collection<IPermStart>? PermStarts { get ; set; }
  
  public Collection<IPermEnd>? PermEnds { get ; set; }
  
  public Collection<IBookmarkStart>? BookmarkStarts { get ; set; }
  
  public Collection<IMarkupRangeType>? BookmarkEnds { get ; set; }
  
  public Collection<IMarkupRangeType>? CommentRangeStarts { get ; set; }
  
  public Collection<IMarkupRangeType>? CommentRangeEnds { get ; set; }
  
  public Collection<IMoveBookmarkType>? MoveFromRangeStarts { get ; set; }
  
  public Collection<IMarkupRangeType>? MoveFromRangeEnds { get ; set; }
  
  public Collection<IMoveBookmarkType>? MoveToRangeStarts { get ; set; }
  
  public Collection<IMarkupRangeType>? MoveToRangeEnds { get ; set; }
  
  public Collection<ITrackChangeType>? CustomXmlInsRangeStarts { get ; set; }
  
  public Collection<IMarkupType>? CustomXmlInsRangeEnds { get ; set; }
  
  public Collection<ITrackChangeType>? CustomXmlDelRangeStarts { get ; set; }
  
  public Collection<IMarkupType>? CustomXmlDelRangeEnds { get ; set; }
  
  public Collection<ITrackChangeType>? CustomXmlMoveFromRangeStarts { get ; set; }
  
  public Collection<IMarkupType>? CustomXmlMoveFromRangeEnds { get ; set; }
  
  public Collection<ITrackChangeType>? CustomXmlMoveToRangeStarts { get ; set; }
  
  public Collection<IMarkupType>? CustomXmlMoveToRangeEnds { get ; set; }
  
  public Collection<ITrackChangeType>? CustomXmlConflictInsertionRangeStarts { get ; set; }
  
  public Collection<IMarkupType>? CustomXmlConflictInsertionRangeEnds { get ; set; }
  
  public Collection<ITrackChangeType>? CustomXmlConflictDeletionRangeStarts { get ; set; }
  
  public Collection<IMarkupType>? CustomXmlConflictDeletionRangeEnds { get ; set; }
  
  public Collection<IInsertedRun>? InsertedRuns { get ; set; }
  
  public Collection<IDeletedRun>? DeletedRuns { get ; set; }
  
  public Collection<IMoveFromRun>? MoveFromRuns { get ; set; }
  
  public Collection<IMoveToRun>? MoveToRuns { get ; set; }
  
  public Collection<IRunConflictInsertion>? RunConflictInsertions { get ; set; }
  
  public Collection<IRunConflictDeletion>? RunConflictDeletions { get ; set; }
  
}
