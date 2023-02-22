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
      return DMXW.CommentsExtensibleConverter.CreateModelElement(openXmlElement?.RootElement as DXO2021WComtExt.CommentsExtensible);
  }
  
  private static bool CmpCommentsExtensible(DXPack.WordCommentsExtensiblePart openXmlElement, DMW.CommentsExtensible? value, DiffList? diffs, string? objName)
  {
      return true;
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
  
  private static bool CmpContentType(DXPack.WordCommentsExtensiblePart openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.ContentType == value) return true;
    diffs?.Add(objName, "ContentType", openXmlElement?.ContentType, value);
    return false;
  }
  
  private static String? GetRelationshipType(DXPack.WordCommentsExtensiblePart openXmlElement)
  {
    return openXmlElement?.RelationshipType;
  }
  
  private static bool CmpRelationshipType(DXPack.WordCommentsExtensiblePart openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.RelationshipType == value) return true;
    diffs?.Add(objName, "RelationshipType", openXmlElement?.RelationshipType, value);
    return false;
  }
  
  public static DocumentModel.Packaging.WordCommentsExtensiblePart? CreateModelElement(DXPack.WordCommentsExtensiblePart? openXmlElement)
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
  
  public static bool CompareModelElement(DXPack.WordCommentsExtensiblePart? openXmlElement, DMPack.WordCommentsExtensiblePart? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpCommentsExtensible(openXmlElement, value.CommentsExtensible, diffs, objName))
        ok = false;
      if (!CmpContentType(openXmlElement, value.ContentType, diffs, objName))
        ok = false;
      if (!CmpRelationshipType(openXmlElement, value.RelationshipType, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMPack.WordCommentsExtensiblePart value)
    where OpenXmlElementType: DXPack.WordCommentsExtensiblePart, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXPack.WordCommentsExtensiblePart openXmlElement, DMPack.WordCommentsExtensiblePart value)
  {
    SetCommentsExtensible(openXmlElement, value?.CommentsExtensible);
    //SetContentType(openXmlElement, value?.ContentType);
    //SetRelationshipType(openXmlElement, value?.RelationshipType);
    }
  }
