namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the type of item assigned to the key binding.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdkeycategory?view=office-pia` for Office interop details.
/// </remarks>
public enum WdKeyCategory
{
  /// <summary>
  /// Key is disabled.
  /// </summary>
  Disable = 0,
  /// <summary>
  /// Key is assigned to a command
  /// </summary>
  Command = 1,
  /// <summary>
  /// Key is assigned to a
  /// </summary>
  Macro = 2,
  /// <summary>
  /// Key is assigned to a font.
  /// </summary>
  Font = 3,
  /// <summary>
  /// Key is assigned to autotext.
  /// </summary>
  AutoText = 4,
  /// <summary>
  /// Key is assigned to a style.
  /// </summary>
  Style = 5,
  /// <summary>
  /// Key is assigned to a symbol.
  /// </summary>
  Symbol = 6,
  /// <summary>
  /// Key is assigned to a prefix.
  /// </summary>
  Prefix = 7,
  /// <summary>
  /// Key is not assigned.
  /// </summary>
  Nil = -1
}
