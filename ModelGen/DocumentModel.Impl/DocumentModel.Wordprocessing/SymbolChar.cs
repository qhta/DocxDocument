namespace DocumentModel.Wordprocessing;

/// <summary>
/// Symbol Character.
/// </summary>
public class SymbolChar: ISymbolChar
{
  /// <summary>
  /// Symbol Character Font
  /// </summary>
  public string? Font
  {
    get;
    set;
  }
  
  /// <summary>
  /// Symbol Character Code
  /// </summary>
  public IHexBinaryValue? Char
  {
    get;
    set;
  }
  
}
