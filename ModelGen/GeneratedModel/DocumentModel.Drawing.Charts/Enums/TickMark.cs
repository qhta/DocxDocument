namespace DocumentModel.Drawing.Charts;

/// <summary>
/// Tick Mark
/// </summary>
public enum TickMark
{
  /// <summary>
  /// Cross.
  /// </summary>
  [XmlEnum("cross")]
  Cross,
  
  /// <summary>
  /// Inside.
  /// </summary>
  [XmlEnum("in")]
  Inside,
  
  /// <summary>
  /// None.
  /// </summary>
  [XmlEnum("none")]
  None,
  
  /// <summary>
  /// Outside.
  /// </summary>
  [XmlEnum("out")]
  Outside,
  
}
