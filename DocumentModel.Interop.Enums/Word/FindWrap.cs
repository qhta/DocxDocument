namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies wrap behavior if a selection or range is specified for a find operation and the search text isn't
/// found in the selection or range.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdfindwrap?view=office-pia` for Office interop details.
/// </remarks>
[WordInteropEnumType(typeof(Microsoft.Office.Interop.Word.WdFindWrap))]
public enum FindWrap
{
  /// <summary>
  /// The find operation ends if the beginning or end of the search range is reached.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdFindWrap.wdFindStop))]
  Stop = 0,
  /// <summary>
  /// The find operation continues if the beginning or end of the search range is reached.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdFindWrap.wdFindContinue))]
  Continue = 1,
  /// <summary>
  /// After searching the selection or range, Microsoft Word displays a message asking whether to search the
  /// remainder of the document.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdFindWrap.wdFindAsk))]
  Ask = 2
}
