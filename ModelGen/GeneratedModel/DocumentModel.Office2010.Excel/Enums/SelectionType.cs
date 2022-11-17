namespace DocumentModel.Office2010.Excel;

public enum SelectionType
{

  [XmlEnum("single")]
  Single,

  [XmlEnum("multi")]
  Multiple,

  [XmlEnum("extended")]
  Extended,
}
