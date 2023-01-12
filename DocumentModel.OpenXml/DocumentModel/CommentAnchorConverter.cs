namespace DocumentModel.OpenXml;

/// <summary>
/// Defines the CommentAnchor Class.
/// </summary>
public static class CommentAnchorConverter
{
  /// <summary>
  /// id, this property is only available in Office 2021 and later.
  /// </summary>
  public static String? GetId(DocumentFormat.OpenXml.Office2021.DocumentTasks.CommentAnchor? openXmlElement)
  {
    return openXmlElement?.Id?.Value;
  }
  
  public static void SetId(DocumentFormat.OpenXml.Office2021.DocumentTasks.CommentAnchor? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Id = new StringValue { Value = value };
      else
        openXmlElement.Id = null;
  }
  
  public static DocumentModel.CommentAnchor? CreateModelElement(DocumentFormat.OpenXml.Office2021.DocumentTasks.CommentAnchor? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.CommentAnchor();
      value.Id = GetId(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.CommentAnchor? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Office2021.DocumentTasks.CommentAnchor, new()
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
