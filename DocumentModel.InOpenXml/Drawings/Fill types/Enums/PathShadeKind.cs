namespace DocumentModel.Drawings;

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