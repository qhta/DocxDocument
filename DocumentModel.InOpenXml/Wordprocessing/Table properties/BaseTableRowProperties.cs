namespace DocumentModel.Wordprocessing;
/// <summary>
/// Base interface for all TableRowProperties classes.
/// Contains common properties for table row formatting, layout, and behavior, including height, splitting, header status, alignment, cell spacing, grid columns, preferred widths, HTML div association, and conditional formatting.
/// </summary>
public partial class BaseTableRowProperties : ModelElement // <OpenXmlItemType> where OpenXmlItemType : DX.OpenXmlElement
{
  /// <summary>
  /// Specifies the height of the current table row within the current table. This height is used to determine the resulting height of the table row, which can be absolute or relative.
  /// </summary>
  public TableRowHeight? RowHeight { get; set; }
  /// <summary>
  /// Specifies whether the contents within the current cell shall be rendered on a single page. If set, all contents of a table row are rendered on the same page by moving the start of the row to a new page if necessary.
  /// </summary>
  public bool? CantSplit { get; set; }
  /// <summary>
  /// Specifies that the current table row shall be repeated at the top of each new page on which part of this table is displayed, giving the row header behavior.
  /// </summary>
  public bool? IsHeader { get; set; }
  /// <summary>
  /// Specifies the alignment of a single row in the parent table with respect to the text margins in the current section.
  /// </summary>
  public TableRowAlignmentKind? RowAlignment { get; set; }
  /// <summary>
  /// Specifies the default table cell spacing for all cells in the parent row, determining the minimum space between cells including borders.
  /// </summary>
  public TableWidth? CellSpacing { get; set; }
  /// <summary>
  /// Specifies that the glyph representing the end character of the current table row shall not be displayed in the document.
  /// </summary>
  public bool? GlyphHidden { get; set; }
  /// <summary>
  /// Specifies the number of grid columns in the parent table's grid to skip before adding the row's cells, used for non-standard table layouts.
  /// </summary>
  public Int32? GridBefore { get; set; }
  /// <summary>
  /// Specifies the number of grid columns in the parent table's grid to leave after the last cell in the row, used for non-standard table layouts.
  /// </summary>
  public Int32? GridAfter { get; set; }
  /// <summary>
  /// Specifies the preferred width for the total number of grid columns before this table row, used in table layout algorithms.
  /// </summary>
  public TableWidth? WidthBefore { get; set; }
  /// <summary>
  /// Specifies the preferred width for the total number of grid columns after this table row, used in table layout algorithms.
  /// </summary>
  public TableWidth? WidthAfter { get; set; }
  /// <summary>
  /// Specifies the HTML div information associated with the current table row, used for round-tripping HTML div formatting.
  /// </summary>
  public string? DivId { get; set; }
  /// <summary>
  /// Specifies the set of conditional table style formatting properties applied to this table row, used for style hierarchy and optimization.
  /// </summary>
  public ConditionalFormatFlags? ConditionalFormatStyle { get; set; }
}