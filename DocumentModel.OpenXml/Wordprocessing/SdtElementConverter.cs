namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Defines SdtElement - the base class for the sdt elements.
/// </summary>
public static class SdtElementConverter
{
  /// <summary>
  /// Gets or sets the SdtProperties.
  /// </summary>
  private static DMW.SdtProperties? GetSdtProperties(DXW.SdtElement openXmlElement)
  {
    return DMXW.SdtPropertiesConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXW.SdtProperties>());
  }
  
  private static bool CmpSdtProperties(DXW.SdtElement openXmlElement, DMW.SdtProperties? value, DiffList? diffs, string? objName)
  {
    return DMXW.SdtPropertiesConverter.CompareModelElement(openXmlElement?.GetFirstChild<DXW.SdtProperties>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetSdtProperties(DXW.SdtElement openXmlElement, DMW.SdtProperties? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.SdtProperties>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.SdtPropertiesConverter.CreateOpenXmlElement<DXW.SdtProperties>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Gets or sets the SdtEndCharProperties.
  /// </summary>
  private static DMW.SdtEndCharProperties? GetSdtEndCharProperties(DXW.SdtElement openXmlElement)
  {
    return DMXW.SdtEndCharPropertiesConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXW.SdtEndCharProperties>());
  }
  
  private static bool CmpSdtEndCharProperties(DXW.SdtElement openXmlElement, DMW.SdtEndCharProperties? value, DiffList? diffs, string? objName)
  {
    return DMXW.SdtEndCharPropertiesConverter.CompareModelElement(openXmlElement?.GetFirstChild<DXW.SdtEndCharProperties>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetSdtEndCharProperties(DXW.SdtElement openXmlElement, DMW.SdtEndCharProperties? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.SdtEndCharProperties>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.SdtEndCharPropertiesConverter.CreateOpenXmlElement<DXW.SdtEndCharProperties>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DMW.SdtElement? CreateModelElement(DXW.SdtElement? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMW.SdtElement();
      value.SdtProperties = GetSdtProperties(openXmlElement);
      value.SdtEndCharProperties = GetSdtEndCharProperties(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXW.SdtElement? openXmlElement, DMW.SdtElement? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpSdtProperties(openXmlElement, value.SdtProperties, diffs, objName))
        ok = false;
      if (!CmpSdtEndCharProperties(openXmlElement, value.SdtEndCharProperties, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().ToString(), openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMW.SdtElement? value)
    where OpenXmlElementType: DXW.SdtElement, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetSdtProperties(openXmlElement, value?.SdtProperties);
      SetSdtEndCharProperties(openXmlElement, value?.SdtEndCharProperties);
      return openXmlElement;
    }
    return default;
  }
}
