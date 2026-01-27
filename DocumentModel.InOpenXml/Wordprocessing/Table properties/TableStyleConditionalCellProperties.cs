namespace DocumentModel.Wordprocessing;
/// <summary>
/// Represents table style conditional formatting properties for a table cell in a Wordprocessing document.
/// This class provides properties for borders, shading, text wrapping, margins, and vertical alignment, enabling advanced styling and formatting options for table cells based on conditional formatting rules.
/// </summary>
public partial class TableStyleConditionalCellProperties : ModelElement //<DXO10W.TableStyleConditionalCellProperties>
{
    /// <summary>
    /// Table cell borders, specifying the style and appearance of cell edges.
    /// </summary>
    public TableCellBorders? TableCellBorders { get => _TableCellBorders; set => UpdateField(ref _TableCellBorders, value, nameof(TableCellBorders)); }

    private TableCellBorders? _TableCellBorders;
    /// <summary>
    /// Shading applied to the table cell, specifying background and pattern formatting.
    /// </summary>
    public Shading? Shading { get => _Shading; set => UpdateField(ref _Shading, value, nameof(Shading)); }

    private Shading? _Shading;
    /// <summary>
    /// Indicates whether text wrapping is disabled for the cell.
    /// </summary>
    public bool? NoWrap { get => _NoWrap; set => UpdateField(ref _NoWrap, value, nameof(NoWrap)); }

    private bool? _NoWrap;
    /// <summary>
    /// Margins for the table cell, specifying padding on each side.
    /// </summary>
    public TableCellMargin? TableCellMargin { get => _TableCellMargin; set => UpdateField(ref _TableCellMargin, value, nameof(TableCellMargin)); }

    private TableCellMargin? _TableCellMargin;
    /// <summary>
    /// Vertical alignment of content within the table cell.
    /// </summary>
    public TableVerticalAlignmentKind? TableCellVerticalAlignment { get => _TableCellVerticalAlignment; set => UpdateField(ref _TableCellVerticalAlignment, value, nameof(TableCellVerticalAlignment)); }

    private TableVerticalAlignmentKind? _TableCellVerticalAlignment;
}