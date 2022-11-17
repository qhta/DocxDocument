namespace DocumentModel.Spreadsheet;

public enum CellFormula
{

  [XmlEnum("normal")]
  Normal,

  [XmlEnum("array")]
  Array,

  [XmlEnum("dataTable")]
  DataTable,

  [XmlEnum("shared")]
  Shared,
}
