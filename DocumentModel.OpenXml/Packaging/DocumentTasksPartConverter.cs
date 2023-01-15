using DocumentFormat.OpenXml.Packaging;

namespace DocumentModel.OpenXml.Packaging;

/// <summary>
///   Defines the DocumentTasksPart
/// </summary>
public static class DocumentTasksPartConverter
{
  public static String? GetContentType(DocumentTasksPart? openXmlElement)
  {
    return openXmlElement?.ContentType;
  }

  public static String? GetRelationshipType(DocumentTasksPart? openXmlElement)
  {
    return openXmlElement?.RelationshipType;
  }

  /// <summary>
  ///   Gets or sets the root element of this part.
  /// </summary>
  public static Tasks? GetTasks(DocumentTasksPart? openXmlElement)
  {
    if (openXmlElement?.RootElement is DocumentFormat.OpenXml.Office2021.DocumentTasks.Tasks rootElement)
      return TasksConverter.CreateModelElement(rootElement);
    return null;
  }

  public static void SetTasks(DocumentTasksPart? openXmlElement, Tasks? value)
  {
    if (openXmlElement != null)
      if (value != null)
      {
        var rootElement = TasksConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2021.DocumentTasks.Tasks>(value);
        if (rootElement != null)
          openXmlElement.Tasks = rootElement;
      }
  }

  public static DocumentModel.Packaging.DocumentTasksPart? CreateModelElement(DocumentTasksPart? openXmlElement)
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

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Packaging.DocumentTasksPart? value)
    where OpenXmlElementType : DocumentTasksPart, new()
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