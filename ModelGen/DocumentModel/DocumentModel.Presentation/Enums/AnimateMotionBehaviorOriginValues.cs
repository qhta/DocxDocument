namespace DocumentModel.Presentation;

/// <summary>
/// Time List Animate Motion Behavior Origin
/// </summary>
public enum AnimateMotionBehaviorOriginValues
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
