namespace DocumentModel.Drawings.Diagrams;

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
  ///   No text in 3D scene.
  /// </summary>
  public FlatText? FlatText { get; set; }
}