namespace DocumentModel.Wordprocessing;
/// <summary>
/// Base interface for all TableProperties classes.
/// Contains common properties for table formatting, including alignment, indentation, cell margins, cell spacing, borders, and shading.
/// </summary>
public partial class BaseTableProperties : ModelElement //<OpenXmlItemType> where OpenXmlItemType : DX.OpenXmlElement
{
    /// <summary>
    /// Table alignment, specifying horizontal justification of the table within the document.
    /// </summary>
    public TableRowAlignmentKind? TableJustification { get => _TableJustification; set => UpdateField(ref _TableJustification, value, nameof(TableJustification)); }

    private TableRowAlignmentKind? _TableJustification;
    /// <summary>
    /// Table indent from leading margin, specifying the distance from the document margin to the table.
    /// </summary>
    public TableWidth? TableIndentation { get => _TableIndentation; set => UpdateField(ref _TableIndentation, value, nameof(TableIndentation)); }

    private TableWidth? _TableIndentation;
    /// <summary>
    /// Default cell margin for the table, specifying padding for all table cells.
    /// </summary>
    public DefaultTableCellMargin? DefaultTableCellMargin { get => _DefaultTableCellMargin; set => UpdateField(ref _DefaultTableCellMargin, value, nameof(DefaultTableCellMargin)); }

    private DefaultTableCellMargin? _DefaultTableCellMargin;
    /// <summary>
    /// Cell spacing for the table, specifying the space between adjacent cells.
    /// </summary>
    public TableWidth? TableCellSpacing { get => _TableCellSpacing; set => UpdateField(ref _TableCellSpacing, value, nameof(TableCellSpacing)); }

    private TableWidth? _TableCellSpacing;
    /// <summary>
    /// Borders for the table, specifying line style, color, and width for table edges.
    /// </summary>
    public TableBorders? TableBorders { get => _TableBorders; set => UpdateField(ref _TableBorders, value, nameof(TableBorders)); }

    private TableBorders? _TableBorders;
    /// <summary>
    /// Shading applied to the table, specifying background and pattern formatting.
    /// </summary>
    public DMWD.Shading? Shading { get => _Shading; set => UpdateField(ref _Shading, value, nameof(Shading)); }

    private DMWD.Shading? _Shading;
}