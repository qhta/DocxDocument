using DocumentFormat.OpenXml.Spreadsheet;

namespace DocumentModel.Wordprocessing;

/// <summary>
/// Represents a single cell in a table within a Wordprocessing document.
/// This interface provides properties and methods for configuring cell formatting, merging, alignment, borders, shading, margins, and content, as well as for manipulating and querying the cell's position and relationships within the table structure.
/// </summary>
/// <remarks>
/// 
/// A Cell is a container for content within a table that occupies one or more grid columns. Cells can contain paragraphs, tables, and other block-level content.
/// 
/// Cells can be merged horizontally (across columns) or vertically (across rows) to create complex table layouts. The grid span and vertical merge properties control this behavior.
/// 
/// </remarks>
public partial interface TableCell : CollectionItem
{
    #region Properties

    /// <summary>
    /// Width of the cell, specified as an absolute value, percentage, or auto.
    /// </summary>
    public TableWidth? Width { get; set; }

    /// <summary>
    /// Preferred width for this cell.
    /// </summary>
    public Twips? PreferredWidth { get; set; }

    /// <summary>
    /// Number of grid columns this cell spans. A value greater than 1 indicates the cell is horizontally merged. Default is 1 (no merge).
    /// </summary>
    public int? ColumnSpan { get; set; }

    /// <summary>
    /// Height of the cell.
    /// </summary>
    public Twips? Height { get; set; }

    /// <summary>
    /// Height rule for the cell, specifying whether the height is at least, exactly, or auto.
    /// </summary>
    public HeightRuleKind? HeightRule { get; set; }

    #endregion

    #region Cell Position

    /// <summary>
    /// Index of the cell in its parent row (zero-based).
    /// </summary>
    public int CellIndex { get; }

    /// <summary>
    /// Row index of the cell in the table.
    /// </summary>
    public int RowIndex { get; }

    /// <summary>
    /// Parent row containing this cell.
    /// </summary>
    public Row? Row { get; }

    /// <summary>
    /// Parent table containing this cell.
    /// </summary>
    public Table? Table { get; }

    /// <summary>
    /// Next cell in the row.
    /// </summary>
    public Cell? Next { get; }

    /// <summary>
    /// Previous cell in the row.
    /// </summary>
    public Cell? Previous { get; }

    #endregion

    #region Content

    /// <summary>
    /// Collection of paragraphs in the cell.
    /// </summary>
    public IEnumerable<Paragraph>? Paragraphs { get; }

    /// <summary>
    /// Collection of tables nested within the cell. Cells can contain nested tables for complex layouts.
    /// </summary>
    public IEnumerable<Table>? Tables { get; }

    /// <summary>
    /// Range object representing the cell's contents.
    /// </summary>
    public Range? Range { get; }

    #endregion

    #region Borders

    /// <summary>
    /// Borders for the cell.
    /// </summary>
    public TableCellBorders? Borders { get; set; }

    /// <summary>
    /// Top border of the cell.
    /// </summary>
    public BorderType? TopBorder { get; set; }

    /// <summary>
    /// Bottom border of the cell.
    /// </summary>
    public BorderType? BottomBorder { get; set; }

    /// <summary>
    /// Left border of the cell.
    /// </summary>
    public BorderType? LeftBorder { get; set; }

    /// <summary>
    /// Right border of the cell.
    /// </summary>
    public BorderType? RightBorder { get; set; }

    /// <summary>
    /// Inside horizontal border (between multiple paragraphs).
    /// </summary>
    public BorderType? InsideHorizontalBorder { get; set; }

    /// <summary>
    /// Inside vertical border (for vertically merged cells).
    /// </summary>
    public BorderType? InsideVerticalBorder { get; set; }

    /// <summary>
    /// Top-left to bottom-right diagonal border.
    /// </summary>
    public BorderType? TopLeftToBottomRightBorder { get; set; }

    /// <summary>
    /// Top-right to bottom-left diagonal border.
    /// </summary>
    public BorderType? TopRightToBottomLeftBorder { get; set; }

    #endregion

    #region Shading and Color

    /// <summary>
    /// Shading pattern and colors for the cell.
    /// </summary>
    public DMWD.Shading? Shading { get; set; }

    /// <summary>
    /// Background color of the cell.
    /// </summary>
    public Color? BackgroundColor { get; set; }

    /// <summary>
    /// Pattern color for cell shading.
    /// </summary>
    public Color? ForegroundColor { get; set; }

    /// <summary>
    /// Shading pattern style.
    /// </summary>
    public ShadingPatternKind? ShadingPattern { get; set; }

    #endregion

    #region Alignment

    /// <summary>
    /// Vertical alignment of content within the cell. Specifies whether content is aligned to top, center, or bottom of the cell.
    /// </summary>
    public TableVerticalAlignmentKind? VerticalAlignment { get; set; }

    /// <summary>
    /// Text direction for the cell content. Supports left-to-right, right-to-left, and various rotated orientations.
    /// </summary>
    public TextDirectionKind? TextDirection { get; set; }

    /// <summary>
    /// Whether text wrapping is disabled for the cell. When true, cell content will not wrap to multiple lines.
    /// </summary>
    public bool? NoWrap { get; set; }

    /// <summary>
    /// Whether cell content should be fit to the cell width. When true, character spacing is adjusted to fit content within cell width.
    /// </summary>
    public bool? FitText { get; set; }

    #endregion

    #region Margins and Spacing

    /// <summary>
    /// Cell margins.
    /// </summary>
    public TableCellMargin? Margins { get; set; }

    /// <summary>
    /// Left margin of the cell content.
    /// </summary>
    public Twips? LeftMargin { get; set; }

    /// <summary>
    /// Right margin of the cell content.
    /// </summary>
    public Twips? RightMargin { get; set; }

    /// <summary>
    /// Top margin of the cell content.
    /// </summary>
    public Twips? TopMargin { get; set; }

    /// <summary>
    /// Bottom margin of the cell content.
    /// </summary>
    public Twips? BottomMargin { get; set; }

    #endregion

    #region Merging

    /// <summary>
    /// Horizontal merge status of the cell. Specifies if cell continues or restarts a horizontal merge.
    /// </summary>
    public MergedCellKind? HorizontalMerge { get; set; }

    /// <summary>
    /// Vertical merge status of the cell. Specifies if cell continues or restarts a vertical merge.
    /// </summary>
    public MergedCellKind? VerticalMerge { get; set; }
  
    #endregion

    #region Advanced Properties

    /// <summary>
    /// Conditional formatting style flags for the cell. Used with table styles to apply conditional formatting.
    /// </summary>
    public ConditionalFormatFlags? ConditionalFormatting { get; set; }

    /// <summary>
    /// Whether the cell end mark is hidden. When true, the end-of-cell marker doesn't affect row height.
    /// </summary>
    public bool? HideMark { get; set; }

    /// <summary>
    /// Nested level if this cell is in a nested table.
    /// </summary>
    public int NestingLevel { get; }

    /// <summary>
    /// Cell identifier for structured tables.
    /// </summary>
    public string? ID { get; set; }

    #endregion

}