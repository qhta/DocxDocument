namespace DocumentModel.Drawing.Charts;

/// <summary>
/// Printed Page Orientation
/// </summary>
public enum PageSetupOrientation
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
