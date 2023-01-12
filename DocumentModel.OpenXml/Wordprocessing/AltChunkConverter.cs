namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Defines the AltChunk Class.
/// </summary>
public static class AltChunkConverter
{
  /// <summary>
  /// Relationship to Part
  /// </summary>
  public static String? GetId(DocumentFormat.OpenXml.Wordprocessing.AltChunk? openXmlElement)
  {
    return openXmlElement?.Id?.Value;
  }
  
  public static void SetId(DocumentFormat.OpenXml.Wordprocessing.AltChunk? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Id = new StringValue { Value = value };
      else
        openXmlElement.Id = null;
  }
  
  /// <summary>
  /// External Content Import Properties.
  /// </summary>
  public static DocumentModel.Wordprocessing.AltChunkProperties? GetAltChunkProperties(DocumentFormat.OpenXml.Wordprocessing.AltChunk? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.AltChunkProperties>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Wordprocessing.AltChunkPropertiesConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetAltChunkProperties(DocumentFormat.OpenXml.Wordprocessing.AltChunk? openXmlElement, DocumentModel.Wordprocessing.AltChunkProperties? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.AltChunkProperties>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Wordprocessing.AltChunkPropertiesConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.AltChunkProperties>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static DocumentModel.Wordprocessing.AltChunk? CreateModelElement(DocumentFormat.OpenXml.Wordprocessing.AltChunk? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Wordprocessing.AltChunk();
      value.Id = GetId(openXmlElement);
      value.AltChunkProperties = GetAltChunkProperties(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Wordprocessing.AltChunk? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Wordprocessing.AltChunk, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetId(openXmlElement, value?.Id);
      SetAltChunkProperties(openXmlElement, value?.AltChunkProperties);
      return openXmlElement;
    }
    return default;
  }
}
