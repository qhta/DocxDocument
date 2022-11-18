namespace DocumentModel.Wordprocessing;

/// <summary>
/// Automatic Caption Positioning Values
/// </summary>
public enum CaptionPosition
{
  /// <summary>
  /// Position Caption Above Object.
  /// </summary>
  [XmlEnum("above")]
  Above,
  
  /// <summary>
  /// Position Caption Below Object.
  /// </summary>
  [XmlEnum("below")]
  Below,
  
}
