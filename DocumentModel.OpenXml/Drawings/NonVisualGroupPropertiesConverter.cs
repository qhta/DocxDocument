namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Defines the NonVisualGroupProperties Class.
/// </summary>
public static class NonVisualGroupPropertiesConverter
{
  /// <summary>
  /// isLegacyGroup, this property is only available in Office 2013 and later.
  /// </summary>
  private static Boolean? GetIsLegacyGroup(DXO2013Draw.NonVisualGroupProperties openXmlElement)
  {
    return openXmlElement?.IsLegacyGroup?.Value;
  }
  
  private static void SetIsLegacyGroup(DXO2013Draw.NonVisualGroupProperties openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.IsLegacyGroup = new BooleanValue { Value = (Boolean)value };
    else
      openXmlElement.IsLegacyGroup = null;
  }
  
  public static DMDraws.NonVisualGroupProperties? CreateModelElement(DXO2013Draw.NonVisualGroupProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDraws.NonVisualGroupProperties();
      value.IsLegacyGroup = GetIsLegacyGroup(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDraws.NonVisualGroupProperties? value)
    where OpenXmlElementType: DXO2013Draw.NonVisualGroupProperties, new()
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
