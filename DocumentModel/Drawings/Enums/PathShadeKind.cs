namespace DocumentModel.Drawings;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Path Shade Type
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
public enum PathShadeKind
{
  /// <summary>
  ///   Shape.
  /// </summary>
  Shape,

  /// <summary>
  ///   Circle.
  /// </summary>
  Circle,

  /// <summary>
  ///   Rectangle.
  /// </summary>
  Rectangle
}