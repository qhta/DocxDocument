namespace DocumentModel.Drawings;

/// <summary>
/// Tick Mark
/// </summary>
public enum TickMarkKind
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
