namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Defines the ObjectProperties Class.
/// </summary>
public static class ObjectPropertiesConverter
{
  /// <summary>
  /// objectId, this property is only available in Office 2013 and later.
  /// </summary>
  public static String? GetId(DocumentFormat.OpenXml.Office2013.Drawing.ObjectProperties? openXmlElement)
  {
    return openXmlElement?.Id?.Value;
  }
  
  public static void SetId(DocumentFormat.OpenXml.Office2013.Drawing.ObjectProperties? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Id = new StringValue { Value = value };
      else
        openXmlElement.Id = null;
  }
  
  /// <summary>
  /// isActiveX, this property is only available in Office 2013 and later.
  /// </summary>
  public static Boolean? GetIsActiveX(DocumentFormat.OpenXml.Office2013.Drawing.ObjectProperties? openXmlElement)
  {
    return openXmlElement?.IsActiveX?.Value;
  }
  
  public static void SetIsActiveX(DocumentFormat.OpenXml.Office2013.Drawing.ObjectProperties? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.IsActiveX = new BooleanValue { Value = (Boolean)value };
      else
        openXmlElement.IsActiveX = null;
  }
  
  /// <summary>
  /// linkType, this property is only available in Office 2013 and later.
  /// </summary>
  public static String? GetLinkType(DocumentFormat.OpenXml.Office2013.Drawing.ObjectProperties? openXmlElement)
  {
    return openXmlElement?.LinkType?.Value;
  }
  
  public static void SetLinkType(DocumentFormat.OpenXml.Office2013.Drawing.ObjectProperties? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.LinkType = new StringValue { Value = value };
      else
        openXmlElement.LinkType = null;
  }
  
  public static DocumentModel.Drawings.ObjectProperties? CreateModelElement(DocumentFormat.OpenXml.Office2013.Drawing.ObjectProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.ObjectProperties();
      value.Id = GetId(openXmlElement);
      value.IsActiveX = GetIsActiveX(openXmlElement);
      value.LinkType = GetLinkType(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.ObjectProperties? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Office2013.Drawing.ObjectProperties, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetId(openXmlElement, value?.Id);
      SetIsActiveX(openXmlElement, value?.IsActiveX);
      SetLinkType(openXmlElement, value?.LinkType);
      return openXmlElement;
    }
    return default;
  }
}
