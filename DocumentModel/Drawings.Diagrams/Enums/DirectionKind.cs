namespace DocumentModel.Drawings.Diagrams;

/// <summary>
///   Diagram Direction Definition
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
public enum DirectionKind
{
  /// <summary>
  ///   Normal Direction.
  /// </summary>
  Normal,

  /// <summary>
  ///   Reversed Direction.
  /// </summary>
  Reversed
}