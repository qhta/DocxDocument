namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the type of item assigned to the key binding.
/// </summary>
public enum WdKeyCategory
{
  /// <summary>
  /// Key is disabled.
  /// </summary>
  wdKeyCategoryDisable = unchecked((int)0),
  /// <summary>
  /// Key is assigned to a command
  /// </summary>
  wdKeyCategoryCommand = unchecked((int)1),
  /// <summary>
  /// Key is assigned to a
  /// </summary>
  wdKeyCategoryMacro = unchecked((int)2),
  /// <summary>
  /// Key is assigned to a font.
  /// </summary>
  wdKeyCategoryFont = unchecked((int)3),
  /// <summary>
  /// Key is assigned to autotext.
  /// </summary>
  wdKeyCategoryAutoText = unchecked((int)4),
  /// <summary>
  /// Key is assigned to a style.
  /// </summary>
  wdKeyCategoryStyle = unchecked((int)5),
  /// <summary>
  /// Key is assigned to a symbol.
  /// </summary>
  wdKeyCategorySymbol = unchecked((int)6),
  /// <summary>
  /// Key is assigned to a prefix.
  /// </summary>
  wdKeyCategoryPrefix = unchecked((int)7),
  /// <summary>
  /// Specifies the type of item assigned to the key binding.
  /// </summary>
  wdKeyCategoryNil = unchecked((int)-1)
}
