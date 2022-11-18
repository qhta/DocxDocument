namespace DocumentModel.Presentation;

/// <summary>
/// Behavior Override Type
/// </summary>
public enum BehaviorOverride
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
