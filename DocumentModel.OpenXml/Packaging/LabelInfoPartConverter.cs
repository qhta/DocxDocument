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
      return DMX.ClassificationLabelListConverter.CreateModelElement(openXmlElement?.RootElement as DXO2021MipLabelMeta.ClassificationLabelList);
  }
  
  private static bool CmpClassificationLabelList(DXPack.LabelInfoPart openXmlElement, DM.ClassificationLabelList? value, DiffList? diffs, string? objName)
  {
      return true;
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
  
  private static bool CmpContentType(DXPack.LabelInfoPart openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.ContentType == value;
  }
  
  private static String? GetRelationshipType(DXPack.LabelInfoPart openXmlElement)
  {
    return openXmlElement?.RelationshipType;
  }
  
  private static bool CmpRelationshipType(DXPack.LabelInfoPart openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.RelationshipType == value;
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
  
  public static bool CompareModelElement(DXPack.LabelInfoPart? openXmlElement, DMPack.LabelInfoPart? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpClassificationLabelList(openXmlElement, value.ClassificationLabelList, diffs, objName))
        ok = false;
      if (!CmpContentType(openXmlElement, value.ContentType, diffs, objName))
        ok = false;
      if (!CmpRelationshipType(openXmlElement, value.RelationshipType, diffs, objName))
        ok = false;
      return ok;
    }
    return openXmlElement == null && value == null;
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
