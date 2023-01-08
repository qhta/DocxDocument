namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Glossary Document Entry Properties.
/// </summary>
public static class DocPartPropertiesConverter
{
  /// <summary>
  /// Entry Name.
  /// </summary>
  public static DocumentModel.Wordprocessing.DocPartName? GetDocPartName(DocumentFormat.OpenXml.Wordprocessing.DocPartProperties? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetDocPartName(DocumentFormat.OpenXml.Wordprocessing.DocPartProperties? openXmlElement, DocumentModel.Wordprocessing.DocPartName? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// Associated Paragraph Style Name.
  /// </summary>
  public static String? GetStyleId(DocumentFormat.OpenXml.Wordprocessing.DocPartProperties? openXmlElement)
  {
    return openXmlElement?.StyleId?.Val?.Value;
  }
  
  public static void SetStyleId(DocumentFormat.OpenXml.Wordprocessing.DocPartProperties? openXmlElement, String? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// Entry Categorization.
  /// </summary>
  public static DocumentModel.Wordprocessing.Category? GetCategory(DocumentFormat.OpenXml.Wordprocessing.DocPartProperties? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetCategory(DocumentFormat.OpenXml.Wordprocessing.DocPartProperties? openXmlElement, DocumentModel.Wordprocessing.Category? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// Entry Types.
  /// </summary>
  public static DocumentModel.Wordprocessing.DocPartTypes? GetDocPartTypes(DocumentFormat.OpenXml.Wordprocessing.DocPartProperties? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetDocPartTypes(DocumentFormat.OpenXml.Wordprocessing.DocPartProperties? openXmlElement, DocumentModel.Wordprocessing.DocPartTypes? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// Entry Insertion Behaviors.
  /// </summary>
  public static DocumentModel.Wordprocessing.Behaviors? GetBehaviors(DocumentFormat.OpenXml.Wordprocessing.DocPartProperties? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetBehaviors(DocumentFormat.OpenXml.Wordprocessing.DocPartProperties? openXmlElement, DocumentModel.Wordprocessing.Behaviors? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// Description for Entry.
  /// </summary>
  public static String? GetDescription(DocumentFormat.OpenXml.Wordprocessing.DocPartProperties? openXmlElement)
  {
    return openXmlElement?.Description?.Val?.Value;
  }
  
  public static void SetDescription(DocumentFormat.OpenXml.Wordprocessing.DocPartProperties? openXmlElement, String? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// Entry ID.
  /// </summary>
  public static String? GetDocPartId(DocumentFormat.OpenXml.Wordprocessing.DocPartProperties? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in propertyType is DocumentFormat.OpenXml.Wordprocessing.DocPartId");
  }
  
  public static void SetDocPartId(DocumentFormat.OpenXml.Wordprocessing.DocPartProperties? openXmlElement, String? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
}
