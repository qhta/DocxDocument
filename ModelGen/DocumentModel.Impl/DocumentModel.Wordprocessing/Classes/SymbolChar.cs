namespace DocumentModel.Wordprocessing;

/// <summary>
/// Symbol Character.
/// </summary>
public class SymbolCharImpl: ModelElementImpl, SymbolChar
{
  public DocumentFormat.OpenXml.Wordprocessing.SymbolChar? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Wordprocessing.SymbolChar?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  /// <summary>
  /// Symbol Character Font
  /// </summary>
  public String? Font
  {
    get;
    set;
  }
  
  /// <summary>
  /// Symbol Character Code
  /// </summary>
  public DocumentModel.HexBinaryValue? Char
  {
    get;
    set;
  }
  
}
