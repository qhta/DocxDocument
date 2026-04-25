namespace DocumentModel.Wordprocessing;
/// <summary>
/// Represents a set of borders for an HTML div element in a Wordprocessing document.
/// This class provides properties for configuring the top, left, bottom, and right borders, enabling advanced formatting and appearance control for HTML div elements.
/// </summary>
[OpenXmlType(typeof(DXW.DivBorder))]
[XmlRoot("DivBorders", Namespace = "DocumentModel.Wordprocessing")]
public partial class DivBorders : ModelElement<DXW.DivBorder>
{
 /// <summary>
 /// Top border for the HTML div, specifying the style and appearance of the top edge.
 /// </summary>
 [OpenXmlProperty(nameof(DXW.DivBorder.TopBorder))]
 public Border? TopBorder { get => _TopBorder; set => UpdateField(ref _TopBorder, value, nameof(TopBorder)); }
 private Border? _TopBorder;

 /// <summary>
 /// Left border for the HTML div, specifying the style and appearance of the left edge.
 /// </summary>
 [OpenXmlProperty(nameof(DXW.DivBorder.LeftBorder))]
 public Border? LeftBorder { get => _LeftBorder; set => UpdateField(ref _LeftBorder, value, nameof(LeftBorder)); }
 private Border? _LeftBorder;

 /// <summary>
 /// Bottom border for the HTML div, specifying the style and appearance of the bottom edge.
 /// </summary>
 [OpenXmlProperty(nameof(DXW.DivBorder.BottomBorder))]
 public Border? BottomBorder { get => _BottomBorder; set => UpdateField(ref _BottomBorder, value, nameof(BottomBorder)); }
 private Border? _BottomBorder;

 /// <summary>
 /// Right border for the HTML div, specifying the style and appearance of the right edge.
 /// </summary>
 [OpenXmlProperty(nameof(DXW.DivBorder.RightBorder))]
 public Border? RightBorder { get => _RightBorder; set => UpdateField(ref _RightBorder, value, nameof(RightBorder)); }
 private Border? _RightBorder;
}