namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the FrameLayoutValues enumeration.
/// </summary>
public enum FrameLayoutKind
{
  /// <summary>
  /// Stack Frames Vertically.
  /// </summary>
  [XmlEnum("rows")]
  Rows,
  
  /// <summary>
  /// Stack Frames Horizontally.
  /// </summary>
  [XmlEnum("cols")]
  Columns,
  
  /// <summary>
  /// Do Not Stack Frames.
  /// </summary>
  [XmlEnum("none")]
  None,
  
}
