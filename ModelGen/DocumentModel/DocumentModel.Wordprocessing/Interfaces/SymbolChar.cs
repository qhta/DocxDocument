namespace DocumentModel.Wordprocessing;

/// <summary>
/// Symbol Character.
/// </summary>
public interface SymbolChar // : System.Boolean
{
  /// <summary>
  /// Symbol Character Font
  /// </summary>
  public String? Font { get ; set; }
  
  /// <summary>
  /// Symbol Character Code
  /// </summary>
  public DocumentModel.HexBinaryValue? Char { get ; set; }
  
}
