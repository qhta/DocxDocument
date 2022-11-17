namespace DocumentModel.Spreadsheet;

public enum CalculateMode
{

  [XmlEnum("manual")]
  Manual,

  [XmlEnum("auto")]
  Auto,

  [XmlEnum("autoNoTable")]
  AutoNoTable,
}
