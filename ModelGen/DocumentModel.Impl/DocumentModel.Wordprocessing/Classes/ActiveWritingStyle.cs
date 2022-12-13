namespace DocumentModel.Wordprocessing;

/// <summary>
/// Grammar Checking Settings.
/// </summary>
public class ActiveWritingStyleImpl: ModelElementImpl, ActiveWritingStyle
{
  public DocumentFormat.OpenXml.Wordprocessing.ActiveWritingStyle? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Wordprocessing.ActiveWritingStyle?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public ActiveWritingStyleImpl(): base() {}
  
  public ActiveWritingStyleImpl(DocumentFormat.OpenXml.Wordprocessing.ActiveWritingStyle openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// Writing Style Language
  /// </summary>
  public String? Language
  {
    get => (System.String?)OpenXmlElement?.Language?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Language = (System.String?)value;
    }
  }
  
  /// <summary>
  /// Grammatical Engine ID
  /// </summary>
  public UInt16? VendorID
  {
    get => (System.UInt16?)OpenXmlElement?.VendorID?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.VendorID = (System.UInt16?)value;
    }
  }
  
  /// <summary>
  /// Grammatical Check Engine Version
  /// </summary>
  public Int32? DllVersion
  {
    get => (System.Int32?)OpenXmlElement?.DllVersion?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.DllVersion = (System.Int32?)value;
    }
  }
  
  /// <summary>
  /// Natural Language Grammar Check
  /// </summary>
  public Boolean? NaturalLanguageGrammarCheck
  {
    get => (System.Boolean?)OpenXmlElement?.NaturalLanguageGrammarCheck?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.NaturalLanguageGrammarCheck = (System.Boolean?)value;
    }
  }
  
  /// <summary>
  /// Check Stylistic Rules With Grammar
  /// </summary>
  public Boolean? CheckStyle
  {
    get => (System.Boolean?)OpenXmlElement?.CheckStyle?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.CheckStyle = (System.Boolean?)value;
    }
  }
  
  /// <summary>
  /// Application Name
  /// </summary>
  public String? ApplicationName
  {
    get => (System.String?)OpenXmlElement?.ApplicationName?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.ApplicationName = (System.String?)value;
    }
  }
  
}
