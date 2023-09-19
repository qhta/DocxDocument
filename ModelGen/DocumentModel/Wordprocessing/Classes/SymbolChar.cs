namespace DocumentModel.Wordprocessing;


/// <summary>
///   This element specifies the presence of a symbol character at the current location in the run’s content. A symbol character is a special character within a run’s content which does not use any of the run fonts specified in the rFonts element (or by the style hierarchy).
/// </summary>
public partial class SymbolChar
{
  
  /// <summary>
  ///   Symbol Character Font
  /// </summary>
  [SchemaAttr("w:font")]
  public String? Font { get; set; }
  
  
  /// <summary>
  ///   Symbol Character Code
  /// </summary>
  [SchemaAttr("w:char")]
  public DocumentModel.HexBinaryValue? Char { get; set; }
  
}
