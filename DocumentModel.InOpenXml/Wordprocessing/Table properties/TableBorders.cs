namespace DocumentModel.Wordprocessing;
/// <summary>
/// Represents the set of borders for a table in a Wordprocessing document.
/// This class provides properties for configuring the top, left, start, bottom, right, end, inside horizontal, and inside vertical borders, enabling advanced formatting and appearance control for table edges and internal lines.
/// </summary>
[OpenXmlType(typeof(DXW.TableBorders))]
[XmlRoot("TableBorders", Namespace = "DocumentModel.Wordprocessing")]
public partial class TableBorders : ModelElement<DXW.TableBorders>
{
 /// <summary>
 /// Table top border, specifying the style and appearance of the top edge of the table.
 /// </summary>
 [OpenXmlProperty(nameof(DXW.TableBorders.TopBorder))]
 public Border? TopBorder { get => _TopBorder; set => UpdateField(ref _TopBorder, value, nameof(TopBorder)); }
 private Border? _TopBorder;

 /// <summary>
 /// Table left border, specifying the style and appearance of the left edge of the table.
 /// </summary>
 [OpenXmlProperty(nameof(DXW.TableBorders.LeftBorder))]
 public Border? LeftBorder { get => _LeftBorder; set => UpdateField(ref _LeftBorder, value, nameof(LeftBorder)); }
 private Border? _LeftBorder;

 /// <summary>
 /// Start border, specifying the style and appearance of the starting edge of the table (contextual to document direction).
 /// </summary>
 [OpenXmlProperty(nameof(DXW.TableBorders.StartBorder))]
 public Border? StartBorder { get => _StartBorder; set => UpdateField(ref _StartBorder, value, nameof(StartBorder)); }
 private Border? _StartBorder;

 /// <summary>
 /// Table bottom border, specifying the style and appearance of the bottom edge of the table.
 /// </summary>
 [OpenXmlProperty(nameof(DXW.TableBorders.BottomBorder))]
 public Border? BottomBorder { get => _BottomBorder; set => UpdateField(ref _BottomBorder, value, nameof(BottomBorder)); }
 private Border? _BottomBorder;

 /// <summary>
 /// Table right border, specifying the style and appearance of the right edge of the table.
 /// </summary>
 [OpenXmlProperty(nameof(DXW.TableBorders.RightBorder))]
 public Border? RightBorder { get => _RightBorder; set => UpdateField(ref _RightBorder, value, nameof(RightBorder)); }
 private Border? _RightBorder;

 /// <summary>
 /// End border, specifying the style and appearance of the ending edge of the table (contextual to document direction).
 /// </summary>
 [OpenXmlProperty(nameof(DXW.TableBorders.EndBorder))]
 public Border? EndBorder { get => _EndBorder; set => UpdateField(ref _EndBorder, value, nameof(EndBorder)); }
 private Border? _EndBorder;

 /// <summary>
 /// Table inside horizontal edges border, specifying the style and appearance of horizontal lines between rows.
 /// </summary>
 [OpenXmlProperty(nameof(DXW.TableBorders.InsideHorizontalBorder))]
 public Border? InsideHorizontalBorder { get => _InsideHorizontalBorder; set => UpdateField(ref _InsideHorizontalBorder, value, nameof(InsideHorizontalBorder)); }
 private Border? _InsideHorizontalBorder;

 /// <summary>
 /// Table inside vertical edges border, specifying the style and appearance of vertical lines between columns.
 /// </summary>
 [OpenXmlProperty(nameof(DXW.TableBorders.InsideVerticalBorder))]
 public Border? InsideVerticalBorder { get => _InsideVerticalBorder; set => UpdateField(ref _InsideVerticalBorder, value, nameof(InsideVerticalBorder)); }
 private Border? _InsideVerticalBorder;
}