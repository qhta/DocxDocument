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
  
  /// <summary>
  /// Gets the content type (MIME type) of the data in the part.
  /// </summary>
  private static String? GetContentType(DXPack.DataPart openXmlElement)
  {
    return openXmlElement?.ContentType;
  }
  
  public static DMPack.DataPart? CreateModelElement(DXPack.DataPart? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMPack.DataPart();
      value.Uri = GetUri(openXmlElement);
      value.ContentType = GetContentType(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMPack.DataPart? value)
    where OpenXmlElementType: DXPack.DataPart, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      //SetUri(openXmlElement, value?.Uri);
      //SetContentType(openXmlElement, value?.ContentType);
      return openXmlElement;
    }
    return default;
  }
}
