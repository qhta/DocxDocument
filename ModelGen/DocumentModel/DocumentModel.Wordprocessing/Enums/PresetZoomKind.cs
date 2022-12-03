namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the PresetZoomValues enumeration.
/// </summary>
public enum PresetZoomKind
{
  /// <summary>
  /// No Preset Magnification.
  /// </summary>
  [XmlEnum("none")]
  None,
  
  /// <summary>
  /// Display One Full Page.
  /// </summary>
  [XmlEnum("fullPage")]
  FullPage,
  
  /// <summary>
  /// Display Page Width.
  /// </summary>
  [XmlEnum("bestFit")]
  BestFit,
  
  /// <summary>
  /// Display Text Width.
  /// </summary>
  [XmlEnum("textFit")]
  TextFit,
  
}
