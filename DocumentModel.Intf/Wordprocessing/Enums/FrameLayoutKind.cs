namespace DocumentModel.Wordprocessing;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Defines the FrameLayoutValues enumeration.
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
public enum FrameLayoutKind
{
  /// <summary>
  ///   Stack Frames Vertically.
  /// </summary>
  Rows,

  /// <summary>
  ///   Stack Frames Horizontally.
  /// </summary>
  Columns,

  /// <summary>
  ///   Do Not Stack Frames.
  /// </summary>
  None
}