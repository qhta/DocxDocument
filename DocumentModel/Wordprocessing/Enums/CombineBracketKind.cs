namespace DocumentModel.Wordprocessing;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Defines the CombineBracketValues enumeration.
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
public enum CombineBracketKind
{
  /// <summary>
  ///   No Enclosing Brackets.
  /// </summary>
  None,

  /// <summary>
  ///   Round Brackets.
  /// </summary>
  Round,

  /// <summary>
  ///   Square Brackets.
  /// </summary>
  Square,

  /// <summary>
  ///   Angle Brackets.
  /// </summary>
  Angle,

  /// <summary>
  ///   Curly Brackets.
  /// </summary>
  Curly
}