namespace DocumentModel.Wordprocessing;

/// <summary>
///   Defines the Table Class.
/// </summary>
public interface Table: ElementCollection<TableContent>, StoryContent, TableCellContent, SdtBlockContent, CommentContent
{
  public TableProperties? TableProperties { get; set; }
  public TableGrid? TableGrid { get; set; }
}