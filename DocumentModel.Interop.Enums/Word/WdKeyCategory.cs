namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the type of item assigned to the key binding.
/// </summary>
public enum WdKeyCategory
{
  /// <summary>
  /// Key is disabled.
  /// </summary>
  Disable = unchecked((int)0),
  /// <summary>
  /// Key is assigned to a command
  /// </summary>
  Command = unchecked((int)1),
  /// <summary>
  /// Key is assigned to a
  /// </summary>
  Macro = unchecked((int)2),
  /// <summary>
  /// Key is assigned to a font.
  /// </summary>
  Font = unchecked((int)3),
  /// <summary>
  /// Key is assigned to autotext.
  /// </summary>
  AutoText = unchecked((int)4),
  /// <summary>
  /// Key is assigned to a style.
  /// </summary>
  Style = unchecked((int)5),
  /// <summary>
  /// Key is assigned to a symbol.
  /// </summary>
  Symbol = unchecked((int)6),
  /// <summary>
  /// Key is assigned to a prefix.
  /// </summary>
  Prefix = unchecked((int)7),
  /// <summary>
  /// Specifies the type of item assigned to the key binding.
  /// </summary>
  Nil = unchecked((int)-1)
}
