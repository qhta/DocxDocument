using DocumentModel.Drawings;

namespace DocumentModel.Wordprocessing.Drawings;

/// <summary>
/// Represents the set of properties for a group shape in a Wordprocessing document.
/// This class provides configuration for black and white rendering, group transformations, fill settings, visual effects, and 3D scene properties, enabling advanced layout and appearance control for grouped drawing elements.
/// </summary>
[OpenXmlType(typeof(DXOD.GroupShapeProperties))]
[DataContract]
[XmlRoot("GroupShapeProperties", Namespace = "DocumentModel.Wordprocessing.Drawings")]
public partial class GroupShapeProperties: ModelElement<DXOD.GroupShapeProperties>, IExtendableElement
{
  /// <summary>
  /// The black and white rendering mode for the group shape, specifying how it appears when displayed or printed in monochrome.
  /// </summary>
  [OpenXmlProperty(nameof(DXOD.GroupShapeProperties.BlackWhiteMode))]
  public BlackWhiteMode? BlackWhiteMode
  {
    get => _BlackWhiteMode ??= GetProperty<BlackWhiteMode?>(GetUpdatableElement()?.BlackWhiteMode);
    set => UpdateField(ref _BlackWhiteMode, value, nameof(BlackWhiteMode));
  }

  private BlackWhiteMode? _BlackWhiteMode;

  /// <summary>
  /// The 2D transformation applied to the group, including translation, scaling, rotation, and skew for grouped objects.
  /// </summary>
  [OpenXmlProperty(nameof(DXOD.GroupShapeProperties.TransformGroup))]
  public TransformGroup? TransformGroup
  {
    get => _TransformGroup ??= GetProperty<TransformGroup?>(GetUpdatableElement()?.TransformGroup);
    set => UpdateField(ref _TransformGroup, value, nameof(TransformGroup));
  }

  private TransformGroup? _TransformGroup;

  /// <summary>
  /// Fill settings for the group shape, specifying color, gradient, or pattern fills.
  /// </summary>
  public Fill? Fill { get => _Fill; set => UpdateField(ref _Fill, value, nameof(Fill)); }

  private Fill? _Fill;

  /// <summary>
  /// List of visual effects applied to the group shape, such as shadows, glows, and reflections.
  /// </summary>
  public EffectList? EffectList { get => _EffectList; set => UpdateField(ref _EffectList, value, nameof(EffectList)); }

  private EffectList? _EffectList;

  /// <summary>
  /// Effect DAG (Directed Acyclic Graph) for advanced effect sequencing and layering on the group shape.
  /// </summary>
  public EffectDag? EffectDag { get => _EffectDag; set => UpdateField(ref _EffectDag, value, nameof(EffectDag)); }

  private EffectDag? _EffectDag;

  /// <summary>
  /// 3D scene settings for the group shape, defining camera, lighting, and perspective.
  /// </summary>
  public Scene3DType? Scene3DType
  {
    get => _Scene3DType;
    set => UpdateField(ref _Scene3DType, value, nameof(Scene3DType));
  }

  private Scene3DType? _Scene3DType;

  /// <summary>
  /// List of extensions for the group shape, allowing for additional properties and behaviors to be defined.
  /// </summary>
  public ExtensionList? ExtensionList
  {
    get => _ExtensionList;
    set => UpdateField(ref _ExtensionList, value, nameof(ExtensionList));
  }

  private ExtensionList? _ExtensionList;
}