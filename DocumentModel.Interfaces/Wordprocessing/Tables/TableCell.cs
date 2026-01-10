namespace DocumentModel.Wordprocessing;

/// <summary>
/// Represents a table cell in a Wordprocessing document.
/// This interface provides access to cell properties, alternative content chunks, custom XML blocks, structured document tags, paragraphs, and nested tables, enabling advanced configuration and content management within table cells.
/// </summary>
public interface TableCell : ElementCollection<TableCellContent>, TableRowContent, SdtCellContent
{

  /// <summary>
  /// Table cell properties, including formatting, borders, and layout options for the cell.
  /// </summary>
  public TableCellProperties? TableCellProperties { get; set; }

  /// <summary>
  /// Collection of alternative content chunks (AltChunk) for the cell, enabling inclusion of external content such as HTML or RTF.
  /// </summary>
  public AltChunks AltChunks { get; set; }

  /// <summary>
  /// Custom XML block contained within the cell, allowing storage of custom data structures.
  /// </summary>
  public CustomXmlBlock? CustomXmlBlock { get; set; }

  /// <summary>
  /// Structured document tag block contained within the cell, enabling advanced content controls.
  /// </summary>
  public SdtBlock? SdtBlock { get; set; }

  /// <summary>
  /// Collection of paragraphs contained within the cell.
  /// </summary>
  public Paragraphs Paragraphs { get; set; }

  /// <summary>
  /// Collection of tables nested within the cell.
  /// </summary>
  public Tables Tables { get; set; }
}