namespace DocumentModel.Wordprocessing;

/// <summary>
///   Defines the PathShadeTypeValues enumeration.
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
public enum PathShadeKind
{
  /// <summary>
  ///   shape.
  /// </summary>
  Shape,
  /// <summary>
  ///   circle.
  /// </summary>
  Circle,
  /// <summary>
  ///   rect.
  /// </summary>
  Rect
}