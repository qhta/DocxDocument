namespace DocumentModel.Wordprocessing;

/// <summary>
/// Represents a table row in a Wordprocessing document.
/// This interface provides access to revision identifiers, paragraph and text IDs, property exceptions, row properties, and enables advanced configuration and management of table rows and their content.
/// </summary>
public partial interface TableRow: IElementCollection<TableRowContent>, TableContent, SdtRowContent
{

  /// <summary>
  /// Revision identifier for table row glyph formatting.
  /// </summary>
  public HexInt? RsidTableRowMarkRevision { get; set; }

  /// <summary>
  /// Revision identifier for table row addition.
  /// </summary>
  public HexInt? RsidTableRowAddition { get; set; }

  /// <summary>
  /// Revision identifier for table row deletion.
  /// </summary>
  public HexInt? RsidTableRowDeletion { get; set; }

  /// <summary>
  /// Revision identifier for table row properties.
  /// </summary>
  public HexInt? RsidTableRowProperties { get; set; }

  /// <summary>
  /// Paragraph identifier for the row.
  /// </summary>
  public HexInt? ParagraphId { get; set; }

  /// <summary>
  /// Text identifier for the row.
  /// </summary>
  public HexInt? TextId { get; set; }

  /// <summary>
  /// Table-level property exceptions for the row, enabling advanced formatting overrides.
  /// </summary>
  public TablePropertyExceptions? TablePropertyExceptions { get; set; }

  /// <summary>
  /// Table row properties, including formatting and layout options for the row.
  /// </summary>
  public TableRowProperties? TableRowProperties { get; set; }
}