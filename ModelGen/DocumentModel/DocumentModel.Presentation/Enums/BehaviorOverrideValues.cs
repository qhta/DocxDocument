namespace DocumentModel.Presentation;

/// <summary>
/// Behavior Override Type
/// </summary>
public enum BehaviorOverrideValues
{
  /// <summary>
  /// Override Enum ( Normal ).
  /// </summary>
  [XmlEnum("normal")]
  Normal,
  
  /// <summary>
  /// Override Enum ( Child Style ).
  /// </summary>
  [XmlEnum("childStyle")]
  ChildStyle,
  
}
