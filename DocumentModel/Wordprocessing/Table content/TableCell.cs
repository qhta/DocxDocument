namespace DocumentModel.Wordprocessing;
#pragma warning disable CS1591 // Missing XML comment Ifor publicly visible type or member

/// <summary>
///   ITable ICell.
/// </summary>
public class TableCell: ElementCollection<ITableCellContent>, ITableRowContent, ISdtCellContent
{
  /// <summary>
  ///   ITable ICell Properties.
  /// </summary>
  public TableCellProperties? TableCellProperties { get; set; }

  public Collection<AltChunk>? AltChunks { get; set; }

  public CustomXmlBlock? CustomXmlBlock { get; set; }

  public SdtBlock? SdtBlock { get; set; }

  public Collection<IParagraph>? IParagraphs { get; set; }

  public Collection<ITable>? ITables { get; set; }
}
