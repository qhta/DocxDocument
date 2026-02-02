namespace DocumentModel.Drawings;
/// <summary>
/// Represents the properties of a text body in a drawing, including layout, overflow, wrapping, insets, columns, anchoring, and 3D effects.
/// </summary>
public partial class BodyProperties : ModelElement, IExtendableElement
{
    /// <summary>
    /// Rotation of the text body.
    /// </summary>
    public Int32? Rotation { get => _Rotation; set => UpdateField(ref _Rotation, value, nameof(Rotation)); }

    private Int32? _Rotation;
    /// <summary>
    /// Gets or sets a value indicating whether paragraph spacing is used.
    /// </summary>
    public bool? UseParagraphSpacing { get => _UseParagraphSpacing; set => UpdateField(ref _UseParagraphSpacing, value, nameof(UseParagraphSpacing)); }

    private bool? _UseParagraphSpacing;
    /// <summary>
    /// Vertical overflow behavior for text.
    /// </summary>
    public TextVerticalOverflow? VerticalOverflow { get => _VerticalOverflow; set => UpdateField(ref _VerticalOverflow, value, nameof(VerticalOverflow)); }

    private TextVerticalOverflow? _VerticalOverflow;
    /// <summary>
    /// Horizontal overflow behavior for text.
    /// </summary>
    public TextHorizontalOverflow? HorizontalOverflow { get => _HorizontalOverflow; set => UpdateField(ref _HorizontalOverflow, value, nameof(HorizontalOverflow)); }

    private TextHorizontalOverflow? _HorizontalOverflow;
    /// <summary>
    /// Vertical text orientation.
    /// </summary>
    public TextVertical? Vertical { get => _Vertical; set => UpdateField(ref _Vertical, value, nameof(Vertical)); }

    private TextVertical? _Vertical;
    /// <summary>
    /// Text wrapping type.
    /// </summary>
    public DMW.TextWrapping? Wrap { get => _Wrap; set => UpdateField(ref _Wrap, value, nameof(Wrap)); }

    private DMW.TextWrapping? _Wrap;
    /// <summary>
    /// Left inset of the text body.
    /// </summary>
    public Int32? LeftInset { get => _LeftInset; set => UpdateField(ref _LeftInset, value, nameof(LeftInset)); }

    private Int32? _LeftInset;
    /// <summary>
    /// Top inset of the text body.
    /// </summary>
    public Int32? TopInset { get => _TopInset; set => UpdateField(ref _TopInset, value, nameof(TopInset)); }

    private Int32? _TopInset;
    /// <summary>
    /// Right inset of the text body.
    /// </summary>
    public Int32? RightInset { get => _RightInset; set => UpdateField(ref _RightInset, value, nameof(RightInset)); }

    private Int32? _RightInset;
    /// <summary>
    /// Bottom inset of the text body.
    /// </summary>
    public Int32? BottomInset { get => _BottomInset; set => UpdateField(ref _BottomInset, value, nameof(BottomInset)); }

    private Int32? _BottomInset;
    /// <summary>
    /// Number of columns in the text body.
    /// </summary>
    public Int32? ColumnCount { get => _ColumnCount; set => UpdateField(ref _ColumnCount, value, nameof(ColumnCount)); }

    private Int32? _ColumnCount;
    /// <summary>
    /// Space between columns.
    /// </summary>
    public Int32? ColumnSpacing { get => _ColumnSpacing; set => UpdateField(ref _ColumnSpacing, value, nameof(ColumnSpacing)); }

    private Int32? _ColumnSpacing;
    /// <summary>
    /// Gets or sets a value indicating whether columns are right-to-left.
    /// </summary>
    public bool? RightToLeftColumns { get => _RightToLeftColumns; set => UpdateField(ref _RightToLeftColumns, value, nameof(RightToLeftColumns)); }

    private bool? _RightToLeftColumns;
    /// <summary>
    /// Gets or sets a value indicating whether the text body is from WordArt.
    /// </summary>
    public bool? FromWordArt { get => _FromWordArt; set => UpdateField(ref _FromWordArt, value, nameof(FromWordArt)); }

