namespace DocumentModel.OpenXml.Packaging;

/// <summary>
/// Defines the WordCommentsExtensiblePart
/// </summary>
public static class WordCommentsExtensiblePartConverter
{
  /// <summary>
  /// Gets or sets the root element of this part.
  /// </summary>
  public static DocumentModel.Wordprocessing.CommentsExtensible? GetCommentsExtensible(DocumentFormat.OpenXml.Packaging.WordCommentsExtensiblePart? openXmlElement)
  {
    if (openXmlElement?.RootElement is DocumentFormat.OpenXml.Office2021.Word.CommentsExt.CommentsExtensible rootElement)
      return DocumentModel.OpenXml.Wordprocessing.CommentsExtensibleConverter.CreateModelElement(rootElement);
    return null;
  }
  
  public static void SetCommentsExtensible(DocumentFormat.OpenXml.Packaging.WordCommentsExtensiblePart? openXmlElement, DocumentModel.Wordprocessing.CommentsExtensible? value)
  {
    if (openXmlElement != null)
      if (value != null)
      {
         var rootElement = DocumentModel.OpenXml.Wordprocessing.CommentsExtensibleConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2021.Word.CommentsExt.CommentsExtensible>(value);
         if (rootElement != null)
           openXmlElement.CommentsExtensible = rootElement;
      }
  }
  
  public static String? GetContentType(DocumentFormat.OpenXml.Packaging.WordCommentsExtensiblePart? openXmlElement)
  {
    return openXmlElement?.ContentType;
  }
  
  public static String? GetRelationshipType(DocumentFormat.OpenXml.Packaging.WordCommentsExtensiblePart? openXmlElement)
  {
    return openXmlElement?.RelationshipType;
  }
  
  public static DocumentModel.Packaging.WordCommentsExtensiblePart? CreateModelElement(DocumentFormat.OpenXml.Packaging.WordCommentsExtensiblePart? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Packaging.WordCommentsExtensiblePart();
      value.CommentsExtensible = GetCommentsExtensible(openXmlElement);
      value.ContentType = GetContentType(openXmlElement);
      value.RelationshipType = GetRelationshipType(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Packaging.WordCommentsExtensiblePart? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Packaging.WordCommentsExtensiblePart, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetCommentsExtensible(openXmlElement, value?.CommentsExtensible);
      //SetContentType(openXmlElement, value?.ContentType);
      //SetRelationshipType(openXmlElement, value?.RelationshipType);
      return openXmlElement;
    }
    return default;
  }
}
