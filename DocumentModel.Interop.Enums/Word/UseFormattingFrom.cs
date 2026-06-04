namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies a source to copy formatting from.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wduseformattingfrom?view=office-pia` for Office interop details.
/// </remarks>
[WordInteropEnumType("WdUseFormattingFrom")]
public enum UseFormattingFrom
{
  /// <summary>
  /// Copy source formatting from the current item.
  /// </summary>
  [WordInteropEnumValue("wdFormattingFromCurrent")]
  Current = 0,
  /// <summary>
  /// Copy source formatting from the current selection.
  /// </summary>
  [WordInteropEnumValue("wdFormattingFromSelected")]
  Selected = 1,
  /// <summary>
  /// Prompt the user for formatting to use.
  /// </summary>
  [WordInteropEnumValue("wdFormattingFromPrompt")]
  Prompt = 2
}
