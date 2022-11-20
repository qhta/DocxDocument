namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the PageOrientationValues enumeration.
/// </summary>
public enum PageOrientationValues
{
  /// <summary>
  /// Portrait Mode.
  /// </summary>
  [XmlEnum("portrait")]
  Portrait,
  
  /// <summary>
  /// Landscape Mode.
  /// </summary>
  [XmlEnum("landscape")]
  Landscape,
  
}
