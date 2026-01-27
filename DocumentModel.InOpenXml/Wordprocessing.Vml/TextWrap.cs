namespace DocumentModel.Wordprocessing.Vml;
/// <summary>
/// Defines text wrapping behavior for VML shapes in a Wordprocessing document.
/// This class specifies how text flows around shapes, including wrapping type, side, and positioning anchors.
/// </summary>
[OpenXmlType(typeof(DXVW.TextWrap))]
public partial class TextWrap : ModelElement<DXVW.TextWrap>
{
 /// <summary>
 /// The wrapping type applied to the shape, determining how text interacts with the object (e.g., square, tight, through).
 /// </summary>
 public WrapKind? Type { get => _Type; set => UpdateField(ref _Type, value, nameof(Type)); }

 private WrapKind? _Type;
 /// <summary>
 /// The side of the shape where text wrapping occurs, specifying whether text wraps on both, left, or right sides.
 /// </summary>
 public WrapSideKind? Side { get => _Side; set => UpdateField(ref _Side, value, nameof(Side)); }

 private WrapSideKind? _Side;
 /// <summary>
 /// The horizontal positioning anchor for the wrapped shape, indicating the reference point for horizontal alignment.
 /// </summary>
 public HorizontalAnchorKind? AnchorX { get => _AnchorX; set => UpdateField(ref _AnchorX, value, nameof(AnchorX)); }

 private HorizontalAnchorKind? _AnchorX;
 /// <summary>
 /// The vertical positioning anchor for the wrapped shape, indicating the reference point for vertical alignment.
 /// </summary>
 public VerticalAnchorKind? AnchorY { get => _AnchorY; set => UpdateField(ref _AnchorY, value, nameof(AnchorY)); }

 private VerticalAnchorKind? _AnchorY;
}