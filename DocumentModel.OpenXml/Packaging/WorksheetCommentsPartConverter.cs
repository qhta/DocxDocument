using DocumentFormat.OpenXml.Packaging;

namespace DocumentModel.OpenXml.Packaging;

/// <summary>
///   Defines the WorksheetCommentsPart
/// </summary>
public static class WorksheetCommentsPartConverter
{
  public static String? GetContentType(WorksheetCommentsPart? openXmlElement)
  {
    return openXmlElement?.ContentType;
  }

  public static String? GetRelationshipType(WorksheetCommentsPart? openXmlElement)
  {
    return openXmlElement?.RelationshipType;
  }

  public static DocumentModel.Packaging.WorksheetCommentsPart? CreateModelElement(WorksheetCommentsPart? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Packaging.WorksheetCommentsPart();
      value.ContentType = GetContentType(openXmlElement);
      value.RelationshipType = GetRelationshipType(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Packaging.WorksheetCommentsPart? value)
    where OpenXmlElementType : WorksheetCommentsPart, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      //SetContentType(openXmlElement, value?.ContentType);
      //SetRelationshipType(openXmlElement, value?.RelationshipType);
      return openXmlElement;
    }
    return default;
  }
}