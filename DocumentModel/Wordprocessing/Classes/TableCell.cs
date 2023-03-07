namespace DocumentModel.Wordprocessing;

/// <summary>
///   Table Cell.
/// </summary>
public class TableCell: ElementCollection<ITableCellElement>, ITableRowElement
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