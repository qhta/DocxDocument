namespace DocumentModel.Presentation;

/// <summary>
/// Trigger RunTime Node
/// </summary>
public enum TriggerRuntimeNode
{
  /// <summary>
  /// Trigger RunTime Node ( First ).
  /// </summary>
  [XmlEnum("first")]
  First,
  
  /// <summary>
  /// Trigger RunTime Node ( Last ).
  /// </summary>
  [XmlEnum("last")]
  Last,
  
  /// <summary>
  /// Trigger RunTime Node Enum ( All ).
  /// </summary>
  [XmlEnum("all")]
  All,
  
}
