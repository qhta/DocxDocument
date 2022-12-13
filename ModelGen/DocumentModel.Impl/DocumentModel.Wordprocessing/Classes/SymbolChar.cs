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
  
  public SymbolCharImpl(): base() {}
  
  public SymbolCharImpl(DocumentFormat.OpenXml.Wordprocessing.SymbolChar openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// Symbol Character Font
  /// </summary>
  public String? Font
  {
    get => (System.String?)OpenXmlElement?.Font?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Font = (System.String?)value;
    }
  }
  
  /// <summary>
  /// Symbol Character Code
  /// </summary>
  public DocumentModel.HexBinaryValue? Char
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
