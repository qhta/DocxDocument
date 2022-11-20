namespace DocumentModel.Office2013.Excel;

/// <summary>
/// Defines the QuestionFormat enumeration.
/// </summary>
public enum QuestionFormat
{
  /// <summary>
  /// generalDate.
  /// </summary>
  [XmlEnum("generalDate")]
  GeneralDate,
  
  /// <summary>
  /// longDate.
  /// </summary>
  [XmlEnum("longDate")]
  LongDate,
  
  /// <summary>
  /// shortDate.
  /// </summary>
  [XmlEnum("shortDate")]
  ShortDate,
  
  /// <summary>
  /// longTime.
  /// </summary>
  [XmlEnum("longTime")]
  LongTime,
  
  /// <summary>
  /// shortTime.
  /// </summary>
  [XmlEnum("shortTime")]
  ShortTime,
  
  /// <summary>
  /// generalNumber.
  /// </summary>
  [XmlEnum("generalNumber")]
  GeneralNumber,
  
  /// <summary>
  /// standard.
  /// </summary>
  [XmlEnum("standard")]
  Standard,
  
  /// <summary>
  /// fixed.
  /// </summary>
  [XmlEnum("fixed")]
  Fixed,
  
  /// <summary>
  /// percent.
  /// </summary>
  [XmlEnum("percent")]
  Percent,
  
  /// <summary>
  /// currency.
  /// </summary>
  [XmlEnum("currency")]
  Currency,
  
}
