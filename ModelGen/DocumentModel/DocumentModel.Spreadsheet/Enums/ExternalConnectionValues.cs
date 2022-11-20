namespace DocumentModel.Spreadsheet;

/// <summary>
/// Text Field Data Type
/// </summary>
public enum ExternalConnectionValues
{
  /// <summary>
  /// General.
  /// </summary>
  [XmlEnum("general")]
  General,
  
  /// <summary>
  /// Text.
  /// </summary>
  [XmlEnum("text")]
  Text,
  
  /// <summary>
  /// Month Day Year.
  /// </summary>
  [XmlEnum("MDY")]
  MonthDayYear,
  
  /// <summary>
  /// Day Month Year.
  /// </summary>
  [XmlEnum("DMY")]
  DayMonthYear,
  
  /// <summary>
  /// Year Month Day.
  /// </summary>
  [XmlEnum("YMD")]
  YearMonthDay,
  
  /// <summary>
  /// Month Day Year.
  /// </summary>
  [XmlEnum("MYD")]
  MonthYearDay,
  
  /// <summary>
  /// Day Year Month.
  /// </summary>
  [XmlEnum("DYM")]
  DayYearMonth,
  
  /// <summary>
  /// Year Day Month.
  /// </summary>
  [XmlEnum("YDM")]
  YearDayMonth,
  
  /// <summary>
  /// Skip Field.
  /// </summary>
  [XmlEnum("skip")]
  Skip,
  
  /// <summary>
  /// East Asian Year Month Day.
  /// </summary>
  [XmlEnum("EMD")]
  EMD,
  
}
