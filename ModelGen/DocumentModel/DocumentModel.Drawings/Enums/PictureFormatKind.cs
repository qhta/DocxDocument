namespace DocumentModel.Drawings;

/// <summary>
/// Picture Format
/// </summary>
public enum PictureFormatKind
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
