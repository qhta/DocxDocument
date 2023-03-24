namespace DocumentModel.Drawings.Diagrams;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Function Type
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
public enum FunctionKind
{
  /// <summary>
  ///   Count.
  /// </summary>
  Count,

  /// <summary>
  ///   Position.
  /// </summary>
  Position,

  /// <summary>
  ///   Reverse Position.
  /// </summary>
  ReversePosition,

  /// <summary>
  ///   Position Even.
  /// </summary>
  PositionEven,

  /// <summary>
  ///   Position Odd.
  /// </summary>
  PositionOdd,

  /// <summary>
  ///   Variable.
  /// </summary>
  Variable,

  /// <summary>
  ///   Depth.
  /// </summary>
  Depth,

  /// <summary>
  ///   Max Depth.
  /// </summary>
  MaxDepth
}