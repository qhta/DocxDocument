namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the LanguageType Class.
/// </summary>
public class LanguageTypeImpl: ModelElementImpl, LanguageType
{
  public DocumentFormat.OpenXml.Wordprocessing.LanguageType? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Wordprocessing.LanguageType?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  /// <summary>
  /// Latin Language
  /// </summary>
  public String? Val
  {
    get => (String?)OpenXmlElement?.Val?.Value;
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
    get => (String?)OpenXmlElement?.EastAsia?.Value;
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
    get => (String?)OpenXmlElement?.Bidi?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Bidi = (System.String?)value;
    }
  }
  
}
