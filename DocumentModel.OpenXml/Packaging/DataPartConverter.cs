namespace DocumentModel.OpenXml.Packaging;

/// <summary>
/// Represents the type of part referenced by a .
/// </summary>
public static class DataPartConverter
{
  /// <summary>
  /// Gets the internal part path in the package.
  /// </summary>
  private static Uri? GetUri(DXPack.DataPart openXmlElement)
  {
    return openXmlElement?.Uri;
  }
  
  private static bool CmpUri(DXPack.DataPart openXmlElement, Uri? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.Uri == value) return true;
    diffs?.Add(objName, "Uri", openXmlElement?.Uri, value);
    return false;
  }
  
  /// <summary>
  /// Gets the content type (MIME type) of the data in the part.
  /// </summary>
  private static String? GetContentType(DXPack.DataPart openXmlElement)
  {
    return openXmlElement?.ContentType;
  }
  
  private static bool CmpContentType(DXPack.DataPart openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.ContentType == value) return true;
    diffs?.Add(objName, "ContentType", openXmlElement?.ContentType, value);
    return false;
  }
  
  public static DocumentModel.Packaging.DataPart? CreateModelElement(DXPack.DataPart? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Packaging.DataPart();
      value.Uri = GetUri(openXmlElement);
      value.ContentType = GetContentType(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXPack.DataPart? openXmlElement, DMPack.DataPart? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpUri(openXmlElement, value.Uri, diffs, objName))
        ok = false;
      if (!CmpContentType(openXmlElement, value.ContentType, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMPack.DataPart value)
    where OpenXmlElementType: DXPack.DataPart, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXPack.DataPart openXmlElement, DMPack.DataPart value)
  {
    //SetUri(openXmlElement, value?.Uri);
    //SetContentType(openXmlElement, value?.ContentType);
  }
}
