namespace DocumentModel.Wordprocessing;
/// <summary>
/// Represents the table look settings for a table in a Wordprocessing document.
/// This interface provides properties for configuring visual appearance flags, such as row and column banding, header and footer rows, and other style options, enabling advanced table styling and formatting.
/// </summary>
public partial class TableLook : ModelElement<DXW.TableLook>
{
    /// <summary>
    /// Hexadecimal value representing the table look settings.
    /// </summary>
    public HexChar? Val { get => _Val; set => UpdateField(ref _Val, value, nameof(Val)); }

    private HexChar? _Val;
    /// <summary>
    /// Indicates whether the first row is styled as a header row.
    /// </summary>
    public bool? FirstRow { get; set; }
    /// <summary>
    /// Indicates whether the last row is styled as a footer row.
    /// </summary>
    public bool? LastRow { get; set; }
    /// <summary>
    /// Indicates whether the first column is styled as a header column.
    /// </summary>
    public bool? FirstColumn { get; set; }
    /// <summary>
    /// Indicates whether the last column is styled as a footer column.
    /// </summary>
    public bool? LastColumn { get; set; }
    /// <summary>
    /// Indicates whether horizontal banding is disabled for the table.
    /// </summary>
    public bool? NoHorizontalBand { get; set; }
    /// <summary>
    /// Indicates whether vertical banding is disabled for the table.
    /// </summary>
    public bool? NoVerticalBand { get; set; }
}