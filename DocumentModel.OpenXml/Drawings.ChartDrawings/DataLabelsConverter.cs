namespace DocumentModel.OpenXml.Drawings.ChartDrawings;

/// <summary>
/// Defines the DataLabels Class.
/// </summary>
public static class DataLabelsConverter
{
  /// <summary>
  /// pos, this property is only available in Office 2016 and later.
  /// </summary>
  private static DMDrawsChartDraws.DataLabelPos? GetPos(DXO2016DrawChartDraw.DataLabels openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.DataLabelPos, DMDrawsChartDraws.DataLabelPos>(openXmlElement?.Pos?.Value);
  }
  
  private static bool CmpPos(DXO2016DrawChartDraw.DataLabels openXmlElement, DMDrawsChartDraws.DataLabelPos? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.DataLabelPos, DMDrawsChartDraws.DataLabelPos>(openXmlElement?.Pos?.Value, value, diffs, objName);
  }
  
  private static void SetPos(DXO2016DrawChartDraw.DataLabels openXmlElement, DMDrawsChartDraws.DataLabelPos? value)
  {
    openXmlElement.Pos = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.DataLabelPos, DMDrawsChartDraws.DataLabelPos>(value);
  }
  
  /// <summary>
  /// NumberFormat.
  /// </summary>
  private static DMDrawsChartDraws.NumberFormat? GetNumberFormat(DXO2016DrawChartDraw.DataLabels openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO2016DrawChartDraw.NumberFormat>();
    if (element != null)
      return DMXDrawsChartDraws.NumberFormatConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpNumberFormat(DXO2016DrawChartDraw.DataLabels openXmlElement, DMDrawsChartDraws.NumberFormat? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsChartDraws.NumberFormatConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO2016DrawChartDraw.NumberFormat>(), value, diffs, objName);
  }
  
