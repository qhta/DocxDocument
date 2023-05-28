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
  
  private static bool CmpId(DXDC.RelationshipIdType openXmlElement, String? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Id, value, diffs, objName, "AnnotationId");
  }
  
  private static void SetId(DXDC.RelationshipIdType openXmlElement, String? value)
  {
    openXmlElement.Id = StringValueConverter.CreateStringValue(value);
  }
  
  public static DMD.Charts.RelationshipIdType? CreateModelElement(DXDC.RelationshipIdType? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMD.Charts.RelationshipIdType();
      value.Id = GetId(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXDC.RelationshipIdType? openXmlElement, DMDC.RelationshipIdType? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpId(openXmlElement, value.Id, diffs, objName, propName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement, value);
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
