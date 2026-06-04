namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the type of item assigned to the key binding.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdkeycategory?view=office-pia` for Office interop details.
/// </remarks>
[WordInteropEnumType("WdKeyCategory")]
public enum KeyCategory
{
  /// <summary>
  /// Key is disabled.
  /// </summary>
  [WordInteropEnumValue("wdKeyCategoryDisable")]
  Disable = 0,
  /// <summary>
  /// Key is assigned to a command
  /// </summary>
  [WordInteropEnumValue("wdKeyCategoryCommand")]
  Command = 1,
  /// <summary>
  /// Key is assigned to a
  /// </summary>
  [WordInteropEnumValue("wdKeyCategoryMacro")]
  Macro = 2,
  /// <summary>
  /// Key is assigned to a font.
  /// </summary>
  [WordInteropEnumValue("wdKeyCategoryFont")]
  Font = 3,
  /// <summary>
  /// Key is assigned to autotext.
  /// </summary>
  [WordInteropEnumValue("wdKeyCategoryAutoText")]
  AutoText = 4,
  /// <summary>
  /// Key is assigned to a style.
  /// </summary>
  [WordInteropEnumValue("wdKeyCategoryStyle")]
  Style = 5,
  /// <summary>
  /// Key is assigned to a symbol.
  /// </summary>
  [WordInteropEnumValue("wdKeyCategorySymbol")]
  Symbol = 6,
  /// <summary>
  /// Key is assigned to a prefix.
  /// </summary>
  [WordInteropEnumValue("wdKeyCategoryPrefix")]
  Prefix = 7,
  /// <summary>
  /// Key is not assigned.
  /// </summary>
  [WordInteropEnumValue("wdKeyCategoryNil")]
  Nil = -1
}
