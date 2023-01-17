namespace DocumentModel.OpenXml.Packaging;

/// <summary>
/// Defines the VbaDataPart
/// </summary>
public static class VbaDataPartConverter
{
  private static String? GetContentType(DocumentFormat.OpenXml.Packaging.VbaDataPart openXmlElement)
  {
    return openXmlElement?.ContentType;
  }
  
  private static String? GetRelationshipType(DocumentFormat.OpenXml.Packaging.VbaDataPart openXmlElement)
  {
    return openXmlElement?.RelationshipType;
  }
  
  /// <summary>
  /// Gets or sets the root element of this part.
  /// </summary>
  private static DocumentModel.Wordprocessing.VbaSuppData? GetVbaSuppData(DocumentFormat.OpenXml.Packaging.VbaDataPart openXmlElement)
  {
    if (openXmlElement?.RootElement is DocumentFormat.OpenXml.Office.Word.VbaSuppData rootElement)
      return DocumentModel.OpenXml.Wordprocessing.VbaSuppDataConverter.CreateModelElement(rootElement);
    return null;
  }
  
  private static void SetVbaSuppData(DocumentFormat.OpenXml.Packaging.VbaDataPart openXmlElement, DocumentModel.Wordprocessing.VbaSuppData? value)
  {
    if (value != null)
    {
       var rootElement = DocumentModel.OpenXml.Wordprocessing.VbaSuppDataConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office.Word.VbaSuppData>(value);
       if (rootElement != null)
         openXmlElement.VbaSuppData = rootElement;
    }
  }
  
  public static DocumentModel.Packaging.VbaDataPart? CreateModelElement(DocumentFormat.OpenXml.Packaging.VbaDataPart? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Packaging.VbaDataPart();
      value.ContentType = GetContentType(openXmlElement);
      value.RelationshipType = GetRelationshipType(openXmlElement);
      value.VbaSuppData = GetVbaSuppData(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Packaging.VbaDataPart? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Packaging.VbaDataPart, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      //SetContentType(openXmlElement, value?.ContentType);
      //SetRelationshipType(openXmlElement, value?.RelationshipType);
      SetVbaSuppData(openXmlElement, value?.VbaSuppData);
      return openXmlElement;
    }
    return default;
  }
}
