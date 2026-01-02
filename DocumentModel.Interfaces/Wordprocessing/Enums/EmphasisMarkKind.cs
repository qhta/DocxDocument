namespace DocumentModel.Wordprocessing;

/// <summary>
///   Defines the EmphasisMarkValues enumeration.
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
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