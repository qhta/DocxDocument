namespace DocumentModel.OpenXml.Packaging;

/// <summary>
/// Defines the LabelInfoPart
/// </summary>
public static class LabelInfoPartConverter
{
  /// <summary>
  /// Gets or sets the root element of this part.
  /// </summary>
  private static DM.ClassificationLabelList? GetClassificationLabelList(DXPack.LabelInfoPart openXmlElement)
  {
    if (openXmlElement?.RootElement is DXO2021MipLabelMeta.ClassificationLabelList rootElement)
      return DMX.ClassificationLabelListConverter.CreateModelElement(rootElement);
    return null;
  }
  
  private static void SetClassificationLabelList(DXPack.LabelInfoPart openXmlElement, DM.ClassificationLabelList? value)
  {
    if (value != null)
    {
       var rootElement = DMX.ClassificationLabelListConverter.CreateOpenXmlElement<DXO2021MipLabelMeta.ClassificationLabelList>(value);
       if (rootElement != null)
         openXmlElement.ClassificationLabelList = rootElement;
    }
  }
  
  private static String? GetContentType(DXPack.LabelInfoPart openXmlElement)
  {
    return openXmlElement?.ContentType;
  }
  
  private static String? GetRelationshipType(DXPack.LabelInfoPart openXmlElement)
  {
    return openXmlElement?.RelationshipType;
  }
  
  public static DMPack.LabelInfoPart? CreateModelElement(DXPack.LabelInfoPart? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMPack.LabelInfoPart();
      value.ClassificationLabelList = GetClassificationLabelList(openXmlElement);
      value.ContentType = GetContentType(openXmlElement);
      value.RelationshipType = GetRelationshipType(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMPack.LabelInfoPart? value)
    where OpenXmlElementType: DXPack.LabelInfoPart, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetClassificationLabelList(openXmlElement, value?.ClassificationLabelList);
      //SetContentType(openXmlElement, value?.ContentType);
      //SetRelationshipType(openXmlElement, value?.RelationshipType);
      return openXmlElement;
    }
    return default;
  }
}
