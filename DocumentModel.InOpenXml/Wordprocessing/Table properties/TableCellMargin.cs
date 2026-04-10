namespace DocumentModel.Wordprocessing;
/// <summary>
///   Specifies a set of cell margins for all cells in the parent table row 
///   via table-level property exceptions.
///   These settings can be overridden by the cell margin definition specified by the tcMar element 
///   within the table cell's properties.
/// </summary>
[OpenXmlType(typeof(DXW.TableCellMargin))]
[XmlRoot("TableCellMargin", Namespace = "DocumentModel.Wordprocessing")]
public partial class TableCellMargin : ModelElement<DXW.TableCellMargin>
{
 static TableCellMargin()
 {
  TableMeasureOpenXmlConverter.RegisterOpenXmlConversion();
 }

 /// <summary>
 ///   Table cell top margin, specifying the padding at the top edge of the cell.
 /// </summary>
 [OpenXmlProperty(nameof(DXW.TableCellMargin.TopMargin))]
 public TableMeasure? TopMargin { get => _TopMargin; set => UpdateField(ref _TopMargin, value, nameof(TopMargin)); }

 private TableMeasure? _TopMargin;
 /// <summary>
 ///   Table cell left margin, specifying the padding at the left edge of the cell.
 /// </summary>
 [OpenXmlProperty(nameof(DXW.TableCellMargin.LeftMargin))]
 public TableMeasure? LeftMargin { get => _LeftMargin; set => UpdateField(ref _LeftMargin, value, nameof(LeftMargin)); }

 private TableMeasure? _LeftMargin;
 /// <summary>
 ///   Start margin, specifying the padding at the starting edge of the cell 
 ///   (contextual to document direction).
 /// </summary>
 [OpenXmlProperty(nameof(DXW.TableCellMargin.StartMargin))]
 public TableMeasure? StartMargin { get => _StartMargin; set => UpdateField(ref _StartMargin, value, nameof(StartMargin)); }

 private TableMeasure? _StartMargin;
 /// <summary>
 ///   Table cell bottom margin, specifying the padding at the bottom edge of the cell.
 /// </summary>
 [OpenXmlProperty(nameof(DXW.TableCellMargin.BottomMargin))]
 public TableMeasure? BottomMargin { get => _BottomMargin; set => UpdateField(ref _BottomMargin, value, nameof(BottomMargin)); }

 private TableMeasure? _BottomMargin;
 /// <summary>
 ///   Table cell right margin, specifying the padding at the right edge of the cell.
 /// </summary>
 [OpenXmlProperty(nameof(DXW.TableCellMargin.RightMargin))]
 public TableMeasure? RightMargin { get => _RightMargin; set => UpdateField(ref _RightMargin, value, nameof(RightMargin)); }

 private TableMeasure? _RightMargin;
 /// <summary>
 ///   End margin, specifying the padding at the ending edge of the cell 
 ///   (contextual to document direction).
 /// </summary>
 [OpenXmlProperty(nameof(DXW.TableCellMargin.EndMargin))]
 public TableMeasure? EndMargin { get => _EndMargin; set => UpdateField(ref _EndMargin, value, nameof(EndMargin)); }

 private TableMeasure? _EndMargin;
}