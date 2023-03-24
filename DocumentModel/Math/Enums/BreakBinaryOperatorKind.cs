namespace DocumentModel.Math;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

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