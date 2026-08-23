namespace DocumentModel.Drawings.ChartsStyle;

/// <summary>
/// Describes the properties for formatting and layout of text bodies in chart elements, including rotation, overflow, insets, columns, anchoring, and 3D effects.
/// </summary>
[OpenXmlType(typeof(DXO13DCS.TextBodyProperties))]
[DataContract]
[XmlRoot("TextBodyProperties", Namespace = "DocumentModel.Drawings.ChartsStyle")]
public partial class TextBodyProperties: ModelElement<DXO13DCS.TextBodyProperties>
{
  /// <summary>
  /// Rotation angle applied to the text body.
  /// </summary>
  [OpenXmlProperty(nameof(DXO13DCS.TextBodyProperties.Rotation))]
  public Int32? Rotation
  {
    get => _Rotation ??= GetProperty<Int32?>(GetUpdatableElement()?.Rotation);
    set => UpdateField(ref _Rotation, value, nameof(Rotation));
  }

  private Int32? _Rotation;

  /// <summary>
  /// Indicates whether paragraph spacing is used between paragraphs.
  /// </summary>
  [OpenXmlProperty(nameof(DXO13DCS.TextBodyProperties.UseParagraphSpacing))]
  public bool? UseParagraphSpacing
  {
    get => _UseParagraphSpacing ??= GetProperty<bool?>(GetUpdatableElement()?.UseParagraphSpacing);
    set => UpdateField(ref _UseParagraphSpacing, value, nameof(UseParagraphSpacing));
  }

  private bool? _UseParagraphSpacing;

  /// <summary>
  /// Vertical overflow behavior for text that exceeds the text box height.
  /// </summary>
  [OpenXmlProperty(nameof(DXO13DCS.TextBodyProperties.VerticalOverflow))]
  public TextVerticalOverflow? VerticalOverflow
  {
    get => _VerticalOverflow ??= GetProperty<TextVerticalOverflow?>(GetUpdatableElement()?.VerticalOverflow);
    set => UpdateField(ref _VerticalOverflow, value, nameof(VerticalOverflow));
  }

  private TextVerticalOverflow? _VerticalOverflow;

  /// <summary>
  /// Horizontal overflow behavior for text that exceeds the text box width.
  /// </summary>
  [OpenXmlProperty(nameof(DXO13DCS.TextBodyProperties.HorizontalOverflow))]
  public TextHorizontalOverflow? HorizontalOverflow
  {
    get => _HorizontalOverflow ??= GetProperty<TextHorizontalOverflow?>(GetUpdatableElement()?.HorizontalOverflow);
    set => UpdateField(ref _HorizontalOverflow, value, nameof(HorizontalOverflow));
  }

  private TextHorizontalOverflow? _HorizontalOverflow;

  /// <summary>
  /// Vertical text orientation setting.
  /// </summary>
  [OpenXmlProperty(nameof(DXO13DCS.TextBodyProperties.Vertical))]
  public TextVertical? Vertical
  {
    get => _Vertical ??= GetProperty<TextVertical?>(GetUpdatableElement()?.Vertical);
    set => UpdateField(ref _Vertical, value, nameof(Vertical));
  }

  private TextVertical? _Vertical;

  /// <summary>
  /// Wrapping type for text within the text body.
  /// </summary>
  [OpenXmlProperty(nameof(DXO13DCS.TextBodyProperties.Wrap))]
  public DMW.TextWrapping? Wrap
  {
    get => _Wrap ??= GetProperty<DMW.TextWrapping?>(GetUpdatableElement()?.Wrap);
    set => UpdateField(ref _Wrap, value, nameof(Wrap));
  }

  private DMW.TextWrapping? _Wrap;

  /// <summary>
  /// Left inset distance between the text and the text box edge.
  /// </summary>
  [OpenXmlProperty(nameof(DXO13DCS.TextBodyProperties.LeftInset))]
  public Int32? LeftInset
  {
    get => _LeftInset ??= GetProperty<Int32?>(GetUpdatableElement()?.LeftInset);
    set => UpdateField(ref _LeftInset, value, nameof(LeftInset));
  }

  private Int32? _LeftInset;

  /// <summary>
  /// Top inset distance between the text and the text box edge.
  /// </summary>
  [OpenXmlProperty(nameof(DXO13DCS.TextBodyProperties.TopInset))]
  public Int32? TopInset
  {
    get => _TopInset ??= GetProperty<Int32?>(GetUpdatableElement()?.TopInset);
    set => UpdateField(ref _TopInset, value, nameof(TopInset));
  }

