namespace DocumentModel.Wordprocessing;
/// <summary>
/// Represents a table cell in a Wordprocessing document.
/// This class provides access to cell properties, alternative content chunks, custom XML blocks, structured document tags, paragraphs, and nested tables, enabling advanced configuration and content management within table cells.
/// </summary>
public partial class TableCell: ModelElement<DXW.TableCell>, ITableRowContent, ISdtCellContent
{
  /// <summary>
  /// Table cell properties, including formatting, borders, and layout options for the cell.
  /// </summary>
  public TableCellProperties? TableCellProperties { get; set; }
}