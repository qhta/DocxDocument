namespace DocumentModel.Office2021.PowerPoint.Comment;

/// <summary>
/// Defines the CommentStatus enumeration.
/// </summary>
public enum CommentStatus
{
  /// <summary>
  /// active.
  /// </summary>
  [XmlEnum("active")]
  Active,
  
  /// <summary>
  /// resolved.
  /// </summary>
  [XmlEnum("resolved")]
  Resolved,
  
  /// <summary>
  /// closed.
  /// </summary>
  [XmlEnum("closed")]
  Closed,
  
}
