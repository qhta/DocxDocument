namespace DocumentModel.Drawing.Charts;

/// <summary>
/// Picture Format
/// </summary>
public enum PictureFormat
{
  /// <summary>
  /// Stretch.
  /// </summary>
  [XmlEnum("stretch")]
  Stretch,
  
  /// <summary>
  /// Stack.
  /// </summary>
  [XmlEnum("stack")]
  Stack,
  
  /// <summary>
  /// Stack and Scale.
  /// </summary>
  [XmlEnum("stackScale")]
  StackScale,
  
}
