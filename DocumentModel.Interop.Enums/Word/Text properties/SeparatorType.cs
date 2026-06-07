namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the type of separator to place between items.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdseparatortype?view=office-pia` for Office interop details.
/// </remarks>
[InteropEnumType("Microsoft.Office.Interop.Word.WdSeparatorType")]
public enum SeparatorType
{
  /// <summary>
  /// A hyphen.
  /// </summary>
  [InteropEnumValue("wdSeparatorHyphen")]
  Hyphen = 0,
  /// <summary>
  /// A period.
  /// </summary>
  [InteropEnumValue("wdSeparatorPeriod")]
  Period = 1,
  /// <summary>
  /// A colon.
  /// </summary>
  [InteropEnumValue("wdSeparatorColon")]
  Colon = 2,
  /// <summary>
  /// An emphasized dash.
  /// </summary>
  [InteropEnumValue("wdSeparatorEmDash")]
  EmDash = 3,
  /// <summary>
  /// A standard dash.
  /// </summary>
  [InteropEnumValue("wdSeparatorEnDash")]
  EnDash = 4
}
