namespace DocumentModel.Wordprocessing;

/// <summary>
/// Base interface for all TableRowProperties classes.
/// Contains common properties for table row formatting, layout, and behavior, including height, splitting, header status, alignment, cell spacing, grid columns, preferred widths, HTML div association, and conditional formatting.
/// </summary>
[OpenXmlType(typeof(DXW.TableRowProperties))]
public abstract partial class BaseTableRowProperties<T>: ModelElement<T>
  where T: DX.OpenXmlElement
{
  static BaseTableRowProperties()
  {
    TableMeasureOpenXmlConverter.RegisterOpenXmlConversion();
    HeightMeasureOpenXmlConverter.RegisterOpenXmlConversion();
  }

  /// <summary>
  /// Specifies the height of the current table row within the current table. This height is used to determine the resulting height of the table row, which can be absolute or relative.
  /// </summary>
  [OpenXmlElement(typeof(DXW.TableRowHeight))]
  public HeightMeasure? RowHeight { get => _RowHeight; set => UpdateField(ref _RowHeight, value, nameof(RowHeight)); }

  private HeightMeasure? _RowHeight;

  /// <summary>
  /// Specifies whether the contents within the current cell shall be rendered on a single page. If set, all contents of a table row are rendered on the same page by moving the start of the row to a new page if necessary.
  /// </summary>
  [OpenXmlElement(typeof(DXW.CantSplit))]
  public bool? CantSplit { get => _CantSplit; set => UpdateField(ref _CantSplit, value, nameof(CantSplit)); }

  private bool? _CantSplit;

  /// <summary>
  /// Specifies that the current table row shall be repeated at the top of each new page on which part of this table is displayed, giving the row header behavior.
  /// </summary>
  [OpenXmlElement(typeof(DXW.TableHeader))]
  public bool? IsHeader { get => _IsHeader; set => UpdateField(ref _IsHeader, value, nameof(IsHeader)); }

  private bool? _IsHeader;

  /// <summary>
  /// Specifies the alignment of a single row in the parent table with respect to the text margins in the current section.
  /// </summary>
  [OpenXmlElement(typeof(DXW.Hidden))]
  public TableRowAlignment? RowAlignment
  {
    get => _RowAlignment;
    set => UpdateField(ref _RowAlignment, value, nameof(RowAlignment));
  }

  private TableRowAlignment? _RowAlignment;

  /// <summary>
  /// Specifies the default table cell spacing for all cells in the parent row, determining the minimum space between cells including borders.
  /// </summary>
  [OpenXmlElement(typeof(DXW.TableCellSpacing))]
  public TableMeasure? CellSpacing
  {
    get => _CellSpacing;
    set => UpdateField(ref _CellSpacing, value, nameof(CellSpacing));
  }

  private TableMeasure? _CellSpacing;

  /// <summary>
  /// Specifies that the glyph representing the end character of the current table row shall not be displayed in the document.
  /// </summary>
  [OpenXmlElement(typeof(DXW.Hidden))]
  public bool? GlyphHidden { get => _GlyphHidden; set => UpdateField(ref _GlyphHidden, value, nameof(GlyphHidden)); }

  private bool? _GlyphHidden;

  /// <summary>
  /// Specifies the number of grid columns in the parent table's grid to skip before adding the row's cells, used for non-standard table layouts.
  /// </summary>
  [OpenXmlElement(typeof(DXW.GridBefore))]
  public Int32? GridBefore { get => _GridBefore; set => UpdateField(ref _GridBefore, value, nameof(GridBefore)); }

  private Int32? _GridBefore;

  /// <summary>
  /// Specifies the number of grid columns in the parent table's grid to leave after the last cell in the row, used for non-standard table layouts.
  /// </summary>
  [OpenXmlElement(typeof(DXW.GridAfter))]
  public Int32? GridAfter { get => _GridAfter; set => UpdateField(ref _GridAfter, value, nameof(GridAfter)); }

  private Int32? _GridAfter;

  /// <summary>
  /// Specifies the preferred width for the total number of grid columns before this table row, used in table layout algorithms.
  /// </summary>
  [OpenXmlElement(typeof(DXW.WidthBeforeTableRow))]
  public TableMeasure? WidthBefore
  {
    get => _WidthBefore;
    set => UpdateField(ref _WidthBefore, value, nameof(WidthBefore));
  }

  private TableMeasure? _WidthBefore;

  /// <summary>
  /// Specifies the preferred width for the total number of grid columns after this table row, used in table layout algorithms.
  /// </summary>
  [OpenXmlElement(typeof(DXW.WidthAfterTableRow))]
  public TableMeasure? WidthAfter { get => _WidthAfter; set => UpdateField(ref _WidthAfter, value, nameof(WidthAfter)); }

  private TableMeasure? _WidthAfter;

  /// <summary>
  /// Specifies the HTML div information associated with the current table row, used for round-tripping HTML div formatting.
  /// </summary>
  [OpenXmlElement(typeof(DXW.DivId))]
  public string? DivId { get => _DivId; set => UpdateField(ref _DivId, value, nameof(DivId)); }

  private string? _DivId;

  /// <summary>
  /// Specifies the set of conditional table style formatting properties applied to this table row, used for style hierarchy and optimization.
  /// </summary>
  [OpenXmlElement(typeof(DXW.ConditionalFormatStyle))]
  public ConditionalFormatFlags? ConditionalFormatStyle
  {
    get => _ConditionalFormatStyle;
    set => UpdateField(ref _ConditionalFormatStyle, value, nameof(ConditionalFormatStyle));
  }

  private ConditionalFormatFlags? _ConditionalFormatStyle;
}

/// <summary>
/// Concrete class for BaseTableRowProperties.
/// </summary>
public class BaseTableRowProperties: BaseTableRowProperties<DXW.TableRowProperties>
{

}