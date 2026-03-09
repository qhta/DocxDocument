namespace DocumentModel.Wordprocessing;
/// <summary>
/// Base interface for all TableProperties classes.
/// Contains common properties for table formatting, including alignment, indentation, cell margins, cell spacing, borders, and shading.
/// </summary>
[OpenXmlType(typeof(DXW.TableProperties))]
public partial class BaseTableProperties<T> : ModelElement<T> where T: DX.OpenXmlElement
{
    /// <summary>
    /// Table alignment, specifying horizontal justification of the table within the document.
    /// </summary>
    public TableRowAlignment? TableJustification { get => _TableJustification; set => UpdateField(ref _TableJustification, value, nameof(TableJustification)); }

    private TableRowAlignment? _TableJustification;
    /// <summary>
    /// Table indent from leading margin, specifying the distance from the document margin to the table.
    /// </summary>
    public TableMeasure? TableIndentation { get => _TableIndentation; set => UpdateField(ref _TableIndentation, value, nameof(TableIndentation)); }

    private TableMeasure? _TableIndentation;
    /// <summary>
    /// Default cell margin for the table, specifying padding for all table cells.
    /// </summary>
    public DefaultTableCellMargin? DefaultTableCellMargin { get => _DefaultTableCellMargin; set => UpdateField(ref _DefaultTableCellMargin, value, nameof(DefaultTableCellMargin)); }

    private DefaultTableCellMargin? _DefaultTableCellMargin;
    /// <summary>
    /// Cell spacing for the table, specifying the space between adjacent cells.
    /// </summary>
    public TableMeasure? TableCellSpacing { get => _TableCellSpacing; set => UpdateField(ref _TableCellSpacing, value, nameof(TableCellSpacing)); }

    private TableMeasure? _TableCellSpacing;
    /// <summary>
    /// Borders for the table, specifying line style, color, and width for table edges.
    /// </summary>
    public TableBorders? TableBorders { get => _TableBorders; set => UpdateField(ref _TableBorders, value, nameof(TableBorders)); }

    private TableBorders? _TableBorders;
    /// <summary>
    /// Shading applied to the table, specifying background and pattern formatting.
    /// </summary>
    public Shading? Shading { get => _Shading; set => UpdateField(ref _Shading, value, nameof(Shading)); }

    private Shading? _Shading;
}