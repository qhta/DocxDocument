namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
/// Data Labels.
/// </summary>
public static class DataLabelsConverter
{
  private static Collection<DMDC.DataLabel>? GetItems(DXDC.DataLabels openXmlElement)
  {
    var collection = new Collection<DMDC.DataLabel>();
    foreach (var item in openXmlElement.Elements<DXDC.DataLabel>())
    {
      var newItem = DMXDC.DataLabelConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    if (collection.Count>0)
      return collection;
    return null;
  }
  
  private static bool CmpItems(DXDC.DataLabels openXmlElement, Collection<DMDC.DataLabel>? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    var origElements = openXmlElement.Elements<DXDC.DataLabel>();
    var origElementsCount = origElements.Count();
    var modelElementsCount = value?.Count() ?? 0;
    if (value != null)
    {
      if (origElementsCount != modelElementsCount)
      {
        diffs?.Add(objName, propName ?? openXmlElement.GetType().Name+".Count", origElementsCount, modelElementsCount);
        return false;
      }
      var ok = true;
      var modelEnumerator = value.GetEnumerator();
      foreach (var origItem in origElements)
      {
        modelEnumerator.MoveNext();
        var modelItem = modelEnumerator.Current;
        if (!DMXDC.DataLabelConverter.CompareModelElement(origItem, modelItem, diffs, objName, propName))
          ok = false;
      }
      return ok;
    }
    if (origElementsCount == 0 && value == null) return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  private static void SetItems(DXDC.DataLabels openXmlElement, Collection<DMDC.DataLabel>? value)
  {
    openXmlElement.RemoveAllChildren<DXDC.DataLabel>();
    if (value != null)
    {
      foreach (var item in value)
      {
        var newItem = DMXDC.DataLabelConverter.CreateOpenXmlElement<DXDC.DataLabel>(item);
        if (newItem != null)
          openXmlElement.AppendChild(newItem);
      }
    }
  }
  
  private static Boolean? GetDelete(DXDC.DataLabels openXmlElement)
  {
    return openXmlElement.GetFirstChild<DXDC.Delete>() != null;
  }
  
  private static bool CmpDelete(DXDC.DataLabels openXmlElement, Boolean? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    var val = openXmlElement.GetFirstChild<DXDC.Delete>() != null;
    if (val == value) return true;
    diffs?.Add(objName, "DXDC.Delete", val, value);
    return false;
  }
  
  private static void SetDelete(DXDC.DataLabels openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DXDC.Delete>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DXDC.Delete();
      openXmlElement.AppendChild(itemElement);
    }
  }
  
  private static DMDC.NumberingFormat? GetNumberingFormat(DXDC.DataLabels openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDC.NumberingFormat>();
    if (element != null)
      return DMXDC.NumberingFormatConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpNumberingFormat(DXDC.DataLabels openXmlElement, DMDC.NumberingFormat? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXDC.NumberingFormatConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDC.NumberingFormat>(), value, diffs, objName, propName);
  }
  
  private static void SetNumberingFormat(DXDC.DataLabels openXmlElement, DMDC.NumberingFormat? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDC.NumberingFormat>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDC.NumberingFormatConverter.CreateOpenXmlElement<DXDC.NumberingFormat>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  private static DMDC.ChartShapeProperties? GetChartShapeProperties(DXDC.DataLabels openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDC.ChartShapeProperties>();
    if (element != null)
      return DMXDC.ChartShapePropertiesConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpChartShapeProperties(DXDC.DataLabels openXmlElement, DMDC.ChartShapeProperties? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXDC.ChartShapePropertiesConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDC.ChartShapeProperties>(), value, diffs, objName, propName);
  }
  
  private static void SetChartShapeProperties(DXDC.DataLabels openXmlElement, DMDC.ChartShapeProperties? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDC.ChartShapeProperties>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDC.ChartShapePropertiesConverter.CreateOpenXmlElement<DXDC.ChartShapeProperties>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  private static DMDC.TextProperties? GetTextProperties(DXDC.DataLabels openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDC.TextProperties>();
    if (element != null)
      return DMXDC.TextPropertiesConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpTextProperties(DXDC.DataLabels openXmlElement, DMDC.TextProperties? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXDC.TextPropertiesConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDC.TextProperties>(), value, diffs, objName, propName);
  }
  
  private static void SetTextProperties(DXDC.DataLabels openXmlElement, DMDC.TextProperties? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDC.TextProperties>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDC.TextPropertiesConverter.CreateOpenXmlElement<DXDC.TextProperties>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  private static DMDC.DataLabelPositionKind? GetDataLabelPosition(DXDC.DataLabels openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.Charts.DataLabelPositionValues, DMDC.DataLabelPositionKind>(openXmlElement.GetFirstChild<DXDC.DataLabelPosition>()?.Val?.Value);
  }
  
  private static bool CmpDataLabelPosition(DXDC.DataLabels openXmlElement, DMDC.DataLabelPositionKind? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Drawing.Charts.DataLabelPositionValues, DMDC.DataLabelPositionKind>(openXmlElement.GetFirstChild<DXDC.DataLabelPosition>()?.Val?.Value, value, diffs, objName, propName);
  }
  
  private static void SetDataLabelPosition(DXDC.DataLabels openXmlElement, DMDC.DataLabelPositionKind? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDC.DataLabelPosition>();
    if (itemElement != null)
    {
      if (value != null)
        EnumValueConverter.UpdateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Charts.DataLabelPositionValues, DMDC.DataLabelPositionKind>(itemElement, (DMDC.DataLabelPositionKind)value);
      else
        itemElement.Remove();
    }
    else
    if (value != null)
      openXmlElement.AppendChild(EnumValueConverter.CreateOpenXmlElement<DXDC.DataLabelPosition, DocumentFormat.OpenXml.Drawing.Charts.DataLabelPositionValues, DMDC.DataLabelPositionKind>((DMDC.DataLabelPositionKind)value));
  }
  
  private static Boolean? GetShowLegendKey(DXDC.DataLabels openXmlElement)
  {
    return openXmlElement.GetFirstChild<DXDC.ShowLegendKey>() != null;
  }
  
  private static bool CmpShowLegendKey(DXDC.DataLabels openXmlElement, Boolean? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    var val = openXmlElement.GetFirstChild<DXDC.ShowLegendKey>() != null;
    if (val == value) return true;
    diffs?.Add(objName, "DXDC.ShowLegendKey", val, value);
    return false;
  }
  
  private static void SetShowLegendKey(DXDC.DataLabels openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DXDC.ShowLegendKey>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DXDC.ShowLegendKey();
      openXmlElement.AppendChild(itemElement);
    }
  }
  
  private static Boolean? GetShowValue(DXDC.DataLabels openXmlElement)
  {
    return openXmlElement.GetFirstChild<DXDC.ShowValue>() != null;
  }
  
  private static bool CmpShowValue(DXDC.DataLabels openXmlElement, Boolean? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    var val = openXmlElement.GetFirstChild<DXDC.ShowValue>() != null;
    if (val == value) return true;
    diffs?.Add(objName, "DXDC.ShowValue", val, value);
    return false;
  }
  
  private static void SetShowValue(DXDC.DataLabels openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DXDC.ShowValue>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DXDC.ShowValue();
      openXmlElement.AppendChild(itemElement);
    }
  }
  
  private static Boolean? GetShowCategoryName(DXDC.DataLabels openXmlElement)
  {
    return openXmlElement.GetFirstChild<DXDC.ShowCategoryName>() != null;
  }
  
  private static bool CmpShowCategoryName(DXDC.DataLabels openXmlElement, Boolean? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    var val = openXmlElement.GetFirstChild<DXDC.ShowCategoryName>() != null;
    if (val == value) return true;
    diffs?.Add(objName, "DXDC.ShowCategoryName", val, value);
    return false;
  }
  
  private static void SetShowCategoryName(DXDC.DataLabels openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DXDC.ShowCategoryName>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DXDC.ShowCategoryName();
      openXmlElement.AppendChild(itemElement);
    }
  }
  
  private static Boolean? GetShowSeriesName(DXDC.DataLabels openXmlElement)
  {
    return openXmlElement.GetFirstChild<DXDC.ShowSeriesName>() != null;
  }
  
  private static bool CmpShowSeriesName(DXDC.DataLabels openXmlElement, Boolean? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    var val = openXmlElement.GetFirstChild<DXDC.ShowSeriesName>() != null;
    if (val == value) return true;
    diffs?.Add(objName, "DXDC.ShowSeriesName", val, value);
    return false;
  }
  
  private static void SetShowSeriesName(DXDC.DataLabels openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DXDC.ShowSeriesName>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DXDC.ShowSeriesName();
      openXmlElement.AppendChild(itemElement);
    }
  }
  
