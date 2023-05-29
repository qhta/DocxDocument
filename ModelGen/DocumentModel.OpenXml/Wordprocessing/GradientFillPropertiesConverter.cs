namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Defines the GradientFillProperties Class.
/// </summary>
public static class GradientFillPropertiesConverter
{
  /// <summary>
  /// GradientStopList.
  /// </summary>
  private static DMW.GradientStopList? GetGradientStopList(DXO2010W.GradientFillProperties openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO2010W.GradientStopList>();
    if (element != null)
      return DMXW.GradientStopListConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpGradientStopList(DXO2010W.GradientFillProperties openXmlElement, DMW.GradientStopList? value, DiffList? diffs, string? objName)
  {
    return DMXW.GradientStopListConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO2010W.GradientStopList>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetGradientStopList(DXO2010W.GradientFillProperties openXmlElement, DMW.GradientStopList? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO2010W.GradientStopList>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.GradientStopListConverter.CreateOpenXmlElement<DXO2010W.GradientStopList>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMW.LinearShadeProperties? GetLinearShadeProperties(DXO2010W.GradientFillProperties openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO2010W.LinearShadeProperties>();
    if (element != null)
      return DMXW.LinearShadePropertiesConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpLinearShadeProperties(DXO2010W.GradientFillProperties openXmlElement, DMW.LinearShadeProperties? value, DiffList? diffs, string? objName)
  {
    return DMXW.LinearShadePropertiesConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO2010W.LinearShadeProperties>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetLinearShadeProperties(DXO2010W.GradientFillProperties openXmlElement, DMW.LinearShadeProperties? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO2010W.LinearShadeProperties>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.LinearShadePropertiesConverter.CreateOpenXmlElement<DXO2010W.LinearShadeProperties>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMW.PathShadeProperties? GetPathShadeProperties(DXO2010W.GradientFillProperties openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO2010W.PathShadeProperties>();
    if (element != null)
      return DMXW.PathShadePropertiesConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpPathShadeProperties(DXO2010W.GradientFillProperties openXmlElement, DMW.PathShadeProperties? value, DiffList? diffs, string? objName)
  {
    return DMXW.PathShadePropertiesConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO2010W.PathShadeProperties>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetPathShadeProperties(DXO2010W.GradientFillProperties openXmlElement, DMW.PathShadeProperties? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO2010W.PathShadeProperties>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.PathShadePropertiesConverter.CreateOpenXmlElement<DXO2010W.PathShadeProperties>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DocumentModel.Wordprocessing.GradientFillProperties? CreateModelElement(DXO2010W.GradientFillProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Wordprocessing.GradientFillProperties();
      value.GradientStopList = GetGradientStopList(openXmlElement);
      value.LinearShadeProperties = GetLinearShadeProperties(openXmlElement);
      value.PathShadeProperties = GetPathShadeProperties(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXO2010W.GradientFillProperties? openXmlElement, DMW.GradientFillProperties? value, DiffList? diffs, string? objName)
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
    where OpenXmlElementType: DXO2010W.GradientFillProperties, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXO2010W.GradientFillProperties openXmlElement, DMW.GradientFillProperties value)
  {
    SetGradientStopList(openXmlElement, value?.GradientStopList);
    SetLinearShadeProperties(openXmlElement, value?.LinearShadeProperties);
    SetPathShadeProperties(openXmlElement, value?.PathShadeProperties);
  }
}
