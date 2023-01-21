namespace DocumentModel.OpenXml.Packaging;

/// <summary>
/// Called from constructors of derived parts to initialize the IFixedContentTypePart interface. All derived parts must be parts that have fixed content type.
/// </summary>
public static class IFixedContentTypePartConverter
{
  public static DMPack.IFixedContentTypePart? CreateModelElement(DXPack.IFixedContentTypePart? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMPack.IFixedContentTypePart();
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMPack.IFixedContentTypePart? value)
    where OpenXmlElementType: DXPack.IFixedContentTypePart, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      return openXmlElement;
    }
    return default;
  }
}
