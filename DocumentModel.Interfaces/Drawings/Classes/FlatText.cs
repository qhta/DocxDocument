namespace DocumentModel.Drawings;

/// <summary>
///   No text in 3D scene.
/// </summary>
public interface FlatText: IModelElement
{
  /// <summary>
  ///   Z Coordinate
  /// </summary>
  public Int64? Z { get; set; }
}