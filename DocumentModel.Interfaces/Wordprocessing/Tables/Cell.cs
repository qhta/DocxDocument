using DocumentFormat.OpenXml.Spreadsheet;

namespace DocumentModel.Wordprocessing;

/// <summary>
///   Represents a single cell in a table.
/// </summary>
/// <remarks>
///   <para>
///   A Cell is a container for content within a table that occupies one or more
///   grid columns. Cells can contain paragraphs, tables, and other block-level content.
///   </para>
///   <para>
///   Cells can be merged horizontally (across columns) or vertically (across rows)
///   to create complex table layouts. The grid span and vertical merge properties
///   control this behavior.
///   </para>
/// </remarks>
public interface Cell: CollectionItem
{
  #region Properties

  /// <summary>
  ///   Gets or sets the table cell properties.
  /// </summary>
  /// <remarks>
  ///   Includes width, borders, shading, margins, and other cell-specific formatting.
  /// </remarks>
  public TableCellProperties? TableCellProperties { get; set; }

  /// <summary>
  ///   Gets or sets the width of the cell.
  /// </summary>
  /// <remarks>
  ///   The width can be specified as an absolute value, percentage, or auto.
  /// </remarks>
  public TableWidth? Width { get; set; }

  /// <summary>
  ///   Gets or sets the preferred width for this cell.
  /// </summary>
  public Twips? PreferredWidth { get; set; }

  /// <summary>
  ///   Gets or sets the number of grid columns this cell spans.
  /// </summary>
  /// <remarks>
  ///   A value greater than 1 indicates the cell is horizontally merged.
  ///   Default is 1 (no merge).
  /// </remarks>
  public int? ColumnSpan { get; set; }

  /// <summary>
  ///   Gets or sets the height of the cell.
  /// </summary>
  public Twips? Height { get; set; }

  /// <summary>
  ///   Gets or sets the height rule for the cell.
  /// </summary>
  /// <remarks>
  ///   Specifies whether the height is at least, exactly, or auto.
  /// </remarks>
  public HeightRuleKind? HeightRule { get; set; }

  #endregion

  #region Cell Position

  /// <summary>
  ///   Gets the index of the cell in its parent row.
  /// </summary>
  /// <remarks>
  ///   Zero-based index position.
  /// </remarks>
  public int CellIndex { get; }

  /// <summary>
  ///   Gets the row index of the cell in the table.
  /// </summary>
  public int RowIndex { get; }

  /// <summary>
  ///   Gets the parent row containing this cell.
  /// </summary>
  public Row? Row { get; }

  /// <summary>
  ///   Gets the parent table containing this cell.
  /// </summary>
  public Table? Table { get; }

  /// <summary>
  ///   Gets the next cell in the row.
  /// </summary>
  public Cell? Next { get; }

  /// <summary>
  ///   Gets the previous cell in the row.
  /// </summary>
  public Cell? Previous { get; }

  #endregion

  #region Content

  /// <summary>
  ///   Gets the collection of paragraphs in the cell.
  /// </summary>
  public Paragraphs? Paragraphs { get; }

  /// <summary>
  ///   Gets the collection of tables nested within the cell.
  /// </summary>
  /// <remarks>
  ///   Cells can contain nested tables for complex layouts.
  /// </remarks>
  public Tables? Tables { get; }

  /// <summary>
  ///   Gets the range object representing the cell's contents.
  /// </summary>
  public Range? Range { get; }

  #endregion

  #region Borders

  /// <summary>
  ///   Gets or sets the borders for the cell.
  /// </summary>
  public TableCellBorders? Borders { get; set; }

  /// <summary>
  ///   Gets or sets the top border of the cell.
  /// </summary>
  public BorderType? TopBorder { get; set; }

  /// <summary>
  ///   Gets or sets the bottom border of the cell.
  /// </summary>
  public BorderType? BottomBorder { get; set; }

  /// <summary>
  ///   Gets or sets the left border of the cell.
  /// </summary>
  public BorderType? LeftBorder { get; set; }

  /// <summary>
  ///   Gets or sets the right border of the cell.
  /// </summary>
  public BorderType? RightBorder { get; set; }

  /// <summary>
  ///   Gets or sets the inside horizontal border (between multiple paragraphs).
  /// </summary>
  public BorderType? InsideHorizontalBorder { get; set; }

  /// <summary>
  ///   Gets or sets the inside vertical border (for vertically merged cells).
  /// </summary>
  public BorderType? InsideVerticalBorder { get; set; }

  /// <summary>
  ///   Gets or sets the top-left to bottom-right diagonal border.
  /// </summary>
  public BorderType? TopLeftToBottomRightBorder { get; set; }

  /// <summary>
  ///   Gets or sets the top-right to bottom-left diagonal border.
  /// </summary>
  public BorderType? TopRightToBottomLeftBorder { get; set; }

  #endregion

  #region Shading and Color

  /// <summary>
  ///   Gets or sets the shading pattern and colors for the cell.
  /// </summary>
  public Shading? Shading { get; set; }

  /// <summary>
  ///   Gets or sets the background color of the cell.
  /// </summary>
  public Color? BackgroundColor { get; set; }

  /// <summary>
  ///   Gets or sets the pattern color for cell shading.
  /// </summary>
  public Color? ForegroundColor { get; set; }

