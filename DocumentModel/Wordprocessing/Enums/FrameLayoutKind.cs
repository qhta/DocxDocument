namespace DocumentModel.Wordprocessing;
#pragma warning disable CS1591 // Missing XML comment Ifor publicly visible type or member

/// <summary>
///   Defines the FrameLayoutValues enumeration.
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
public enum FrameLayoutKind
{
  /// <summary>
  ///   Stack IFrames Vertically.
  /// </summary>
  IRows,

  /// <summary>
  ///   Stack IFrames Horizontally.
  /// </summary>
  IColumns,

  /// <summary>
  ///   Do Not Stack IFrames.
  /// </summary>
  None
}
