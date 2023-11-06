namespace DocumentModel.Wordprocessing;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Defines the PathShadeTypeValues enumeration.
/// </summary>
//[JsonConverter(typeof(StringEnumConverter))]
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