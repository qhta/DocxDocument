namespace DocumentModel.Office2013.Excel;

/// <summary>
/// Defines the QuestionType enumeration.
/// </summary>
public enum QuestionType
{
  /// <summary>
  /// checkBox.
  /// </summary>
  [XmlEnum("checkBox")]
  CheckBox,
  
  /// <summary>
  /// choice.
  /// </summary>
  [XmlEnum("choice")]
  Choice,
  
  /// <summary>
  /// date.
  /// </summary>
  [XmlEnum("date")]
  Date,
  
  /// <summary>
  /// time.
  /// </summary>
  [XmlEnum("time")]
  Time,
  
  /// <summary>
  /// multipleLinesOfText.
  /// </summary>
  [XmlEnum("multipleLinesOfText")]
  MultipleLinesOfText,
  
  /// <summary>
  /// number.
  /// </summary>
  [XmlEnum("number")]
  Number,
  
  /// <summary>
  /// singleLineOfText.
  /// </summary>
  [XmlEnum("singleLineOfText")]
  SingleLineOfText,
  
}
