namespace DocumentModel.Spreadsheet;

public enum RowColumnAction
{

  [XmlEnum("insertRow")]
  InsertRow,

  [XmlEnum("deleteRow")]
  DeleteRow,

  [XmlEnum("insertCol")]
  ColumnInsert,

  [XmlEnum("deleteCol")]
  DeleteColumn,
}
