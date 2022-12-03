namespace DocumentModel.Presentation;

/// <summary>
/// Chart Subelement Type
/// </summary>
public enum ChartSubElementKind
{
  /// <summary>
  /// Chart Build Element Type Enum ( Grid Legend ).
  /// </summary>
  [XmlEnum("gridLegend")]
  GridLegend,
  
  /// <summary>
  /// Chart Build Element Type Enum ( Series ).
  /// </summary>
  [XmlEnum("series")]
  Series,
  
  /// <summary>
  /// Chart Build Element Type Enum ( Category ).
  /// </summary>
  [XmlEnum("category")]
  Category,
  
  /// <summary>
  /// Chart Build Element Type Enum ( Point in Series ).
  /// </summary>
  [XmlEnum("ptInSeries")]
  PointInSeries,
  
  /// <summary>
  /// Chart Build Element Type Enum ( Point in Cat ).
  /// </summary>
  [XmlEnum("ptInCategory")]
  PointInCategory,
  
}
