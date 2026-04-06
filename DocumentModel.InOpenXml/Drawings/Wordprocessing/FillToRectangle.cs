namespace DocumentModel.Drawings;
/// <summary>
/// Represents the rectangle area to which a fill is applied in a Wordprocessing drawing element.
/// This class provides properties for specifying the left, top, right, and bottom boundaries of the fill area, allowing precise control over the fill's position and dimensions within the drawing.
/// </summary>
[OpenXmlType(typeof(DXD.FillToRectangle))]
public partial class FillToRectangle : ModelElement<DXD.FillToRectangle>
{
 /// <summary>
 /// The left boundary of the fill rectangle, representing the distance from the left edge of the drawing element.
 /// </summary>
 [OpenXmlProperty(nameof(DXD.FillToRectangle.Left))]
 public Int32? Left { get => _Left; set => UpdateField(ref _Left, value, nameof(Left)); }
 private Int32? _Left;
 /// <summary>
 /// The top boundary of the fill rectangle, representing the distance from the top edge of the drawing element.
 /// </summary>
 [OpenXmlProperty(nameof(DXD.FillToRectangle.Top))]
 public Int32? Top { get => _Top; set => UpdateField(ref _Top, value, nameof(Top)); }
 private Int32? _Top;
 /// <summary>
 /// The right boundary of the fill rectangle, representing the distance from the right edge of the drawing element.
 /// </summary>
 [OpenXmlProperty(nameof(DXD.FillToRectangle.Right))]
 public Int32? Right { get => _Right; set => UpdateField(ref _Right, value, nameof(Right)); }
 private Int32? _Right;
 /// <summary>
 /// The bottom boundary of the fill rectangle, representing the distance from the bottom edge of the drawing element.
 /// </summary>
 [OpenXmlProperty(nameof(DXD.FillToRectangle.Bottom))]
 public Int32? Bottom { get => _Bottom; set => UpdateField(ref _Bottom, value, nameof(Bottom)); }
 private Int32? _Bottom;
}