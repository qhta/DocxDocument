namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
/// Display Units Label.
/// </summary>
public static class DisplayUnitsLabelConverter
{
  /// <summary>
  /// Layout.
  /// </summary>
  private static DMDC.Layout? GetLayout(DXDC.DisplayUnitsLabel openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDC.Layout>();
    if (element != null)
      return DMXDC.LayoutConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpLayout(DXDC.DisplayUnitsLabel openXmlElement, DMDC.Layout? value, DiffList? diffs, string? objName)
  {
    return DMXDC.LayoutConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDC.Layout>(), value, diffs, objName);
  }
  
  private static void SetLayout(DXDC.DisplayUnitsLabel openXmlElement, DMDC.Layout? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDC.Layout>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDC.LayoutConverter.CreateOpenXmlElement<DXDC.Layout>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// ChartText.
  /// </summary>
  private static DMDC.ChartText? GetChartText(DXDC.DisplayUnitsLabel openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDC.ChartText>();
    if (element != null)
      return DMXDC.ChartTextConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpChartText(DXDC.DisplayUnitsLabel openXmlElement, DMDC.ChartText? value, DiffList? diffs, string? objName)
  {
    return DMXDC.ChartTextConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDC.ChartText>(), value, diffs, objName);
  }
  
  private static void SetChartText(DXDC.DisplayUnitsLabel openXmlElement, DMDC.ChartText? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDC.ChartText>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDC.ChartTextConverter.CreateOpenXmlElement<DXDC.ChartText>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// ChartShapeProperties.
  /// </summary>
  private static DMDC.ChartShapeProperties? GetChartShapeProperties(DXDC.DisplayUnitsLabel openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDC.ChartShapeProperties>();
    if (element != null)
      return DMXDC.ChartShapePropertiesConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpChartShapeProperties(DXDC.DisplayUnitsLabel openXmlElement, DMDC.ChartShapeProperties? value, DiffList? diffs, string? objName)
  {
    return DMXDC.ChartShapePropertiesConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDC.ChartShapeProperties>(), value, diffs, objName);
  }
  
  private static void SetChartShapeProperties(DXDC.DisplayUnitsLabel openXmlElement, DMDC.ChartShapeProperties? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDC.ChartShapeProperties>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDC.ChartShapePropertiesConverter.CreateOpenXmlElement<DXDC.ChartShapeProperties>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// TextProperties.
  /// </summary>
  private static DMDC.TextProperties? GetTextProperties(DXDC.DisplayUnitsLabel openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDC.TextProperties>();
    if (element != null)
      return DMXDC.TextPropertiesConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpTextProperties(DXDC.DisplayUnitsLabel openXmlElement, DMDC.TextProperties? value, DiffList? diffs, string? objName)
  {
    return DMXDC.TextPropertiesConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDC.TextProperties>(), value, diffs, objName);
  }
  
  private static void SetTextProperties(DXDC.DisplayUnitsLabel openXmlElement, DMDC.TextProperties? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDC.TextProperties>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDC.TextPropertiesConverter.CreateOpenXmlElement<DXDC.TextProperties>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DocumentModel.Drawings.Charts.DisplayUnitsLabel? CreateModelElement(DXDC.DisplayUnitsLabel? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Charts.DisplayUnitsLabel();
      value.Layout = GetLayout(openXmlElement);
      value.ChartText = GetChartText(openXmlElement);
      value.ChartShapeProperties = GetChartShapeProperties(openXmlElement);
      value.TextProperties = GetTextProperties(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXDC.DisplayUnitsLabel? openXmlElement, DMDC.DisplayUnitsLabel? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpLayout(openXmlElement, value.Layout, diffs, objName))
        ok = false;
      if (!CmpChartText(openXmlElement, value.ChartText, diffs, objName))
        ok = false;
      if (!CmpChartShapeProperties(openXmlElement, value.ChartShapeProperties, diffs, objName))
        ok = false;
      if (!CmpTextProperties(openXmlElement, value.TextProperties, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDC.DisplayUnitsLabel value)
    where OpenXmlElementType: DXDC.DisplayUnitsLabel, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXDC.DisplayUnitsLabel openXmlElement, DMDC.DisplayUnitsLabel value)
  {
    SetLayout(openXmlElement, value?.Layout);
    SetChartText(openXmlElement, value?.ChartText);
    SetChartShapeProperties(openXmlElement, value?.ChartShapeProperties);
    SetTextProperties(openXmlElement, value?.TextProperties);
  }
}
