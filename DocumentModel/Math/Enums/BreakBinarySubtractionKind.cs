namespace DocumentModel.Math;

/// <summary>
///   Defines the BreakBinarySubtractionValues enumeration.
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
public enum BreakBinarySubtractionKind
{
  /// <summary>
  ///   Minus Minus.
  /// </summary>
  MinusMinus,

  /// <summary>
  ///   Minus Plus.
  /// </summary>
  MinusPlus,

  /// <summary>
  ///   Plus Minus.
  /// </summary>
  PlusMinus
}