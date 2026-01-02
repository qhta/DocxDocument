namespace DocumentModel.Wordprocessing;

/// <summary>
///   Table Row.
/// </summary>
public class TableRow: ElementCollection<ITableRowContent>, ITableContent, ISdtRowContent
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
  ///   paraId, this property is only available in Office 2010 and later.
  /// </summary>
  public IHexInt? ParagraphId { get; set; }
  /// <summary>
  ///   textId, this property is only available in Office 2010 and later.
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