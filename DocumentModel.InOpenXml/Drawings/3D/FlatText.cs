namespace DocumentModel.Drawings;

/// <summary>
///   Indicates that text is not rendered in 3D scene.
/// </summary>
public class FlatText: ModelElement<DXD.FlatText>
{
  /// <summary>
  ///   Z coordinate for positioning in 3D space.
  /// </summary>
  public Int64? Z { get; set; }
}