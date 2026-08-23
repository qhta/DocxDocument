namespace DocumentModel.Drawings.ChartDrawing;

/// <summary>
/// Describes properties for a group shape in chart drawings, including black and white rendering, 2D and 3D transforms, fill, effects, and extension data.
/// </summary>
/// <remarks>
/// <para>The following table lists the possible child types:</para>
/// <list type="bullet">
///   <item><description><see cref="T:DocumentFormat.OpenXml.Drawing.BlipFill"/> <c>&lt;a:blipFill&gt;</c></description></item>
///   <item><description><see cref="T:DocumentFormat.OpenXml.Drawing.EffectDag"/> <c>&lt;a:effectDag&gt;</c></description></item>
///   <item><description><see cref="T:DocumentFormat.OpenXml.Drawing.EffectList"/> <c>&lt;a:effectLst&gt;</c></description></item>
///   <item><description><see cref="T:DocumentFormat.OpenXml.Drawing.GradientFill"/> <c>&lt;a:gradFill&gt;</c></description></item>
///   <item><description><see cref="T:DocumentFormat.OpenXml.Drawing.GroupFill"/> <c>&lt;a:grpFill&gt;</c></description></item>
///   <item><description><see cref="T:DocumentFormat.OpenXml.Drawing.TransformGroup"/> <c>&lt;a:xfrm&gt;</c></description></item>
///   <item><description><see cref="T:DocumentFormat.OpenXml.Drawing.NoFill"/> <c>&lt;a:noFill&gt;</c></description></item>
///   <item><description><see cref="T:DocumentFormat.OpenXml.Drawing.ExtensionList"/> <c>&lt;a:extLst&gt;</c></description></item>
///   <item><description><see cref="T:DocumentFormat.OpenXml.Drawing.PatternFill"/> <c>&lt;a:pattFill&gt;</c></description></item>
///   <item><description><see cref="T:DocumentFormat.OpenXml.Drawing.Scene3DType"/> <c>&lt;a:scene3d&gt;</c></description></item>
///   <item><description><see cref="T:DocumentFormat.OpenXml.Drawing.SolidFill"/> <c>&lt;a:solidFill&gt;</c></description></item>
/// </list>
/// </remarks>
[OpenXmlType(typeof(DXDCD.GroupShapeProperties))]
[DataContract]
[XmlRoot("GroupShapeProperties", Namespace = "DocumentModel.Drawings.ChartDrawing")]
public partial class GroupShapeProperties: ModelElement<DXDCD.GroupShapeProperties>
{
  /// <summary>
  /// Specifies the black and white rendering mode for the group shape.
  /// </summary>
  [OpenXmlProperty(nameof(DXDCD.GroupShapeProperties.BlackWhiteMode))]
  public BlackWhiteMode? BlackWhiteMode
  {
    get => _BlackWhiteMode ??= GetProperty<BlackWhiteMode?>(GetUpdatableElement()?.BlackWhiteMode);
    set => UpdateField(ref _BlackWhiteMode, value, nameof(BlackWhiteMode));
  }

  private BlackWhiteMode? _BlackWhiteMode;

  /// <summary>
  /// 2D transformation settings for positioning and scaling grouped objects.
  /// </summary>
  [OpenXmlProperty(nameof(DXDCD.GroupShapeProperties.TransformGroup))]
  public TransformGroup? TransformGroup
  {
    get => _TransformGroup ??= GetProperty<TransformGroup?>(GetUpdatableElement()?.TransformGroup);
    set => UpdateField(ref _TransformGroup, value, nameof(TransformGroup));
  }

  private TransformGroup? _TransformGroup;

  /// <summary>
  /// Fill formatting applied to the group shape.
  /// </summary>
  [OpenXmlElement(typeof(DXD.Fill))]
  public Fill? Fill
  {
    get => _Fill ??= GetElement<Fill, DXD.Fill>(GetUpdatableElement());
    set => UpdateField(ref _Fill, value, nameof(Fill));
  }

  private Fill? _Fill;

  /// <summary>
  /// Collection of effects applied to the group shape.
  /// </summary>
  [OpenXmlElement(typeof(DXD.EffectList))]
  public EffectList? EffectList
  {
    get => _EffectList ??= GetElement<EffectList, DXD.EffectList>(GetUpdatableElement());
    set => UpdateField(ref _EffectList, value, nameof(EffectList));
  }

  private EffectList? _EffectList;

  /// <summary>
  /// Directed acyclic graph representing the structure and relationships of effects.
  /// </summary>
  [OpenXmlElement(typeof(DXD.EffectDag))]
  public EffectDag? EffectDag
  {
    get => _EffectDag ??= GetElement<EffectDag, DXD.EffectDag>(GetUpdatableElement());
    set => UpdateField(ref _EffectDag, value, nameof(EffectDag));
  }

  private EffectDag? _EffectDag;

  /// <summary>
  /// 3D scene type specifying the environment for the group shape.
  /// </summary>
  [OpenXmlElement(typeof(DXD.Scene3DType))]
  public Scene3DType? Scene3DType
  {
    get => _Scene3DType ??= GetElement<Scene3DType, DXD.Scene3DType>(GetUpdatableElement());
    set => UpdateField(ref _Scene3DType, value, nameof(Scene3DType));
  }

  private Scene3DType? _Scene3DType;

  /// <summary>
  /// Extension list for additional or future group shape properties.
  /// </summary>
  [OpenXmlElement(typeof(DXD.ExtensionList))]
  public IExtensionList? ExtensionList
  {
    get => _ExtensionList ??= GetElement<IExtensionList, DXD.ExtensionList>(GetUpdatableElement());
    set => UpdateField(ref _ExtensionList, value, nameof(ExtensionList));
  }

  private IExtensionList? _ExtensionList;
}