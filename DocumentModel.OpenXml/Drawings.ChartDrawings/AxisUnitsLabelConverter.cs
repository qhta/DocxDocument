namespace DocumentModel.OpenXml.Drawings.ChartDrawings;

/// <summary>
/// Defines the AxisUnitsLabel Class.
/// </summary>
public static class AxisUnitsLabelConverter
{
  /// <summary>
  /// Text.
  /// </summary>
  private static DMDrawsChartDraws.Text? GetText(DXO2016DrawChartDraw.AxisUnitsLabel openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO2016DrawChartDraw.Text>();
    if (element != null)
      return DMXDrawsChartDraws.TextConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpText(DXO2016DrawChartDraw.AxisUnitsLabel openXmlElement, DMDrawsChartDraws.Text? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsChartDraws.TextConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO2016DrawChartDraw.Text>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetText(DXO2016DrawChartDraw.AxisUnitsLabel openXmlElement, DMDrawsChartDraws.Text? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO2016DrawChartDraw.Text>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDrawsChartDraws.TextConverter.CreateOpenXmlElement<DXO2016DrawChartDraw.Text>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// ShapeProperties.
  /// </summary>
  private static DMDrawsChartDraws.ShapeProperties? GetShapeProperties(DXO2016DrawChartDraw.AxisUnitsLabel openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO2016DrawChartDraw.ShapeProperties>();
    if (element != null)
      return DMXDrawsChartDraws.ShapePropertiesConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpShapeProperties(DXO2016DrawChartDraw.AxisUnitsLabel openXmlElement, DMDrawsChartDraws.ShapeProperties? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsChartDraws.ShapePropertiesConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO2016DrawChartDraw.ShapeProperties>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetShapeProperties(DXO2016DrawChartDraw.AxisUnitsLabel openXmlElement, DMDrawsChartDraws.ShapeProperties? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO2016DrawChartDraw.ShapeProperties>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDrawsChartDraws.ShapePropertiesConverter.CreateOpenXmlElement<DXO2016DrawChartDraw.ShapeProperties>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// TxPrTextBody.
  /// </summary>
  private static DMDrawsChartDraws.TxPrTextBody? GetTxPrTextBody(DXO2016DrawChartDraw.AxisUnitsLabel openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO2016DrawChartDraw.TxPrTextBody>();
    if (element != null)
      return DMXDrawsChartDraws.TxPrTextBodyConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpTxPrTextBody(DXO2016DrawChartDraw.AxisUnitsLabel openXmlElement, DMDrawsChartDraws.TxPrTextBody? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsChartDraws.TxPrTextBodyConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO2016DrawChartDraw.TxPrTextBody>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetTxPrTextBody(DXO2016DrawChartDraw.AxisUnitsLabel openXmlElement, DMDrawsChartDraws.TxPrTextBody? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO2016DrawChartDraw.TxPrTextBody>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDrawsChartDraws.TxPrTextBodyConverter.CreateOpenXmlElement<DXO2016DrawChartDraw.TxPrTextBody>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// ExtensionList.
  /// </summary>
  private static DMDrawsChartDraws.ExtensionList? GetExtensionList(DXO2016DrawChartDraw.AxisUnitsLabel openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO2016DrawChartDraw.ExtensionList>();
    if (element != null)
      return DMXDrawsChartDraws.ExtensionListConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpExtensionList(DXO2016DrawChartDraw.AxisUnitsLabel openXmlElement, DMDrawsChartDraws.ExtensionList? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsChartDraws.ExtensionListConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO2016DrawChartDraw.ExtensionList>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetExtensionList(DXO2016DrawChartDraw.AxisUnitsLabel openXmlElement, DMDrawsChartDraws.ExtensionList? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO2016DrawChartDraw.ExtensionList>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDrawsChartDraws.ExtensionListConverter.CreateOpenXmlElement<DXO2016DrawChartDraw.ExtensionList>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DocumentModel.Drawings.ChartDrawings.AxisUnitsLabel? CreateModelElement(DXO2016DrawChartDraw.AxisUnitsLabel? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.ChartDrawings.AxisUnitsLabel();
      value.Text = GetText(openXmlElement);
      value.ShapeProperties = GetShapeProperties(openXmlElement);
      value.TxPrTextBody = GetTxPrTextBody(openXmlElement);
      value.ExtensionList = GetExtensionList(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXO2016DrawChartDraw.AxisUnitsLabel? openXmlElement, DMDrawsChartDraws.AxisUnitsLabel? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpText(openXmlElement, value.Text, diffs, objName))
        ok = false;
      if (!CmpShapeProperties(openXmlElement, value.ShapeProperties, diffs, objName))
        ok = false;
      if (!CmpTxPrTextBody(openXmlElement, value.TxPrTextBody, diffs, objName))
        ok = false;
      if (!CmpExtensionList(openXmlElement, value.ExtensionList, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDrawsChartDraws.AxisUnitsLabel value)
    where OpenXmlElementType: DXO2016DrawChartDraw.AxisUnitsLabel, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXO2016DrawChartDraw.AxisUnitsLabel openXmlElement, DMDrawsChartDraws.AxisUnitsLabel value)
  {
    SetText(openXmlElement, value?.Text);
    SetShapeProperties(openXmlElement, value?.ShapeProperties);
    SetTxPrTextBody(openXmlElement, value?.TxPrTextBody);
    SetExtensionList(openXmlElement, value?.ExtensionList);
    }
  }
