namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Structured Document Tag End Character Properties.
/// </summary>
public static class SdtEndCharPropertiesConverter
{
  private static DMW.RunProperties? GetRunProperties(DXW.SdtEndCharProperties openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXW.RunProperties>();
    if (element != null)
      return DMXW.RunPropertiesConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpRunProperties(DXW.SdtEndCharProperties openXmlElement, DMW.RunProperties? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXW.RunPropertiesConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.RunProperties>(), value, diffs, objName, propName);
  }
  
  private static void SetRunProperties(DXW.SdtEndCharProperties openXmlElement, DMW.RunProperties? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.RunProperties>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.RunPropertiesConverter.CreateOpenXmlElement(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
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
  
  public static bool CompareModelElement(DXW.SdtEndCharProperties? openXmlElement, DMW.SdtEndCharProperties? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpRunProperties(openXmlElement, value.RunProperties, diffs, objName, propName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMW.SdtEndCharProperties value)
    where OpenXmlElementType: DXW.SdtEndCharProperties, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXW.SdtEndCharProperties openXmlElement, DMW.SdtEndCharProperties value)
  {
    SetRunProperties(openXmlElement, value?.RunProperties);
  }
}