  private Int32? _TopInset;

  /// <summary>
  /// Right inset distance between the text and the text box edge.
  /// </summary>
  [OpenXmlProperty(nameof(DXO13DCS.TextBodyProperties.RightInset))]
  public Int32? RightInset
  {
    get => _RightInset ??= GetProperty<Int32?>(GetUpdatableElement()?.RightInset);
    set => UpdateField(ref _RightInset, value, nameof(RightInset));
  }

  private Int32? _RightInset;

  /// <summary>
  /// Bottom inset distance between the text and the text box edge.
  /// </summary>
  [OpenXmlProperty(nameof(DXO13DCS.TextBodyProperties.BottomInset))]
  public Int32? BottomInset
  {
    get => _BottomInset ??= GetProperty<Int32?>(GetUpdatableElement()?.BottomInset);
    set => UpdateField(ref _BottomInset, value, nameof(BottomInset));
  }

  private Int32? _BottomInset;

  /// <summary>
  /// Number of columns in the text body.
  /// </summary>
  [OpenXmlProperty(nameof(DXO13DCS.TextBodyProperties.ColumnCount))]
  public Int32? ColumnCount
  {
    get => _ColumnCount ??= GetProperty<Int32?>(GetUpdatableElement()?.ColumnCount);
    set => UpdateField(ref _ColumnCount, value, nameof(ColumnCount));
  }

  private Int32? _ColumnCount;

  /// <summary>
  /// Space between columns in the text body.
  /// </summary>
  [OpenXmlProperty(nameof(DXO13DCS.TextBodyProperties.ColumnSpacing))]
  public Int32? ColumnSpacing
  {
    get => _ColumnSpacing ??= GetProperty<Int32?>(GetUpdatableElement()?.ColumnSpacing);
    set => UpdateField(ref _ColumnSpacing, value, nameof(ColumnSpacing));
  }

  private Int32? _ColumnSpacing;

  /// <summary>
  /// Indicates if columns are arranged right-to-left.
  /// </summary>
  [OpenXmlProperty(nameof(DXO13DCS.TextBodyProperties.RightToLeftColumns))]
  public bool? RightToLeftColumns
  {
    get => _RightToLeftColumns ??= GetProperty<bool?>(GetUpdatableElement()?.RightToLeftColumns);
    set => UpdateField(ref _RightToLeftColumns, value, nameof(RightToLeftColumns));
  }

  private bool? _RightToLeftColumns;

  /// <summary>
  /// Indicates if the text body is derived from WordArt.
  /// </summary>
  [OpenXmlProperty(nameof(DXO13DCS.TextBodyProperties.FromWordArt))]
  public bool? FromWordArt
  {
    get => _FromWordArt ??= GetProperty<bool?>(GetUpdatableElement()?.FromWordArt);
    set => UpdateField(ref _FromWordArt, value, nameof(FromWordArt));
  }

  private bool? _FromWordArt;

  /// <summary>
  /// Anchoring type for the text body within the shape.
  /// </summary>
  [OpenXmlProperty(nameof(DXO13DCS.TextBodyProperties.Anchor))]
  public TextAnchoring? Anchor
  {
    get => _Anchor ??= GetProperty<TextAnchoring?>(GetUpdatableElement()?.Anchor);
    set => UpdateField(ref _Anchor, value, nameof(Anchor));
  }

  private TextAnchoring? _Anchor;

  /// <summary>
  /// Indicates if the anchor is centered within the text body.
  /// </summary>
  [OpenXmlProperty(nameof(DXO13DCS.TextBodyProperties.AnchorCenter))]
  public bool? AnchorCenter
  {
    get => _AnchorCenter ??= GetProperty<bool?>(GetUpdatableElement()?.AnchorCenter);
    set => UpdateField(ref _AnchorCenter, value, nameof(AnchorCenter));
  }

  private bool? _AnchorCenter;

  /// <summary>
  /// Indicates if anti-aliasing is forced for the text.
  /// </summary>
  [OpenXmlProperty(nameof(DXO13DCS.TextBodyProperties.ForceAntiAlias))]
  public bool? ForceAntiAlias
  {
    get => _ForceAntiAlias ??= GetProperty<bool?>(GetUpdatableElement()?.ForceAntiAlias);
    set => UpdateField(ref _ForceAntiAlias, value, nameof(ForceAntiAlias));
  }

  private bool? _ForceAntiAlias;

