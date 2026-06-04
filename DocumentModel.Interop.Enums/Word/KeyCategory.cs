namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the type of item assigned to the key binding.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdkeycategory?view=office-pia` for Office interop details.
/// </remarks>
[WordInteropEnumType(typeof(Microsoft.Office.Interop.Word.WdKeyCategory))]
public enum KeyCategory
{
  /// <summary>
  /// Key is disabled.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdKeyCategory.wdKeyCategoryDisable))]
  Disable = 0,
  /// <summary>
  /// Key is assigned to a command
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdKeyCategory.wdKeyCategoryCommand))]
  Command = 1,
  /// <summary>
  /// Key is assigned to a
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdKeyCategory.wdKeyCategoryMacro))]
  Macro = 2,
  /// <summary>
  /// Key is assigned to a font.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdKeyCategory.wdKeyCategoryFont))]
  Font = 3,
  /// <summary>
  /// Key is assigned to autotext.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdKeyCategory.wdKeyCategoryAutoText))]
  AutoText = 4,
  /// <summary>
  /// Key is assigned to a style.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdKeyCategory.wdKeyCategoryStyle))]
  Style = 5,
  /// <summary>
  /// Key is assigned to a symbol.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdKeyCategory.wdKeyCategorySymbol))]
  Symbol = 6,
  /// <summary>
  /// Key is assigned to a prefix.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdKeyCategory.wdKeyCategoryPrefix))]
  Prefix = 7,
  /// <summary>
  /// Key is not assigned.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdKeyCategory.wdKeyCategoryNil))]
  Nil = -1
}
