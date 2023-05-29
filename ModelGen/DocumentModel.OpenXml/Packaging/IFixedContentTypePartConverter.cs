namespace DocumentModel.OpenXml.Packaging;

/// <summary>
/// Called from constructors of derived parts to initialize the IFixedContentTypePart interface. All derived parts must be parts that have fixed content type.
/// </summary>
public static class IFixedContentTypePartConverter
{
  public static DocumentModel.Packaging.IFixedContentTypePart? CreateModelElement(DXPack.IFixedContentTypePart? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Packaging.IFixedContentTypePart();
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXPack.IFixedContentTypePart? openXmlElement, DMPack.IFixedContentTypePart? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMPack.IFixedContentTypePart value)
    where OpenXmlElementType: DXPack.IFixedContentTypePart, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXPack.IFixedContentTypePart openXmlElement, DMPack.IFixedContentTypePart value)
  {
  }
}
