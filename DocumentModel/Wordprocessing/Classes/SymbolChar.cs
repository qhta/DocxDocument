namespace DocumentModel.Wordprocessing;

/// <summary>
///   Symbol Character.
/// </summary>
public class SymbolChar
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