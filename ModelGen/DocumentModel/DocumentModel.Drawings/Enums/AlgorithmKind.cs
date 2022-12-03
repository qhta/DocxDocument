namespace DocumentModel.Drawings;

/// <summary>
/// Algorithm Types
/// </summary>
public enum AlgorithmKind
{
  /// <summary>
  /// Composite.
  /// </summary>
  [XmlEnum("composite")]
  Composite,
  
  /// <summary>
  /// Connector Algorithm.
  /// </summary>
  [XmlEnum("conn")]
  Connector,
  
  /// <summary>
  /// Cycle Algorithm.
  /// </summary>
  [XmlEnum("cycle")]
  Cycle,
  
  /// <summary>
  /// Hierarchy Child Algorithm.
  /// </summary>
  [XmlEnum("hierChild")]
  HierarchyChild,
  
  /// <summary>
  /// Hierarchy Root Algorithm.
  /// </summary>
  [XmlEnum("hierRoot")]
  HierarchyRoot,
  
  /// <summary>
  /// Pyramid Algorithm.
  /// </summary>
  [XmlEnum("pyra")]
  Pyramid,
  
  /// <summary>
  /// Linear Algorithm.
  /// </summary>
  [XmlEnum("lin")]
  Linear,
  
  /// <summary>
  /// Space Algorithm.
  /// </summary>
  [XmlEnum("sp")]
  Space,
  
  /// <summary>
  /// Text Algorithm.
  /// </summary>
  [XmlEnum("tx")]
  Text,
  
  /// <summary>
  /// Snake Algorithm.
  /// </summary>
  [XmlEnum("snake")]
  Snake,
  
}
