namespace DocumentModel.Presentation;

/// <summary>
/// Time Node Master Relation
/// </summary>
public enum TimeNodeMasterRelationValues
{
  /// <summary>
  /// TimeNode Master Relation Enum ( Same Click ).
  /// </summary>
  [XmlEnum("sameClick")]
  SameClick,
  
  /// <summary>
  /// TimeNode Master Relation Enum ( Next Click ).
  /// </summary>
  [XmlEnum("nextClick")]
  NextClick,
  
}
