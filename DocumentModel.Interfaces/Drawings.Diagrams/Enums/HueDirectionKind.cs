namespace DocumentModel.Drawings.Diagrams;

/// <summary>
///   Hue Direction
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
public enum HueDirectionKind
{
  /// <summary>
  ///   Clockwise Hue Direction.
  /// </summary>
  Clockwise,
  /// <summary>
  ///   Counterclockwise Hue Direction.
  /// </summary>
  Counterclockwise
}