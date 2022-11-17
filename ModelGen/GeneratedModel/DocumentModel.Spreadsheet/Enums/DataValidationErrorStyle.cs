namespace DocumentModel.Spreadsheet;

public enum DataValidationErrorStyle
{

  [XmlEnum("stop")]
  Stop,

  [XmlEnum("warning")]
  Warning,

  [XmlEnum("information")]
  Information,
}
