namespace DocumentModel.OpenXml.Drawings.ChartDrawings;

/// <summary>
/// Defines the DataLabel Class.
/// </summary>
public static class DataLabelConverter
{
  /// <summary>
  /// idx, this property is only available in Office 2016 and later.
  /// </summary>
  private static UInt32? GetIdx(DXO16DCD.DataLabel openXmlElement)
  {
    return openXmlElement?.Idx?.Value;
  }
  
  private static bool CmpIdx(DXO16DCD.DataLabel openXmlElement, UInt32? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement?.Idx?.Value == value) return true;
    diffs?.Add(objName, "Idx", openXmlElement?.Idx?.Value, value);
    return false;
  }
  
  private static void SetIdx(DXO16DCD.DataLabel openXmlElement, UInt32? value)
  {
    openXmlElement.Idx = value;
  }
  
  /// <summary>
  /// pos, this property is only available in Office 2016 and later.
  /// </summary>
  private static DMDCDs.DataLabelPos? GetPos(DXO16DCD.DataLabel openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.DataLabelPos, DMDCDs.DataLabelPos>(openXmlElement?.Pos?.Value);
  }
  
  private static bool CmpPos(DXO16DCD.DataLabel openXmlElement, DMDCDs.DataLabelPos? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.DataLabelPos, DMDCDs.DataLabelPos>(openXmlElement?.Pos?.Value, value, diffs, objName, propName);
  }
  
  private static void SetPos(DXO16DCD.DataLabel openXmlElement, DMDCDs.DataLabelPos? value)
  {
    openXmlElement.Pos = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.DataLabelPos, DMDCDs.DataLabelPos>(value);
  }
  
  /// <summary>
  /// NumberFormat.
  /// </summary>
  private static DMDCDs.NumberFormat? GetNumberFormat(DXO16DCD.DataLabel openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO16DCD.NumberFormat>();
    if (element != null)
      return DMXDCDs.NumberFormatConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpNumberFormat(DXO16DCD.DataLabel openXmlElement, DMDCDs.NumberFormat? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXDCDs.NumberFormatConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO16DCD.NumberFormat>(), value, diffs, objName, propName);
  }
  
  private static void SetNumberFormat(DXO16DCD.DataLabel openXmlElement, DMDCDs.NumberFormat? value)
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
  private static DMDCDs.ShapeProperties? GetShapeProperties(DXO16DCD.DataLabel openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO16DCD.ShapeProperties>();
    if (element != null)
      return DMXDCDs.ShapePropertiesConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpShapeProperties(DXO16DCD.DataLabel openXmlElement, DMDCDs.ShapeProperties? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXDCDs.ShapePropertiesConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO16DCD.ShapeProperties>(), value, diffs, objName, propName);
  }
  
  private static void SetShapeProperties(DXO16DCD.DataLabel openXmlElement, DMDCDs.ShapeProperties? value)
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
  private static DMDCDs.TxPrTextBody? GetTxPrTextBody(DXO16DCD.DataLabel openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO16DCD.TxPrTextBody>();
    if (element != null)
      return DMXDCDs.TxPrTextBodyConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpTxPrTextBody(DXO16DCD.DataLabel openXmlElement, DMDCDs.TxPrTextBody? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXDCDs.TxPrTextBodyConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO16DCD.TxPrTextBody>(), value, diffs, objName, propName);
  }
  
  private static void SetTxPrTextBody(DXO16DCD.DataLabel openXmlElement, DMDCDs.TxPrTextBody? value)
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
  private static DMDCDs.DataLabelVisibilities? GetDataLabelVisibilities(DXO16DCD.DataLabel openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO16DCD.DataLabelVisibilities>();
    if (element != null)
      return DMXDCDs.DataLabelVisibilitiesConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpDataLabelVisibilities(DXO16DCD.DataLabel openXmlElement, DMDCDs.DataLabelVisibilities? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXDCDs.DataLabelVisibilitiesConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO16DCD.DataLabelVisibilities>(), value, diffs, objName, propName);
  }
  
  private static void SetDataLabelVisibilities(DXO16DCD.DataLabel openXmlElement, DMDCDs.DataLabelVisibilities? value)
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
  private static String? GetSeparatorXsdstring(DXO16DCD.DataLabel openXmlElement)
  {
      return openXmlElement?.GetFirstChild<DXO16DCD.SeparatorXsdstring>()?.Text;
  }
  
  private static bool CmpSeparatorXsdstring(DXO16DCD.DataLabel openXmlElement, String? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
      return openXmlElement?.GetFirstChild<DXO16DCD.SeparatorXsdstring>()?.Text == value;
  }
  
  private static void SetSeparatorXsdstring(DXO16DCD.DataLabel openXmlElement, String? value)
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
  
  /// <summary>
  /// ExtensionList.
  /// </summary>
  private static DMDCDs.ExtensionList? GetExtensionList(DXO16DCD.DataLabel openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO16DCD.ExtensionList>();
    if (element != null)
      return DMXDCDs.ExtensionListConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpExtensionList(DXO16DCD.DataLabel openXmlElement, DMDCDs.ExtensionList? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXDCDs.ExtensionListConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO16DCD.ExtensionList>(), value, diffs, objName, propName);
  }
  
  private static void SetExtensionList(DXO16DCD.DataLabel openXmlElement, DMDCDs.ExtensionList? value)
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
  
  public static DMDCDs.DataLabel? CreateModelElement(DXO16DCD.DataLabel? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDCDs.DataLabel();
      value.Idx = GetIdx(openXmlElement);
      value.Pos = GetPos(openXmlElement);
      value.NumberFormat = GetNumberFormat(openXmlElement);
      value.ShapeProperties = GetShapeProperties(openXmlElement);
      value.TxPrTextBody = GetTxPrTextBody(openXmlElement);
      value.DataLabelVisibilities = GetDataLabelVisibilities(openXmlElement);
      value.SeparatorXsdstring = GetSeparatorXsdstring(openXmlElement);
      value.ExtensionList = GetExtensionList(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXO16DCD.DataLabel? openXmlElement, DMDCDs.DataLabel? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpIdx(openXmlElement, value.Idx, diffs, objName, propName))
        ok = false;
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
      if (!CmpExtensionList(openXmlElement, value.ExtensionList, diffs, objName, propName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDCDs.DataLabel value)
    where OpenXmlElementType: DXO16DCD.DataLabel, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXO16DCD.DataLabel openXmlElement, DMDCDs.DataLabel value)
  {
    SetIdx(openXmlElement, value?.Idx);
    SetPos(openXmlElement, value?.Pos);
    SetNumberFormat(openXmlElement, value?.NumberFormat);
    SetShapeProperties(openXmlElement, value?.ShapeProperties);
    SetTxPrTextBody(openXmlElement, value?.TxPrTextBody);
    SetDataLabelVisibilities(openXmlElement, value?.DataLabelVisibilities);
    SetSeparatorXsdstring(openXmlElement, value?.SeparatorXsdstring);
    SetExtensionList(openXmlElement, value?.ExtensionList);
  }
}
