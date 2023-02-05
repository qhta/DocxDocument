namespace DocumentModel.Wordprocessing;

/// <summary>
///   Table Row.
/// </summary>
public class TableRow
{
  /// <summary>
  ///   Revision Identifier for Table Row Glyph Formatting
  /// </summary>
  public HexInt? RsidTableRowMarkRevision { get; set; }

  /// <summary>
  ///   Revision Identifier for Table Row
  /// </summary>
  public HexInt? RsidTableRowAddition { get; set; }

  /// <summary>
  ///   Revision Identifier for Table Row Deletion
  /// </summary>
  public HexInt? RsidTableRowDeletion { get; set; }

  /// <summary>
  ///   Revision Identifier for Table Row Properties
  /// </summary>
  public HexInt? RsidTableRowProperties { get; set; }

  /// <summary>
  ///   paraId, this property is only available in Office 2010 and later.
  /// </summary>
  public HexInt? ParagraphId { get; set; }

  /// <summary>
  ///   textId, this property is only available in Office 2010 and later.
  /// </summary>
  public HexInt? TextId { get; set; }

  /// <summary>
  ///   Table-Level Property Exceptions.
  /// </summary>
  public TablePropertyExceptions? TablePropertyExceptions { get; set; }

  /// <summary>
  ///   Table Row Properties.
  /// </summary>
  public TableRowProperties? TableRowProperties { get; set; }

  public Collection<TableCell>? TableCells { get; set; }

  public CustomXmlCell? CustomXmlCell { get; set; }

  public SdtCell? SdtCell { get; set; }

  public ProofError? ProofError { get; set; }

  public PermStart? PermStart { get; set; }

  public PermEnd? PermEnd { get; set; }

  public BookmarkStart? BookmarkStart { get; set; }

  public MarkupRangeType? BookmarkEnd { get; set; }

  public MarkupRangeType? CommentRangeStart { get; set; }

  public MarkupRangeType? CommentRangeEnd { get; set; }

  public MoveBookmarkType? MoveFromRangeStart { get; set; }

  public MarkupRangeType? MoveFromRangeEnd { get; set; }

  public MoveBookmarkType? MoveToRangeStart { get; set; }

  public MarkupRangeType? MoveToRangeEnd { get; set; }

  public TrackChangeType? CustomXmlInsRangeStart { get; set; }

  public MarkupType? CustomXmlInsRangeEnd { get; set; }

  public TrackChangeType? CustomXmlDelRangeStart { get; set; }

  public MarkupType? CustomXmlDelRangeEnd { get; set; }

  public TrackChangeType? CustomXmlMoveFromRangeStart { get; set; }

  public MarkupType? CustomXmlMoveFromRangeEnd { get; set; }

  public TrackChangeType? CustomXmlMoveToRangeStart { get; set; }

  public MarkupType? CustomXmlMoveToRangeEnd { get; set; }

  public TrackChangeType2? CustomXmlConflictInsertionRangeStart { get; set; }

  public MarkupType2? CustomXmlConflictInsertionRangeEnd { get; set; }

  public TrackChangeType2? CustomXmlConflictDeletionRangeStart { get; set; }

  public MarkupType2? CustomXmlConflictDeletionRangeEnd { get; set; }

  public InsertedRun? InsertedRun { get; set; }

  public DeletedRun? DeletedRun { get; set; }

  public MoveFromRun? MoveFromRun { get; set; }

  public MoveToRun? MoveToRun { get; set; }

  public RunConflictInsertion? RunConflictInsertion { get; set; }

  public RunConflictDeletion? RunConflictDeletion { get; set; }
}