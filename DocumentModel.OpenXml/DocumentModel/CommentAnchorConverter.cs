namespace DocumentModel.OpenXml;

/// <summary>
/// Defines the CommentAnchor Class.
/// </summary>
public static class CommentAnchorConverter
{
  /// <summary>
  /// id, this property is only available in Office 2021 and later.
  /// </summary>
  private static String? GetId(DXO2021DocTasks.CommentAnchor openXmlElement)
  {
    return openXmlElement?.Id?.Value;
  }
  
  private static void SetId(DXO2021DocTasks.CommentAnchor openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Id = new StringValue { Value = value };
    else
      openXmlElement.Id = null;
  }
  
  public static DM.CommentAnchor? CreateModelElement(DXO2021DocTasks.CommentAnchor? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DM.CommentAnchor();
      value.Id = GetId(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DM.CommentAnchor? value)
    where OpenXmlElementType: DXO2021DocTasks.CommentAnchor, new()
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
