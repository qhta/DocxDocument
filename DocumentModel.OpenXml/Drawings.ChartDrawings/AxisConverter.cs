namespace DocumentModel.OpenXml.Drawings.ChartDrawings;

/// <summary>
/// Defines the Axis Class.
/// </summary>
public static class AxisConverter
{
  /// <summary>
  /// id, this property is only available in Office 2016 and later.
  /// </summary>
  private static UInt32? GetId(DXO2016DrawChartDraw.Axis openXmlElement)
  {
    return openXmlElement?.Id?.Value;
  }
  
  private static bool CmpId(DXO2016DrawChartDraw.Axis openXmlElement, UInt32? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.Id?.Value == value) return true;
    diffs?.Add(objName, "Id", openXmlElement?.Id?.Value, value);
    return false;
  }
  
  private static void SetId(DXO2016DrawChartDraw.Axis openXmlElement, UInt32? value)
  {
    openXmlElement.Id = value;
  }
  
  /// <summary>
  /// hidden, this property is only available in Office 2016 and later.
  /// </summary>
  private static Boolean? GetHidden(DXO2016DrawChartDraw.Axis openXmlElement)
  {
    return openXmlElement?.Hidden?.Value;
  }
  
  private static bool CmpHidden(DXO2016DrawChartDraw.Axis openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.Hidden?.Value == value) return true;
    diffs?.Add(objName, "Hidden", openXmlElement?.Hidden?.Value, value);
    return false;
  }
  
  private static void SetHidden(DXO2016DrawChartDraw.Axis openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.Hidden = new BooleanValue { Value = (Boolean)value };
    else
      openXmlElement.Hidden = null;
  }
  
  private static DMDrawsChartDraws.CategoryAxisScaling? GetCategoryAxisScaling(DXO2016DrawChartDraw.Axis openXmlElement)
  {
    return DMXDrawsChartDraws.CategoryAxisScalingConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXO2016DrawChartDraw.CategoryAxisScaling>());
  }
  
  private static bool CmpCategoryAxisScaling(DXO2016DrawChartDraw.Axis openXmlElement, DMDrawsChartDraws.CategoryAxisScaling? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsChartDraws.CategoryAxisScalingConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO2016DrawChartDraw.CategoryAxisScaling>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetCategoryAxisScaling(DXO2016DrawChartDraw.Axis openXmlElement, DMDrawsChartDraws.CategoryAxisScaling? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO2016DrawChartDraw.CategoryAxisScaling>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDrawsChartDraws.CategoryAxisScalingConverter.CreateOpenXmlElement<DXO2016DrawChartDraw.CategoryAxisScaling>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMDrawsChartDraws.ValueAxisScaling? GetValueAxisScaling(DXO2016DrawChartDraw.Axis openXmlElement)
  {
    return DMXDrawsChartDraws.ValueAxisScalingConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXO2016DrawChartDraw.ValueAxisScaling>());
  }
  
  private static bool CmpValueAxisScaling(DXO2016DrawChartDraw.Axis openXmlElement, DMDrawsChartDraws.ValueAxisScaling? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsChartDraws.ValueAxisScalingConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO2016DrawChartDraw.ValueAxisScaling>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetValueAxisScaling(DXO2016DrawChartDraw.Axis openXmlElement, DMDrawsChartDraws.ValueAxisScaling? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO2016DrawChartDraw.ValueAxisScaling>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDrawsChartDraws.ValueAxisScalingConverter.CreateOpenXmlElement<DXO2016DrawChartDraw.ValueAxisScaling>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMDrawsChartDraws.AxisTitle? GetAxisTitle(DXO2016DrawChartDraw.Axis openXmlElement)
  {
    return DMXDrawsChartDraws.AxisTitleConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXO2016DrawChartDraw.AxisTitle>());
  }
  
  private static bool CmpAxisTitle(DXO2016DrawChartDraw.Axis openXmlElement, DMDrawsChartDraws.AxisTitle? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsChartDraws.AxisTitleConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO2016DrawChartDraw.AxisTitle>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetAxisTitle(DXO2016DrawChartDraw.Axis openXmlElement, DMDrawsChartDraws.AxisTitle? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO2016DrawChartDraw.AxisTitle>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDrawsChartDraws.AxisTitleConverter.CreateOpenXmlElement<DXO2016DrawChartDraw.AxisTitle>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMDrawsChartDraws.AxisUnits? GetAxisUnits(DXO2016DrawChartDraw.Axis openXmlElement)
  {
    return DMXDrawsChartDraws.AxisUnitsConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXO2016DrawChartDraw.AxisUnits>());
  }
  
  private static bool CmpAxisUnits(DXO2016DrawChartDraw.Axis openXmlElement, DMDrawsChartDraws.AxisUnits? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsChartDraws.AxisUnitsConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO2016DrawChartDraw.AxisUnits>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetAxisUnits(DXO2016DrawChartDraw.Axis openXmlElement, DMDrawsChartDraws.AxisUnits? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO2016DrawChartDraw.AxisUnits>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDrawsChartDraws.AxisUnitsConverter.CreateOpenXmlElement<DXO2016DrawChartDraw.AxisUnits>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMDrawsChartDraws.MajorGridlinesGridlines? GetMajorGridlinesGridlines(DXO2016DrawChartDraw.Axis openXmlElement)
  {
    return DMXDrawsChartDraws.MajorGridlinesGridlinesConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXO2016DrawChartDraw.MajorGridlinesGridlines>());
  }
  
  private static bool CmpMajorGridlinesGridlines(DXO2016DrawChartDraw.Axis openXmlElement, DMDrawsChartDraws.MajorGridlinesGridlines? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsChartDraws.MajorGridlinesGridlinesConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO2016DrawChartDraw.MajorGridlinesGridlines>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetMajorGridlinesGridlines(DXO2016DrawChartDraw.Axis openXmlElement, DMDrawsChartDraws.MajorGridlinesGridlines? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO2016DrawChartDraw.MajorGridlinesGridlines>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDrawsChartDraws.MajorGridlinesGridlinesConverter.CreateOpenXmlElement<DXO2016DrawChartDraw.MajorGridlinesGridlines>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMDrawsChartDraws.MinorGridlinesGridlines? GetMinorGridlinesGridlines(DXO2016DrawChartDraw.Axis openXmlElement)
  {
    return DMXDrawsChartDraws.MinorGridlinesGridlinesConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXO2016DrawChartDraw.MinorGridlinesGridlines>());
  }
  
  private static bool CmpMinorGridlinesGridlines(DXO2016DrawChartDraw.Axis openXmlElement, DMDrawsChartDraws.MinorGridlinesGridlines? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsChartDraws.MinorGridlinesGridlinesConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO2016DrawChartDraw.MinorGridlinesGridlines>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetMinorGridlinesGridlines(DXO2016DrawChartDraw.Axis openXmlElement, DMDrawsChartDraws.MinorGridlinesGridlines? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO2016DrawChartDraw.MinorGridlinesGridlines>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDrawsChartDraws.MinorGridlinesGridlinesConverter.CreateOpenXmlElement<DXO2016DrawChartDraw.MinorGridlinesGridlines>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMDrawsChartDraws.MajorTickMarksTickMarks? GetMajorTickMarksTickMarks(DXO2016DrawChartDraw.Axis openXmlElement)
  {
    return DMXDrawsChartDraws.MajorTickMarksTickMarksConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXO2016DrawChartDraw.MajorTickMarksTickMarks>());
  }
  
  private static bool CmpMajorTickMarksTickMarks(DXO2016DrawChartDraw.Axis openXmlElement, DMDrawsChartDraws.MajorTickMarksTickMarks? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsChartDraws.MajorTickMarksTickMarksConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO2016DrawChartDraw.MajorTickMarksTickMarks>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetMajorTickMarksTickMarks(DXO2016DrawChartDraw.Axis openXmlElement, DMDrawsChartDraws.MajorTickMarksTickMarks? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO2016DrawChartDraw.MajorTickMarksTickMarks>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDrawsChartDraws.MajorTickMarksTickMarksConverter.CreateOpenXmlElement<DXO2016DrawChartDraw.MajorTickMarksTickMarks>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMDrawsChartDraws.MinorTickMarksTickMarks? GetMinorTickMarksTickMarks(DXO2016DrawChartDraw.Axis openXmlElement)
  {
    return DMXDrawsChartDraws.MinorTickMarksTickMarksConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXO2016DrawChartDraw.MinorTickMarksTickMarks>());
  }
  
  private static bool CmpMinorTickMarksTickMarks(DXO2016DrawChartDraw.Axis openXmlElement, DMDrawsChartDraws.MinorTickMarksTickMarks? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsChartDraws.MinorTickMarksTickMarksConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO2016DrawChartDraw.MinorTickMarksTickMarks>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetMinorTickMarksTickMarks(DXO2016DrawChartDraw.Axis openXmlElement, DMDrawsChartDraws.MinorTickMarksTickMarks? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO2016DrawChartDraw.MinorTickMarksTickMarks>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDrawsChartDraws.MinorTickMarksTickMarksConverter.CreateOpenXmlElement<DXO2016DrawChartDraw.MinorTickMarksTickMarks>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMDrawsChartDraws.TickLabels? GetTickLabels(DXO2016DrawChartDraw.Axis openXmlElement)
  {
    return DMXDrawsChartDraws.TickLabelsConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXO2016DrawChartDraw.TickLabels>());
  }
  
  private static bool CmpTickLabels(DXO2016DrawChartDraw.Axis openXmlElement, DMDrawsChartDraws.TickLabels? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsChartDraws.TickLabelsConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO2016DrawChartDraw.TickLabels>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetTickLabels(DXO2016DrawChartDraw.Axis openXmlElement, DMDrawsChartDraws.TickLabels? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO2016DrawChartDraw.TickLabels>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDrawsChartDraws.TickLabelsConverter.CreateOpenXmlElement<DXO2016DrawChartDraw.TickLabels>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMDrawsChartDraws.NumberFormat? GetNumberFormat(DXO2016DrawChartDraw.Axis openXmlElement)
  {
    return DMXDrawsChartDraws.NumberFormatConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXO2016DrawChartDraw.NumberFormat>());
  }
  
  private static bool CmpNumberFormat(DXO2016DrawChartDraw.Axis openXmlElement, DMDrawsChartDraws.NumberFormat? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsChartDraws.NumberFormatConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO2016DrawChartDraw.NumberFormat>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetNumberFormat(DXO2016DrawChartDraw.Axis openXmlElement, DMDrawsChartDraws.NumberFormat? value)
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
  
  private static DMDrawsChartDraws.ShapeProperties? GetShapeProperties(DXO2016DrawChartDraw.Axis openXmlElement)
  {
    return DMXDrawsChartDraws.ShapePropertiesConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXO2016DrawChartDraw.ShapeProperties>());
  }
  
  private static bool CmpShapeProperties(DXO2016DrawChartDraw.Axis openXmlElement, DMDrawsChartDraws.ShapeProperties? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsChartDraws.ShapePropertiesConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO2016DrawChartDraw.ShapeProperties>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetShapeProperties(DXO2016DrawChartDraw.Axis openXmlElement, DMDrawsChartDraws.ShapeProperties? value)
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
  
  private static DMDrawsChartDraws.TxPrTextBody? GetTxPrTextBody(DXO2016DrawChartDraw.Axis openXmlElement)
  {
    return DMXDrawsChartDraws.TxPrTextBodyConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXO2016DrawChartDraw.TxPrTextBody>());
  }
  
  private static bool CmpTxPrTextBody(DXO2016DrawChartDraw.Axis openXmlElement, DMDrawsChartDraws.TxPrTextBody? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsChartDraws.TxPrTextBodyConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO2016DrawChartDraw.TxPrTextBody>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetTxPrTextBody(DXO2016DrawChartDraw.Axis openXmlElement, DMDrawsChartDraws.TxPrTextBody? value)
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
  
  private static DMDrawsChartDraws.ExtensionList? GetExtensionList(DXO2016DrawChartDraw.Axis openXmlElement)
  {
    return DMXDrawsChartDraws.ExtensionListConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXO2016DrawChartDraw.ExtensionList>());
  }
  
  private static bool CmpExtensionList(DXO2016DrawChartDraw.Axis openXmlElement, DMDrawsChartDraws.ExtensionList? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsChartDraws.ExtensionListConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO2016DrawChartDraw.ExtensionList>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetExtensionList(DXO2016DrawChartDraw.Axis openXmlElement, DMDrawsChartDraws.ExtensionList? value)
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
  
  public static DMDrawsChartDraws.Axis? CreateModelElement(DXO2016DrawChartDraw.Axis? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDrawsChartDraws.Axis();
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
  
  public static bool CompareModelElement(DXO2016DrawChartDraw.Axis? openXmlElement, DMDrawsChartDraws.Axis? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpId(openXmlElement, value.Id, diffs, objName))
        ok = false;
      if (!CmpHidden(openXmlElement, value.Hidden, diffs, objName))
        ok = false;
      if (!CmpCategoryAxisScaling(openXmlElement, value.CategoryAxisScaling, diffs, objName))
        ok = false;
      if (!CmpValueAxisScaling(openXmlElement, value.ValueAxisScaling, diffs, objName))
        ok = false;
      if (!CmpAxisTitle(openXmlElement, value.AxisTitle, diffs, objName))
        ok = false;
      if (!CmpAxisUnits(openXmlElement, value.AxisUnits, diffs, objName))
        ok = false;
      if (!CmpMajorGridlinesGridlines(openXmlElement, value.MajorGridlinesGridlines, diffs, objName))
        ok = false;
      if (!CmpMinorGridlinesGridlines(openXmlElement, value.MinorGridlinesGridlines, diffs, objName))
        ok = false;
      if (!CmpMajorTickMarksTickMarks(openXmlElement, value.MajorTickMarksTickMarks, diffs, objName))
        ok = false;
      if (!CmpMinorTickMarksTickMarks(openXmlElement, value.MinorTickMarksTickMarks, diffs, objName))
        ok = false;
      if (!CmpTickLabels(openXmlElement, value.TickLabels, diffs, objName))
        ok = false;
      if (!CmpNumberFormat(openXmlElement, value.NumberFormat, diffs, objName))
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
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDrawsChartDraws.Axis? value)
    where OpenXmlElementType: DXO2016DrawChartDraw.Axis, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
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
      return openXmlElement;
    }
    return default;
  }
}
