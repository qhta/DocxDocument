namespace DocumentModel.Spreadsheet;

/// <summary>
/// Table Type
/// </summary>
public enum TableValues
{
  /// <summary>
  /// Worksheet.
  /// </summary>
  [XmlEnum("worksheet")]
  Worksheet,
  
  /// <summary>
  /// XML.
  /// </summary>
  [XmlEnum("xml")]
  Xml,
  
  /// <summary>
  /// Query Table.
  /// </summary>
  [XmlEnum("queryTable")]
  QueryTable,
  
}
