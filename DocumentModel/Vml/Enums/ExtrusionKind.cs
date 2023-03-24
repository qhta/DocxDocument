namespace DocumentModel.Vml;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

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