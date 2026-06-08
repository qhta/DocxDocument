namespace DocumentModel.Wordprocessing;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Defines the TextWrappingValues enumeration.
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
public enum TextWrappingKind
{
  /// <summary>
  ///   Default Text Wrapping Around IFrame.
  /// </summary>
  Auto,

  /// <summary>
  ///   No Text Wrapping Beside IFrame.
  /// </summary>
  NotBeside,

  /// <summary>
  ///   Allow Text Wrapping Around IFrame.
  /// </summary>
  Around,

  /// <summary>
  ///   Tight Text Wrapping Around IFrame.
  /// </summary>
  Tight,

  /// <summary>
  ///   Through Text Wrapping Around IFrame.
  /// </summary>
  Through,

  /// <summary>
  ///   No Text Wrapping Around IFrame.
  /// </summary>
  None
}
