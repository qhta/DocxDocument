namespace DocumentModel.Spreadsheet;

/// <summary>
/// Defines the DataBarAxisPositionValues enumeration.
/// </summary>
public enum DataBarAxisPositionKind
{
  /// <summary>
  /// automatic.
  /// </summary>
  [XmlEnum("automatic")]
  Automatic,
  
  /// <summary>
  /// middle.
  /// </summary>
  [XmlEnum("middle")]
  Middle,
  
  /// <summary>
  /// none.
  /// </summary>
  [XmlEnum("none")]
  None,
  
}
