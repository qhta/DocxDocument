namespace DocumentModel.Drawings.Diagrams;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

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