namespace DocumentModel.Wordprocessing;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Table Cell.
/// </summary>
public class TableCell: ElementCollection<ITableCellContent>, ITableRowContent, ISdtCellContent
{
  /// <summary>
  ///   Table Cell Properties.
  /// </summary>
  public TableCellProperties? TableCellProperties { get; set; }

  public Collection<AltChunk>? AltChunks { get; set; }

  public CustomXmlBlock? CustomXmlBlock { get; set; }

  public SdtBlock? SdtBlock { get; set; }

  public Collection<Paragraph>? Paragraphs { get; set; }

  public Collection<Table>? Tables { get; set; }
}