namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies a source to copy formatting from.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wduseformattingfrom?view=office-pia` for Office interop details.
/// </remarks>
[InteropEnumType("Microsoft.Office.Interop.Word.WdUseFormattingFrom")]
public enum UseFormattingFrom
{
  /// <summary>
  /// Copy source formatting from the current item.
  /// </summary>
  [InteropEnumValue("wdFormattingFromCurrent")]
  Current = 0,
  /// <summary>
  /// Copy source formatting from the current selection.
  /// </summary>
  [InteropEnumValue("wdFormattingFromSelected")]
  Selected = 1,
  /// <summary>
  /// Prompt the user for formatting to use.
  /// </summary>
  [InteropEnumValue("wdFormattingFromPrompt")]
  Prompt = 2
}
