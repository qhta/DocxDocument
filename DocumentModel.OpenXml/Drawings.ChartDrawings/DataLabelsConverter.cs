namespace DocumentModel.OpenXml.Drawings.ChartDrawings;

/// <summary>
/// Defines the DataLabels Class.
/// </summary>
public static class DataLabelsConverter
{
  /// <summary>
  /// pos, this property is only available in Office 2016 and later.
  /// </summary>
  private static DMDCDs.DataLabelPos? GetPos(DXO16DCD.DataLabels openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.DataLabelPos, DMDCDs.DataLabelPos>(openXmlElement?.Pos?.Value);
  }
  
  private static bool CmpPos(DXO16DCD.DataLabels openXmlElement, DMDCDs.DataLabelPos? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.DataLabelPos, DMDCDs.DataLabelPos>(openXmlElement?.Pos?.Value, value, diffs, objName, propName);
  }
  
  private static void SetPos(DXO16DCD.DataLabels openXmlElement, DMDCDs.DataLabelPos? value)
  {
    openXmlElement.Pos = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.DataLabelPos, DMDCDs.DataLabelPos>(value);
  }
  
  /// <summary>
  /// NumberFormat.
  /// </summary>
  private static DMDCDs.NumberFormat? GetNumberFormat(DXO16DCD.DataLabels openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO16DCD.NumberFormat>();
    if (element != null)
      return DMXDCDs.NumberFormatConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpNumberFormat(DXO16DCD.DataLabels openXmlElement, DMDCDs.NumberFormat? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXDCDs.NumberFormatConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO16DCD.NumberFormat>(), value, diffs, objName, propName);
  }
  
