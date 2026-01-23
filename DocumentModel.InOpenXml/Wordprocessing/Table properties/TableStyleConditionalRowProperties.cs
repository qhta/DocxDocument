namespace DocumentModel.Wordprocessing;
/// <summary>
/// Represents table style conditional formatting properties for a table row in a Wordprocessing document.
/// This class provides properties for row visibility, splitting, header status, cell spacing, and justification, enabling advanced styling and formatting options for table rows based on conditional formatting rules.
/// </summary>
public partial class TableStyleConditionalRowProperties : ModelElement //<DXW.TableStyleConditionalRowProperties>
{
    /// <summary>
    /// Indicates whether the row is hidden from view in the table.
    /// </summary>
    public bool? Hidden { get => _Hidden; set => UpdateField(ref _Hidden, value, nameof(Hidden)); }

    private bool? _Hidden;
    /// <summary>
    /// Indicates whether the row cannot be split across pages.
    /// </summary>
    public bool? CantSplit { get; set; }
    /// <summary>
    /// Indicates whether the row is styled as a table header row.
    /// </summary>
    public bool? TableHeader { get; set; }
    /// <summary>
    /// Cell spacing for the row, specifying the space between adjacent cells.
    /// </summary>
    public TableWidth? TableCellSpacing { get; set; }
    /// <summary>
    /// Table row justification, specifying horizontal alignment of the row within the table.
    /// </summary>
    public TableRowAlignmentKind? TableJustification { get; set; }
}