namespace DocumentModel.Wordprocessing;

/// <summary>
///   Defines the DocGridValues enumeration.
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
public enum DocGridKind
{
  /// <summary>
  ///   No Document Grid.
  /// </summary>
  Default,

  /// <summary>
  ///   Line Grid Only.
  /// </summary>
  Lines,

  /// <summary>
  ///   Line and Character Grid.
  /// </summary>
  LinesAndChars,

  /// <summary>
  ///   Character Grid Only.
  /// </summary>
  SnapToChars
}