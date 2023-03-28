namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
/// Defines the DLblsExtension Class.
/// </summary>
public static class DLblsExtensionConverter
{
  /// <summary>
  /// URI
  /// </summary>
  private static String? GetUri(DXDrawCharts.DLblsExtension openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Uri);
  }
  
  private static bool CmpUri(DXDrawCharts.DLblsExtension openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Uri, value, diffs, objName, "Uri");
  }
  
  private static void SetUri(DXDrawCharts.DLblsExtension openXmlElement, String? value)
  {
    openXmlElement.Uri = StringValueConverter.CreateStringValue(value);
  }
  
  private static DMDrawsCharts.ChartText3? GetChartText(DXDrawCharts.DLblsExtension openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO2013DrawChart.ChartText>();
    if (element != null)
      return DMXDrawsCharts.ChartText3Converter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpChartText(DXDrawCharts.DLblsExtension openXmlElement, DMDrawsCharts.ChartText3? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsCharts.ChartText3Converter.CompareModelElement(openXmlElement.GetFirstChild<DXO2013DrawChart.ChartText>(), value, diffs, objName);
  }
  
  private static void SetChartText(DXDrawCharts.DLblsExtension openXmlElement, DMDrawsCharts.ChartText3? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO2013DrawChart.ChartText>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDrawsCharts.ChartText3Converter.CreateOpenXmlElement<DXO2013DrawChart.ChartText>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMDrawsCharts.DataLabelFieldTable? GetDataLabelFieldTable(DXDrawCharts.DLblsExtension openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO2013DrawChart.DataLabelFieldTable>();
    if (element != null)
      return DMXDrawsCharts.DataLabelFieldTableConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpDataLabelFieldTable(DXDrawCharts.DLblsExtension openXmlElement, DMDrawsCharts.DataLabelFieldTable? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsCharts.DataLabelFieldTableConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO2013DrawChart.DataLabelFieldTable>(), value, diffs, objName);
  }
  
  private static void SetDataLabelFieldTable(DXDrawCharts.DLblsExtension openXmlElement, DMDrawsCharts.DataLabelFieldTable? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO2013DrawChart.DataLabelFieldTable>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDrawsCharts.DataLabelFieldTableConverter.CreateOpenXmlElement<DXO2013DrawChart.DataLabelFieldTable>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static Boolean? GetShowDataLabelsRange(DXDrawCharts.DLblsExtension openXmlElement)
  {
    return openXmlElement.GetFirstChild<DXO2013DrawChart.ShowDataLabelsRange>() != null;
  }
  
  private static bool CmpShowDataLabelsRange(DXDrawCharts.DLblsExtension openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    var val = openXmlElement.GetFirstChild<DXO2013DrawChart.ShowDataLabelsRange>() != null;
    if (val == value) return true;
    diffs?.Add(objName, "DXO2013DrawChart.ShowDataLabelsRange", val, value);
    return false;
  }
  
  private static void SetShowDataLabelsRange(DXDrawCharts.DLblsExtension openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DXO2013DrawChart.ShowDataLabelsRange>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DXO2013DrawChart.ShowDataLabelsRange();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMDrawsCharts.ShapeProperties3? GetShapeProperties(DXDrawCharts.DLblsExtension openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO2013DrawChart.ShapeProperties>();
    if (element != null)
      return DMXDrawsCharts.ShapeProperties3Converter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpShapeProperties(DXDrawCharts.DLblsExtension openXmlElement, DMDrawsCharts.ShapeProperties3? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsCharts.ShapeProperties3Converter.CompareModelElement(openXmlElement.GetFirstChild<DXO2013DrawChart.ShapeProperties>(), value, diffs, objName);
  }
  
  private static void SetShapeProperties(DXDrawCharts.DLblsExtension openXmlElement, DMDrawsCharts.ShapeProperties3? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO2013DrawChart.ShapeProperties>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDrawsCharts.ShapeProperties3Converter.CreateOpenXmlElement<DXO2013DrawChart.ShapeProperties>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMDrawsCharts.Layout3? GetLayout(DXDrawCharts.DLblsExtension openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO2013DrawChart.Layout>();
    if (element != null)
      return DMXDrawsCharts.Layout3Converter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpLayout(DXDrawCharts.DLblsExtension openXmlElement, DMDrawsCharts.Layout3? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsCharts.Layout3Converter.CompareModelElement(openXmlElement.GetFirstChild<DXO2013DrawChart.Layout>(), value, diffs, objName);
  }
  
  private static void SetLayout(DXDrawCharts.DLblsExtension openXmlElement, DMDrawsCharts.Layout3? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO2013DrawChart.Layout>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDrawsCharts.Layout3Converter.CreateOpenXmlElement<DXO2013DrawChart.Layout>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static Boolean? GetShowLeaderLines(DXDrawCharts.DLblsExtension openXmlElement)
  {
    return openXmlElement.GetFirstChild<DXO2013DrawChart.ShowLeaderLines>() != null;
  }
  
  private static bool CmpShowLeaderLines(DXDrawCharts.DLblsExtension openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    var val = openXmlElement.GetFirstChild<DXO2013DrawChart.ShowLeaderLines>() != null;
    if (val == value) return true;
    diffs?.Add(objName, "DXO2013DrawChart.ShowLeaderLines", val, value);
    return false;
  }
  
  private static void SetShowLeaderLines(DXDrawCharts.DLblsExtension openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DXO2013DrawChart.ShowLeaderLines>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DXO2013DrawChart.ShowLeaderLines();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMDrawsCharts.LeaderLines3? GetLeaderLines(DXDrawCharts.DLblsExtension openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO2013DrawChart.LeaderLines>();
    if (element != null)
      return DMXDrawsCharts.LeaderLines3Converter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpLeaderLines(DXDrawCharts.DLblsExtension openXmlElement, DMDrawsCharts.LeaderLines3? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsCharts.LeaderLines3Converter.CompareModelElement(openXmlElement.GetFirstChild<DXO2013DrawChart.LeaderLines>(), value, diffs, objName);
  }
  
  private static void SetLeaderLines(DXDrawCharts.DLblsExtension openXmlElement, DMDrawsCharts.LeaderLines3? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO2013DrawChart.LeaderLines>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDrawsCharts.LeaderLines3Converter.CreateOpenXmlElement<DXO2013DrawChart.LeaderLines>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DocumentModel.Drawings.Charts.DLblsExtension? CreateModelElement(DXDrawCharts.DLblsExtension? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Charts.DLblsExtension();
      value.Uri = GetUri(openXmlElement);
      value.ChartText = GetChartText(openXmlElement);
      value.DataLabelFieldTable = GetDataLabelFieldTable(openXmlElement);
      value.ShowDataLabelsRange = GetShowDataLabelsRange(openXmlElement);
      value.ShapeProperties = GetShapeProperties(openXmlElement);
      value.Layout = GetLayout(openXmlElement);
      value.ShowLeaderLines = GetShowLeaderLines(openXmlElement);
      value.LeaderLines = GetLeaderLines(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXDrawCharts.DLblsExtension? openXmlElement, DMDrawsCharts.DLblsExtension? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpUri(openXmlElement, value.Uri, diffs, objName))
        ok = false;
      if (!CmpChartText(openXmlElement, value.ChartText, diffs, objName))
        ok = false;
      if (!CmpDataLabelFieldTable(openXmlElement, value.DataLabelFieldTable, diffs, objName))
        ok = false;
      if (!CmpShowDataLabelsRange(openXmlElement, value.ShowDataLabelsRange, diffs, objName))
        ok = false;
      if (!CmpShapeProperties(openXmlElement, value.ShapeProperties, diffs, objName))
        ok = false;
      if (!CmpLayout(openXmlElement, value.Layout, diffs, objName))
        ok = false;
      if (!CmpShowLeaderLines(openXmlElement, value.ShowLeaderLines, diffs, objName))
        ok = false;
      if (!CmpLeaderLines(openXmlElement, value.LeaderLines, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDrawsCharts.DLblsExtension value)
    where OpenXmlElementType: DXDrawCharts.DLblsExtension, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXDrawCharts.DLblsExtension openXmlElement, DMDrawsCharts.DLblsExtension value)
  {
    SetUri(openXmlElement, value?.Uri);
    SetChartText(openXmlElement, value?.ChartText);
    SetDataLabelFieldTable(openXmlElement, value?.DataLabelFieldTable);
    SetShowDataLabelsRange(openXmlElement, value?.ShowDataLabelsRange);
    SetShapeProperties(openXmlElement, value?.ShapeProperties);
    SetLayout(openXmlElement, value?.Layout);
    SetShowLeaderLines(openXmlElement, value?.ShowLeaderLines);
    SetLeaderLines(openXmlElement, value?.LeaderLines);
  }
}
