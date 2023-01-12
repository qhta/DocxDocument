namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Defines the NonVisualGroupProperties Class.
/// </summary>
public static class NonVisualGroupPropertiesConverter
{
  /// <summary>
  /// isLegacyGroup, this property is only available in Office 2013 and later.
  /// </summary>
  public static Boolean? GetIsLegacyGroup(DocumentFormat.OpenXml.Office2013.Drawing.NonVisualGroupProperties? openXmlElement)
  {
    return openXmlElement?.IsLegacyGroup?.Value;
  }
  
  public static void SetIsLegacyGroup(DocumentFormat.OpenXml.Office2013.Drawing.NonVisualGroupProperties? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.IsLegacyGroup = new BooleanValue { Value = (Boolean)value };
      else
        openXmlElement.IsLegacyGroup = null;
  }
  
  public static DocumentModel.Drawings.NonVisualGroupProperties? CreateModelElement(DocumentFormat.OpenXml.Office2013.Drawing.NonVisualGroupProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.NonVisualGroupProperties();
      value.IsLegacyGroup = GetIsLegacyGroup(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.NonVisualGroupProperties? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Office2013.Drawing.NonVisualGroupProperties, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetIsLegacyGroup(openXmlElement, value?.IsLegacyGroup);
      return openXmlElement;
    }
    return default;
  }
}
