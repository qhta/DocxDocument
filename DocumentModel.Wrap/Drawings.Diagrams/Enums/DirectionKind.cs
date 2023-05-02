namespace DocumentModel.Drawings.Diagrams;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

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