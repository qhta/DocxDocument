namespace DocumentModel.Spreadsheet;

/// <summary>
/// Orientation
/// </summary>
public enum Orientation
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
