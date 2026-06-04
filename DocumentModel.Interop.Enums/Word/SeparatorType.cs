namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the type of separator to place between items.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdseparatortype?view=office-pia` for Office interop details.
/// </remarks>
[WordInteropEnumType("WdSeparatorType")]
public enum SeparatorType
{
  /// <summary>
  /// A hyphen.
  /// </summary>
  [WordInteropEnumValue("wdSeparatorHyphen")]
  Hyphen = 0,
  /// <summary>
  /// A period.
  /// </summary>
  [WordInteropEnumValue("wdSeparatorPeriod")]
  Period = 1,
  /// <summary>
  /// A colon.
  /// </summary>
  [WordInteropEnumValue("wdSeparatorColon")]
  Colon = 2,
  /// <summary>
  /// An emphasized dash.
  /// </summary>
  [WordInteropEnumValue("wdSeparatorEmDash")]
  EmDash = 3,
  /// <summary>
  /// A standard dash.
  /// </summary>
  [WordInteropEnumValue("wdSeparatorEnDash")]
  EnDash = 4
}
