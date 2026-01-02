namespace DocumentModel.Wordprocessing;

/// <summary>
///   Defines the Table Class.
/// </summary>
public class Table: ElementCollection<ITableContent>, IStoryContent, ITableCellContent, ISdtBlockContent, ICommentContent
{
  public TableProperties? TableProperties { get; set; }
  public TableGrid? TableGrid { get; set; }
}