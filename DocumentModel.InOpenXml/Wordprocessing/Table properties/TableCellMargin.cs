namespace DocumentModel.Wordprocessing;
/// <summary>
///   Specifies a set of cell margins for all cells in the parent table row 
///   via table-level property exceptions.
///   These settings can be overridden by the cell margin definition specified by the tcMar element 
///   within the table cell's properties.
/// </summary>
[OpenXmlType(typeof(DXW.TableCellMargin))]
public partial class TableCellMargin : ModelElement<DXW.TableCellMargin>
{
 /// <summary>
 ///   Table cell top margin, specifying the padding at the top edge of the cell.
 /// </summary>
 [OpenXmlProperty(nameof(DXW.TableCellMargin.TopMargin))]
 [OpenXmlElement(typeof(DXW.TableCellMargin))]
 public TableWidth? TopMargin { get => _TopMargin; set => UpdateField(ref _TopMargin, value, nameof(TopMargin)); }

 private TableWidth? _TopMargin;
 /// <summary>
 ///   Table cell left margin, specifying the padding at the left edge of the cell.
 /// </summary>
 [OpenXmlProperty(nameof(DXW.TableCellMargin.LeftMargin))]
 [OpenXmlElement(typeof(DXW.TableCellMargin))]
 public TableWidth? LeftMargin { get => _LeftMargin; set => UpdateField(ref _LeftMargin, value, nameof(LeftMargin)); }

 private TableWidth? _LeftMargin;
 /// <summary>
 ///   Start margin, specifying the padding at the starting edge of the cell 
 ///   (contextual to document direction).
 /// </summary>
 [OpenXmlProperty(nameof(DXW.TableCellMargin.StartMargin))]
 [OpenXmlElement(typeof(DXW.TableCellMargin))]
 public TableWidth? StartMargin { get => _StartMargin; set => UpdateField(ref _StartMargin, value, nameof(StartMargin)); }

 private TableWidth? _StartMargin;
 /// <summary>
 ///   Table cell bottom margin, specifying the padding at the bottom edge of the cell.
 /// </summary>
 [OpenXmlProperty(nameof(DXW.TableCellMargin.BottomMargin))]
 [OpenXmlElement(typeof(DXW.TableCellMargin))]
 public TableWidth? BottomMargin { get => _BottomMargin; set => UpdateField(ref _BottomMargin, value, nameof(BottomMargin)); }

 private TableWidth? _BottomMargin;
 /// <summary>
 ///   Table cell right margin, specifying the padding at the right edge of the cell.
 /// </summary>
 [OpenXmlProperty(nameof(DXW.TableCellMargin.RightMargin))]
 [OpenXmlElement(typeof(DXW.TableCellMargin))]
 public TableWidth? RightMargin { get => _RightMargin; set => UpdateField(ref _RightMargin, value, nameof(RightMargin)); }

 private TableWidth? _RightMargin;
 /// <summary>
 ///   End margin, specifying the padding at the ending edge of the cell 
 ///   (contextual to document direction).
 /// </summary>
 [OpenXmlProperty(nameof(DXW.TableCellMargin.EndMargin))]
 [OpenXmlElement(typeof(DXW.TableCellMargin))]
 public TableWidth? EndMargin { get => _EndMargin; set => UpdateField(ref _EndMargin, value, nameof(EndMargin)); }

 private TableWidth? _EndMargin;
}