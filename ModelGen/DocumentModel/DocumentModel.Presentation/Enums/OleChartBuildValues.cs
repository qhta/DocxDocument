namespace DocumentModel.Presentation;

/// <summary>
/// OLE Chart Build Type
/// </summary>
public enum OleChartBuildValues
{
  /// <summary>
  /// Chart Build Type Enum ( All At Once ).
  /// </summary>
  [XmlEnum("allAtOnce")]
  AllAtOnce,
  
  /// <summary>
  /// Chart Build Type Enum ( Series ).
  /// </summary>
  [XmlEnum("series")]
  Series,
  
  /// <summary>
  /// Chart Build Type Enum ( Category ).
  /// </summary>
  [XmlEnum("category")]
  Category,
  
  /// <summary>
  /// Chart Build Type Enum ( Series Element ).
  /// </summary>
  [XmlEnum("seriesEl")]
  SeriesElement,
  
  /// <summary>
  /// Chart Build Type Enum ( Category Element ).
  /// </summary>
  [XmlEnum("categoryEl")]
  CategoryElement,
  
}
