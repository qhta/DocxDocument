namespace DocumentModel.Spreadsheet;

public enum Comments
{
  
  [XmlEnum("commNone")]
  CommentNone,
  
  [XmlEnum("commIndicator")]
  CommentIndicator,
  
  [XmlEnum("commIndAndComment")]
  CommentIndicatorAndComment,
}
