namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
/// Defines the RelationshipIdType Class.
/// </summary>
public static class RelationshipIdTypeConverter
{
  /// <summary>
  /// Relationship Reference
  /// </summary>
  private static String? GetId(DXDC.RelationshipIdType openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Id);
  }
  
  private static bool CmpId(DXDC.RelationshipIdType openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Id, value, diffs, objName, "AnnotationId");
  }
  
  private static void SetId(DXDC.RelationshipIdType openXmlElement, String? value)
  {
    openXmlElement.Id = StringValueConverter.CreateStringValue(value);
  }
  
  public static DocumentModel.Drawings.Charts.RelationshipIdType? CreateModelElement(DXDC.RelationshipIdType? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Charts.RelationshipIdType();
      value.Id = GetId(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXDC.RelationshipIdType? openXmlElement, DMDC.RelationshipIdType? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpId(openXmlElement, value.Id, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDC.RelationshipIdType value)
    where OpenXmlElementType: DXDC.RelationshipIdType, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXDC.RelationshipIdType openXmlElement, DMDC.RelationshipIdType value)
  {
    SetId(openXmlElement, value?.Id);
  }
}
