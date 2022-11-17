namespace DocumentModel.Spreadsheet;

public enum ConditionalFormat
{

  [XmlEnum("expression")]
  Expression,

  [XmlEnum("cellIs")]
  CellIs,

  [XmlEnum("colorScale")]
  ColorScale,

  [XmlEnum("dataBar")]
  DataBar,

  [XmlEnum("iconSet")]
  IconSet,

  [XmlEnum("top10")]
  Top10,

  [XmlEnum("uniqueValues")]
  UniqueValues,

  [XmlEnum("duplicateValues")]
  DuplicateValues,

  [XmlEnum("containsText")]
  ContainsText,

  [XmlEnum("notContainsText")]
  NotContainsText,

  [XmlEnum("beginsWith")]
  BeginsWith,

  [XmlEnum("endsWith")]
  EndsWith,

  [XmlEnum("containsBlanks")]
  ContainsBlanks,

  [XmlEnum("notContainsBlanks")]
  NotContainsBlanks,

  [XmlEnum("containsErrors")]
  ContainsErrors,

  [XmlEnum("notContainsErrors")]
  NotContainsErrors,

  [XmlEnum("timePeriod")]
  TimePeriod,

  [XmlEnum("aboveAverage")]
  AboveAverage,
}
