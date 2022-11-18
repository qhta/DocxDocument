namespace DocumentModel.Presentation;

/// <summary>
/// Behavior Additive Type
/// </summary>
public enum BehaviorAdditive
{
  /// <summary>
  /// Additive Enum ( Base ).
  /// </summary>
  [XmlEnum("base")]
  Base,
  
  /// <summary>
  /// Additive Enum ( Sum ).
  /// </summary>
  [XmlEnum("sum")]
  Sum,
  
  /// <summary>
  /// Additive Enum ( Replace ).
  /// </summary>
  [XmlEnum("repl")]
  Replace,
  
  /// <summary>
  /// Additive Enum ( Multiply ).
  /// </summary>
  [XmlEnum("mult")]
  Multiply,
  
  /// <summary>
  /// None.
  /// </summary>
  [XmlEnum("none")]
  None,
  
}
