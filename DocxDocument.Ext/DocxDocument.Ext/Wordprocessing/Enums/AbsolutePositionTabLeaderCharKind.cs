namespace DocumentModel.Wordprocessing;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Defines the AbsolutePositionTabLeaderCharValues enumeration.
/// </summary>
//[JsonConverter(typeof(StringEnumConverter))]
public enum AbsolutePositionTabLeaderCharKind
{
  /// <summary>
  ///   No Leader Character.
  /// </summary>
  None,

  /// <summary>
  ///   Dot Leader Character.
  /// </summary>
  Dot,

  /// <summary>
  ///   Hyphen Leader Character.
  /// </summary>
  Hyphen,

  /// <summary>
  ///   Underscore Leader Character.
  /// </summary>
  Underscore,

  /// <summary>
  ///   Centered Dot Leader Character.
  /// </summary>
  MiddleDot
}