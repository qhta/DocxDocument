namespace DocumentModel.Presentation;

/// <summary>
/// Time List Animate Motion Path Edit Mode
/// </summary>
public enum AnimateMotionPathEditMode
{
  /// <summary>
  /// Path Edit Mode Enum ( Relative ).
  /// </summary>
  [XmlEnum("relative")]
  Relative,
  
  /// <summary>
  /// Path Edit Mode Enum ( Fixed ).
  /// </summary>
  [XmlEnum("fixed")]
  Fixed,
  
}
