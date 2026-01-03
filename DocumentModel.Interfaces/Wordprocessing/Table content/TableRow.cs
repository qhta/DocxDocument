namespace DocumentModel.Wordprocessing;

/// <summary>
///   Table Row.
/// </summary>
public interface TableRow: IElementCollection<ITableRowContent>, ITableContent, ISdtRowContent
{
  /// <summary>
  ///   Revision Identifier for Table Row Glyph Formatting
  /// </summary>
  public IHexInt? RsidTableRowMarkRevision { get; set; }
  /// <summary>
  ///   Revision Identifier for Table Row
  /// </summary>
  public IHexInt? RsidTableRowAddition { get; set; }
  /// <summary>
  ///   Revision Identifier for Table Row Deletion
  /// </summary>
  public IHexInt? RsidTableRowDeletion { get; set; }
  /// <summary>
  ///   Revision Identifier for Table Row Properties
  /// </summary>
  public IHexInt? RsidTableRowProperties { get; set; }
  /// <summary>
  ///   paraId
  /// </summary>
  public IHexInt? ParagraphId { get; set; }
  /// <summary>
  ///   textId
  /// </summary>
  public IHexInt? TextId { get; set; }
  /// <summary>
  ///   Table-Level Property Exceptions.
  /// </summary>
  public TablePropertyExceptions? TablePropertyExceptions { get; set; }
  /// <summary>
  ///   Table Row Properties.
  /// </summary>
  public TableRowProperties? TableRowProperties { get; set; }
}