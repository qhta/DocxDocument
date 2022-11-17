namespace DocumentModel.Office2013.Excel;

public enum QuestionType
{

  [XmlEnum("checkBox")]
  CheckBox,

  [XmlEnum("choice")]
  Choice,

  [XmlEnum("date")]
  Date,

  [XmlEnum("time")]
  Time,

  [XmlEnum("multipleLinesOfText")]
  MultipleLinesOfText,

  [XmlEnum("number")]
  Number,

  [XmlEnum("singleLineOfText")]
  SingleLineOfText,
}
