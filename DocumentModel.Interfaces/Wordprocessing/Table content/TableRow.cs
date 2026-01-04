namespace DocumentModel.Wordprocessing;

/// <summary>
///   Table Row.
/// </summary>
public interface TableRow: IElementCollection<ITableRowContent>, ITableContent, ISdtRowContent
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
  ///   paraId
  /// </summary>
  public HexInt? ParagraphId { get; set; }
  /// <summary>
  ///   textId
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
}