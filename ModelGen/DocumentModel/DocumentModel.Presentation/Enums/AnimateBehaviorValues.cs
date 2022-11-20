namespace DocumentModel.Presentation;

/// <summary>
/// Time List Animate Behavior Value Types
/// </summary>
public enum AnimateBehaviorValues
{
  /// <summary>
  /// Value Type Enum ( String ).
  /// </summary>
  [XmlEnum("str")]
  String,
  
  /// <summary>
  /// Value Type Enum ( Number ).
  /// </summary>
  [XmlEnum("num")]
  Number,
  
  /// <summary>
  /// Value Type Enum ( Color ).
  /// </summary>
  [XmlEnum("clr")]
  Color,
  
}
