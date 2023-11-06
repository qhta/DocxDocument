namespace DocumentModel.Wordprocessing;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Defines the EmphasisMarkValues enumeration.
/// </summary>
//[JsonConverter(typeof(StringEnumConverter))]
public enum EmphasisMarkKind
{
  /// <summary>
  ///   No Emphasis Mark.
  /// </summary>
  None,

  /// <summary>
  ///   Dot Emphasis Mark Above Characters.
  /// </summary>
  Dot,

  /// <summary>
  ///   Comma Emphasis Mark Above Characters.
  /// </summary>
  Comma,

  /// <summary>
  ///   Circle Emphasis Mark Above Characters.
  /// </summary>
  Circle,

  /// <summary>
  ///   Dot Emphasis Mark Below Characters.
  /// </summary>
  UnderDot
}