namespace DocumentModel.Spreadsheet;

/// <summary>
/// Rule Type
/// </summary>
public enum PivotAreaValues
{
  /// <summary>
  /// None.
  /// </summary>
  [XmlEnum("none")]
  None,
  
  /// <summary>
  /// Normal.
  /// </summary>
  [XmlEnum("normal")]
  Normal,
  
  /// <summary>
  /// Data.
  /// </summary>
  [XmlEnum("data")]
  Data,
  
  /// <summary>
  /// All.
  /// </summary>
  [XmlEnum("all")]
  All,
  
  /// <summary>
  /// Origin.
  /// </summary>
  [XmlEnum("origin")]
  Origin,
  
  /// <summary>
  /// Field Button.
  /// </summary>
  [XmlEnum("button")]
  Button,
  
  /// <summary>
  /// Top Right.
  /// </summary>
  [XmlEnum("topRight")]
  TopRight,
  
  /// <summary>
  /// topEnd.
  /// </summary>
  [XmlEnum("topEnd")]
  TopEnd,
  
}
