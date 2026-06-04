namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the level of importance of a style sheet compared to other cascading style sheets attached to the
/// Web document.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdstylesheetprecedence?view=office-pia` for Office interop details.
/// </remarks>
[WordInteropEnumType(typeof(Microsoft.Office.Interop.Word.WdStyleSheetPrecedence))]
public enum StyleSheetPrecedence
{
  /// <summary>
  /// Lowest precedence.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdStyleSheetPrecedence.wdStyleSheetPrecedenceLowest))]
  Lowest = 0,
  /// <summary>
  /// Highest precedence.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdStyleSheetPrecedence.wdStyleSheetPrecedenceHighest))]
  Highest = 1,
  /// <summary>
  /// Lower precedence.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdStyleSheetPrecedence.wdStyleSheetPrecedenceLower))]
  Lower = -2,
  /// <summary>
  /// Raise precedence.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdStyleSheetPrecedence.wdStyleSheetPrecedenceHigher))]
  Higher = -1
}
