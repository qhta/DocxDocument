namespace DocumentModel.Wordprocessing;

/// <summary>
///   Defines the Table Class.
/// </summary>
public interface Table: IElementCollection<TableContent>, StoryContent, TableCellContent, SdtBlockContent, CommentContent
{
  public TableProperties? TableProperties { get; set; }
  public TableGrid? TableGrid { get; set; }
}