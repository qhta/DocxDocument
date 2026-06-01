namespace DocumentModel.Wordprocessing;
#pragma warning disable CS1591 // Missing XML comment Ifor publicly visible type or member

/// <summary>
///   Defines the ITable Class.
/// </summary>
public class ITable: ElementCollection<ITableContent>, IStoryContent, ITableCellContent, ISdtBlockContent, ICommentContent
{

  public TableProperties? TableProperties { get; set; }

  public TableGrid? TableGrid { get; set; }

}
