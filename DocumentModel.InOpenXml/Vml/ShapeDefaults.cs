namespace DocumentModel.Vml;

/// <summary>
///   New Shape Defaults.
/// </summary>
[OpenXmlType(typeof(DXVO.ShapeDefaults))]
[DataContract]
[XmlRoot("ShapeDefaults", Namespace = "DocumentModel.Vml")]
public partial class ShapeDefaults : ModelElement<DXVO.ShapeDefaults>
{
  /// <summary>
  ///   Shape ID Optional Storage
  /// </summary>
  [OpenXmlProperty(nameof(DXVO.ShapeDefaults.MaxShapeId))]
  public Int64? MaxShapeId
  {
    get => _MaxShapeId ??= GetProperty<Int64?>(GetUpdatableElement()?.MaxShapeId);
    set => UpdateField(ref _MaxShapeId, value, nameof(MaxShapeId));
  }
  private Int64? _MaxShapeId;

  /// <summary>
  ///   style
  /// </summary>
  [OpenXmlProperty(nameof(DXVO.ShapeDefaults.Style))]
  public string? Style
  {
    get => _Style ??= GetProperty<string?>(GetUpdatableElement()?.Style);
    set => UpdateField(ref _Style, value, nameof(Style));
  }
  private string? _Style;

  /// <summary>
  ///   Shape Fill Toggle
  /// </summary>
  [OpenXmlProperty(nameof(DXVO.ShapeDefaults.BeFilled))]
  public bool? BeFilled
  {
    get => _BeFilled ??= GetProperty<bool?>(GetUpdatableElement()?.BeFilled);
    set => UpdateField(ref _BeFilled, value, nameof(BeFilled));
  }
  private bool? _BeFilled;

  /// <summary>
  ///   Default Fill Color
  /// </summary>
  [OpenXmlProperty(nameof(DXVO.ShapeDefaults.FillColor))]
  public DMV.VmlColor? FillColor
  {
    get => _FillColor ??= GetProperty<DMV.VmlColor?>(GetUpdatableElement()?.FillColor);
    set => UpdateField(ref _FillColor, value, nameof(FillColor));
  }
  private DMV.VmlColor? _FillColor;

  /// <summary>
  ///   Shape Stroke Toggle
  /// </summary>
  [OpenXmlProperty(nameof(DXVO.ShapeDefaults.IsStroke))]
  public bool? IsStroke
  {
    get => _IsStroke ??= GetProperty<bool?>(GetUpdatableElement()?.IsStroke);
    set => UpdateField(ref _IsStroke, value, nameof(IsStroke));
  }
  private bool? _IsStroke;

  /// <summary>
  ///   Shape Stroke Color
  /// </summary>
  [OpenXmlProperty(nameof(DXVO.ShapeDefaults.StrokeColor))]
  public DMV.VmlColor? StrokeColor
  {
    get => _StrokeColor ??= GetProperty<DMV.VmlColor?>(GetUpdatableElement()?.StrokeColor);
    set => UpdateField(ref _StrokeColor, value, nameof(StrokeColor));
  }
  private DMV.VmlColor? _StrokeColor;

  /// <summary>
  ///   Allow in Table Cell
  /// </summary>
  [OpenXmlProperty(nameof(DXVO.ShapeDefaults.AllowInCell))]
  public bool? AllowInCell
  {
    get => _AllowInCell ??= GetProperty<bool?>(GetUpdatableElement()?.AllowInCell);
    set => UpdateField(ref _AllowInCell, value, nameof(AllowInCell));
  }
  private bool? _AllowInCell;

  /// <summary>
  ///   Allow shape overlap
  /// </summary>
  [OpenXmlProperty(nameof(DXVO.ShapeDefaults.AllowOverlap))]
  public bool? AllowOverlap
  {
    get => _AllowOverlap ??= GetProperty<bool?>(GetUpdatableElement()?.AllowOverlap);
    set => UpdateField(ref _AllowOverlap, value, nameof(AllowOverlap));
  }
  private bool? _AllowOverlap;

  /// <summary>
  ///   Type of Inset Margin
  /// </summary>
  [OpenXmlProperty(nameof(DXVO.ShapeDefaults.InsetMode))]
  public InsetMargin? InsetMode
  {
    get => _InsetMode ??= GetProperty<InsetMargin?>(GetUpdatableElement()?.InsetMode);
    set => UpdateField(ref _InsetMode, value, nameof(InsetMode));
  }
  private InsetMargin? _InsetMode;

  /// <summary>
  ///   Fill.
  /// </summary>

  [OpenXmlProperty(nameof(DXVO.ShapeDefaults.Fill))]
  public Fill? Fill
  {
    get => _Fill ??= GetProperty<Fill?>(GetUpdatableElement()?.Fill);
    set => UpdateField(ref _Fill, value, nameof(Fill));
  }
  private Fill? _Fill;

