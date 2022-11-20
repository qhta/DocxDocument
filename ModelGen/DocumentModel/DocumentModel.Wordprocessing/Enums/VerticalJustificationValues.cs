namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the VerticalJustificationValues enumeration.
/// </summary>
public enum VerticalJustificationValues
{
  /// <summary>
  /// Align Top.
  /// </summary>
  [XmlEnum("top")]
  Top,
  
  /// <summary>
  /// Align Center.
  /// </summary>
  [XmlEnum("center")]
  Center,
  
  /// <summary>
  /// Vertical Justification.
  /// </summary>
  [XmlEnum("both")]
  Both,
  
  /// <summary>
  /// Align Bottom.
  /// </summary>
  [XmlEnum("bottom")]
  Bottom,
  
}
