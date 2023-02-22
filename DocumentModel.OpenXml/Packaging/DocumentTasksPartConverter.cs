namespace DocumentModel.OpenXml.Packaging;

/// <summary>
/// Defines the DocumentTasksPart
/// </summary>
public static class DocumentTasksPartConverter
{
  private static String? GetContentType(DXPack.DocumentTasksPart openXmlElement)
  {
    return openXmlElement?.ContentType;
  }
  
  private static bool CmpContentType(DXPack.DocumentTasksPart openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.ContentType == value) return true;
    diffs?.Add(objName, "ContentType", openXmlElement?.ContentType, value);
    return false;
  }
  
  private static String? GetRelationshipType(DXPack.DocumentTasksPart openXmlElement)
  {
    return openXmlElement?.RelationshipType;
  }
  
  private static bool CmpRelationshipType(DXPack.DocumentTasksPart openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.RelationshipType == value) return true;
    diffs?.Add(objName, "RelationshipType", openXmlElement?.RelationshipType, value);
    return false;
  }
  
  /// <summary>
  /// Gets or sets the root element of this part.
  /// </summary>
  private static DM.Tasks? GetTasks(DXPack.DocumentTasksPart openXmlElement)
  {
      return DMX.TasksConverter.CreateModelElement(openXmlElement?.RootElement as DXO2021DocTasks.Tasks);
  }
  
  private static bool CmpTasks(DXPack.DocumentTasksPart openXmlElement, DM.Tasks? value, DiffList? diffs, string? objName)
  {
      return true;
  }
  
  private static void SetTasks(DXPack.DocumentTasksPart openXmlElement, DM.Tasks? value)
  {
    if (value != null)
    {
       var rootElement = DMX.TasksConverter.CreateOpenXmlElement<DXO2021DocTasks.Tasks>(value);
       if (rootElement != null)
         openXmlElement.Tasks = rootElement;
    }
  }
  
  public static DocumentModel.Packaging.DocumentTasksPart? CreateModelElement(DXPack.DocumentTasksPart? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Packaging.DocumentTasksPart();
      value.ContentType = GetContentType(openXmlElement);
      value.RelationshipType = GetRelationshipType(openXmlElement);
      value.Tasks = GetTasks(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXPack.DocumentTasksPart? openXmlElement, DMPack.DocumentTasksPart? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpContentType(openXmlElement, value.ContentType, diffs, objName))
        ok = false;
      if (!CmpRelationshipType(openXmlElement, value.RelationshipType, diffs, objName))
        ok = false;
      if (!CmpTasks(openXmlElement, value.Tasks, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMPack.DocumentTasksPart value)
    where OpenXmlElementType: DXPack.DocumentTasksPart, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXPack.DocumentTasksPart openXmlElement, DMPack.DocumentTasksPart value)
  {
    //SetContentType(openXmlElement, value?.ContentType);
    //SetRelationshipType(openXmlElement, value?.RelationshipType);
    SetTasks(openXmlElement, value?.Tasks);
    }
  }
