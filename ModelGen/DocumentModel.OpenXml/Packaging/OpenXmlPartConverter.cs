namespace DocumentModel.OpenXml.Packaging;

/// <summary>
/// Represents an abstract base class for all OpenXml parts.
/// </summary>
public static class OpenXmlPartConverter
{
  /// <summary>
  /// Gets the internal part path in the package.
  /// </summary>
  private static Uri? GetUri(DXPack.OpenXmlPart openXmlElement)
  {
    return openXmlElement?.Uri;
  }
  
  private static bool CmpUri(DXPack.OpenXmlPart openXmlElement, Uri? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.Uri == value) return true;
    diffs?.Add(objName, "Uri", openXmlElement?.Uri, value);
    return false;
  }
  
  /// <summary>
  /// Gets the content type (MIME type) of the content data in the part.
  /// </summary>
  private static String? GetContentType(DXPack.OpenXmlPart openXmlElement)
  {
    return openXmlElement?.ContentType;
  }
  
  private static bool CmpContentType(DXPack.OpenXmlPart openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.ContentType == value) return true;
    diffs?.Add(objName, "ContentType", openXmlElement?.ContentType, value);
    return false;
  }
  
  /// <summary>
  /// Gets the relationship type of the part.
  /// </summary>
  private static String? GetRelationshipType(DXPack.OpenXmlPart openXmlElement)
  {
    return openXmlElement?.RelationshipType;
  }
  
  private static bool CmpRelationshipType(DXPack.OpenXmlPart openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.RelationshipType == value) return true;
    diffs?.Add(objName, "RelationshipType", openXmlElement?.RelationshipType, value);
    return false;
  }
  
  /// <summary>
  /// Gets the root element of the current part.
  /// </summary>
  private static DM.ModelElement? GetRootElement(DXPack.OpenXmlPart openXmlElement)
  {
      return DMX.ModelElementConverter.CreateModelElement(openXmlElement?.RootElement as DX.OpenXmlPartRootElement);
  }
  
  private static bool CmpRootElement(DXPack.OpenXmlPart openXmlElement, DM.ModelElement? value, DiffList? diffs, string? objName)
  {
      return true;
  }
  
  public static DocumentModel.Packaging.OpenXmlPart? CreateModelElement(DXPack.OpenXmlPart? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Packaging.OpenXmlPart();
      value.Uri = GetUri(openXmlElement);
      value.ContentType = GetContentType(openXmlElement);
      value.RelationshipType = GetRelationshipType(openXmlElement);
      value.RootElement = GetRootElement(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXPack.OpenXmlPart? openXmlElement, DMPack.OpenXmlPart? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpUri(openXmlElement, value.Uri, diffs, objName))
        ok = false;
      if (!CmpContentType(openXmlElement, value.ContentType, diffs, objName))
        ok = false;
      if (!CmpRelationshipType(openXmlElement, value.RelationshipType, diffs, objName))
        ok = false;
      if (!CmpRootElement(openXmlElement, value.RootElement, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMPack.OpenXmlPart value)
    where OpenXmlElementType: DXPack.OpenXmlPart, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXPack.OpenXmlPart openXmlElement, DMPack.OpenXmlPart value)
  {
    //SetUri(openXmlElement, value?.Uri);
    //SetContentType(openXmlElement, value?.ContentType);
    //SetRelationshipType(openXmlElement, value?.RelationshipType);
    //SetRootElement(openXmlElement, value?.RootElement);
  }
}
