namespace DocumentModel.Office2021.PowerPoint.Comment;

public enum CommentStatus
{

  [XmlEnum("active")]
  Active,

  [XmlEnum("resolved")]
  Resolved,

  [XmlEnum("closed")]
  Closed,
}
