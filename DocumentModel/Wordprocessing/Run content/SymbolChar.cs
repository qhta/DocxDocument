namespace DocumentModel.Wordprocessing;

/// <summary>
///  Represents a symbol character Iin the text run. 
///  A symbol character is a special character which does not use any of the run fonts 
///  specified Iin the font table (or by the style hierarchy).
///  Instead, this character shall be determined by pulling the character with the hexadecimal value 
///  specified Iin the char attribute from the font specified Iin the font attribute.
/// </summary>
public class SymbolChar: ModelElement, IRunContent
{
  /// <summary>
  ///   Symbol Character IFont
  /// </summary>
  public string? IFont { get; set; }

  /// <summary>
  ///   Symbol Character Code
  /// </summary>
  public HexChar? Char { get; set; }
}
