namespace DocumentModel.Spreadsheet;

/// <summary>
/// Orientation
/// </summary>
public enum OrientationValues
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
