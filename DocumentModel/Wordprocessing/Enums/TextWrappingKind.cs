namespace DocumentModel.Wordprocessing;

/// <summary>
///   Defines the TextWrappingValues enumeration.
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
public enum TextWrappingKind
{
  /// <summary>
  ///   Default Text Wrapping Around Frame.
  /// </summary>
  Auto,

  /// <summary>
  ///   No Text Wrapping Beside Frame.
  /// </summary>
  NotBeside,

  /// <summary>
  ///   Allow Text Wrapping Around Frame.
  /// </summary>
  Around,

  /// <summary>
  ///   Tight Text Wrapping Around Frame.
  /// </summary>
  Tight,

  /// <summary>
  ///   Through Text Wrapping Around Frame.
  /// </summary>
  Through,

  /// <summary>
  ///   No Text Wrapping Around Frame.
  /// </summary>
  None
}