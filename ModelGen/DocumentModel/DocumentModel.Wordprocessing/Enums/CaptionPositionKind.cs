namespace DocumentModel.Wordprocessing;

/// <summary>
/// Automatic Caption Positioning Values
/// </summary>
public enum CaptionPositionKind
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
