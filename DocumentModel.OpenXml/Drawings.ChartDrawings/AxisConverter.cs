namespace DocumentModel.OpenXml.Drawings.ChartDrawings;

/// <summary>
/// Defines the Axis Class.
/// </summary>
public static class AxisConverter
{
  /// <summary>
  /// id, this property is only available in Office 2016 and later.
  /// </summary>
  private static UInt32? GetId(DXO16DCD.Axis openXmlElement)
  {
    return openXmlElement?.Id?.Value;
  }
  
  private static bool CmpId(DXO16DCD.Axis openXmlElement, UInt32? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement?.Id?.Value == value) return true;
    diffs?.Add(objName, "AnnotationId", openXmlElement?.Id?.Value, value);
    return false;
  }
  
  private static void SetId(DXO16DCD.Axis openXmlElement, UInt32? value)
  {
    openXmlElement.Id = value;
  }
  
  /// <summary>
  /// hidden, this property is only available in Office 2016 and later.
  /// </summary>
  private static Boolean? GetHidden(DXO16DCD.Axis openXmlElement)
  {
    return openXmlElement?.Hidden?.Value;
  }
  
  private static bool CmpHidden(DXO16DCD.Axis openXmlElement, Boolean? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement?.Hidden?.Value == value) return true;
    diffs?.Add(objName, "GlyphHidden", openXmlElement?.Hidden?.Value, value);
    return false;
  }
  
  private static void SetHidden(DXO16DCD.Axis openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.Hidden = new BooleanValue { Value = (Boolean)value };
    else
      openXmlElement.Hidden = null;
  }
  
  private static DMDCDs.CategoryAxisScaling? GetCategoryAxisScaling(DXO16DCD.Axis openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO16DCD.CategoryAxisScaling>();
    if (element != null)
      return DMXDCDs.CategoryAxisScalingConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpCategoryAxisScaling(DXO16DCD.Axis openXmlElement, DMDCDs.CategoryAxisScaling? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXDCDs.CategoryAxisScalingConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO16DCD.CategoryAxisScaling>(), value, diffs, objName, propName);
  }
  
  private static void SetCategoryAxisScaling(DXO16DCD.Axis openXmlElement, DMDCDs.CategoryAxisScaling? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO16DCD.CategoryAxisScaling>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDCDs.CategoryAxisScalingConverter.CreateOpenXmlElement<DXO16DCD.CategoryAxisScaling>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  private static DMDCDs.ValueAxisScaling? GetValueAxisScaling(DXO16DCD.Axis openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO16DCD.ValueAxisScaling>();
    if (element != null)
      return DMXDCDs.ValueAxisScalingConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpValueAxisScaling(DXO16DCD.Axis openXmlElement, DMDCDs.ValueAxisScaling? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXDCDs.ValueAxisScalingConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO16DCD.ValueAxisScaling>(), value, diffs, objName, propName);
  }
  
  private static void SetValueAxisScaling(DXO16DCD.Axis openXmlElement, DMDCDs.ValueAxisScaling? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO16DCD.ValueAxisScaling>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDCDs.ValueAxisScalingConverter.CreateOpenXmlElement<DXO16DCD.ValueAxisScaling>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  private static DMDCDs.AxisTitle? GetAxisTitle(DXO16DCD.Axis openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO16DCD.AxisTitle>();
    if (element != null)
      return DMXDCDs.AxisTitleConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpAxisTitle(DXO16DCD.Axis openXmlElement, DMDCDs.AxisTitle? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXDCDs.AxisTitleConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO16DCD.AxisTitle>(), value, diffs, objName, propName);
  }
  
  private static void SetAxisTitle(DXO16DCD.Axis openXmlElement, DMDCDs.AxisTitle? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO16DCD.AxisTitle>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDCDs.AxisTitleConverter.CreateOpenXmlElement<DXO16DCD.AxisTitle>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  private static DMDCDs.AxisUnits? GetAxisUnits(DXO16DCD.Axis openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO16DCD.AxisUnits>();
    if (element != null)
      return DMXDCDs.AxisUnitsConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpAxisUnits(DXO16DCD.Axis openXmlElement, DMDCDs.AxisUnits? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXDCDs.AxisUnitsConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO16DCD.AxisUnits>(), value, diffs, objName, propName);
  }
  
  private static void SetAxisUnits(DXO16DCD.Axis openXmlElement, DMDCDs.AxisUnits? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO16DCD.AxisUnits>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDCDs.AxisUnitsConverter.CreateOpenXmlElement<DXO16DCD.AxisUnits>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  private static DMDCDs.MajorGridlinesGridlines? GetMajorGridlinesGridlines(DXO16DCD.Axis openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO16DCD.MajorGridlinesGridlines>();
    if (element != null)
      return DMXDCDs.MajorGridlinesGridlinesConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpMajorGridlinesGridlines(DXO16DCD.Axis openXmlElement, DMDCDs.MajorGridlinesGridlines? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXDCDs.MajorGridlinesGridlinesConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO16DCD.MajorGridlinesGridlines>(), value, diffs, objName, propName);
  }
  
  private static void SetMajorGridlinesGridlines(DXO16DCD.Axis openXmlElement, DMDCDs.MajorGridlinesGridlines? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO16DCD.MajorGridlinesGridlines>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDCDs.MajorGridlinesGridlinesConverter.CreateOpenXmlElement<DXO16DCD.MajorGridlinesGridlines>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  private static DMDCDs.MinorGridlinesGridlines? GetMinorGridlinesGridlines(DXO16DCD.Axis openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO16DCD.MinorGridlinesGridlines>();
    if (element != null)
      return DMXDCDs.MinorGridlinesGridlinesConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpMinorGridlinesGridlines(DXO16DCD.Axis openXmlElement, DMDCDs.MinorGridlinesGridlines? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXDCDs.MinorGridlinesGridlinesConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO16DCD.MinorGridlinesGridlines>(), value, diffs, objName, propName);
  }
  
  private static void SetMinorGridlinesGridlines(DXO16DCD.Axis openXmlElement, DMDCDs.MinorGridlinesGridlines? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO16DCD.MinorGridlinesGridlines>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDCDs.MinorGridlinesGridlinesConverter.CreateOpenXmlElement<DXO16DCD.MinorGridlinesGridlines>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  private static DMDCDs.MajorTickMarksTickMarks? GetMajorTickMarksTickMarks(DXO16DCD.Axis openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO16DCD.MajorTickMarksTickMarks>();
    if (element != null)
      return DMXDCDs.MajorTickMarksTickMarksConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpMajorTickMarksTickMarks(DXO16DCD.Axis openXmlElement, DMDCDs.MajorTickMarksTickMarks? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXDCDs.MajorTickMarksTickMarksConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO16DCD.MajorTickMarksTickMarks>(), value, diffs, objName, propName);
  }
  
  private static void SetMajorTickMarksTickMarks(DXO16DCD.Axis openXmlElement, DMDCDs.MajorTickMarksTickMarks? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO16DCD.MajorTickMarksTickMarks>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDCDs.MajorTickMarksTickMarksConverter.CreateOpenXmlElement<DXO16DCD.MajorTickMarksTickMarks>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  private static DMDCDs.MinorTickMarksTickMarks? GetMinorTickMarksTickMarks(DXO16DCD.Axis openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO16DCD.MinorTickMarksTickMarks>();
    if (element != null)
      return DMXDCDs.MinorTickMarksTickMarksConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpMinorTickMarksTickMarks(DXO16DCD.Axis openXmlElement, DMDCDs.MinorTickMarksTickMarks? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXDCDs.MinorTickMarksTickMarksConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO16DCD.MinorTickMarksTickMarks>(), value, diffs, objName, propName);
  }
  
  private static void SetMinorTickMarksTickMarks(DXO16DCD.Axis openXmlElement, DMDCDs.MinorTickMarksTickMarks? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO16DCD.MinorTickMarksTickMarks>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDCDs.MinorTickMarksTickMarksConverter.CreateOpenXmlElement<DXO16DCD.MinorTickMarksTickMarks>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  private static DMDCDs.TickLabels? GetTickLabels(DXO16DCD.Axis openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO16DCD.TickLabels>();
    if (element != null)
      return DMXDCDs.TickLabelsConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpTickLabels(DXO16DCD.Axis openXmlElement, DMDCDs.TickLabels? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXDCDs.TickLabelsConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO16DCD.TickLabels>(), value, diffs, objName, propName);
  }
  
  private static void SetTickLabels(DXO16DCD.Axis openXmlElement, DMDCDs.TickLabels? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO16DCD.TickLabels>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDCDs.TickLabelsConverter.CreateOpenXmlElement<DXO16DCD.TickLabels>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  private static DMDCDs.NumberFormat? GetNumberFormat(DXO16DCD.Axis openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO16DCD.NumberFormat>();
    if (element != null)
      return DMXDCDs.NumberFormatConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpNumberFormat(DXO16DCD.Axis openXmlElement, DMDCDs.NumberFormat? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXDCDs.NumberFormatConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO16DCD.NumberFormat>(), value, diffs, objName, propName);
  }
  
  private static void SetNumberFormat(DXO16DCD.Axis openXmlElement, DMDCDs.NumberFormat? value)
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
  
  private static DMDCDs.ShapeProperties? GetShapeProperties(DXO16DCD.Axis openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO16DCD.ShapeProperties>();
    if (element != null)
      return DMXDCDs.ShapePropertiesConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpShapeProperties(DXO16DCD.Axis openXmlElement, DMDCDs.ShapeProperties? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXDCDs.ShapePropertiesConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO16DCD.ShapeProperties>(), value, diffs, objName, propName);
  }
  
  private static void SetShapeProperties(DXO16DCD.Axis openXmlElement, DMDCDs.ShapeProperties? value)
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
  
  private static DMDCDs.TxPrTextBody? GetTxPrTextBody(DXO16DCD.Axis openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO16DCD.TxPrTextBody>();
    if (element != null)
      return DMXDCDs.TxPrTextBodyConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpTxPrTextBody(DXO16DCD.Axis openXmlElement, DMDCDs.TxPrTextBody? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXDCDs.TxPrTextBodyConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO16DCD.TxPrTextBody>(), value, diffs, objName, propName);
  }
  
  private static void SetTxPrTextBody(DXO16DCD.Axis openXmlElement, DMDCDs.TxPrTextBody? value)
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
  
  private static DMDCDs.ExtensionList? GetExtensionList(DXO16DCD.Axis openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO16DCD.ExtensionList>();
    if (element != null)
      return DMXDCDs.ExtensionListConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpExtensionList(DXO16DCD.Axis openXmlElement, DMDCDs.ExtensionList? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXDCDs.ExtensionListConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO16DCD.ExtensionList>(), value, diffs, objName, propName);
  }
  
  private static void SetExtensionList(DXO16DCD.Axis openXmlElement, DMDCDs.ExtensionList? value)
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
  
  public static DocumentModel.Drawings.ChartDrawings.Axis? CreateModelElement(DXO16DCD.Axis? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.ChartDrawings.Axis();
      value.Id = GetId(openXmlElement);
      value.Hidden = GetHidden(openXmlElement);
      value.CategoryAxisScaling = GetCategoryAxisScaling(openXmlElement);
      value.ValueAxisScaling = GetValueAxisScaling(openXmlElement);
      value.AxisTitle = GetAxisTitle(openXmlElement);
      value.AxisUnits = GetAxisUnits(openXmlElement);
      value.MajorGridlinesGridlines = GetMajorGridlinesGridlines(openXmlElement);
      value.MinorGridlinesGridlines = GetMinorGridlinesGridlines(openXmlElement);
      value.MajorTickMarksTickMarks = GetMajorTickMarksTickMarks(openXmlElement);
      value.MinorTickMarksTickMarks = GetMinorTickMarksTickMarks(openXmlElement);
      value.TickLabels = GetTickLabels(openXmlElement);
      value.NumberFormat = GetNumberFormat(openXmlElement);
      value.ShapeProperties = GetShapeProperties(openXmlElement);
      value.TxPrTextBody = GetTxPrTextBody(openXmlElement);
      value.ExtensionList = GetExtensionList(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXO16DCD.Axis? openXmlElement, DMDCDs.Axis? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpId(openXmlElement, value.Id, diffs, objName, propName))
        ok = false;
      if (!CmpHidden(openXmlElement, value.Hidden, diffs, objName, propName))
        ok = false;
      if (!CmpCategoryAxisScaling(openXmlElement, value.CategoryAxisScaling, diffs, objName, propName))
        ok = false;
      if (!CmpValueAxisScaling(openXmlElement, value.ValueAxisScaling, diffs, objName, propName))
        ok = false;
      if (!CmpAxisTitle(openXmlElement, value.AxisTitle, diffs, objName, propName))
        ok = false;
      if (!CmpAxisUnits(openXmlElement, value.AxisUnits, diffs, objName, propName))
        ok = false;
      if (!CmpMajorGridlinesGridlines(openXmlElement, value.MajorGridlinesGridlines, diffs, objName, propName))
        ok = false;
      if (!CmpMinorGridlinesGridlines(openXmlElement, value.MinorGridlinesGridlines, diffs, objName, propName))
        ok = false;
      if (!CmpMajorTickMarksTickMarks(openXmlElement, value.MajorTickMarksTickMarks, diffs, objName, propName))
        ok = false;
      if (!CmpMinorTickMarksTickMarks(openXmlElement, value.MinorTickMarksTickMarks, diffs, objName, propName))
        ok = false;
      if (!CmpTickLabels(openXmlElement, value.TickLabels, diffs, objName, propName))
        ok = false;
      if (!CmpNumberFormat(openXmlElement, value.NumberFormat, diffs, objName, propName))
        ok = false;
      if (!CmpShapeProperties(openXmlElement, value.ShapeProperties, diffs, objName, propName))
        ok = false;
      if (!CmpTxPrTextBody(openXmlElement, value.TxPrTextBody, diffs, objName, propName))
        ok = false;
      if (!CmpExtensionList(openXmlElement, value.ExtensionList, diffs, objName, propName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDCDs.Axis value)
    where OpenXmlElementType: DXO16DCD.Axis, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXO16DCD.Axis openXmlElement, DMDCDs.Axis value)
  {
    SetId(openXmlElement, value?.Id);
    SetHidden(openXmlElement, value?.Hidden);
    SetCategoryAxisScaling(openXmlElement, value?.CategoryAxisScaling);
    SetValueAxisScaling(openXmlElement, value?.ValueAxisScaling);
    SetAxisTitle(openXmlElement, value?.AxisTitle);
    SetAxisUnits(openXmlElement, value?.AxisUnits);
    SetMajorGridlinesGridlines(openXmlElement, value?.MajorGridlinesGridlines);
    SetMinorGridlinesGridlines(openXmlElement, value?.MinorGridlinesGridlines);
    SetMajorTickMarksTickMarks(openXmlElement, value?.MajorTickMarksTickMarks);
    SetMinorTickMarksTickMarks(openXmlElement, value?.MinorTickMarksTickMarks);
    SetTickLabels(openXmlElement, value?.TickLabels);
    SetNumberFormat(openXmlElement, value?.NumberFormat);
    SetShapeProperties(openXmlElement, value?.ShapeProperties);
    SetTxPrTextBody(openXmlElement, value?.TxPrTextBody);
    SetExtensionList(openXmlElement, value?.ExtensionList);
  }
}