  /// <summary>
  ///   ImageData.
  /// </summary>
  [OpenXmlProperty(nameof(DXVO.ShapeDefaults.ImageData))]
  public ImageData? ImageData
  {
    get => _ImageData ??= GetProperty<ImageData?>(GetUpdatableElement()?.ImageData);
    set => UpdateField(ref _ImageData, value, nameof(ImageData));
  }
  private ImageData? _ImageData;

  /// <summary>
  ///   Stroke.
  /// </summary>
  [OpenXmlProperty(nameof(DXVO.ShapeDefaults.Stroke))]
  public Stroke? Stroke
  {
    get => _Stroke ??= GetProperty<Stroke?>(GetUpdatableElement()?.Stroke);
    set => UpdateField(ref _Stroke, value, nameof(Stroke));
  }
  private Stroke? _Stroke;

  /// <summary>
  ///   TextBox.
  /// </summary>
  [OpenXmlProperty(nameof(DXVO.ShapeDefaults.TextBox))]
  public TextBox? TextBox
  {
    get => _TextBox ??= GetProperty<TextBox?>(GetUpdatableElement()?.TextBox);
    set => UpdateField(ref _TextBox, value, nameof(TextBox));
  }
  private TextBox? _TextBox;

  /// <summary>
  ///   Shadow.
  /// </summary>
  [OpenXmlProperty(nameof(DXVO.ShapeDefaults.Shadow))]
  public Shadow? Shadow
  {
    get => _Shadow ??= GetProperty<Shadow?>(GetUpdatableElement()?.Shadow);
    set => UpdateField(ref _Shadow, value, nameof(Shadow));
  }
  private Shadow? _Shadow;

  /// <summary>
  ///   Skew.
  /// </summary>
  [OpenXmlProperty(nameof(DXVO.ShapeDefaults.Skew))]
  public Skew? Skew
  {
    get => _Skew ??= GetProperty<Skew?>(GetUpdatableElement()?.Skew);
    set => UpdateField(ref _Skew, value, nameof(Skew));
  }
  private Skew? _Skew;

  /// <summary>
  ///   Extrusion.
  /// </summary>
  [OpenXmlProperty(nameof(DXVO.ShapeDefaults.Extrusion))]
  public Extrusion? Extrusion
  {
    get => _Extrusion ??= GetProperty<Extrusion?>(GetUpdatableElement()?.Extrusion);
    set => UpdateField(ref _Extrusion, value, nameof(Extrusion));
  }
  private Extrusion? _Extrusion;

  /// <summary>
  ///   Callout.
  /// </summary>
  [OpenXmlProperty(nameof(DXVO.ShapeDefaults.Callout))]
  public Callout? Callout
  {
    get => _Callout ??= GetProperty<Callout?>(GetUpdatableElement()?.Callout);
    set => UpdateField(ref _Callout, value, nameof(Callout));
  }
  private Callout? _Callout;

  /// <summary>
  ///   Shape Protections.
  /// </summary>
  [OpenXmlProperty(nameof(DXVO.ShapeDefaults.Lock))]
  public Lock? Lock
  {
    get => _Lock ??= GetProperty<Lock?>(GetUpdatableElement()?.Lock);
    set => UpdateField(ref _Lock, value, nameof(Lock));
  }
  private Lock? _Lock;

  /// <summary>
  ///   Most Recently Used Colors.
  /// </summary>
  [OpenXmlProperty(nameof(DXVO.ShapeDefaults.ColorMostRecentlyUsed))]
  public ColorMostRecentlyUsed? ColorMostRecentlyUsed
  {
    get => _ColorMostRecentlyUsed ??= GetProperty<ColorMostRecentlyUsed?>(GetUpdatableElement()?.ColorMostRecentlyUsed);
    set => UpdateField(ref _ColorMostRecentlyUsed, value, nameof(ColorMostRecentlyUsed));
  }
  private ColorMostRecentlyUsed? _ColorMostRecentlyUsed;

  /// <summary>
  ///   UI Default Colors.
  /// </summary>
  [OpenXmlProperty(nameof(DXVO.ShapeDefaults.ColorMenu))]
  public ColorMenu? ColorMenu
  {
    get => _ColorMenu ??= GetProperty<ColorMenu?>(GetUpdatableElement()?.ColorMenu);
    set => UpdateField(ref _ColorMenu, value, nameof(ColorMenu));
  }
  private ColorMenu? _ColorMenu;

  /// <summary>
  ///   VML Extension Handling Behavior
  /// </summary>
  [OpenXmlProperty(nameof(DXVO.ShapeDefaults.Extension))]
  public ExtensionHandlingBehavior? Extension
  {
    get => _Extension ??= GetProperty<ExtensionHandlingBehavior?>(GetUpdatableElement()?.Extension);
    set => UpdateField(ref _Extension, value, nameof(Extension));
  }
  private ExtensionHandlingBehavior? _Extension;
}
