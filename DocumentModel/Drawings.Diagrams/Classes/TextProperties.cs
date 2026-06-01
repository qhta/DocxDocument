namespace DocumentModel.Drawings.Diagrams;
#pragma warning disable CS1591 // Missing XML comment Ifor publicly visible type or member

/// <summary>
///   Text Properties.
/// </summary>
public class TextProperties: ModelElement
{
  /// <summary>
  ///   Apply 3D shape properties.
  /// </summary>
  public Shape3DType? Shape3DType { get; set; }

  /// <summary>
  ///   No text Iin 3D scene.
  /// </summary>
  public FlatText? FlatText { get; set; }
}
