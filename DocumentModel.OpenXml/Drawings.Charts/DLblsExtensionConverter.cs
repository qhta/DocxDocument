namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
/// Defines the DLblsExtension Class.
/// </summary>
public static class DLblsExtensionConverter
{
  /// <summary>
  /// URI
  /// </summary>
  private static String? GetUri(DXDC.DLblsExtension openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Uri);
  }
  
  private static bool CmpUri(DXDC.DLblsExtension openXmlElement, String? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Uri, value, diffs, objName, "Uri");
  }
  
  private static void SetUri(DXDC.DLblsExtension openXmlElement, String? value)
  {
    openXmlElement.Uri = StringValueConverter.CreateStringValue(value);
  }
  
  private static DMDC.ChartText3? GetChartText(DXDC.DLblsExtension openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO13DC.ChartText>();
    if (element != null)
      return DMXDC.ChartText3Converter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpChartText(DXDC.DLblsExtension openXmlElement, DMDC.ChartText3? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXDC.ChartText3Converter.CompareModelElement(openXmlElement.GetFirstChild<DXO13DC.ChartText>(), value, diffs, objName, propName);
  }
  
  private static void SetChartText(DXDC.DLblsExtension openXmlElement, DMDC.ChartText3? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO13DC.ChartText>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDC.ChartText3Converter.CreateOpenXmlElement<DXO13DC.ChartText>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  private static DMDC.DataLabelFieldTable? GetDataLabelFieldTable(DXDC.DLblsExtension openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO13DC.DataLabelFieldTable>();
    if (element != null)
      return DMXDC.DataLabelFieldTableConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpDataLabelFieldTable(DXDC.DLblsExtension openXmlElement, DMDC.DataLabelFieldTable? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXDC.DataLabelFieldTableConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO13DC.DataLabelFieldTable>(), value, diffs, objName, propName);
  }
  
  private static void SetDataLabelFieldTable(DXDC.DLblsExtension openXmlElement, DMDC.DataLabelFieldTable? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO13DC.DataLabelFieldTable>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDC.DataLabelFieldTableConverter.CreateOpenXmlElement<DXO13DC.DataLabelFieldTable>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  private static Boolean? GetShowDataLabelsRange(DXDC.DLblsExtension openXmlElement)
  {
    return openXmlElement.GetFirstChild<DXO13DC.ShowDataLabelsRange>() != null;
  }
  
  private static bool CmpShowDataLabelsRange(DXDC.DLblsExtension openXmlElement, Boolean? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    var val = openXmlElement.GetFirstChild<DXO13DC.ShowDataLabelsRange>() != null;
    if (val == value) return true;
    diffs?.Add(objName, "DXO13DC.ShowDataLabelsRange", val, value);
    return false;
  }
  
  private static void SetShowDataLabelsRange(DXDC.DLblsExtension openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DXO13DC.ShowDataLabelsRange>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DXO13DC.ShowDataLabelsRange();
      openXmlElement.AppendChild(itemElement);
    }
  }
  
  private static DMDC.ShapeProperties3? GetShapeProperties(DXDC.DLblsExtension openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO13DC.ShapeProperties>();
    if (element != null)
      return DMXDC.ShapeProperties3Converter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpShapeProperties(DXDC.DLblsExtension openXmlElement, DMDC.ShapeProperties3? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXDC.ShapeProperties3Converter.CompareModelElement(openXmlElement.GetFirstChild<DXO13DC.ShapeProperties>(), value, diffs, objName, propName);
  }
  
  private static void SetShapeProperties(DXDC.DLblsExtension openXmlElement, DMDC.ShapeProperties3? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO13DC.ShapeProperties>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDC.ShapeProperties3Converter.CreateOpenXmlElement<DXO13DC.ShapeProperties>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  private static DMDC.Layout3? GetLayout(DXDC.DLblsExtension openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO13DC.Layout>();
    if (element != null)
      return DMXDC.Layout3Converter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpLayout(DXDC.DLblsExtension openXmlElement, DMDC.Layout3? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXDC.Layout3Converter.CompareModelElement(openXmlElement.GetFirstChild<DXO13DC.Layout>(), value, diffs, objName, propName);
  }
  
  private static void SetLayout(DXDC.DLblsExtension openXmlElement, DMDC.Layout3? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO13DC.Layout>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDC.Layout3Converter.CreateOpenXmlElement<DXO13DC.Layout>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  private static Boolean? GetShowLeaderLines(DXDC.DLblsExtension openXmlElement)
  {
    return openXmlElement.GetFirstChild<DXO13DC.ShowLeaderLines>() != null;
  }
  
  private static bool CmpShowLeaderLines(DXDC.DLblsExtension openXmlElement, Boolean? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    var val = openXmlElement.GetFirstChild<DXO13DC.ShowLeaderLines>() != null;
    if (val == value) return true;
    diffs?.Add(objName, "DXO13DC.ShowLeaderLines", val, value);
    return false;
  }
  
  private static void SetShowLeaderLines(DXDC.DLblsExtension openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DXO13DC.ShowLeaderLines>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DXO13DC.ShowLeaderLines();
      openXmlElement.AppendChild(itemElement);
    }
  }
  
  private static DMDC.LeaderLines3? GetLeaderLines(DXDC.DLblsExtension openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO13DC.LeaderLines>();
    if (element != null)
      return DMXDC.LeaderLines3Converter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpLeaderLines(DXDC.DLblsExtension openXmlElement, DMDC.LeaderLines3? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXDC.LeaderLines3Converter.CompareModelElement(openXmlElement.GetFirstChild<DXO13DC.LeaderLines>(), value, diffs, objName, propName);
  }
  
  private static void SetLeaderLines(DXDC.DLblsExtension openXmlElement, DMDC.LeaderLines3? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO13DC.LeaderLines>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDC.LeaderLines3Converter.CreateOpenXmlElement<DXO13DC.LeaderLines>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  public static DocumentModel.Drawings.Charts.DLblsExtension? CreateModelElement(DXDC.DLblsExtension? openXmlElement)
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
  
  public static bool CompareModelElement(DXDC.DLblsExtension? openXmlElement, DMDC.DLblsExtension? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpUri(openXmlElement, value.Uri, diffs, objName, propName))
        ok = false;
      if (!CmpChartText(openXmlElement, value.ChartText, diffs, objName, propName))
        ok = false;
      if (!CmpDataLabelFieldTable(openXmlElement, value.DataLabelFieldTable, diffs, objName, propName))
        ok = false;
      if (!CmpShowDataLabelsRange(openXmlElement, value.ShowDataLabelsRange, diffs, objName, propName))
        ok = false;
      if (!CmpShapeProperties(openXmlElement, value.ShapeProperties, diffs, objName, propName))
        ok = false;
      if (!CmpLayout(openXmlElement, value.Layout, diffs, objName, propName))
        ok = false;
      if (!CmpShowLeaderLines(openXmlElement, value.ShowLeaderLines, diffs, objName, propName))
        ok = false;
      if (!CmpLeaderLines(openXmlElement, value.LeaderLines, diffs, objName, propName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDC.DLblsExtension value)
    where OpenXmlElementType: DXDC.DLblsExtension, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXDC.DLblsExtension openXmlElement, DMDC.DLblsExtension value)
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
