namespace DocumentModel.Presentation;

/// <summary>
/// Time List Animate Color Space
/// </summary>
public enum AnimateColorSpaceKind
{
  /// <summary>
  /// Color Space Enum ( RGB ).
  /// </summary>
  [XmlEnum("rgb")]
  Rgb,
  
  /// <summary>
  /// Color Space Enum ( HSL ).
  /// </summary>
  [XmlEnum("hsl")]
  Hsl,
  
}