  private static Boolean? GetShowPercent(DXDC.DataLabels openXmlElement)
  {
    return openXmlElement.GetFirstChild<DXDC.ShowPercent>() != null;
  }
  
  private static bool CmpShowPercent(DXDC.DataLabels openXmlElement, Boolean? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    var val = openXmlElement.GetFirstChild<DXDC.ShowPercent>() != null;
    if (val == value) return true;
    diffs?.Add(objName, "DXDC.ShowPercent", val, value);
    return false;
  }
  
  private static void SetShowPercent(DXDC.DataLabels openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DXDC.ShowPercent>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DXDC.ShowPercent();
      openXmlElement.AppendChild(itemElement);
    }
  }
  
  private static Boolean? GetShowBubbleSize(DXDC.DataLabels openXmlElement)
  {
    return openXmlElement.GetFirstChild<DXDC.ShowBubbleSize>() != null;
  }
  
  private static bool CmpShowBubbleSize(DXDC.DataLabels openXmlElement, Boolean? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    var val = openXmlElement.GetFirstChild<DXDC.ShowBubbleSize>() != null;
    if (val == value) return true;
    diffs?.Add(objName, "DXDC.ShowBubbleSize", val, value);
    return false;
  }
  
  private static void SetShowBubbleSize(DXDC.DataLabels openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DXDC.ShowBubbleSize>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DXDC.ShowBubbleSize();
      openXmlElement.AppendChild(itemElement);
    }
  }
  
  private static String? GetSeparator(DXDC.DataLabels openXmlElement)
  {
      return openXmlElement?.GetFirstChild<DXDC.Separator>()?.Text;
  }
  
  private static bool CmpSeparator(DXDC.DataLabels openXmlElement, String? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
      return openXmlElement?.GetFirstChild<DXDC.Separator>()?.Text == value;
  }
  
  private static void SetSeparator(DXDC.DataLabels openXmlElement, String? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDC.Separator>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DXDC.Separator { Text = value };
      openXmlElement.AppendChild(itemElement);
    }
  }
  
  private static Boolean? GetShowLeaderLines(DXDC.DataLabels openXmlElement)
  {
    return openXmlElement.GetFirstChild<DXDC.ShowLeaderLines>() != null;
  }
  
  private static bool CmpShowLeaderLines(DXDC.DataLabels openXmlElement, Boolean? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    var val = openXmlElement.GetFirstChild<DXDC.ShowLeaderLines>() != null;
    if (val == value) return true;
    diffs?.Add(objName, "DXDC.ShowLeaderLines", val, value);
    return false;
  }
  
  private static void SetShowLeaderLines(DXDC.DataLabels openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DXDC.ShowLeaderLines>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DXDC.ShowLeaderLines();
      openXmlElement.AppendChild(itemElement);
    }
  }
  
  private static DMDC.LeaderLines? GetLeaderLines(DXDC.DataLabels openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDC.LeaderLines>();
    if (element != null)
      return DMXDC.LeaderLinesConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpLeaderLines(DXDC.DataLabels openXmlElement, DMDC.LeaderLines? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXDC.LeaderLinesConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDC.LeaderLines>(), value, diffs, objName, propName);
  }
  
  private static void SetLeaderLines(DXDC.DataLabels openXmlElement, DMDC.LeaderLines? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDC.LeaderLines>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDC.LeaderLinesConverter.CreateOpenXmlElement<DXDC.LeaderLines>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  private static DMDC.DLblsExtensionList? GetDLblsExtensionList(DXDC.DataLabels openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDC.DLblsExtensionList>();
    if (element != null)
      return DMXDC.DLblsExtensionListConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpDLblsExtensionList(DXDC.DataLabels openXmlElement, DMDC.DLblsExtensionList? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXDC.DLblsExtensionListConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDC.DLblsExtensionList>(), value, diffs, objName, propName);
  }
  
  private static void SetDLblsExtensionList(DXDC.DataLabels openXmlElement, DMDC.DLblsExtensionList? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDC.DLblsExtensionList>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDC.DLblsExtensionListConverter.CreateOpenXmlElement<DXDC.DLblsExtensionList>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  public static DMD.Charts.DataLabels? CreateModelElement(DXDC.DataLabels? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMD.Charts.DataLabels();
      value.Items = GetItems(openXmlElement);
      value.Delete = GetDelete(openXmlElement);
      value.NumberingFormat = GetNumberingFormat(openXmlElement);
      value.ChartShapeProperties = GetChartShapeProperties(openXmlElement);
      value.TextProperties = GetTextProperties(openXmlElement);
      value.DataLabelPosition = GetDataLabelPosition(openXmlElement);
      value.ShowLegendKey = GetShowLegendKey(openXmlElement);
      value.ShowValue = GetShowValue(openXmlElement);
      value.ShowCategoryName = GetShowCategoryName(openXmlElement);
      value.ShowSeriesName = GetShowSeriesName(openXmlElement);
      value.ShowPercent = GetShowPercent(openXmlElement);
      value.ShowBubbleSize = GetShowBubbleSize(openXmlElement);
      value.Separator = GetSeparator(openXmlElement);
      value.ShowLeaderLines = GetShowLeaderLines(openXmlElement);
      value.LeaderLines = GetLeaderLines(openXmlElement);
      value.DLblsExtensionList = GetDLblsExtensionList(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXDC.DataLabels? openXmlElement, DMDC.DataLabels? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpItems(openXmlElement, value.Items, diffs, objName, propName))
        ok = false;
      if (!CmpDelete(openXmlElement, value.Delete, diffs, objName, propName))
        ok = false;
      if (!CmpNumberingFormat(openXmlElement, value.NumberingFormat, diffs, objName, propName))
        ok = false;
      if (!CmpChartShapeProperties(openXmlElement, value.ChartShapeProperties, diffs, objName, propName))
        ok = false;
      if (!CmpTextProperties(openXmlElement, value.TextProperties, diffs, objName, propName))
        ok = false;
      if (!CmpDataLabelPosition(openXmlElement, value.DataLabelPosition, diffs, objName, propName))
        ok = false;
      if (!CmpShowLegendKey(openXmlElement, value.ShowLegendKey, diffs, objName, propName))
        ok = false;
      if (!CmpShowValue(openXmlElement, value.ShowValue, diffs, objName, propName))
        ok = false;
      if (!CmpShowCategoryName(openXmlElement, value.ShowCategoryName, diffs, objName, propName))
        ok = false;
      if (!CmpShowSeriesName(openXmlElement, value.ShowSeriesName, diffs, objName, propName))
        ok = false;
      if (!CmpShowPercent(openXmlElement, value.ShowPercent, diffs, objName, propName))
        ok = false;
      if (!CmpShowBubbleSize(openXmlElement, value.ShowBubbleSize, diffs, objName, propName))
        ok = false;
      if (!CmpSeparator(openXmlElement, value.Separator, diffs, objName, propName))
        ok = false;
      if (!CmpShowLeaderLines(openXmlElement, value.ShowLeaderLines, diffs, objName, propName))
        ok = false;
      if (!CmpLeaderLines(openXmlElement, value.LeaderLines, diffs, objName, propName))
        ok = false;
      if (!CmpDLblsExtensionList(openXmlElement, value.DLblsExtensionList, diffs, objName, propName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDC.DataLabels value)
    where OpenXmlElementType: DXDC.DataLabels, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXDC.DataLabels openXmlElement, DMDC.DataLabels value)
  {
    SetItems(openXmlElement, value?.Items);
    SetDelete(openXmlElement, value?.Delete);
    SetNumberingFormat(openXmlElement, value?.NumberingFormat);
    SetChartShapeProperties(openXmlElement, value?.ChartShapeProperties);
    SetTextProperties(openXmlElement, value?.TextProperties);
    SetDataLabelPosition(openXmlElement, value?.DataLabelPosition);
    SetShowLegendKey(openXmlElement, value?.ShowLegendKey);
    SetShowValue(openXmlElement, value?.ShowValue);
    SetShowCategoryName(openXmlElement, value?.ShowCategoryName);
    SetShowSeriesName(openXmlElement, value?.ShowSeriesName);
    SetShowPercent(openXmlElement, value?.ShowPercent);
    SetShowBubbleSize(openXmlElement, value?.ShowBubbleSize);
    SetSeparator(openXmlElement, value?.Separator);
    SetShowLeaderLines(openXmlElement, value?.ShowLeaderLines);
    SetLeaderLines(openXmlElement, value?.LeaderLines);
    SetDLblsExtensionList(openXmlElement, value?.DLblsExtensionList);
  }
}
