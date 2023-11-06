namespace DocumentModel.Math;

/// <summary>
///   Defines the BreakBinaryOperatorValues enumeration.
/// </summary>
//[JsonConverter(typeof(StringEnumConverter))]
public enum BreakBinaryOperatorKind
{
  /// <summary>
  ///   Break occurs before binary operator.
  /// </summary>
  Before,

  /// <summary>
  ///   Break occurs after binary operator.
  /// </summary>
  After,

  /// <summary>
  ///   Break occurs after binary operator, but the operator is repeated at the beginning on the next line.
  /// </summary>
  Repeat
}