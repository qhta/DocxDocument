namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Defines SdtElement - the base class for the sdt elements.
/// </summary>
public static class SdtElementConverter
{
  #region SdtProperties conversion
  public static DMW.SdtProperties? GetSdtProperties(DXW.SdtElement openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXW.SdtProperties>();
    if (element != null)
      return DMXW.SdtPropertiesConverter.CreateModelElement(element);
    return null;
  }
  
  public static bool CmpSdtProperties(DXW.SdtElement openXmlElement, DMW.SdtProperties? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXW.SdtPropertiesConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.SdtProperties>(), value, diffs, objName, propName);
  }
  
  public static void SetSdtProperties(DXW.SdtElement openXmlElement, DMW.SdtProperties? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.SdtProperties>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.SdtPropertiesConverter.CreateOpenXmlElement<DXW.SdtProperties>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  #endregion

  #region SdtEndCharProperties conversion
  /// <summary>
  /// Gets or sets the SdtEndCharProperties.
  /// </summary>
  public static DMW.SdtEndCharProperties? GetSdtEndCharProperties(DXW.SdtElement openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXW.SdtEndCharProperties>();
    if (element != null)
      return DMXW.SdtEndCharPropertiesConverter.CreateModelElement(element);
    return null;
  }
  
  public static bool CmpSdtEndCharProperties(DXW.SdtElement openXmlElement, DMW.SdtEndCharProperties? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXW.SdtEndCharPropertiesConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.SdtEndCharProperties>(), value, diffs, objName, propName);
  }
  
  public static void SetSdtEndCharProperties(DXW.SdtElement openXmlElement, DMW.SdtEndCharProperties? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.SdtEndCharProperties>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.SdtEndCharPropertiesConverter.CreateOpenXmlElement<DXW.SdtEndCharProperties>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  #endregion

  #region SdtElement conversion
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
  
  public static bool CompareModelElement(DXW.SdtElement? openXmlElement, DMW.SdtElement? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpSdtProperties(openXmlElement, value.SdtProperties, diffs, objName, propName))
        ok = false;
      if (!CmpSdtEndCharProperties(openXmlElement, value.SdtEndCharProperties, diffs, objName, propName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMW.SdtElement value)
    where OpenXmlElementType: DXW.SdtElement, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXW.SdtElement openXmlElement, DMW.SdtElement value)
  {
    SetSdtProperties(openXmlElement, value?.SdtProperties);
    SetSdtEndCharProperties(openXmlElement, value?.SdtEndCharProperties);
  }
  #endregion
}
