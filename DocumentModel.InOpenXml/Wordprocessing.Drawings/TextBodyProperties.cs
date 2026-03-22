using DocumentModel.Drawings;
namespace DocumentModel.Wordprocessing.Drawings;
/// <summary>
/// Represents the set of properties for a text body within a shape in a Wordprocessing document.
/// This class provides configuration for text layout, rotation, paragraph spacing, overflow behavior, insets, columns, anchoring, auto-fit, 3D settings, and extension data.
/// </summary>
[OpenXmlType(typeof(DXO10WDS.TextBodyProperties))]
public partial class TextBodyProperties : ModelElement<DXO10WDS.TextBodyProperties>
{
    /// <summary>
    /// The rotation angle applied to the text body, specified in degrees.
    /// </summary>
    public Int32? Rotation { get => _Rotation; set => UpdateField(ref _Rotation, value, nameof(Rotation)); }
    private Int32? _Rotation;
    /// <summary>
    /// Indicates whether paragraph spacing is used for the text body.
    /// </summary>
    public bool? UseParagraphSpacing { get => _UseParagraphSpacing; set => UpdateField(ref _UseParagraphSpacing, value, nameof(UseParagraphSpacing)); }
    private bool? _UseParagraphSpacing;
    /// <summary>
    /// Specifies the vertical overflow behavior for the text body, such as clipping or overflowing text.
    /// </summary>
    public TextVerticalOverflow? VerticalOverflow { get => _VerticalOverflow; set => UpdateField(ref _VerticalOverflow, value, nameof(VerticalOverflow)); }
    private TextVerticalOverflow? _VerticalOverflow;
    /// <summary>
    /// Specifies the horizontal overflow behavior for the text body, such as clipping or overflowing text.
    /// </summary>
    public TextHorizontalOverflow? HorizontalOverflow { get => _HorizontalOverflow; set => UpdateField(ref _HorizontalOverflow, value, nameof(HorizontalOverflow)); }
    private TextHorizontalOverflow? _HorizontalOverflow;
    /// <summary>
    /// The vertical text orientation for the text body, such as horizontal, vertical, or stacked.
    /// </summary>
    public TextVertical? Vertical { get => _Vertical; set => UpdateField(ref _Vertical, value, nameof(Vertical)); }
    private TextVertical? _Vertical;
    /// <summary>
    /// The type of text wrapping applied to the text body, controlling how text flows within the shape.
    /// </summary>
    public TextWrapping? Wrap { get => _Wrap; set => UpdateField(ref _Wrap, value, nameof(Wrap)); }
    private TextWrapping? _Wrap;
    /// <summary>
    /// The left inset distance for the text body, specifying padding from the left edge.
    /// </summary>
    public Int32? LeftInset { get => _LeftInset; set => UpdateField(ref _LeftInset, value, nameof(LeftInset)); }
    private Int32? _LeftInset;
    /// <summary>
    /// The top inset distance for the text body, specifying padding from the top edge.
    /// </summary>
    public Int32? TopInset { get => _TopInset; set => UpdateField(ref _TopInset, value, nameof(TopInset)); }
    private Int32? _TopInset;
    /// <summary>
    /// The right inset distance for the text body, specifying padding from the right edge.
    /// </summary>
    public Int32? RightInset { get => _RightInset; set => UpdateField(ref _RightInset, value, nameof(RightInset)); }
    private Int32? _RightInset;
    /// <summary>
    /// The bottom inset distance for the text body, specifying padding from the bottom edge.
    /// </summary>
    public Int32? BottomInset { get => _BottomInset; set => UpdateField(ref _BottomInset, value, nameof(BottomInset)); }
    private Int32? _BottomInset;
    /// <summary>
    /// The number of columns used in the text body layout.
    /// </summary>
    public Int32? ColumnCount { get => _ColumnCount; set => UpdateField(ref _ColumnCount, value, nameof(ColumnCount)); }
    private Int32? _ColumnCount;
    /// <summary>
    /// The spacing between columns in the text body layout.
    /// </summary>
    public Int32? ColumnSpacing { get => _ColumnSpacing; set => UpdateField(ref _ColumnSpacing, value, nameof(ColumnSpacing)); }
    private Int32? _ColumnSpacing;
    /// <summary>
    /// Indicates whether columns are arranged right-to-left in the text body.
    /// </summary>
    public bool? RightToLeftColumns { get => _RightToLeftColumns; set => UpdateField(ref _RightToLeftColumns, value, nameof(RightToLeftColumns)); }
    private bool? _RightToLeftColumns;
    /// <summary>
    /// Indicates whether the text body originates from WordArt formatting.
    /// </summary>
    public bool? FromWordArt { get => _FromWordArt; set => UpdateField(ref _FromWordArt, value, nameof(FromWordArt)); }
    private bool? _FromWordArt;
    /// <summary>
    /// The anchoring type for the text body, specifying how text is anchored within the shape.
    /// </summary>
    public TextAnchoring? Anchor { get => _Anchor; set => UpdateField(ref _Anchor, value, nameof(Anchor)); }
    private TextAnchoring? _Anchor;
    /// <summary>
    /// Indicates whether the anchor is centered within the text body.
    /// </summary>
    public bool? AnchorCenter { get => _AnchorCenter; set => UpdateField(ref _AnchorCenter, value, nameof(AnchorCenter)); }
    private bool? _AnchorCenter;
    /// <summary>
    /// Indicates whether anti-aliasing is forced for the text body, improving text rendering quality.
    /// </summary>
    public bool? ForceAntiAlias { get => _ForceAntiAlias; set => UpdateField(ref _ForceAntiAlias, value, nameof(ForceAntiAlias)); }
    private bool? _ForceAntiAlias;
    /// <summary>
    /// Indicates whether the text is rendered upright, regardless of rotation or orientation settings.
    /// </summary>
    public bool? UpRight { get => _UpRight; set => UpdateField(ref _UpRight, value, nameof(UpRight)); }
    private bool? _UpRight;
    /// <summary>
    /// Indicates whether compatible line spacing is used for the text body.
    /// </summary>
    public bool? CompatibleLineSpacing { get => _CompatibleLineSpacing; set => UpdateField(ref _CompatibleLineSpacing, value, nameof(CompatibleLineSpacing)); }
    private bool? _CompatibleLineSpacing;
    /// <summary>
    /// Preset text wrapping settings for the text body, providing predefined wrap configurations.
    /// </summary>
    public PresetTextWrap? PresetTextWrap { get => _PresetTextWrap; set => UpdateField(ref _PresetTextWrap, value, nameof(PresetTextWrap)); }
    private PresetTextWrap? _PresetTextWrap;
    /// <summary>
    /// Indicates that no auto-fit is applied to the text body.
    /// </summary>
    public bool? NoAutoFit { get => _NoAutoFit; set => UpdateField(ref _NoAutoFit, value, nameof(NoAutoFit)); }
    private bool? _NoAutoFit;
    /// <summary>
    /// Normal auto-fit settings for the text body, allowing text to resize automatically to fit within the shape.
    /// </summary>
    public NormalAutoFit? NormalAutoFit { get => _NormalAutoFit; set => UpdateField(ref _NormalAutoFit, value, nameof(NormalAutoFit)); }
    private NormalAutoFit? _NormalAutoFit;
    /// <summary>
    /// Indicates that shape auto-fit is applied to the text body, resizing the shape to fit the text.
    /// </summary>
    public bool? ShapeAutoFit { get => _ShapeAutoFit; set => UpdateField(ref _ShapeAutoFit, value, nameof(ShapeAutoFit)); }
    private bool? _ShapeAutoFit;
    /// <summary>
    /// 3D scene settings for the text body, defining camera, lighting, and perspective.
    /// </summary>
    public Scene3DType? Scene3DType { get => _Scene3DType; set => UpdateField(ref _Scene3DType, value, nameof(Scene3DType)); }
    private Scene3DType? _Scene3DType;
    /// <summary>
    /// 3D shape settings for the text body, specifying extrusion, bevel, and contour properties.
    /// </summary>
    public Shape3DType? Shape3DType { get => _Shape3DType; set => UpdateField(ref _Shape3DType, value, nameof(Shape3DType)); }
    private Shape3DType? _Shape3DType;
    /// <summary>
    /// Flat text settings for the text body, controlling flat text rendering options.
    /// </summary>
    public FlatText? FlatText { get => _FlatText; set => UpdateField(ref _FlatText, value, nameof(FlatText)); }
    private FlatText? _FlatText;
    /// <summary>
    /// List of extensions for text body properties, allowing for additional metadata or custom features.
    /// </summary>
    public IExtensionList? ExtensionList { get => _ExtensionList; set => UpdateField(ref _ExtensionList, value, nameof(ExtensionList)); }
    private IExtensionList? _ExtensionList;
}