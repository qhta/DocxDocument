namespace DocumentModel.Spreadsheet;

/// <summary>
/// Comment Display Types
/// </summary>
public enum CommentsValues
{
  /// <summary>
  /// No Comments.
  /// </summary>
  [XmlEnum("commNone")]
  CommentNone,
  
  /// <summary>
  /// Show Comment Indicator.
  /// </summary>
  [XmlEnum("commIndicator")]
  CommentIndicator,
  
  /// <summary>
  /// Show Comment and Indicator.
  /// </summary>
  [XmlEnum("commIndAndComment")]
  CommentIndicatorAndComment,
  
}
