namespace DocumentModel.Spreadsheet;

/// <summary>
/// Orientation
/// </summary>
public enum OrientationKind
{
  /// <summary>
  /// Default.
  /// </summary>
  [XmlEnum("default")]
  Default,
  
  /// <summary>
  /// Portrait.
  /// </summary>
  [XmlEnum("portrait")]
  Portrait,
  
  /// <summary>
  /// Landscape.
  /// </summary>
  [XmlEnum("landscape")]
  Landscape,
  
}
