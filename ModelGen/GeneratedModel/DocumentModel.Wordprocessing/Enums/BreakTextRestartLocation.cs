namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the BreakTextRestartLocationValues enumeration.
/// </summary>
public enum BreakTextRestartLocation
{
  /// <summary>
  /// Restart On Next Line.
  /// </summary>
  [XmlEnum("none")]
  None,
  
  /// <summary>
  /// Restart In Next Text Region When In Leftmost Position.
  /// </summary>
  [XmlEnum("left")]
  Left,
  
  /// <summary>
  /// Restart In Next Text Region When In Rightmost Position.
  /// </summary>
  [XmlEnum("right")]
  Right,
  
  /// <summary>
  /// Restart On Next Full Line.
  /// </summary>
  [XmlEnum("all")]
  All,
  
}
