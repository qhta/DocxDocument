namespace DocumentModel.Wordprocessing;

/// <summary>
/// Represents a table element in a Wordprocessing document.
/// This interface provides access to table properties and grid definitions, enabling configuration and management of table structure, formatting, and layout within the document.
/// </summary>
public interface Table : ElementCollection<TableContent>, StoryContent, TableCellContent, SdtBlockContent, CommentContent
{

  /// <summary>
  /// Table properties, including borders, cell spacing, alignment, and other formatting options.
  /// </summary>
  public TableProperties? TableProperties { get; set; }

  /// <summary>
  /// Table grid definition, specifying the column structure and widths for the table.
  /// </summary>
  public TableGrid? TableGrid { get; set; }
}