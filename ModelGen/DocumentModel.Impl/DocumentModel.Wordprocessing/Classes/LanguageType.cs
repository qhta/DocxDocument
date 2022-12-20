namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the LanguageType Class.
/// </summary>
public partial class LanguageTypeImpl: ModelElementImpl, LanguageType
{
  public DocumentFormat.OpenXml.Wordprocessing.LanguageType? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Wordprocessing.LanguageType?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public LanguageTypeImpl(): base() {}
  
  public LanguageTypeImpl(DocumentFormat.OpenXml.Wordprocessing.LanguageType openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// Latin Language
  /// </summary>
  public String? Val
  {
    get => (System.String?)OpenXmlElement?.Val?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Val = (System.String?)value;
    }
  }
  
  /// <summary>
  /// East Asian Language
  /// </summary>
  public String? EastAsia
  {
    get => (System.String?)OpenXmlElement?.EastAsia?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.EastAsia = (System.String?)value;
    }
  }
  
  /// <summary>
  /// Complex Script Language
  /// </summary>
  public String? Bidi
  {
    get => (System.String?)OpenXmlElement?.Bidi?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Bidi = (System.String?)value;
    }
  }
  
}
