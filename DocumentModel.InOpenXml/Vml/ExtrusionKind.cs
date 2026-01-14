namespace DocumentModel.Vml;

/// <summary>
///   Extrusion Type
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
public enum ExtrusionKind
{
  /// <summary>
  ///   Perspective Projection.
  /// </summary>
  Perspective,
  /// <summary>
  ///   Parallel Projection.
  /// </summary>
  Parallel
}