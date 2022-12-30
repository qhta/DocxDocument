namespace DocumentModel.Wordprocessing;

/// <summary>
/// Symbol Character.
/// </summary>
public partial class SymbolChar
{
  /// <summary>
  /// Symbol Character Font
  /// </summary>
  public String? Font { get; set; }
  
  /// <summary>
  /// Symbol Character Code
  /// </summary>
  public DocumentModel.HexBinary? Char { get; set; }
  
}
