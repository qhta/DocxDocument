namespace DocumentModel.OpenXml.Packaging;

/// <summary>
/// Defines the VbaDataPart
/// </summary>
public static class VbaDataPartConverter
{
  private static String? GetContentType(DXPack.VbaDataPart openXmlElement)
  {
    return openXmlElement?.ContentType;
  }
  
  private static String? GetRelationshipType(DXPack.VbaDataPart openXmlElement)
  {
    return openXmlElement?.RelationshipType;
  }
  
  /// <summary>
  /// Gets or sets the root element of this part.
  /// </summary>
  private static DMW.VbaSuppData? GetVbaSuppData(DXPack.VbaDataPart openXmlElement)
  {
    if (openXmlElement?.RootElement is DXOW.VbaSuppData rootElement)
      return DMXW.VbaSuppDataConverter.CreateModelElement(rootElement);
    return null;
  }
  
  private static void SetVbaSuppData(DXPack.VbaDataPart openXmlElement, DMW.VbaSuppData? value)
  {
    if (value != null)
    {
       var rootElement = DMXW.VbaSuppDataConverter.CreateOpenXmlElement<DXOW.VbaSuppData>(value);
       if (rootElement != null)
         openXmlElement.VbaSuppData = rootElement;
    }
  }
  
  public static DMPack.VbaDataPart? CreateModelElement(DXPack.VbaDataPart? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMPack.VbaDataPart();
      value.ContentType = GetContentType(openXmlElement);
      value.RelationshipType = GetRelationshipType(openXmlElement);
      value.VbaSuppData = GetVbaSuppData(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMPack.VbaDataPart? value)
    where OpenXmlElementType: DXPack.VbaDataPart, new()
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
