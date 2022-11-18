namespace DocumentModel.Math;

/// <summary>
/// Defines the LimitLocationValues enumeration.
/// </summary>
public enum LimitLocation
{
  /// <summary>
  /// Under-Over location.
  /// </summary>
  [XmlEnum("undOvr")]
  UnderOver,
  
  /// <summary>
  /// Subscript-Superscript location.
  /// </summary>
  [XmlEnum("subSup")]
  SubscriptSuperscript,
  
}
