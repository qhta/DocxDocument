namespace DocumentModel.Wordprocessing;

  /// <summary>
  /// Represents a symbol character in a text run in WordprocessingML documents.
  /// A symbol character is a special character that does not use any of the run fonts specified in the font table or style hierarchy. Instead, the character is determined by pulling the character with the specified hexadecimal value from the specified font.
  /// </summary>
  public interface SymbolChar : RunContent
  {
    
    /// <summary>
    /// Font name from which the symbol character is selected.
    /// </summary>
    public string? Font { get; set; }
    
    /// <summary>
    /// Hexadecimal character code specifying the symbol to display from the given font.
    /// </summary>
    public HexChar? Char { get; set; }
  }