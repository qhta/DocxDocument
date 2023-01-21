namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Structured Document Tag End Character Properties.
/// </summary>
public static class SdtEndCharPropertiesConverter
{
  private static DMW.RunProperties? GetRunProperties(DXW.SdtEndCharProperties openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXW.RunProperties>();
    if (itemElement != null)
      return DMXW.RunPropertiesConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetRunProperties(DXW.SdtEndCharProperties openXmlElement, DMW.RunProperties? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.RunProperties>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.RunPropertiesConverter.CreateOpenXmlElement<DXW.RunProperties>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DMW.SdtEndCharProperties? CreateModelElement(DXW.SdtEndCharProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMW.SdtEndCharProperties();
      value.RunProperties = GetRunProperties(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMW.SdtEndCharProperties? value)
    where OpenXmlElementType: DXW.SdtEndCharProperties, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetRunProperties(openXmlElement, value?.RunProperties);
      return openXmlElement;
    }
    return default;
  }
}
