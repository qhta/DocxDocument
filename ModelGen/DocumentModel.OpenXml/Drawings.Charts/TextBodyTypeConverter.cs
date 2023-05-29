namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
/// Defines the TextBodyType Class.
/// </summary>
public static class TextBodyTypeConverter
{
  /// <summary>
  /// Body Properties.
  /// </summary>
  private static DMDraws.BodyProperties? GetBodyProperties(DXDrawCharts.TextBodyType openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDraw.BodyProperties>();
    if (element != null)
      return DMXDraws.BodyPropertiesConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpBodyProperties(DXDrawCharts.TextBodyType openXmlElement, DMDraws.BodyProperties? value, DiffList? diffs, string? objName)
  {
    return DMXDraws.BodyPropertiesConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDraw.BodyProperties>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetBodyProperties(DXDrawCharts.TextBodyType openXmlElement, DMDraws.BodyProperties? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDraw.BodyProperties>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDraws.BodyPropertiesConverter.CreateOpenXmlElement<DXDraw.BodyProperties>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Text List Styles.
  /// </summary>
  private static DMDraws.ListStyle? GetListStyle(DXDrawCharts.TextBodyType openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDraw.ListStyle>();
    if (element != null)
      return DMXDraws.ListStyleConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpListStyle(DXDrawCharts.TextBodyType openXmlElement, DMDraws.ListStyle? value, DiffList? diffs, string? objName)
  {
    return DMXDraws.ListStyleConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDraw.ListStyle>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetListStyle(DXDrawCharts.TextBodyType openXmlElement, DMDraws.ListStyle? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDraw.ListStyle>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDraws.ListStyleConverter.CreateOpenXmlElement<DXDraw.ListStyle>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DocumentModel.Drawings.Charts.TextBodyType? CreateModelElement(DXDrawCharts.TextBodyType? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Charts.TextBodyType();
      value.BodyProperties = GetBodyProperties(openXmlElement);
      value.ListStyle = GetListStyle(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXDrawCharts.TextBodyType? openXmlElement, DMDrawsCharts.TextBodyType? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpBodyProperties(openXmlElement, value.BodyProperties, diffs, objName))
        ok = false;
      if (!CmpListStyle(openXmlElement, value.ListStyle, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDrawsCharts.TextBodyType value)
    where OpenXmlElementType: DXDrawCharts.TextBodyType, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXDrawCharts.TextBodyType openXmlElement, DMDrawsCharts.TextBodyType value)
  {
    SetBodyProperties(openXmlElement, value?.BodyProperties);
    SetListStyle(openXmlElement, value?.ListStyle);
  }
}
