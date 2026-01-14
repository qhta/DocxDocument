namespace DocumentModel.Wordprocessing.Vml;

/// <summary>
/// Defines text wrapping behavior for VML shapes in a Wordprocessing document.
/// This interface specifies how text flows around shapes, including wrapping type, side, and positioning anchors.
/// </summary>
public class TextWrap: ModelElement
{
    /// <summary>
    /// The wrapping type applied to the shape, determining how text interacts with the object (e.g., square, tight, through).
    /// </summary>
    public WrapKind? Type { get; set; }
    /// <summary>
    /// The side of the shape where text wrapping occurs, specifying whether text wraps on both, left, or right sides.
    /// </summary>
    public WrapSideKind? Side { get; set; }
    /// <summary>
    /// The horizontal positioning anchor for the wrapped shape, indicating the reference point for horizontal alignment.
    /// </summary>
    public HorizontalAnchorKind? AnchorX { get; set; }
    /// <summary>
    /// The vertical positioning anchor for the wrapped shape, indicating the reference point for vertical alignment.
    /// </summary>
    public VerticalAnchorKind? AnchorY { get; set; }
}