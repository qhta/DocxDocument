namespace DocumentModel.Presentation;

/// <summary>
/// Time List Animate Motion Behavior Origin
/// </summary>
public enum AnimateMotionBehaviorOriginKind
{
  /// <summary>
  /// Origin Enum ( Parent ).
  /// </summary>
  [XmlEnum("parent")]
  Parent,
  
  /// <summary>
  /// Origin Enum ( Layout ).
  /// </summary>
  [XmlEnum("layout")]
  Layout,
  
}
