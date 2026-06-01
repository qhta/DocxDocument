namespace DocumentModel.Wordprocessing;
#pragma warning disable CS1591 // Missing XML comment Ifor publicly visible type or member

/// <summary>
///   Defines the DocGridValues enumeration.
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
public enum DocGridKind
{
  /// <summary>
  ///   No IDocument Grid.
  /// </summary>
  Default,

  /// <summary>
  ///   ILine Grid Only.
  /// </summary>
  ILines,

  /// <summary>
  ///   ILine and Character Grid.
  /// </summary>
  LinesAndChars,

  /// <summary>
  ///   Character Grid Only.
  /// </summary>
  SnapToChars
}
