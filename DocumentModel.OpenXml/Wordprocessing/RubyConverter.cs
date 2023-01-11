namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Phonetic Guide.
/// </summary>
public static class RubyConverter
{
  /// <summary>
  /// Phonetic Guide Properties.
  /// </summary>
  public static DocumentModel.Wordprocessing.RubyProperties? GetRubyProperties(DocumentFormat.OpenXml.Wordprocessing.Ruby? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.RubyProperties>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Wordprocessing.RubyPropertiesConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetRubyProperties(DocumentFormat.OpenXml.Wordprocessing.Ruby? openXmlElement, DocumentModel.Wordprocessing.RubyProperties? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.RubyProperties>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Wordprocessing.RubyPropertiesConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.RubyProperties>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  /// <summary>
  /// Phonetic Guide Text.
  /// </summary>
  public static DocumentModel.Wordprocessing.RubyContent? GetRubyContent(DocumentFormat.OpenXml.Wordprocessing.Ruby? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.RubyContent>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Wordprocessing.RubyContentConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetRubyContent(DocumentFormat.OpenXml.Wordprocessing.Ruby? openXmlElement, DocumentModel.Wordprocessing.RubyContent? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.RubyContent>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Wordprocessing.RubyContentConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.RubyContent>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  /// <summary>
  /// Phonetic Guide Base Text.
  /// </summary>
  public static DocumentModel.Wordprocessing.RubyBase? GetRubyBase(DocumentFormat.OpenXml.Wordprocessing.Ruby? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.RubyBase>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Wordprocessing.RubyBaseConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetRubyBase(DocumentFormat.OpenXml.Wordprocessing.Ruby? openXmlElement, DocumentModel.Wordprocessing.RubyBase? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.RubyBase>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Wordprocessing.RubyBaseConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.RubyBase>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static DocumentModel.Wordprocessing.Ruby? CreateModelElement(DocumentFormat.OpenXml.Wordprocessing.Ruby? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Wordprocessing.Ruby();
      value.RubyProperties = GetRubyProperties(openXmlElement);
      value.RubyContent = GetRubyContent(openXmlElement);
      value.RubyBase = GetRubyBase(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Wordprocessing.Ruby? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Wordprocessing.Ruby, new()
  {
  throw new NotImplementedException("Not implemented in GenerateCreateOpenXmlElementMethod: 1");
  }
}
