namespace DocumentModel.Wordprocessing;

/// <summary>
///   Defines the Table Class.
/// </summary>
public class Table: ElementCollection<ITableElement>, IBodyElement, ITableCellElement, ISdtBlockElement
{

  public TableProperties? TableProperties { get; set; }

  public TableGrid? TableGrid { get; set; }

}