namespace DocumentModel.Wordprocessing;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Defines the TabStopLeaderCharValues enumeration.
/// </summary>
//[JsonConverter(typeof(StringEnumConverter))]
public enum TabStopLeaderCharKind
{
  /// <summary>
  ///   No tab stop leader.
  /// </summary>
  None,

  /// <summary>
  ///   Dotted leader line.
  /// </summary>
  Dot,

  /// <summary>
  ///   Dashed tab stop leader line.
  /// </summary>
  Hyphen,

  /// <summary>
  ///   Solid leader line.
  /// </summary>
  Underscore,

  /// <summary>
  ///   Heavy solid leader line.
  /// </summary>
  Heavy,

  /// <summary>
  ///   Middle dot leader line.
  /// </summary>
  MiddleDot
}