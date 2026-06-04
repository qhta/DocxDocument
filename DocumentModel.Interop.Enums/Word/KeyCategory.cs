namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the type of item assigned to the key binding.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdkeycategory?view=office-pia` for Office interop details.
/// </remarks>
[InteropEnumType("Microsoft.Office.Interop.Word.WdKeyCategory")]
public enum KeyCategory
{
  /// <summary>
  /// Key is disabled.
  /// </summary>
  [InteropEnumValue("wdKeyCategoryDisable")]
  Disable = 0,
  /// <summary>
  /// Key is assigned to a command
  /// </summary>
  [InteropEnumValue("wdKeyCategoryCommand")]
  Command = 1,
  /// <summary>
  /// Key is assigned to a
  /// </summary>
  [InteropEnumValue("wdKeyCategoryMacro")]
  Macro = 2,
  /// <summary>
  /// Key is assigned to a font.
  /// </summary>
  [InteropEnumValue("wdKeyCategoryFont")]
  Font = 3,
  /// <summary>
  /// Key is assigned to autotext.
  /// </summary>
  [InteropEnumValue("wdKeyCategoryAutoText")]
  AutoText = 4,
  /// <summary>
  /// Key is assigned to a style.
  /// </summary>
  [InteropEnumValue("wdKeyCategoryStyle")]
  Style = 5,
  /// <summary>
  /// Key is assigned to a symbol.
  /// </summary>
  [InteropEnumValue("wdKeyCategorySymbol")]
  Symbol = 6,
  /// <summary>
  /// Key is assigned to a prefix.
  /// </summary>
  [InteropEnumValue("wdKeyCategoryPrefix")]
  Prefix = 7,
  /// <summary>
  /// Key is not assigned.
  /// </summary>
  [InteropEnumValue("wdKeyCategoryNil")]
  Nil = -1
}
