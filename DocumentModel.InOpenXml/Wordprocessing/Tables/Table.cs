namespace DocumentModel.Wordprocessing;
/// <summary>
/// Represents a table element in a Wordprocessing document.
/// This class provides access to table properties and grid definitions, enabling configuration and management of table structure, formatting, and layout within the document.
/// </summary>
public partial class Table : ModelElement<DXW.Table>, IStoryContent, ITableCellContent, ISdtBlockContent, ICommentContent, ICustomXmlBlockContent
{
    /// <summary>
    /// Table properties, including borders, cell spacing, alignment, and other formatting options.
    /// </summary>
    public TableProperties? TableProperties { get => _TableProperties; set => UpdateField(ref _TableProperties, value, nameof(TableProperties)); }

    private TableProperties? _TableProperties;
    /// <summary>
    /// Table grid definition, specifying the column structure and widths for the table.
    /// </summary>
    public TableGrid? TableGrid { get => _TableGrid; set => UpdateField(ref _TableGrid, value, nameof(TableGrid)); }

    private TableGrid? _TableGrid;
}