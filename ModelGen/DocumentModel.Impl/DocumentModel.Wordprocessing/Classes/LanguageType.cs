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
    get;
    set;
  }
  
  /// <summary>
  /// East Asian Language
  /// </summary>
  public String? EastAsia
  {
    get;
    set;
  }
  
  /// <summary>
  /// Complex Script Language
  /// </summary>
  public String? Bidi
  {
    get;
    set;
  }
  
}
