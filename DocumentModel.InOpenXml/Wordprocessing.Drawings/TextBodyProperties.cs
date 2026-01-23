using DocumentModel.Drawings;

namespace DocumentModel.Wordprocessing.Drawings;
/// <summary>
/// Represents the set of properties for a text body within a shape in a Wordprocessing document.
/// This class provides configuration for text layout, rotation, paragraph spacing, overflow behavior, insets, columns, anchoring, auto-fit, 3D settings, and extension data.
/// </summary>
public partial class TextBodyProperties : ModelElement
{
    /// <summary>
    /// The rotation angle applied to the text body, specified in degrees.
    /// </summary>
    public Int32? Rotation { get => _Rotation; set => UpdateField(ref _Rotation, value, nameof(Rotation)); }

    private Int32? _Rotation;
    /// <summary>
    /// Indicates whether paragraph spacing is used for the text body.
    /// </summary>
    public bool? UseParagraphSpacing { get; set; }
    /// <summary>
    /// Specifies the vertical overflow behavior for the text body, such as clipping or overflowing text.
    /// </summary>
    public TextVerticalOverflowKind? VerticalOverflow { get; set; }
    /// <summary>
    /// Specifies the horizontal overflow behavior for the text body, such as clipping or overflowing text.
    /// </summary>
    public TextHorizontalOverflowKind? HorizontalOverflow { get; set; }
    /// <summary>
    /// The vertical text orientation for the text body, such as horizontal, vertical, or stacked.
    /// </summary>
    public TextVerticalKind? Vertical { get; set; }
    /// <summary>
    /// The type of text wrapping applied to the text body, controlling how text flows within the shape.
    /// </summary>
    public TextWrappingKind? Wrap { get; set; }
    /// <summary>
    /// The left inset distance for the text body, specifying padding from the left edge.
    /// </summary>
    public Int32? LeftInset { get; set; }
    /// <summary>
    /// The top inset distance for the text body, specifying padding from the top edge.
    /// </summary>
    public Int32? TopInset { get; set; }
    /// <summary>
    /// The right inset distance for the text body, specifying padding from the right edge.
    /// </summary>
    public Int32? RightInset { get; set; }
    /// <summary>
    /// The bottom inset distance for the text body, specifying padding from the bottom edge.
    /// </summary>
    public Int32? BottomInset { get; set; }
    /// <summary>
    /// The number of columns used in the text body layout.
    /// </summary>
    public Int32? ColumnCount { get; set; }
    /// <summary>
    /// The spacing between columns in the text body layout.
    /// </summary>
    public Int32? ColumnSpacing { get; set; }
    /// <summary>
    /// Indicates whether columns are arranged right-to-left in the text body.
    /// </summary>
    public bool? RightToLeftColumns { get; set; }
    /// <summary>
    /// Indicates whether the text body originates from WordArt formatting.
    /// </summary>
    public bool? FromWordArt { get; set; }
    /// <summary>
    /// The anchoring type for the text body, specifying how text is anchored within the shape.
    /// </summary>
    public TextAnchoringKind? Anchor { get; set; }
    /// <summary>
    /// Indicates whether the anchor is centered within the text body.
    /// </summary>
    public bool? AnchorCenter { get; set; }
    /// <summary>
    /// Indicates whether anti-aliasing is forced for the text body, improving text rendering quality.
    /// </summary>
    public bool? ForceAntiAlias { get; set; }
    /// <summary>
    /// Indicates whether the text is rendered upright, regardless of rotation or orientation settings.
    /// </summary>
    public bool? UpRight { get; set; }
    /// <summary>
    /// Indicates whether compatible line spacing is used for the text body.
    /// </summary>
    public bool? CompatibleLineSpacing { get; set; }
    /// <summary>
    /// Preset text wrapping settings for the text body, providing predefined wrap configurations.
    /// </summary>
    public PresetTextWrap? PresetTextWrap { get; set; }
    /// <summary>
    /// Indicates that no auto-fit is applied to the text body.
    /// </summary>
    public bool? NoAutoFit { get; set; }
    /// <summary>
    /// Normal auto-fit settings for the text body, allowing text to resize automatically to fit within the shape.
    /// </summary>
    public NormalAutoFit? NormalAutoFit { get; set; }
    /// <summary>
    /// Indicates that shape auto-fit is applied to the text body, resizing the shape to fit the text.
    /// </summary>
    public bool? ShapeAutoFit { get; set; }
    /// <summary>
    /// 3D scene settings for the text body, defining camera, lighting, and perspective.
    /// </summary>
    public Scene3DType? Scene3DType { get; set; }
    /// <summary>
    /// 3D shape settings for the text body, specifying extrusion, bevel, and contour properties.
    /// </summary>
    public Shape3DType? Shape3DType { get; set; }
    /// <summary>
    /// Flat text settings for the text body, controlling flat text rendering options.
    /// </summary>
    public FlatText? FlatText { get; set; }
    /// <summary>
    /// List of extensions for text body properties, allowing for additional metadata or custom features.
    /// </summary>
    public IExtensionList? ExtensionList { get; set; }
}