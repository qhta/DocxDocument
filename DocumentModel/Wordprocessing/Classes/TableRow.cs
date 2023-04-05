namespace DocumentModel.Wordprocessing;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Table Row.
/// </summary>
public class TableRow: ElementCollection<ITableRowContent>, ITableContent, ISdtRowContent
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

}