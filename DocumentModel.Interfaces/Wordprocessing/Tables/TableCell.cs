namespace DocumentModel.Wordprocessing;

/// <summary>
///   Table Cell.
/// </summary>
public interface TableCell: ElementCollection<TableCellContent>, TableRowContent, SdtCellContent
{
  /// <summary>
  ///   Table Cell Properties.
  /// </summary>
  public TableCellProperties? TableCellProperties { get; set; }
  public AltChunks AltChunks { get; set; }

  public CustomXmlBlock? CustomXmlBlock { get; set; }
  public SdtBlock? SdtBlock { get; set; }
  public Paragraphs Paragraphs { get; set; }
  public Tables Tables { get; set; }
}