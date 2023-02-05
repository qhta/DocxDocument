namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
/// Defines the RelationshipIdType Class.
/// </summary>
public static class RelationshipIdTypeConverter
{
  /// <summary>
  /// Relationship Reference
  /// </summary>
  private static String? GetId(DXDrawCharts.RelationshipIdType openXmlElement)
  {
    return openXmlElement?.Id?.Value;
  }
  
  private static bool CmpId(DXDrawCharts.RelationshipIdType openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.Id?.Value == value) return true;
    diffs?.Add(objName, "Id", openXmlElement?.Id?.Value, value);
    return false;
  }
  
  private static void SetId(DXDrawCharts.RelationshipIdType openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Id = new StringValue { Value = value };
    else
      openXmlElement.Id = null;
  }
  
  public static DMDrawsCharts.RelationshipIdType? CreateModelElement(DXDrawCharts.RelationshipIdType? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDrawsCharts.RelationshipIdType();
      value.Id = GetId(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXDrawCharts.RelationshipIdType? openXmlElement, DMDrawsCharts.RelationshipIdType? value, DiffList? diffs, string? objName)
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
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDrawsCharts.RelationshipIdType? value)
    where OpenXmlElementType: DXDrawCharts.RelationshipIdType, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetId(openXmlElement, value?.Id);
      return openXmlElement;
    }
    return default;
  }
}
