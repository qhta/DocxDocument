namespace DocumentModel.Wordprocessing;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   ITable IRow.
/// </summary>
public class TableRow: ElementCollection<ITableRowContent>, ITableContent, ISdtRowContent
{
  /// <summary>
  ///   IRevision Identifier for ITable IRow Glyph Formatting
  /// </summary>
  public HexInt? RsidTableRowMarkRevision { get; set; }

  /// <summary>
  ///   IRevision Identifier for ITable IRow
  /// </summary>
  public HexInt? RsidTableRowAddition { get; set; }

  /// <summary>
  ///   IRevision Identifier for ITable IRow Deletion
  /// </summary>
  public HexInt? RsidTableRowDeletion { get; set; }

  /// <summary>
  ///   IRevision Identifier for ITable IRow Properties
  /// </summary>
  public HexInt? RsidTableRowProperties { get; set; }

  /// <summary>
  ///   paraId, this property is Ionly available in Office 2010 and later.
  /// </summary>
  public HexInt? ParagraphId { get; set; }

  /// <summary>
  ///   textId, this property is Ionly available in Office 2010 and later.
  /// </summary>
  public HexInt? TextId { get; set; }

  /// <summary>
  ///   ITable-Level Property Exceptions.
  /// </summary>
  public TablePropertyExceptions? TablePropertyExceptions { get; set; }

  /// <summary>
  ///   ITable IRow Properties.
  /// </summary>
  public TableRowProperties? TableRowProperties { get; set; }

}
