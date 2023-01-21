namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Defines the ObjectProperties Class.
/// </summary>
public static class ObjectPropertiesConverter
{
  /// <summary>
  /// objectId, this property is only available in Office 2013 and later.
  /// </summary>
  private static String? GetId(DXO2013Draw.ObjectProperties openXmlElement)
  {
    return openXmlElement?.Id?.Value;
  }
  
  private static void SetId(DXO2013Draw.ObjectProperties openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Id = new StringValue { Value = value };
    else
      openXmlElement.Id = null;
  }
  
  /// <summary>
  /// isActiveX, this property is only available in Office 2013 and later.
  /// </summary>
  private static Boolean? GetIsActiveX(DXO2013Draw.ObjectProperties openXmlElement)
  {
    return openXmlElement?.IsActiveX?.Value;
  }
  
  private static void SetIsActiveX(DXO2013Draw.ObjectProperties openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.IsActiveX = new BooleanValue { Value = (Boolean)value };
    else
      openXmlElement.IsActiveX = null;
  }
  
  /// <summary>
  /// linkType, this property is only available in Office 2013 and later.
  /// </summary>
  private static String? GetLinkType(DXO2013Draw.ObjectProperties openXmlElement)
  {
    return openXmlElement?.LinkType?.Value;
  }
  
  private static void SetLinkType(DXO2013Draw.ObjectProperties openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.LinkType = new StringValue { Value = value };
    else
      openXmlElement.LinkType = null;
  }
  
  public static DMDraws.ObjectProperties? CreateModelElement(DXO2013Draw.ObjectProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDraws.ObjectProperties();
      value.Id = GetId(openXmlElement);
      value.IsActiveX = GetIsActiveX(openXmlElement);
      value.LinkType = GetLinkType(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDraws.ObjectProperties? value)
    where OpenXmlElementType: DXO2013Draw.ObjectProperties, new()
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
