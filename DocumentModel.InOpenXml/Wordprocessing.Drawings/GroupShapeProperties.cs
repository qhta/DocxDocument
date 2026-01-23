using DocumentModel.Drawings;

namespace DocumentModel.Wordprocessing.Drawings;

/// <summary>
/// Represents the set of properties for a group shape in a Wordprocessing document.
/// This class provides configuration for black and white rendering, group transformations, fill settings, visual effects, and 3D scene properties, enabling advanced layout and appearance control for grouped drawing elements.
/// </summary>
public class GroupShapeProperties : ModelElement<DXOD.GroupShapeProperties>, IExtendableElement
{
  /// <summary>
  /// The black and white rendering mode for the group shape, specifying how it appears when displayed or printed in monochrome.
  /// </summary>
  public BlackWhiteMode? BlackWhiteMode { get; set; }

  /// <summary>
  /// The 2D transformation applied to the group, including translation, scaling, rotation, and skew for grouped objects.
  /// </summary>
  public TransformGroup? TransformGroup { get; set; }

  /// <summary>
  /// Fill settings for the group shape, specifying color, gradient, or pattern fills.
  /// </summary>
  public Fill? Fill { get; set; }

  /// <summary>
  /// List of visual effects applied to the group shape, such as shadows, glows, and reflections.
  /// </summary>
  public EffectList? EffectList { get; set; }

  /// <summary>
  /// Effect DAG (Directed Acyclic Graph) for advanced effect sequencing and layering on the group shape.
  /// </summary>
  public EffectDag? EffectDag { get; set; }

  /// <summary>
  /// 3D scene settings for the group shape, defining camera, lighting, and perspective.
  /// </summary>
  public Scene3DType? Scene3DType { get; set; }

  /// <summary>
  /// List of extensions for the group shape, allowing for additional properties and behaviors to be defined.
  /// </summary>
  public ExtensionList? ExtensionList { get; set; }
}