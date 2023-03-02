namespace DocumentModel.Wordprocessing;

/// <summary>
///  Represents a symbol character in the text run. 
///  A symbol character is a special character which does not use any of the run fonts 
///  specified in the font table (or by the style hierarchy).
///  Instead, this character shall be determined by pulling the character with the hexadecimal value 
///  specified in the char attribute from the font specified in the font attribute.
/// </summary>
public record SymbolChar: RunElement
{
  /// <summary>
  ///   Symbol Character Font
  /// </summary>
  public String? Font { get; set; }

  /// <summary>
  ///   Symbol Character Code
  /// </summary>
  public HexChar? Char { get; set; }
}