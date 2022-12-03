namespace DocumentModel.Spreadsheet;

/// <summary>
/// Defines the ConditionalFormattingValueObjectTypeValues enumeration.
/// </summary>
public enum ConditionalFormattingValueObjectKind
{
  /// <summary>
  /// num.
  /// </summary>
  [XmlEnum("num")]
  Numeric,
  
  /// <summary>
  /// percent.
  /// </summary>
  [XmlEnum("percent")]
  Percent,
  
  /// <summary>
  /// max.
  /// </summary>
  [XmlEnum("max")]
  Max,
  
  /// <summary>
  /// min.
  /// </summary>
  [XmlEnum("min")]
  Min,
  
  /// <summary>
  /// formula.
  /// </summary>
  [XmlEnum("formula")]
  Formula,
  
  /// <summary>
  /// percentile.
  /// </summary>
  [XmlEnum("percentile")]
  Percentile,
  
  /// <summary>
  /// autoMin.
  /// </summary>
  [XmlEnum("autoMin")]
  AutoMin,
  
  /// <summary>
  /// autoMax.
  /// </summary>
  [XmlEnum("autoMax")]
  AutoMax,
  
}
