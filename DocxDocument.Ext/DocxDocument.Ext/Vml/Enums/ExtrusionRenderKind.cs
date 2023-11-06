namespace DocumentModel.Vml;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Extrusion Rendering Types
/// </summary>
//[JsonConverter(typeof(StringEnumConverter))]
public enum ExtrusionRenderKind
{
  /// <summary>
  ///   Solid.
  /// </summary>
  Solid,

  /// <summary>
  ///   Wireframe.
  /// </summary>
  WireFrame,

  /// <summary>
  ///   Bounding Cube.
  /// </summary>
  BoundingCube
}