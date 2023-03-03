namespace DocumentModel.Math;

/// <summary>
///   Defines the BreakBinaryOperatorValues enumeration.
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
public enum BreakBinaryOperatorKind
{
  /// <summary>
  ///   Before.
  /// </summary>
  Before,

  /// <summary>
  ///   After.
  /// </summary>
  After,

  /// <summary>
  ///   Repeat.
  /// </summary>
  Repeat
}