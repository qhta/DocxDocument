namespace DocumentModel.Drawings;
/// <summary>
///   Represents a 2D transformation for grouped objects, including rotation, flipping, offset, extents, and child transformation settings.
/// </summary>
[OpenXmlType(typeof(DXD.TransformGroup))]
public partial class TransformGroup : ModelElement<DXD.TransformGroup>
{
 /// <summary>
 ///   Rotation angle for the group transformation.
 /// </summary>
 [OpenXmlProperty(nameof(DXD.TransformGroup.Rotation))]
 public Int32? Rotation { get => _Rotation; set => UpdateField(ref _Rotation, value, nameof(Rotation)); }

 private Int32? _Rotation;
 /// <summary>
 ///   Indicates whether the group is flipped horizontally.
 /// </summary>
 [OpenXmlProperty(nameof(DXD.TransformGroup.HorizontalFlip))]
 public bool? HorizontalFlip { get => _HorizontalFlip; set => UpdateField(ref _HorizontalFlip, value, nameof(HorizontalFlip)); }

 private bool? _HorizontalFlip;
 /// <summary>
 ///   Indicates whether the group is flipped vertically.
 /// </summary>
 [OpenXmlProperty(nameof(DXD.TransformGroup.VerticalFlip))]
 public bool? VerticalFlip { get => _VerticalFlip; set => UpdateField(ref _VerticalFlip, value, nameof(VerticalFlip)); }

 private bool? _VerticalFlip;
 /// <summary>
 ///   Offset point for the group transformation.
 /// </summary>
 [OpenXmlProperty(nameof(DXD.TransformGroup.Offset))]
 public Point2DType? Offset { get => _Offset; set => UpdateField(ref _Offset, value, nameof(Offset)); }

 private Point2DType? _Offset;
 /// <summary>
 ///   Extents (width and height) for the group transformation.
 /// </summary>
 [OpenXmlProperty(nameof(DXD.TransformGroup.Extents))]
 public PositiveSize2DType? Extents { get => _Extents; set => UpdateField(ref _Extents, value, nameof(Extents)); }

 private PositiveSize2DType? _Extents;
 /// <summary>
 ///   Offset point for child elements within the group.
 /// </summary>
 [OpenXmlProperty(nameof(DXD.TransformGroup.ChildOffset))]
 public Point2DType? ChildOffset { get => _ChildOffset; set => UpdateField(ref _ChildOffset, value, nameof(ChildOffset)); }

 private Point2DType? _ChildOffset;
 /// <summary>
 ///   Extents (width and height) for child elements within the group.
 /// </summary>
 [OpenXmlProperty(nameof(DXD.TransformGroup.ChildExtents))]
 public PositiveSize2DType? ChildExtents { get => _ChildExtents; set => UpdateField(ref _ChildExtents, value, nameof(ChildExtents)); }

 private PositiveSize2DType? _ChildExtents;
}