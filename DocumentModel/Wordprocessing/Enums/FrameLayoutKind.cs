namespace DocumentModel.Wordprocessing;

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