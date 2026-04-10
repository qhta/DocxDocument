namespace DocumentModel.Drawings;
/// <summary>
///   Represents a rectangle defined by relative offsets for each side, used for specifying areas within a parent element.
/// </summary>
[OpenXmlType(typeof(DXD.RelativeRectangleType))]
[XmlRoot("RelativeRectangleType", Namespace = "DocumentModel.Drawings")]
public partial class RelativeRectangleType : ModelElement<DXD.RelativeRectangleType>
{
 /// <summary>
 ///   Left offset of the rectangle.
 /// </summary>
 public Int32? Left { get => _Left; set => UpdateField(ref _Left, value, nameof(Left)); }

 private Int32? _Left;
 /// <summary>
 ///   Top offset of the rectangle.
 /// </summary>
 public Int32? Top { get => _Top; set => UpdateField(ref _Top, value, nameof(Top)); }

 private Int32? _Top;
 /// <summary>
 ///   Right offset of the rectangle.
 /// </summary>
 public Int32? Right { get => _Right; set => UpdateField(ref _Right, value, nameof(Right)); }

 private Int32? _Right;
 /// <summary>
 ///   Bottom offset of the rectangle.
 /// </summary>
 public Int32? Bottom { get => _Bottom; set => UpdateField(ref _Bottom, value, nameof(Bottom)); }

 private Int32? _Bottom;
}