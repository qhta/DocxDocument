namespace DocumentModel.Drawings;

/// <summary>
/// Printed Page Orientation
/// </summary>
public enum PageSetupOrientationKind
{
  /// <summary>
  /// Default Page Orientation.
  /// </summary>
  [XmlEnum("default")]
  Default,
  
  /// <summary>
  /// Portrait Page.
  /// </summary>
  [XmlEnum("portrait")]
  Portrait,
  
  /// <summary>
  /// Landscape Page.
  /// </summary>
  [XmlEnum("landscape")]
  Landscape,
  
}
