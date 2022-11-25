namespace DocumentModel.Presentation;

/// <summary>
/// OLE Chart Build Type
/// </summary>
public enum OleChartBuildKind
{
  /// <summary>
  /// Chart Build Type Enum ( All At Once ).
  /// </summary>
  AllAtOnce,
  
  /// <summary>
  /// Chart Build Type Enum ( Series ).
  /// </summary>
  Series,
  
  /// <summary>
  /// Chart Build Type Enum ( Category ).
  /// </summary>
  Category,
  
  /// <summary>
  /// Chart Build Type Enum ( Series Element ).
  /// </summary>
  SeriesElement,
  
  /// <summary>
  /// Chart Build Type Enum ( Category Element ).
  /// </summary>
  CategoryElement,
  
}
