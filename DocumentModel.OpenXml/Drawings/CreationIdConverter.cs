namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Defines the CreationId Class.
/// </summary>
public static class CreationIdConverter
{
  /// <summary>
  /// id, this property is only available in Office 2016 and later.
  /// </summary>
  public static String? GetId(DocumentFormat.OpenXml.Office2016.Drawing.CreationId? openXmlElement)
  {
    return openXmlElement?.Id?.Value;
  }
  
  public static void SetId(DocumentFormat.OpenXml.Office2016.Drawing.CreationId? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Id = new StringValue { Value = value };
      else
        openXmlElement.Id = null;
  }
  
  public static DocumentModel.Drawings.CreationId? CreateModelElement(DocumentFormat.OpenXml.Office2016.Drawing.CreationId? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.CreationId();
      value.Id = GetId(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.CreationId? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Office2016.Drawing.CreationId, new()
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
