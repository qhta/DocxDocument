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
    return openXmlElement.Id?.Value;
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
  
  private static void SetHidden(DXO2016DrawChartDraw.Axis openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.Hidden = new BooleanValue { Value = (Boolean)value };
    else
      openXmlElement.Hidden = null;
  }
  
  private static DMDrawsChartDraws.CategoryAxisScaling? GetCategoryAxisScaling(DXO2016DrawChartDraw.Axis openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXO2016DrawChartDraw.CategoryAxisScaling>();
    if (itemElement != null)
      return DMXDrawsChartDraws.CategoryAxisScalingConverter.CreateModelElement(itemElement);
    return null;
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
    var itemElement = openXmlElement?.GetFirstChild<DXO2016DrawChartDraw.ValueAxisScaling>();
    if (itemElement != null)
      return DMXDrawsChartDraws.ValueAxisScalingConverter.CreateModelElement(itemElement);
    return null;
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
    var itemElement = openXmlElement?.GetFirstChild<DXO2016DrawChartDraw.AxisTitle>();
    if (itemElement != null)
      return DMXDrawsChartDraws.AxisTitleConverter.CreateModelElement(itemElement);
    return null;
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
    var itemElement = openXmlElement?.GetFirstChild<DXO2016DrawChartDraw.AxisUnits>();
    if (itemElement != null)
      return DMXDrawsChartDraws.AxisUnitsConverter.CreateModelElement(itemElement);
    return null;
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
    var itemElement = openXmlElement?.GetFirstChild<DXO2016DrawChartDraw.MajorGridlinesGridlines>();
    if (itemElement != null)
      return DMXDrawsChartDraws.MajorGridlinesGridlinesConverter.CreateModelElement(itemElement);
    return null;
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
    var itemElement = openXmlElement?.GetFirstChild<DXO2016DrawChartDraw.MinorGridlinesGridlines>();
    if (itemElement != null)
      return DMXDrawsChartDraws.MinorGridlinesGridlinesConverter.CreateModelElement(itemElement);
    return null;
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
    var itemElement = openXmlElement?.GetFirstChild<DXO2016DrawChartDraw.MajorTickMarksTickMarks>();
    if (itemElement != null)
      return DMXDrawsChartDraws.MajorTickMarksTickMarksConverter.CreateModelElement(itemElement);
    return null;
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
    var itemElement = openXmlElement?.GetFirstChild<DXO2016DrawChartDraw.MinorTickMarksTickMarks>();
    if (itemElement != null)
      return DMXDrawsChartDraws.MinorTickMarksTickMarksConverter.CreateModelElement(itemElement);
    return null;
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
    var itemElement = openXmlElement?.GetFirstChild<DXO2016DrawChartDraw.TickLabels>();
    if (itemElement != null)
      return DMXDrawsChartDraws.TickLabelsConverter.CreateModelElement(itemElement);
    return null;
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
    var itemElement = openXmlElement?.GetFirstChild<DXO2016DrawChartDraw.NumberFormat>();
    if (itemElement != null)
      return DMXDrawsChartDraws.NumberFormatConverter.CreateModelElement(itemElement);
    return null;
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
    var itemElement = openXmlElement?.GetFirstChild<DXO2016DrawChartDraw.ShapeProperties>();
    if (itemElement != null)
      return DMXDrawsChartDraws.ShapePropertiesConverter.CreateModelElement(itemElement);
    return null;
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
    var itemElement = openXmlElement?.GetFirstChild<DXO2016DrawChartDraw.TxPrTextBody>();
    if (itemElement != null)
      return DMXDrawsChartDraws.TxPrTextBodyConverter.CreateModelElement(itemElement);
    return null;
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
    var itemElement = openXmlElement?.GetFirstChild<DXO2016DrawChartDraw.ExtensionList>();
    if (itemElement != null)
      return DMXDrawsChartDraws.ExtensionListConverter.CreateModelElement(itemElement);
    return null;
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
