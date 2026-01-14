namespace DocumentModel.Drawings;

/// <summary>
/// Represents a style that defines a set of effects and 3D properties for a drawing element.
/// </summary>
public interface EffectStyle : ICollectionItem, IExtendableElement
{
  /// <summary>
  /// List of effects applied to the drawing element.
  /// </summary>
  public EffectList? EffectList { get; set; }

  /// <summary>
  /// Effect directed acyclic graph, which defines the structure and relationships of effects.
  /// </summary>
  public EffectDag? EffectDag { get; set; }

  /// <summary>
  /// Gets or sets the 3D scene type, specifying the 3D environment for the drawing element.
  /// </summary>
  public Scene3DType? Scene3DType { get; set; }

  /// <summary>
  /// Gets or sets the 3D shape type, specifying the 3D geometry for the drawing element.
  /// </summary>
  public Shape3DType? Shape3DType { get; set; }
}