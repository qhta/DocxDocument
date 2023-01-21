namespace DocumentModel.OpenXml.Packaging;

/// <summary>
/// Defines the WordCommentsExtensiblePart
/// </summary>
public static class WordCommentsExtensiblePartConverter
{
  /// <summary>
  /// Gets or sets the root element of this part.
  /// </summary>
  private static DMW.CommentsExtensible? GetCommentsExtensible(DXPack.WordCommentsExtensiblePart openXmlElement)
  {
    if (openXmlElement?.RootElement is DXO2021WComtExt.CommentsExtensible rootElement)
      return DMXW.CommentsExtensibleConverter.CreateModelElement(rootElement);
    return null;
  }
  
  private static void SetCommentsExtensible(DXPack.WordCommentsExtensiblePart openXmlElement, DMW.CommentsExtensible? value)
  {
    if (value != null)
    {
       var rootElement = DMXW.CommentsExtensibleConverter.CreateOpenXmlElement<DXO2021WComtExt.CommentsExtensible>(value);
       if (rootElement != null)
         openXmlElement.CommentsExtensible = rootElement;
    }
  }
  
  private static String? GetContentType(DXPack.WordCommentsExtensiblePart openXmlElement)
  {
    return openXmlElement?.ContentType;
  }
  
  private static String? GetRelationshipType(DXPack.WordCommentsExtensiblePart openXmlElement)
  {
    return openXmlElement?.RelationshipType;
  }
  
  public static DMPack.WordCommentsExtensiblePart? CreateModelElement(DXPack.WordCommentsExtensiblePart? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMPack.WordCommentsExtensiblePart();
      value.CommentsExtensible = GetCommentsExtensible(openXmlElement);
      value.ContentType = GetContentType(openXmlElement);
      value.RelationshipType = GetRelationshipType(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMPack.WordCommentsExtensiblePart? value)
    where OpenXmlElementType: DXPack.WordCommentsExtensiblePart, new()
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
