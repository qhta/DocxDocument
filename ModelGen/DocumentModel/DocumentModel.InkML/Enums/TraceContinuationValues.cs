namespace DocumentModel.InkML;

/// <summary>
/// Defines the TraceContinuationValues enumeration.
/// </summary>
public enum TraceContinuationValues
{
  /// <summary>
  /// begin.
  /// </summary>
  [XmlEnum("begin")]
  Begin,
  
  /// <summary>
  /// end.
  /// </summary>
  [XmlEnum("end")]
  End,
  
  /// <summary>
  /// middle.
  /// </summary>
  [XmlEnum("middle")]
  Middle,
  
}
