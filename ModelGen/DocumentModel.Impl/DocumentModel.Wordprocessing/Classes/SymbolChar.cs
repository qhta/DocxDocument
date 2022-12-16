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
  public DocumentModel.HexBinary? Char
  {
    get
    {
      if (OpenXmlElement?.Char?.Value != null)
        return (DocumentModel.HexBinary)OpenXmlElement.Char.Value;
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        if (value != null)
          OpenXmlElement.Char = new DocumentFormat.OpenXml.HexBinaryValue{ Value = value.ToString() };
        else
          OpenXmlElement.Char = null;
      }
    }
  }
  
}
