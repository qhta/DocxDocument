namespace DocumentModel.Drawings;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   No text in 3D scene.
/// </summary>
public class FlatText: ModelElement
{
  /// <summary>
  ///   Z Coordinate
  /// </summary>
  public Int64? Z { get; set; }
}