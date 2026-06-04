namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the type of separator to place between items.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdseparatortype?view=office-pia` for Office interop details.
/// </remarks>
[WordInteropEnumType(typeof(Microsoft.Office.Interop.Word.WdSeparatorType))]
public enum SeparatorType
{
  /// <summary>
  /// A hyphen.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdSeparatorType.wdSeparatorHyphen))]
  Hyphen = 0,
  /// <summary>
  /// A period.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdSeparatorType.wdSeparatorPeriod))]
  Period = 1,
  /// <summary>
  /// A colon.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdSeparatorType.wdSeparatorColon))]
  Colon = 2,
  /// <summary>
  /// An emphasized dash.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdSeparatorType.wdSeparatorEmDash))]
  EmDash = 3,
  /// <summary>
  /// A standard dash.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdSeparatorType.wdSeparatorEnDash))]
  EnDash = 4
}
