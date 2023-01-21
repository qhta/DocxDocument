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
    var itemElement = openXmlElement?.GetFirstChild<DXO2010W.GradientStopList>();
    if (itemElement != null)
      return DMXW.GradientStopListConverter.CreateModelElement(itemElement);
    return null;
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
    var itemElement = openXmlElement?.GetFirstChild<DXO2010W.LinearShadeProperties>();
    if (itemElement != null)
      return DMXW.LinearShadePropertiesConverter.CreateModelElement(itemElement);
    return null;
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
    var itemElement = openXmlElement?.GetFirstChild<DXO2010W.PathShadeProperties>();
    if (itemElement != null)
      return DMXW.PathShadePropertiesConverter.CreateModelElement(itemElement);
    return null;
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
  
  public static DMW.GradientFillProperties? CreateModelElement(DXO2010W.GradientFillProperties? openXmlElement)
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
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMW.GradientFillProperties? value)
    where OpenXmlElementType: DXO2010W.GradientFillProperties, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetGradientStopList(openXmlElement, value?.GradientStopList);
      SetLinearShadeProperties(openXmlElement, value?.LinearShadeProperties);
      SetPathShadeProperties(openXmlElement, value?.PathShadeProperties);
      return openXmlElement;
    }
    return default;
  }
}