  private static void SetNumberFormat(DXO16DCD.DataLabels openXmlElement, DMDCDs.NumberFormat? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO16DCD.NumberFormat>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDCDs.NumberFormatConverter.CreateOpenXmlElement<DXO16DCD.NumberFormat>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  /// <summary>
  /// ShapeProperties.
  /// </summary>
  private static DMDCDs.ShapeProperties? GetShapeProperties(DXO16DCD.DataLabels openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO16DCD.ShapeProperties>();
    if (element != null)
      return DMXDCDs.ShapePropertiesConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpShapeProperties(DXO16DCD.DataLabels openXmlElement, DMDCDs.ShapeProperties? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXDCDs.ShapePropertiesConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO16DCD.ShapeProperties>(), value, diffs, objName, propName);
  }
  
  private static void SetShapeProperties(DXO16DCD.DataLabels openXmlElement, DMDCDs.ShapeProperties? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO16DCD.ShapeProperties>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDCDs.ShapePropertiesConverter.CreateOpenXmlElement<DXO16DCD.ShapeProperties>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  /// <summary>
  /// TxPrTextBody.
  /// </summary>
  private static DMDCDs.TxPrTextBody? GetTxPrTextBody(DXO16DCD.DataLabels openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO16DCD.TxPrTextBody>();
    if (element != null)
      return DMXDCDs.TxPrTextBodyConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpTxPrTextBody(DXO16DCD.DataLabels openXmlElement, DMDCDs.TxPrTextBody? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXDCDs.TxPrTextBodyConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO16DCD.TxPrTextBody>(), value, diffs, objName, propName);
  }
  
  private static void SetTxPrTextBody(DXO16DCD.DataLabels openXmlElement, DMDCDs.TxPrTextBody? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO16DCD.TxPrTextBody>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDCDs.TxPrTextBodyConverter.CreateOpenXmlElement<DXO16DCD.TxPrTextBody>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  /// <summary>
  /// DataLabelVisibilities.
  /// </summary>
  private static DMDCDs.DataLabelVisibilities? GetDataLabelVisibilities(DXO16DCD.DataLabels openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO16DCD.DataLabelVisibilities>();
    if (element != null)
      return DMXDCDs.DataLabelVisibilitiesConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpDataLabelVisibilities(DXO16DCD.DataLabels openXmlElement, DMDCDs.DataLabelVisibilities? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXDCDs.DataLabelVisibilitiesConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO16DCD.DataLabelVisibilities>(), value, diffs, objName, propName);
  }
  
  private static void SetDataLabelVisibilities(DXO16DCD.DataLabels openXmlElement, DMDCDs.DataLabelVisibilities? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO16DCD.DataLabelVisibilities>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDCDs.DataLabelVisibilitiesConverter.CreateOpenXmlElement<DXO16DCD.DataLabelVisibilities>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  /// <summary>
  /// SeparatorXsdstring.
  /// </summary>
  private static String? GetSeparatorXsdstring(DXO16DCD.DataLabels openXmlElement)
  {
      return openXmlElement?.GetFirstChild<DXO16DCD.SeparatorXsdstring>()?.Text;
  }
  
  private static bool CmpSeparatorXsdstring(DXO16DCD.DataLabels openXmlElement, String? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
      return openXmlElement?.GetFirstChild<DXO16DCD.SeparatorXsdstring>()?.Text == value;
  }
  
  private static void SetSeparatorXsdstring(DXO16DCD.DataLabels openXmlElement, String? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO16DCD.SeparatorXsdstring>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DXO16DCD.SeparatorXsdstring { Text = value };
      openXmlElement.AppendChild(itemElement);
    }
  }
  
  private static Collection<DMDCDs.DataLabel>? GetItems(DXO16DCD.DataLabels openXmlElement)
  {
    var collection = new Collection<DMDCDs.DataLabel>();
    foreach (var item in openXmlElement.Elements<DXO16DCD.DataLabel>())
    {
      var newItem = DMXDCDs.DataLabelConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    if (collection.Count>0)
      return collection;
    return null;
  }
  
  private static bool CmpItems(DXO16DCD.DataLabels openXmlElement, Collection<DMDCDs.DataLabel>? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    var origElements = openXmlElement.Elements<DXO16DCD.DataLabel>();
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
        if (!DMXDCDs.DataLabelConverter.CompareModelElement(origItem, modelItem, diffs, objName, propName))
          ok = false;
      }
      return ok;
    }
    if (origElementsCount == 0 && value == null) return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  private static void SetItems(DXO16DCD.DataLabels openXmlElement, Collection<DMDCDs.DataLabel>? value)
  {
    openXmlElement.RemoveAllChildren<DXO16DCD.DataLabel>();
    if (value != null)
    {
      foreach (var item in value)
      {
        var newItem = DMXDCDs.DataLabelConverter.CreateOpenXmlElement<DXO16DCD.DataLabel>(item);
        if (newItem != null)
          openXmlElement.AppendChild(newItem);
      }
    }
  }
  
  private static Collection<DMDCDs.DataLabelHidden>? GetDataLabelHiddens(DXO16DCD.DataLabels openXmlElement)
  {
    var collection = new Collection<DMDCDs.DataLabelHidden>();
    foreach (var item in openXmlElement.Elements<DXO16DCD.DataLabelHidden>())
    {
      var newItem = DMXDCDs.DataLabelHiddenConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    if (collection.Count>0)
      return collection;
    return null;
  }
  
  private static bool CmpDataLabelHiddens(DXO16DCD.DataLabels openXmlElement, Collection<DMDCDs.DataLabelHidden>? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    var origElements = openXmlElement.Elements<DXO16DCD.DataLabelHidden>();
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
        if (!DMXDCDs.DataLabelHiddenConverter.CompareModelElement(origItem, modelItem, diffs, objName, propName))
          ok = false;
      }
      return ok;
    }
    if (origElementsCount == 0 && value == null) return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  private static void SetDataLabelHiddens(DXO16DCD.DataLabels openXmlElement, Collection<DMDCDs.DataLabelHidden>? value)
  {
    openXmlElement.RemoveAllChildren<DXO16DCD.DataLabelHidden>();
    if (value != null)
    {
      foreach (var item in value)
      {
        var newItem = DMXDCDs.DataLabelHiddenConverter.CreateOpenXmlElement<DXO16DCD.DataLabelHidden>(item);
        if (newItem != null)
          openXmlElement.AppendChild(newItem);
      }
    }
  }
  
  private static DMDCDs.ExtensionList? GetExtensionList(DXO16DCD.DataLabels openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO16DCD.ExtensionList>();
    if (element != null)
      return DMXDCDs.ExtensionListConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpExtensionList(DXO16DCD.DataLabels openXmlElement, DMDCDs.ExtensionList? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXDCDs.ExtensionListConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO16DCD.ExtensionList>(), value, diffs, objName, propName);
  }
  
  private static void SetExtensionList(DXO16DCD.DataLabels openXmlElement, DMDCDs.ExtensionList? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO16DCD.ExtensionList>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDCDs.ExtensionListConverter.CreateOpenXmlElement<DXO16DCD.ExtensionList>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  public static DocumentModel.Drawings.ChartDrawings.DataLabels? CreateModelElement(DXO16DCD.DataLabels? openXmlElement)
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
  
  public static bool CompareModelElement(DXO16DCD.DataLabels? openXmlElement, DMDCDs.DataLabels? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpPos(openXmlElement, value.Pos, diffs, objName, propName))
        ok = false;
      if (!CmpNumberFormat(openXmlElement, value.NumberFormat, diffs, objName, propName))
        ok = false;
      if (!CmpShapeProperties(openXmlElement, value.ShapeProperties, diffs, objName, propName))
        ok = false;
      if (!CmpTxPrTextBody(openXmlElement, value.TxPrTextBody, diffs, objName, propName))
        ok = false;
      if (!CmpDataLabelVisibilities(openXmlElement, value.DataLabelVisibilities, diffs, objName, propName))
        ok = false;
      if (!CmpSeparatorXsdstring(openXmlElement, value.SeparatorXsdstring, diffs, objName, propName))
        ok = false;
      if (!CmpItems(openXmlElement, value.Items, diffs, objName, propName))
        ok = false;
      if (!CmpDataLabelHiddens(openXmlElement, value.DataLabelHiddens, diffs, objName, propName))
        ok = false;
      if (!CmpExtensionList(openXmlElement, value.ExtensionList, diffs, objName, propName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDCDs.DataLabels value)
    where OpenXmlElementType: DXO16DCD.DataLabels, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXO16DCD.DataLabels openXmlElement, DMDCDs.DataLabels value)
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
