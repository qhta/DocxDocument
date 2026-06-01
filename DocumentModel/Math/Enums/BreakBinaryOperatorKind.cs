namespace DocumentModel.Math;

/// <summary>
///   Defines the BreakBinaryOperatorValues enumeration.
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
public enum BreakBinaryOperatorKind
{
  /// <summary>
  ///   IBreak occurs before binary operator.
  /// </summary>
  Before,

  /// <summary>
  ///   IBreak occurs after binary operator.
  /// </summary>
  After,

  /// <summary>
  ///   IBreak occurs after binary operator, but the operator is repeater at the beginning on the next line.
  /// </summary>
  Repeat
}
