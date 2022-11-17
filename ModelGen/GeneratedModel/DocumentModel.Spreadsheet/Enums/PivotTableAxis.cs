namespace DocumentModel.Spreadsheet;

public enum PivotTableAxis
{

  [XmlEnum("axisRow")]
  AxisRow,

  [XmlEnum("axisCol")]
  AxisColumn,

  [XmlEnum("axisPage")]
  AxisPage,

  [XmlEnum("axisValues")]
  AxisValues,
}
