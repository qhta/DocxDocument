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
      return DMX.ClassificationLabelListConverter.CreateModelElement(openXmlElement?.RootElement as DXO21MLMD.ClassificationLabelList);
  }
  
  private static bool CmpClassificationLabelList(DXPack.LabelInfoPart openXmlElement, DM.ClassificationLabelList? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
      return true;
  }
  
  private static void SetClassificationLabelList(DXPack.LabelInfoPart openXmlElement, DM.ClassificationLabelList? value)
  {
    if (value != null)
    {
       var rootElement = DMX.ClassificationLabelListConverter.CreateOpenXmlElement<DXO21MLMD.ClassificationLabelList>(value);
       if (rootElement != null)
         openXmlElement.ClassificationLabelList = rootElement;
    }
  }
  
  private static String? GetContentType(DXPack.LabelInfoPart openXmlElement)
  {
    return openXmlElement?.ContentType;
  }
  
  private static bool CmpContentType(DXPack.LabelInfoPart openXmlElement, String? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement?.ContentType == value) return true;
    diffs?.Add(objName, "ContentType", openXmlElement?.ContentType, value);
    return false;
  }
  
  private static String? GetRelationshipType(DXPack.LabelInfoPart openXmlElement)
  {
    return openXmlElement?.RelationshipType;
  }
  
  private static bool CmpRelationshipType(DXPack.LabelInfoPart openXmlElement, String? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement?.RelationshipType == value) return true;
    diffs?.Add(objName, "RelationshipType", openXmlElement?.RelationshipType, value);
    return false;
  }
  
  public static DocumentModel.Packaging.LabelInfoPart? CreateModelElement(DXPack.LabelInfoPart? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Packaging.LabelInfoPart();
      value.ClassificationLabelList = GetClassificationLabelList(openXmlElement);
      value.ContentType = GetContentType(openXmlElement);
      value.RelationshipType = GetRelationshipType(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXPack.LabelInfoPart? openXmlElement, DMPack.LabelInfoPart? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpClassificationLabelList(openXmlElement, value.ClassificationLabelList, diffs, objName, propName))
        ok = false;
      if (!CmpContentType(openXmlElement, value.ContentType, diffs, objName, propName))
        ok = false;
      if (!CmpRelationshipType(openXmlElement, value.RelationshipType, diffs, objName, propName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMPack.LabelInfoPart value)
    where OpenXmlElementType: DXPack.LabelInfoPart, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXPack.LabelInfoPart openXmlElement, DMPack.LabelInfoPart value)
  {
    SetClassificationLabelList(openXmlElement, value?.ClassificationLabelList);
    //SetContentType(openXmlElement, value?.ContentType);
    //SetRelationshipType(openXmlElement, value?.RelationshipType);
  }
}
