namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the CheckBoxSymbolType Class.
/// </summary>
public class CheckBoxSymbolTypeImpl: ModelElementImpl, CheckBoxSymbolType
{
  public DocumentFormat.OpenXml.Office2010.Word.CheckBoxSymbolType? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office2010.Word.CheckBoxSymbolType?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public CheckBoxSymbolTypeImpl(): base() {}
  
  public CheckBoxSymbolTypeImpl(DocumentFormat.OpenXml.Office2010.Word.CheckBoxSymbolType openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// font, this property is only available in Office 2010 and later.
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
  /// val, this property is only available in Office 2010 and later.
  /// </summary>
  public DocumentModel.HexBinaryValue? Val
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
