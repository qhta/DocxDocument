namespace DocumentModel.Spreadsheet;

/// <summary>
/// Formula Expression Type
/// </summary>
public enum FormulaExpressionValues
{
  /// <summary>
  /// Reference.
  /// </summary>
  [XmlEnum("ref")]
  Reference,
  
  /// <summary>
  /// Reference Is Error.
  /// </summary>
  [XmlEnum("refError")]
  ReferenceError,
  
  /// <summary>
  /// Area.
  /// </summary>
  [XmlEnum("area")]
  Area,
  
  /// <summary>
  /// Area Error.
  /// </summary>
  [XmlEnum("areaError")]
  AreaError,
  
  /// <summary>
  /// Computed Area.
  /// </summary>
  [XmlEnum("computedArea")]
  ComputedArea,
  
}
