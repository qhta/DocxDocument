namespace DocumentModel.Drawings.Charts;
/// <summary>
///   Represents the visual and shape properties for a chart element.
///   This class allows configuration of fill, outline, effects, geometry, and 3D settings to control the appearance of chart components such as data points, labels, or the chart area.
/// </summary>
/// <remarks>
/// <para>The following table lists the possible child types:</para>
/// <list type="bullet">
///   <item><description><see cref="T:DocumentFormat.OpenXml.Drawing.BlipFill" /> <c>&lt;a:blipFill&gt;</c></description></item>
///   <item><description><see cref="T:DocumentFormat.OpenXml.Drawing.CustomGeometry" /> <c>&lt;a:custGeom&gt;</c></description></item>
///   <item><description><see cref="T:DocumentFormat.OpenXml.Drawing.EffectDag" /> <c>&lt;a:effectDag&gt;</c></description></item>
///   <item><description><see cref="T:DocumentFormat.OpenXml.Drawing.EffectList" /> <c>&lt;a:effectLst&gt;</c></description></item>
///   <item><description><see cref="T:DocumentFormat.OpenXml.Drawing.GradientFill" /> <c>&lt;a:gradFill&gt;</c></description></item>
///   <item><description><see cref="T:DocumentFormat.OpenXml.Drawing.Outline" /> <c>&lt;a:ln&gt;</c></description></item>
///   <item><description><see cref="T:DocumentFormat.OpenXml.Drawing.NoFill" /> <c>&lt;a:noFill&gt;</c></description></item>
///   <item><description><see cref="T:DocumentFormat.OpenXml.Drawing.ExtensionList" /> <c>&lt;a:extLst&gt;</c></description></item>
///   <item><description><see cref="T:DocumentFormat.OpenXml.Drawing.PatternFill" /> <c>&lt;a:pattFill&gt;</c></description></item>
///   <item><description><see cref="T:DocumentFormat.OpenXml.Drawing.PresetGeometry" /> <c>&lt;a:prstGeom&gt;</c></description></item>
///   <item><description><see cref="T:DocumentFormat.OpenXml.Drawing.Scene3DType" /> <c>&lt;a:scene3d&gt;</c></description></item>
///   <item><description><see cref="T:DocumentFormat.OpenXml.Drawing.Shape3DType" /> <c>&lt;a:sp3d&gt;</c></description></item>
///   <item><description><see cref="T:DocumentFormat.OpenXml.Drawing.SolidFill" /> <c>&lt;a:solidFill&gt;</c></description></item>
///   <item><description><see cref="T:DocumentFormat.OpenXml.Drawing.Transform2D" /> <c>&lt;a:xfrm&gt;</c></description></item>
/// </list>
/// </remarks>
[OpenXmlType(typeof(DXDC.ChartShapeProperties))]
public partial class ChartShapeProperties : ModelElement<DXDC.ChartShapeProperties>
{
  /// <summary>
  ///   Black and white rendering mode for the chart element.
  /// </summary>
  [OpenXmlProperty(nameof(DXDC.ChartShapeProperties.BlackWhiteMode))]
  public BlackWhiteMode? BlackWhiteMode { get => _BlackWhiteMode; set => UpdateField(ref _BlackWhiteMode, value, nameof(BlackWhiteMode)); }

  private BlackWhiteMode? _BlackWhiteMode;
  /// <summary>
  ///   2D transformation settings for positioning, scaling, and rotating the chart element.
  /// </summary>
  [OpenXmlProperty(nameof(DXDC.ChartShapeProperties.Transform2D))]
  public Transform2D? Transform2D { get => _Transform2D; set => UpdateField(ref _Transform2D, value, nameof(Transform2D)); }

  private Transform2D? _Transform2D;
  /// <summary>
  ///   Custom geometry definition for the chart element's shape.
  /// </summary>
  [OpenXmlElement(typeof(DXD.CustomGeometry))]
  public CustomGeometry? CustomGeometry { get => _CustomGeometry; set => UpdateField(ref _CustomGeometry, value, nameof(CustomGeometry)); }

  private CustomGeometry? _CustomGeometry;
  /// <summary>
  ///   Preset geometry type for the chart element's shape.
  /// </summary>
  [OpenXmlElement(typeof(DXD.PresetGeometry))]
  public PresetGeometry? PresetGeometry { get => _PresetGeometry; set => UpdateField(ref _PresetGeometry, value, nameof(PresetGeometry)); }

  private PresetGeometry? _PresetGeometry;
  /// <summary>
  ///   Fill formatting for the chart element, such as solid, gradient, or pattern fill.
  /// </summary>
  [OpenXmlElement(typeof(DXD.Fill))]
  public Fill? Fill { get => _Fill; set => UpdateField(ref _Fill, value, nameof(Fill)); }

  private Fill? _Fill;
  /// <summary>
  ///   Outline or border formatting for the chart element.
  /// </summary>
  [OpenXmlElement(typeof(DXD.Outline))]
  public LineProperties? Outline { get => _Outline; set => UpdateField(ref _Outline, value, nameof(Outline)); }

  private LineProperties? _Outline;
  /// <summary>
  ///   List of visual effects applied to the chart element, such as shadows or glows.
  /// </summary>
  [OpenXmlElement(typeof(DXD.EffectList))]
  public EffectList? EffectList { get => _EffectList; set => UpdateField(ref _EffectList, value, nameof(EffectList)); }

  private EffectList? _EffectList;
  /// <summary>
  ///   Complex effect container for advanced visual effects.
  /// </summary>
  [OpenXmlElement(typeof(DXD.EffectDag))]
  public EffectDag? EffectDag { get => _EffectDag; set => UpdateField(ref _EffectDag, value, nameof(EffectDag)); }

  private EffectDag? _EffectDag;
  /// <summary>
  ///   3D scene settings for the chart element.
  /// </summary>
  [OpenXmlElement(typeof(DXD.Scene3DType))]
  public Scene3DType? Scene3DType { get => _Scene3DType; set => UpdateField(ref _Scene3DType, value, nameof(Scene3DType)); }

  private Scene3DType? _Scene3DType;
  /// <summary>
  ///   3D shape settings for the chart element.
  /// </summary>
  [OpenXmlElement(typeof(DXD.Shape3DType))]
  public Shape3DType? Shape3DType { get => _Shape3DType; set => UpdateField(ref _Shape3DType, value, nameof(Shape3DType)); }

  private Shape3DType? _Shape3DType;
  /// <summary>
  ///   Collection of extension elements for additional shape customization.
  /// </summary>
  [OpenXmlElement(typeof(DXD.ExtensionList))]
  public ExtensionList? ExtensionList { get => _ExtensionList; set => UpdateField(ref _ExtensionList, value, nameof(ExtensionList)); }

  private ExtensionList? _ExtensionList;
}