    private bool? _FromWordArt;
    /// <summary>
    /// Text anchor type.
    /// </summary>
    public TextAnchoring? Anchor { get => _Anchor; set => UpdateField(ref _Anchor, value, nameof(Anchor)); }

    private TextAnchoring? _Anchor;
    /// <summary>
    /// Gets or sets a value indicating whether the anchor is centered.
    /// </summary>
    public bool? AnchorCenter { get => _AnchorCenter; set => UpdateField(ref _AnchorCenter, value, nameof(AnchorCenter)); }

    private bool? _AnchorCenter;
    /// <summary>
    /// Gets or sets a value indicating whether anti-aliasing is forced.
    /// </summary>
    public bool? ForceAntiAlias { get => _ForceAntiAlias; set => UpdateField(ref _ForceAntiAlias, value, nameof(ForceAntiAlias)); }

    private bool? _ForceAntiAlias;
    /// <summary>
    /// Gets or sets a value indicating whether the text is upright.
    /// </summary>
    public bool? UpRight { get => _UpRight; set => UpdateField(ref _UpRight, value, nameof(UpRight)); }

    private bool? _UpRight;
    /// <summary>
    /// Gets or sets a value indicating whether compatible line spacing is used.
    /// </summary>
    public bool? CompatibleLineSpacing { get => _CompatibleLineSpacing; set => UpdateField(ref _CompatibleLineSpacing, value, nameof(CompatibleLineSpacing)); }

    private bool? _CompatibleLineSpacing;
    /// <summary>
    /// Preset text wrap type.
    /// </summary>
    public PresetTextWrap? PresetTextWrap { get => _PresetTextWrap; set => UpdateField(ref _PresetTextWrap, value, nameof(PresetTextWrap)); }

    private PresetTextWrap? _PresetTextWrap;
    /// <summary>
    /// Gets or sets a value indicating whether auto-fit is disabled.
    /// </summary>
    public bool? NoAutoFit { get => _NoAutoFit; set => UpdateField(ref _NoAutoFit, value, nameof(NoAutoFit)); }

    private bool? _NoAutoFit;
    /// <summary>
    /// Normal auto-fit settings.
    /// </summary>
    public NormalAutoFit? NormalAutoFit { get => _NormalAutoFit; set => UpdateField(ref _NormalAutoFit, value, nameof(NormalAutoFit)); }

    private NormalAutoFit? _NormalAutoFit;
    /// <summary>
    /// Gets or sets a value indicating whether shape auto-fit is enabled.
    /// </summary>
    public bool? ShapeAutoFit { get => _ShapeAutoFit; set => UpdateField(ref _ShapeAutoFit, value, nameof(ShapeAutoFit)); }

    private bool? _ShapeAutoFit;
    /// <summary>
    /// Gets or sets the 3D scene type for the text body.
    /// </summary>
    public Scene3DType? Scene3DType { get => _Scene3DType; set => UpdateField(ref _Scene3DType, value, nameof(Scene3DType)); }

    private Scene3DType? _Scene3DType;
    /// <summary>
    /// Gets or sets the 3D shape type for the text body.
    /// </summary>
    public Shape3DType? Shape3DType { get => _Shape3DType; set => UpdateField(ref _Shape3DType, value, nameof(Shape3DType)); }

    private Shape3DType? _Shape3DType;
    /// <summary>
    /// Flat text properties.
    /// </summary>
    public FlatText? FlatText { get => _FlatText; set => UpdateField(ref _FlatText, value, nameof(FlatText)); }

    private FlatText? _FlatText;
    /// <summary>
    /// List of extensions for additional properties.
    /// </summary>
    public ExtensionList? ExtensionList { get => _ExtensionList; set => UpdateField(ref _ExtensionList, value, nameof(ExtensionList)); }

    private ExtensionList? _ExtensionList;
}