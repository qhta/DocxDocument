namespace DocumentModel.Presentation;

/// <summary>
/// Behavior Transform Type
/// </summary>
public enum BehaviorTransformKind
{
  /// <summary>
  /// Point.
  /// </summary>
  [XmlEnum("pt")]
  Point,
  
  /// <summary>
  /// Image.
  /// </summary>
  [XmlEnum("img")]
  Image,
  
}