  private static void SetNumberFormat(DXO2016DrawChartDraw.DataLabels openXmlElement, DMDrawsChartDraws.NumberFormat? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO2016DrawChartDraw.NumberFormat>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDrawsChartDraws.NumberFormatConverter.CreateOpenXmlElement<DXO2016DrawChartDraw.NumberFormat>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// ShapeProperties.
  /// </summary>
  private static DMDrawsChartDraws.ShapeProperties? GetShapeProperties(DXO2016DrawChartDraw.DataLabels openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO2016DrawChartDraw.ShapeProperties>();
    if (element != null)
      return DMXDrawsChartDraws.ShapePropertiesConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpShapeProperties(DXO2016DrawChartDraw.DataLabels openXmlElement, DMDrawsChartDraws.ShapeProperties? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsChartDraws.ShapePropertiesConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO2016DrawChartDraw.ShapeProperties>(), value, diffs, objName);
  }
  
  private static void SetShapeProperties(DXO2016DrawChartDraw.DataLabels openXmlElement, DMDrawsChartDraws.ShapeProperties? value)
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
  private static DMDrawsChartDraws.TxPrTextBody? GetTxPrTextBody(DXO2016DrawChartDraw.DataLabels openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO2016DrawChartDraw.TxPrTextBody>();
    if (element != null)
      return DMXDrawsChartDraws.TxPrTextBodyConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpTxPrTextBody(DXO2016DrawChartDraw.DataLabels openXmlElement, DMDrawsChartDraws.TxPrTextBody? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsChartDraws.TxPrTextBodyConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO2016DrawChartDraw.TxPrTextBody>(), value, diffs, objName);
  }
  
  private static void SetTxPrTextBody(DXO2016DrawChartDraw.DataLabels openXmlElement, DMDrawsChartDraws.TxPrTextBody? value)
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
  /// DataLabelVisibilities.
  /// </summary>
  private static DMDrawsChartDraws.DataLabelVisibilities? GetDataLabelVisibilities(DXO2016DrawChartDraw.DataLabels openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO2016DrawChartDraw.DataLabelVisibilities>();
    if (element != null)
      return DMXDrawsChartDraws.DataLabelVisibilitiesConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpDataLabelVisibilities(DXO2016DrawChartDraw.DataLabels openXmlElement, DMDrawsChartDraws.DataLabelVisibilities? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsChartDraws.DataLabelVisibilitiesConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO2016DrawChartDraw.DataLabelVisibilities>(), value, diffs, objName);
  }
  
  private static void SetDataLabelVisibilities(DXO2016DrawChartDraw.DataLabels openXmlElement, DMDrawsChartDraws.DataLabelVisibilities? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO2016DrawChartDraw.DataLabelVisibilities>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDrawsChartDraws.DataLabelVisibilitiesConverter.CreateOpenXmlElement<DXO2016DrawChartDraw.DataLabelVisibilities>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// SeparatorXsdstring.
  /// </summary>
  private static String? GetSeparatorXsdstring(DXO2016DrawChartDraw.DataLabels openXmlElement)
  {
      return openXmlElement?.GetFirstChild<DXO2016DrawChartDraw.SeparatorXsdstring>()?.Text;
  }
  
  private static bool CmpSeparatorXsdstring(DXO2016DrawChartDraw.DataLabels openXmlElement, String? value, DiffList? diffs, string? objName)
  {
      return openXmlElement?.GetFirstChild<DXO2016DrawChartDraw.SeparatorXsdstring>()?.Text == value;
  }
  
  private static void SetSeparatorXsdstring(DXO2016DrawChartDraw.DataLabels openXmlElement, String? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO2016DrawChartDraw.SeparatorXsdstring>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DXO2016DrawChartDraw.SeparatorXsdstring { Text = value };
      openXmlElement.AddChild(itemElement);
    }
  }
  
  private static Collection<DMDrawsChartDraws.DataLabel>? GetItems(DXO2016DrawChartDraw.DataLabels openXmlElement)
  {
    var collection = new Collection<DMDrawsChartDraws.DataLabel>();
    foreach (var item in openXmlElement.Elements<DXO2016DrawChartDraw.DataLabel>())
    {
      var newItem = DMXDrawsChartDraws.DataLabelConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    if (collection.Count>0)
      return collection;
    return null;
  }
  
  private static bool CmpItems(DXO2016DrawChartDraw.DataLabels openXmlElement, Collection<DMDrawsChartDraws.DataLabel>? value, DiffList? diffs, string? objName)
  {
    var origElements = openXmlElement.Elements<DXO2016DrawChartDraw.DataLabel>();
    var origElementsCount = origElements.Count();
    var modelElementsCount = value?.Count() ?? 0;
    if (value != null)
    {
      if (origElementsCount != modelElementsCount)
      {
        diffs?.Add(objName, openXmlElement.GetType().Name+".Count", origElementsCount, modelElementsCount);
        return false;
      }
      var ok = true;
      var modelEnumerator = value.GetEnumerator();
      foreach (var origItem in origElements)
      {
        modelEnumerator.MoveNext();
        var modelItem = modelEnumerator.Current;
        if (!DMXDrawsChartDraws.DataLabelConverter.CompareModelElement(origItem, modelItem, diffs, objName))
          ok = false;
      }
      return ok;
    }
    if (origElementsCount == 0 && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  private static void SetItems(DXO2016DrawChartDraw.DataLabels openXmlElement, Collection<DMDrawsChartDraws.DataLabel>? value)
  {
    openXmlElement.RemoveAllChildren<DXO2016DrawChartDraw.DataLabel>();
    if (value != null)
    {
      foreach (var item in value)
      {
        var newItem = DMXDrawsChartDraws.DataLabelConverter.CreateOpenXmlElement<DXO2016DrawChartDraw.DataLabel>(item);
        if (newItem != null)
          openXmlElement.AddChild(newItem);
      }
    }
  }
  
  private static Collection<DMDrawsChartDraws.DataLabelHidden>? GetDataLabelHiddens(DXO2016DrawChartDraw.DataLabels openXmlElement)
  {
    var collection = new Collection<DMDrawsChartDraws.DataLabelHidden>();
    foreach (var item in openXmlElement.Elements<DXO2016DrawChartDraw.DataLabelHidden>())
    {
      var newItem = DMXDrawsChartDraws.DataLabelHiddenConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    if (collection.Count>0)
      return collection;
    return null;
  }
  
  private static bool CmpDataLabelHiddens(DXO2016DrawChartDraw.DataLabels openXmlElement, Collection<DMDrawsChartDraws.DataLabelHidden>? value, DiffList? diffs, string? objName)
  {
    var origElements = openXmlElement.Elements<DXO2016DrawChartDraw.DataLabelHidden>();
    var origElementsCount = origElements.Count();
    var modelElementsCount = value?.Count() ?? 0;
    if (value != null)
    {
      if (origElementsCount != modelElementsCount)
      {
        diffs?.Add(objName, openXmlElement.GetType().Name+".Count", origElementsCount, modelElementsCount);
        return false;
      }
      var ok = true;
      var modelEnumerator = value.GetEnumerator();
      foreach (var origItem in origElements)
      {
        modelEnumerator.MoveNext();
        var modelItem = modelEnumerator.Current;
        if (!DMXDrawsChartDraws.DataLabelHiddenConverter.CompareModelElement(origItem, modelItem, diffs, objName))
          ok = false;
      }
      return ok;
    }
    if (origElementsCount == 0 && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  private static void SetDataLabelHiddens(DXO2016DrawChartDraw.DataLabels openXmlElement, Collection<DMDrawsChartDraws.DataLabelHidden>? value)
  {
    openXmlElement.RemoveAllChildren<DXO2016DrawChartDraw.DataLabelHidden>();
    if (value != null)
    {
      foreach (var item in value)
      {
        var newItem = DMXDrawsChartDraws.DataLabelHiddenConverter.CreateOpenXmlElement<DXO2016DrawChartDraw.DataLabelHidden>(item);
        if (newItem != null)
          openXmlElement.AddChild(newItem);
      }
    }
  }
  
  private static DMDrawsChartDraws.ExtensionList? GetExtensionList(DXO2016DrawChartDraw.DataLabels openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO2016DrawChartDraw.ExtensionList>();
    if (element != null)
      return DMXDrawsChartDraws.ExtensionListConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpExtensionList(DXO2016DrawChartDraw.DataLabels openXmlElement, DMDrawsChartDraws.ExtensionList? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsChartDraws.ExtensionListConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO2016DrawChartDraw.ExtensionList>(), value, diffs, objName);
  }
  
  private static void SetExtensionList(DXO2016DrawChartDraw.DataLabels openXmlElement, DMDrawsChartDraws.ExtensionList? value)
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
  
  public static DocumentModel.Drawings.ChartDrawings.DataLabels? CreateModelElement(DXO2016DrawChartDraw.DataLabels? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.ChartDrawings.DataLabels();
      value.Pos = GetPos(openXmlElement);
      value.NumberFormat = GetNumberFormat(openXmlElement);
      value.ShapeProperties = GetShapeProperties(openXmlElement);
      value.TxPrTextBody = GetTxPrTextBody(openXmlElement);
      value.DataLabelVisibilities = GetDataLabelVisibilities(openXmlElement);
      value.SeparatorXsdstring = GetSeparatorXsdstring(openXmlElement);
      value.Items = GetItems(openXmlElement);
      value.DataLabelHiddens = GetDataLabelHiddens(openXmlElement);
      value.ExtensionList = GetExtensionList(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXO2016DrawChartDraw.DataLabels? openXmlElement, DMDrawsChartDraws.DataLabels? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpPos(openXmlElement, value.Pos, diffs, objName))
        ok = false;
      if (!CmpNumberFormat(openXmlElement, value.NumberFormat, diffs, objName))
        ok = false;
      if (!CmpShapeProperties(openXmlElement, value.ShapeProperties, diffs, objName))
        ok = false;
      if (!CmpTxPrTextBody(openXmlElement, value.TxPrTextBody, diffs, objName))
        ok = false;
      if (!CmpDataLabelVisibilities(openXmlElement, value.DataLabelVisibilities, diffs, objName))
        ok = false;
      if (!CmpSeparatorXsdstring(openXmlElement, value.SeparatorXsdstring, diffs, objName))
        ok = false;
      if (!CmpItems(openXmlElement, value.Items, diffs, objName))
        ok = false;
      if (!CmpDataLabelHiddens(openXmlElement, value.DataLabelHiddens, diffs, objName))
        ok = false;
      if (!CmpExtensionList(openXmlElement, value.ExtensionList, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDrawsChartDraws.DataLabels value)
    where OpenXmlElementType: DXO2016DrawChartDraw.DataLabels, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXO2016DrawChartDraw.DataLabels openXmlElement, DMDrawsChartDraws.DataLabels value)
  {
    SetPos(openXmlElement, value?.Pos);
    SetNumberFormat(openXmlElement, value?.NumberFormat);
    SetShapeProperties(openXmlElement, value?.ShapeProperties);
    SetTxPrTextBody(openXmlElement, value?.TxPrTextBody);
    SetDataLabelVisibilities(openXmlElement, value?.DataLabelVisibilities);
    SetSeparatorXsdstring(openXmlElement, value?.SeparatorXsdstring);
    SetItems(openXmlElement, value?.Items);
    SetDataLabelHiddens(openXmlElement, value?.DataLabelHiddens);
    SetExtensionList(openXmlElement, value?.ExtensionList);
  }
}