  /// <summary>
  ///   Gets or sets the shading pattern style.
  /// </summary>
  public ShadingPatternKind? ShadingPattern { get; set; }

  #endregion

  #region Alignment

  /// <summary>
  ///   Gets or sets the vertical alignment of content within the cell.
  /// </summary>
  /// <remarks>
  ///   Specifies whether content is aligned to top, center, or bottom of the cell.
  /// </remarks>
  public TableVerticalAlignmentKind? VerticalAlignment { get; set; }

  /// <summary>
  ///   Gets or sets the text direction for the cell content.
  /// </summary>
  /// <remarks>
  ///   Supports left-to-right, right-to-left, and various rotated orientations.
  /// </remarks>
  public TextDirectionKind? TextDirection { get; set; }

  /// <summary>
  ///   Gets or sets whether text wrapping is disabled for the cell.
  /// </summary>
  /// <remarks>
  ///   When true, cell content will not wrap to multiple lines.
  /// </remarks>
  public bool? NoWrap { get; set; }

  /// <summary>
  ///   Gets or sets whether cell content should be fit to the cell width.
  /// </summary>
  /// <remarks>
  ///   When true, character spacing is adjusted to fit content within cell width.
  /// </remarks>
  public bool? FitText { get; set; }

  #endregion

  #region Margins and Spacing

  /// <summary>
  ///   Gets or sets the cell margins.
  /// </summary>
  public TableCellMargin? Margins { get; set; }

  /// <summary>
  ///   Gets or sets the left margin of the cell content.
  /// </summary>
  public Twips? LeftMargin { get; set; }

  /// <summary>
  ///   Gets or sets the right margin of the cell content.
  /// </summary>
  public Twips? RightMargin { get; set; }

  /// <summary>
  ///   Gets or sets the top margin of the cell content.
  /// </summary>
  public Twips? TopMargin { get; set; }

  /// <summary>
  ///   Gets or sets the bottom margin of the cell content.
  /// </summary>
  public Twips? BottomMargin { get; set; }

  #endregion

  #region Merging

  /// <summary>
  ///   Gets or sets the horizontal merge status of the cell.
  /// </summary>
  /// <remarks>
  ///   Specifies if cell continues or restarts a horizontal merge.
  /// </remarks>
  public MergedCellKind? HorizontalMerge { get; set; }

  /// <summary>
  ///   Gets or sets the vertical merge status of the cell.
  /// </summary>
  /// <remarks>
  ///   Specifies if cell continues or restarts a vertical merge.
  /// </remarks>
  public MergedCellKind? VerticalMerge { get; set; }

  /// <summary>
  ///   Merges the cell with the cell to its right.
  /// </summary>
  public void MergeRight();

  /// <summary>
  ///   Merges the cell with the cell below it.
  /// </summary>
  public void MergeDown();

  /// <summary>
  ///   Splits a merged cell into separate cells.
  /// </summary>
  /// <param name="numRows">Number of rows to split into.</param>
  /// <param name="numColumns">Number of columns to split into.</param>
  public void Split(int numRows, int numColumns);

  #endregion

  #region Methods

  /// <summary>
  ///   Selects the cell.
  /// </summary>
  public void Select();

  /// <summary>
  ///   Deletes the cell from the table.
  /// </summary>
  /// <param name="shiftCells">Whether to shift remaining cells to fill the gap.</param>
  public void Delete(bool shiftCells = true);

  /// <summary>
  ///   Sets the width of the cell.
  /// </summary>
  /// <param name="width">The width value.</param>
  /// <param name="rulerkind">The width type (auto, percentage, or absolute).</param>
  public void SetWidth(float width, WidthRuleKind rulerkind);

  /// <summary>
  ///   Sets the height of the cell.
  /// </summary>
  /// <param name="height">The height value in points.</param>
  /// <param name="heightRule">The height rule (auto, at least, or exactly).</param>
  public void SetHeight(float height, HeightRuleKind heightRule);

  /// <summary>
  ///   Converts the cell to text.
  /// </summary>
  /// <param name="separator">Optional character to use as paragraph separator.</param>
  /// <returns>Range containing the converted text.</returns>
  public Range? ConvertToText(string? separator = null);

  /// <summary>
  ///   Applies autofit to the cell based on its content.
  /// </summary>
  public void AutoFit();

  #endregion

  #region Advanced Properties

  /// <summary>
  ///   Gets or sets the conditional formatting style flags for the cell.
  /// </summary>
  /// <remarks>
  ///   Used with table styles to apply conditional formatting.
  /// </remarks>
  public ConditionalFormatFlags? ConditionalFormatting { get; set; }

  /// <summary>
  ///   Gets or sets whether the cell end mark is hidden.
  /// </summary>
  /// <remarks>
  ///   When true, the end-of-cell marker doesn't affect row height.
  /// </remarks>
  public bool? HideMark { get; set; }

  /// <summary>
  ///   Gets the nested level if this cell is in a nested table.
  /// </summary>
  public int NestingLevel { get; }

  /// <summary>
  ///   Gets or sets the cell identifier for structured tables.
  /// </summary>
  public string? ID { get; set; }

  #endregion

  #region Parent and Application

  /// <summary>
  ///   Gets the parent object.
  /// </summary>
  public object? Parent { get; }

  /// <summary>
  ///   Gets the application object.
  /// </summary>
  public Application? Application { get; }

  #endregion
}