  /// <summary>
  /// Indicates if the text is rendered upright.
  /// </summary>
  [OpenXmlProperty(nameof(DXO13DCS.TextBodyProperties.UpRight))]
  public bool? UpRight
  {
    get => _UpRight ??= GetProperty<bool?>(GetUpdatableElement()?.UpRight);
    set => UpdateField(ref _UpRight, value, nameof(UpRight));
  }

  private bool? _UpRight;

  /// <summary>
  /// Indicates if compatible line spacing is used.
  /// </summary>
  [OpenXmlProperty(nameof(DXO13DCS.TextBodyProperties.CompatibleLineSpacing))]
  public bool? CompatibleLineSpacing
  {
    get => _CompatibleLineSpacing ??= GetProperty<bool?>(GetUpdatableElement()?.CompatibleLineSpacing);
    set => UpdateField(ref _CompatibleLineSpacing, value, nameof(CompatibleLineSpacing));
  }

  private bool? _CompatibleLineSpacing;

  /// <summary>
  /// Preset text shape wrapping option.
  /// </summary>
  [OpenXmlElement(typeof(DXD.PresetTextWarp))]
  public PresetTextWrap? PresetTextWrap
  {
    get => _PresetTextWrap ??= GetElement<PresetTextWrap, DXD.PresetTextWarp>(GetUpdatableElement());
    set => UpdateField(ref _PresetTextWrap, value, nameof(PresetTextWrap));
  }

  private PresetTextWrap? _PresetTextWrap;

  /// <summary>
  /// Indicates if auto-fit is disabled for the text body.
  /// </summary>
  [OpenXmlElement(typeof(DXD.NoAutoFit))]
  public bool? NoAutoFit
  {
    get => _NoAutoFit ??= GetElement<bool, DXD.NoAutoFit>(GetUpdatableElement());
    set => UpdateField(ref _NoAutoFit, value, nameof(NoAutoFit));
  }

  private bool? _NoAutoFit;

  /// <summary>
  /// Normal auto-fit settings for the text body.
  /// </summary>
  [OpenXmlElement(typeof(DXD.NormalAutoFit))]
  public NormalAutoFit? NormalAutoFit
  {
    get => _NormalAutoFit ??= GetElement<NormalAutoFit, DXD.NormalAutoFit>(GetUpdatableElement());
    set => UpdateField(ref _NormalAutoFit, value, nameof(NormalAutoFit));
  }

  private NormalAutoFit? _NormalAutoFit;

  /// <summary>
  /// Indicates if shape auto-fit is enabled for the text body.
  /// </summary>
  [OpenXmlElement(typeof(DXD.ShapeAutoFit))]
  public bool? ShapeAutoFit
  {
    get => _ShapeAutoFit ??= GetElement<bool, DXD.ShapeAutoFit>(GetUpdatableElement());
    set => UpdateField(ref _ShapeAutoFit, value, nameof(ShapeAutoFit));
  }

  private bool? _ShapeAutoFit;

  /// <summary>
  /// 3D scene type applied to the text body.
  /// </summary>
  [OpenXmlElement(typeof(DXD.Scene3DType))]
  public Scene3DType? Scene3DType
  {
    get => _Scene3DType ??= GetElement<Scene3DType, DXD.Scene3DType>(GetUpdatableElement());
    set => UpdateField(ref _Scene3DType, value, nameof(Scene3DType));
  }

  private Scene3DType? _Scene3DType;

  /// <summary>
  /// 3D shape type applied to the text body.
  /// </summary>
  [OpenXmlElement(typeof(DXD.Shape3DType))]
  public Shape3DType? Shape3DType
  {
    get => _Shape3DType ??= GetElement<Shape3DType, DXD.Shape3DType>(GetUpdatableElement());
    set => UpdateField(ref _Shape3DType, value, nameof(Shape3DType));
  }

  private Shape3DType? _Shape3DType;

  /// <summary>
  /// Flat text formatting for the text body.
  /// </summary>
  [OpenXmlElement(typeof(DXD.FlatText))]
  public FlatText? FlatText
  {
    get => _FlatText ??= GetElement<FlatText, DXD.FlatText>(GetUpdatableElement());
    set => UpdateField(ref _FlatText, value, nameof(FlatText));
  }

  private FlatText? _FlatText;

  /// <summary>
  /// Extension list for additional text body properties.
  /// </summary>
  [OpenXmlElement(typeof(DXD.ExtensionList))]
  public IExtensionList? ExtensionList
  {
    get => _ExtensionList ??= GetElement<IExtensionList, DXD.ExtensionList>(GetUpdatableElement());
    set => UpdateField(ref _ExtensionList, value, nameof(ExtensionList));
  }

  private IExtensionList? _ExtensionList;
}