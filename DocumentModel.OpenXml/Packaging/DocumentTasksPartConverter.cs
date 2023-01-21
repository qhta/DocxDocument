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
  
  private static String? GetRelationshipType(DXPack.DocumentTasksPart openXmlElement)
  {
    return openXmlElement?.RelationshipType;
  }
  
  /// <summary>
  /// Gets or sets the root element of this part.
  /// </summary>
  private static DM.Tasks? GetTasks(DXPack.DocumentTasksPart openXmlElement)
  {
    if (openXmlElement?.RootElement is DXO2021DocTasks.Tasks rootElement)
      return DMX.TasksConverter.CreateModelElement(rootElement);
    return null;
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
  
  public static DMPack.DocumentTasksPart? CreateModelElement(DXPack.DocumentTasksPart? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMPack.DocumentTasksPart();
      value.ContentType = GetContentType(openXmlElement);
      value.RelationshipType = GetRelationshipType(openXmlElement);
      value.Tasks = GetTasks(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMPack.DocumentTasksPart? value)
    where OpenXmlElementType: DXPack.DocumentTasksPart, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      //SetContentType(openXmlElement, value?.ContentType);
      //SetRelationshipType(openXmlElement, value?.RelationshipType);
      SetTasks(openXmlElement, value?.Tasks);
      return openXmlElement;
    }
    return default;
  }
}
