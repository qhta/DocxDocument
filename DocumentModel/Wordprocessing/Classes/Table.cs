namespace DocumentModel.Wordprocessing;

/// <summary>
///   Defines the Table Class.
/// </summary>
public class Table: ElementCollection<ITableElement>, IBodyElement, ITableCellElement, ISdtBlockElement
{

  [XmlContentElement] public TableProperties? TableProperties { get; set; }

  [XmlContentElement] public TableGrid? TableGrid { get; set; }

}