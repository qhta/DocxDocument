namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the CheckBoxSymbolType Class.
/// </summary>
public partial class CheckBoxSymbolTypeImpl: ModelElementImpl, CheckBoxSymbolType
{
  [XmlIgnore]
  public DocumentFormat.OpenXml.Office2010.Word.CheckBoxSymbolType? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office2010.Word.CheckBoxSymbolType?)_OpenXmlElement;
    protected set => _OpenXmlElement = value;
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
  public DocumentModel.HexBinary? Val
  {
    get
    {
      if (OpenXmlElement?.Val?.Value != null)
        return (DocumentModel.HexBinary)OpenXmlElement.Val.Value;
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        if (value != null)
          OpenXmlElement.Val = new DocumentFormat.OpenXml.HexBinaryValue{ Value = value.ToString() };
        else
          OpenXmlElement.Val = null;
      }
    }
  }
  
}
