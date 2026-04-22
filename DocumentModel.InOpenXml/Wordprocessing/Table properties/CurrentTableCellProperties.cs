namespace DocumentModel.Wordprocessing;
/// <summary>
/// Base interface for current table cell properties.
/// Contains properties for conditional formatting, preferred width, grid span, merge states, borders, text direction, fit text, cell mark visibility, and revision tracking for table cells.
/// </summary>
[OpenXmlType(typeof(DXW.TableCellProperties))]
[XmlRoot("CurrentTableCellProperties", Namespace = "DocumentModel.Wordprocessing")]
public partial class CurrentTableCellProperties<T> : BaseTableCellProperties<T> where T : DX.OpenXmlElement
{
 static CurrentTableCellProperties()
 {
  TableMeasureOpenXmlConverter.RegisterOpenXmlConversion();
 }

 /// <summary>
 /// Set of conditional table style formatting properties applied to this table cell, used for style hierarchy and optimization.
 /// </summary>
 [OpenXmlProperty(nameof(DXW.TableCellProperties.ConditionalFormatStyle))]
 public ConditionalFormatFlags? ConditionalFormatStyle { get => _ConditionalFormatStyle; set => UpdateField(ref _ConditionalFormatStyle, value, nameof(ConditionalFormatStyle)); }
 private ConditionalFormatFlags? _ConditionalFormatStyle;

 /// <summary>
 /// Preferred width for this table cell, used in table layout algorithms.
 /// </summary>
 [OpenXmlProperty(nameof(DXW.TableCellProperties.TableCellWidth))]
 public TableMeasure? TableCellWidth { get => _TableCellWidth; set => UpdateField(ref _TableCellWidth, value, nameof(TableCellWidth)); }
 private TableMeasure? _TableCellWidth;

 /// <summary>
 /// Number of grid columns in the parent table's grid spanned by the current cell, allowing merged cell appearance.
 /// </summary>
 [OpenXmlProperty(nameof(DXW.TableCellProperties.GridSpan))]
 public Int32? GridSpan { get => _GridSpan; set => UpdateField(ref _GridSpan, value, nameof(GridSpan)); }
 private Int32? _GridSpan;

 /// <summary>
 /// Indicates that this cell is part of a horizontally merged set of cells in a table.
 /// </summary>
 [OpenXmlProperty(nameof(DXW.TableCellProperties.HorizontalMerge))]
 public MergedCell? HorizontalMerge { get => _HorizontalMerge; set => UpdateField(ref _HorizontalMerge, value, nameof(HorizontalMerge)); }
 private MergedCell? _HorizontalMerge;

 /// <summary>
 /// Indicates that this cell is part of a vertically merged set of cells in a table.
 /// </summary>
 [OpenXmlProperty(nameof(DXW.TableCellProperties.VerticalMerge))]
 public MergedCell? VerticalMerge { get => _VerticalMerge; set => UpdateField(ref _VerticalMerge, value, nameof(VerticalMerge)); }
 private MergedCell? _VerticalMerge;

 /// <summary>
 /// Set of borders for the edges of the current table cell, using the eight border types defined by its child elements.
 /// </summary>
 [OpenXmlProperty(nameof(DXW.TableCellProperties.TableCellBorders))]
 public TableCellBorders? TableCellBorders { get => _TableCellBorders; set => UpdateField(ref _TableCellBorders, value, nameof(TableCellBorders)); }
 private TableCellBorders? _TableCellBorders;

 /// <summary>
 /// Direction of the text flow for this table cell.
 /// </summary>
 [OpenXmlProperty(nameof(DXW.TableCellProperties.TextDirection))]
 public TextDirection? TextDirection { get => _TextDirection; set => UpdateField(ref _TextDirection, value, nameof(TextDirection)); }
 private TextDirection? _TextDirection;

 /// <summary>
 /// Indicates that the contents of the current cell have their inter-character spacing adjusted to fit the cell width.
 /// </summary>
 [OpenXmlProperty(nameof(DXW.TableCellProperties.TableCellFitText))]
 public bool? TableCellFitText { get => _TableCellFitText; set => UpdateField(ref _TableCellFitText, value, nameof(TableCellFitText)); }
 private bool? _TableCellFitText;

 /// <summary>
 /// Indicates whether the end of cell glyph influences the height of the table row.
 /// </summary>
 [OpenXmlProperty(nameof(DXW.TableCellProperties.HideMark))]
 public bool? HideMark { get => _HideMark; set => UpdateField(ref _HideMark, value, nameof(HideMark)); }
 private bool? _HideMark;

 /// <summary>
 /// Indicates that the parent table cell was inserted while revisions were being recorded.
 /// </summary>
 [OpenXmlElement(typeof(DXW.TableCellProperties))]
 public CellInsertion? CellInsertion { get => _CellInsertion; set => UpdateField(ref _CellInsertion, value, nameof(CellInsertion)); }
 private CellInsertion? _CellInsertion;

 /// <summary>
 /// Indicates that the parent table cell was deleted while revisions were being recorded.
 /// </summary>
 [OpenXmlElement(typeof(DXW.TableCellProperties))]
 public CellDeletion? CellDeletion { get => _CellDeletion; set => UpdateField(ref _CellDeletion, value, nameof(CellDeletion)); }
 private CellDeletion? _CellDeletion;

 /// <summary>
 /// Indicates that the vertical merge state of the parent table cell was modified while revisions were being tracked.
 /// </summary>
 [OpenXmlElement(typeof(DXW.TableCellProperties))]
 public CellMerge? CellMerge { get => _CellMerge; set => UpdateField(ref _CellMerge, value, nameof(CellMerge)); }
 private CellMerge? _CellMerge;
}