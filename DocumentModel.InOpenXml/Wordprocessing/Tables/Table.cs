namespace DocumentModel.Wordprocessing;
/// <summary>
/// Represents a table element in a Wordprocessing document.
/// This class provides access to table properties and grid definitions, enabling configuration and management of table structure, formatting, and layout within the document.
/// </summary>
[OpenXmlType(typeof(DXW.Table))]
[XmlRoot("Table", Namespace = "DocumentModel.Wordprocessing")]
[SpecificClass]
public partial class Table : ModelElement<DXW.Table>, IStoryContent, ITableCellContent, ISdtBlockContent, ICommentContent, ICustomXmlBlockContent
{
  /// <summary>
  /// Default constructor.
  /// </summary>
  public Table() : base() { }

  /// <summary>
  /// Constructor that initializes the element within an owner collection.
  /// </summary>
  /// <param name="collection">The collection to which this element belongs.</param>
  public Table(object collection) : base(collection) { }

  /// <summary>
  /// Table properties, including borders, cell spacing, alignment, and other formatting options.
  /// </summary>
  [OpenXmlProperty(nameof(DXW.Table.TableProperties))]
  public TableProperties? TableProperties { get => _TableProperties; set => UpdateField(ref _TableProperties, value, nameof(TableProperties)); }

  private TableProperties? _TableProperties;
  /// <summary>
  /// Table grid definition, specifying the column structure and widths for the table.
  /// </summary>
  [OpenXmlProperty(nameof(DXW.Table.TableGrid))]
  public TableGrid? TableGrid { get => _TableGrid; set => UpdateField(ref _TableGrid, value, nameof(TableGrid)); }

  private TableGrid? _TableGrid;
}