namespace DocumentModel.Wordprocessing;
/// <summary>
/// Base interface for current table cell properties.
/// Contains properties for conditional formatting, preferred width, grid span, merge states, borders, text direction, fit text, cell mark visibility, and revision tracking for table cells.
/// </summary>
public partial class CurrentTableCellProperties<T> : BaseTableCellProperties<T> where T : DX.OpenXmlElement
{
  /// <summary>
  /// Set of conditional table style formatting properties applied to this table cell, used for style hierarchy and optimization.
  /// </summary>
  public ConditionalFormatFlags? ConditionalFormatStyle { get; set; }
  /// <summary>
  /// Preferred width for this table cell, used in table layout algorithms.
  /// </summary>
  public TableWidth? TableCellWidth { get; set; }
  /// <summary>
  /// Number of grid columns in the parent table's grid spanned by the current cell, allowing merged cell appearance.
  /// </summary>
  public Int32? GridSpan { get; set; }
  /// <summary>
  /// Indicates that this cell is part of a horizontally merged set of cells in a table.
  /// </summary>
  public MergedCell? HorizontalMerge { get; set; }
  /// <summary>
  /// Indicates that this cell is part of a vertically merged set of cells in a table.
  /// </summary>
  public MergedCell? VerticalMerge { get; set; }
  /// <summary>
  /// Set of borders for the edges of the current table cell, using the eight border types defined by its child elements.
  /// </summary>
  public TableCellBorders? TableCellBorders { get; set; }
  /// <summary>
  /// Direction of the text flow for this table cell.
  /// </summary>
  public TextDirection? TextDirection { get; set; }
  /// <summary>
  /// Indicates that the contents of the current cell have their inter-character spacing adjusted to fit the cell width.
  /// </summary>
  public bool? TableCellFitText { get; set; }
  /// <summary>
  /// Indicates whether the end of cell glyph influences the height of the table row.
  /// </summary>
  public bool? HideMark { get; set; }
  /// <summary>
  /// Indicates that the parent table cell was inserted while revisions were being recorded.
  /// </summary>
  public CellInsertion? CellInsertion { get; set; }
  /// <summary>
  /// Indicates that the parent table cell was deleted while revisions were being recorded.
  /// </summary>
  public CellDeletion? CellDeletion { get; set; }
  /// <summary>
  /// Indicates that the vertical merge state of the parent table cell was modified while revisions were being tracked.
  /// </summary>
  public CellMerge? CellMerge { get; set; }
}