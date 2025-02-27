namespace DocumentModel.Wordprocessing;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Defines the Table Class.
/// </summary>
public class Table: ElementCollection<ITableContent>, IStoryContent, ITableCellContent, ISdtBlockContent, ICommentContent
{

  public TableProperties? TableProperties { get; set; }

  public TableGrid? TableGrid { get; set; }

}