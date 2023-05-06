namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Defines the GradientFillProperties Class.
/// </summary>
public static class GradientFillPropertiesConverter
{
  /// <summary>
  /// GradientStopList.
  /// </summary>
  private static DMW.GradientStopList? GetGradientStopList(DXO10W.GradientFillProperties openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO10W.GradientStopList>();
    if (element != null)
      return DMXW.GradientStopListConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpGradientStopList(DXO10W.GradientFillProperties openXmlElement, DMW.GradientStopList? value, DiffList? diffs, string? objName)
  {
    return DMXW.GradientStopListConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO10W.GradientStopList>(), value, diffs, objName);
  }
  
  private static void SetGradientStopList(DXO10W.GradientFillProperties openXmlElement, DMW.GradientStopList? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO10W.GradientStopList>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.GradientStopListConverter.CreateOpenXmlElement<DXO10W.GradientStopList>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  private static DMW.LinearShadeProperties? GetLinearShadeProperties(DXO10W.GradientFillProperties openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO10W.LinearShadeProperties>();
    if (element != null)
      return DMXW.LinearShadePropertiesConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpLinearShadeProperties(DXO10W.GradientFillProperties openXmlElement, DMW.LinearShadeProperties? value, DiffList? diffs, string? objName)
  {
    return DMXW.LinearShadePropertiesConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO10W.LinearShadeProperties>(), value, diffs, objName);
  }
  
  private static void SetLinearShadeProperties(DXO10W.GradientFillProperties openXmlElement, DMW.LinearShadeProperties? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO10W.LinearShadeProperties>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.LinearShadePropertiesConverter.CreateOpenXmlElement<DXO10W.LinearShadeProperties>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  private static DMW.PathShadeProperties? GetPathShadeProperties(DXO10W.GradientFillProperties openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO10W.PathShadeProperties>();
    if (element != null)
      return DMXW.PathShadePropertiesConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpPathShadeProperties(DXO10W.GradientFillProperties openXmlElement, DMW.PathShadeProperties? value, DiffList? diffs, string? objName)
  {
    return DMXW.PathShadePropertiesConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO10W.PathShadeProperties>(), value, diffs, objName);
  }
  
  private static void SetPathShadeProperties(DXO10W.GradientFillProperties openXmlElement, DMW.PathShadeProperties? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO10W.PathShadeProperties>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.PathShadePropertiesConverter.CreateOpenXmlElement<DXO10W.PathShadeProperties>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  public static DMW.GradientFillProperties? CreateModelElement(DXO10W.GradientFillProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMW.GradientFillProperties();
      value.GradientStopList = GetGradientStopList(openXmlElement);
      value.LinearShadeProperties = GetLinearShadeProperties(openXmlElement);
      value.PathShadeProperties = GetPathShadeProperties(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXO10W.GradientFillProperties? openXmlElement, DMW.GradientFillProperties? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpGradientStopList(openXmlElement, value.GradientStopList, diffs, objName))
        ok = false;
      if (!CmpLinearShadeProperties(openXmlElement, value.LinearShadeProperties, diffs, objName))
        ok = false;
      if (!CmpPathShadeProperties(openXmlElement, value.PathShadeProperties, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMW.GradientFillProperties value)
    where OpenXmlElementType: DXO10W.GradientFillProperties, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXO10W.GradientFillProperties openXmlElement, DMW.GradientFillProperties value)
  {
    SetGradientStopList(openXmlElement, value?.GradientStopList);
    SetLinearShadeProperties(openXmlElement, value?.LinearShadeProperties);
    SetPathShadeProperties(openXmlElement, value?.PathShadeProperties);
  }
}
