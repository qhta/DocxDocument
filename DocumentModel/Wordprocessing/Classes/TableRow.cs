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

  public BookmarkEnd? BookmarkEnd { get; set; }

  public CommentRangeStart? CommentRangeStart { get; set; }

  public CommentRangeEnd? CommentRangeEnd { get; set; }

  public MoveFromRangeStart? MoveFromRangeStart { get; set; }

  public MoveFromRangeEnd? MoveFromRangeEnd { get; set; }

  public MoveToRangeStart? MoveToRangeStart { get; set; }

  public MoveToRangeEnd? MoveToRangeEnd { get; set; }

  public CustomXmlInsRangeStart? CustomXmlInsRangeStart { get; set; }

  public CustomXmlInsRangeEnd? CustomXmlInsRangeEnd { get; set; }

  public CustomXmlDelRangeStart? CustomXmlDelRangeStart { get; set; }

  public CustomXmlDelRangeEnd? CustomXmlDelRangeEnd { get; set; }

  public CustomXmlMoveFromRangeStart? CustomXmlMoveFromRangeStart { get; set; }

  public CustomXmlMoveFromRangeEnd? CustomXmlMoveFromRangeEnd { get; set; }

  public CustomXmlMoveToRangeStart? CustomXmlMoveToRangeStart { get; set; }

  public CustomXmlMoveToRangeEnd? CustomXmlMoveToRangeEnd { get; set; }

  public CustomXmlConflictInsertionRangeStart? CustomXmlConflictInsertionRangeStart { get; set; }

  public CustomXmlConflictInsertionRangeEnd? CustomXmlConflictInsertionRangeEnd { get; set; }

  public CustomXmlConflictDeletionRangeStart? CustomXmlConflictDeletionRangeStart { get; set; }

  public CustomXmlConflictDeletionRangeEnd? CustomXmlConflictDeletionRangeEnd { get; set; }

  public InsertedRun? InsertedRun { get; set; }

  public DeletedRun? DeletedRun { get; set; }

  public MoveFromRun? MoveFromRun { get; set; }

  public MoveToRun? MoveToRun { get; set; }

  public RunConflictInsertion? RunConflictInsertion { get; set; }

  public RunConflictDeletion? RunConflictDeletion { get; set; }
}