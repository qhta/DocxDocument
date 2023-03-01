namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
/// Value Axis.
/// </summary>
public static class ValueAxisConverter
{
  /// <summary>
  /// Axis ID.
  /// </summary>
  private static UInt32? GetAxisId(DXDrawCharts.ValueAxis openXmlElement)
  {
    return SimpleValueConverter.GetValue(openXmlElement?.GetFirstChild<DXDrawCharts.AxisId>()?.Val);
  }
  
  private static bool CmpAxisId(DXDrawCharts.ValueAxis openXmlElement, UInt32? value, DiffList? diffs, string? objName)
  {
    return SimpleValueConverter.CmpValue(openXmlElement?.GetFirstChild<DXDrawCharts.AxisId>()?.Val, value, diffs, objName, "AxisId");
  }
  
  private static void SetAxisId(DXDrawCharts.ValueAxis openXmlElement, UInt32? value)
  {
    SimpleValueConverter.SetValue<DXDrawCharts.AxisId,System.UInt32>(openXmlElement, value);
  }
  
  /// <summary>
  /// Scaling.
  /// </summary>
  private static DMDrawsCharts.Scaling? GetScaling(DXDrawCharts.ValueAxis openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDrawCharts.Scaling>();
    if (element != null)
      return DMXDrawsCharts.ScalingConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpScaling(DXDrawCharts.ValueAxis openXmlElement, DMDrawsCharts.Scaling? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsCharts.ScalingConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDrawCharts.Scaling>(), value, diffs, objName);
  }
  
  private static void SetScaling(DXDrawCharts.ValueAxis openXmlElement, DMDrawsCharts.Scaling? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDrawCharts.Scaling>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDrawsCharts.ScalingConverter.CreateOpenXmlElement<DXDrawCharts.Scaling>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Delete.
  /// </summary>
  private static Boolean? GetDelete(DXDrawCharts.ValueAxis openXmlElement)
  {
    return openXmlElement.GetFirstChild<DXDrawCharts.Delete>() != null;
  }
  
  private static bool CmpDelete(DXDrawCharts.ValueAxis openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    var val = openXmlElement.GetFirstChild<DXDrawCharts.Delete>() != null;
    if (val == value) return true;
    diffs?.Add(objName, "DXDrawCharts.Delete", val, value);
    return false;
  }
  
  private static void SetDelete(DXDrawCharts.ValueAxis openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DXDrawCharts.Delete>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DXDrawCharts.Delete();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Axis Position.
  /// </summary>
  private static DMDrawsCharts.AxisPositionKind? GetAxisPosition(DXDrawCharts.ValueAxis openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.Charts.AxisPositionValues, DMDrawsCharts.AxisPositionKind>(openXmlElement.GetFirstChild<DXDrawCharts.AxisPosition>()?.Val?.Value);
  }
  
  private static bool CmpAxisPosition(DXDrawCharts.ValueAxis openXmlElement, DMDrawsCharts.AxisPositionKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Drawing.Charts.AxisPositionValues, DMDrawsCharts.AxisPositionKind>(openXmlElement.GetFirstChild<DXDrawCharts.AxisPosition>()?.Val?.Value, value, diffs, objName);
  }
  
  private static void SetAxisPosition(DXDrawCharts.ValueAxis openXmlElement, DMDrawsCharts.AxisPositionKind? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDrawCharts.AxisPosition>();
    if (itemElement != null)
    {
      if (value != null)
        EnumValueConverter.UpdateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Charts.AxisPositionValues, DMDrawsCharts.AxisPositionKind>(itemElement, (DMDrawsCharts.AxisPositionKind)value);
      else
        itemElement.Remove();
    }
    else
    if (value != null)
      openXmlElement.AddChild(EnumValueConverter.CreateOpenXmlElement<DXDrawCharts.AxisPosition, DocumentFormat.OpenXml.Drawing.Charts.AxisPositionValues, DMDrawsCharts.AxisPositionKind>((DMDrawsCharts.AxisPositionKind)value));
  }
  
  /// <summary>
  /// Major Gridlines.
  /// </summary>
  private static DMDrawsCharts.MajorGridlines? GetMajorGridlines(DXDrawCharts.ValueAxis openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDrawCharts.MajorGridlines>();
    if (element != null)
      return DMXDrawsCharts.MajorGridlinesConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpMajorGridlines(DXDrawCharts.ValueAxis openXmlElement, DMDrawsCharts.MajorGridlines? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsCharts.MajorGridlinesConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDrawCharts.MajorGridlines>(), value, diffs, objName);
  }
  
  private static void SetMajorGridlines(DXDrawCharts.ValueAxis openXmlElement, DMDrawsCharts.MajorGridlines? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDrawCharts.MajorGridlines>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDrawsCharts.MajorGridlinesConverter.CreateOpenXmlElement<DXDrawCharts.MajorGridlines>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Minor Gridlines.
  /// </summary>
  private static DMDrawsCharts.MinorGridlines? GetMinorGridlines(DXDrawCharts.ValueAxis openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDrawCharts.MinorGridlines>();
    if (element != null)
      return DMXDrawsCharts.MinorGridlinesConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpMinorGridlines(DXDrawCharts.ValueAxis openXmlElement, DMDrawsCharts.MinorGridlines? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsCharts.MinorGridlinesConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDrawCharts.MinorGridlines>(), value, diffs, objName);
  }
  
  private static void SetMinorGridlines(DXDrawCharts.ValueAxis openXmlElement, DMDrawsCharts.MinorGridlines? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDrawCharts.MinorGridlines>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDrawsCharts.MinorGridlinesConverter.CreateOpenXmlElement<DXDrawCharts.MinorGridlines>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Title.
  /// </summary>
  private static DMDrawsCharts.Title? GetTitle(DXDrawCharts.ValueAxis openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDrawCharts.Title>();
    if (element != null)
      return DMXDrawsCharts.TitleConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpTitle(DXDrawCharts.ValueAxis openXmlElement, DMDrawsCharts.Title? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsCharts.TitleConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDrawCharts.Title>(), value, diffs, objName);
  }
  
  private static void SetTitle(DXDrawCharts.ValueAxis openXmlElement, DMDrawsCharts.Title? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDrawCharts.Title>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDrawsCharts.TitleConverter.CreateOpenXmlElement<DXDrawCharts.Title>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Number Format.
  /// </summary>
  private static DMDrawsCharts.NumberingFormat? GetNumberingFormat(DXDrawCharts.ValueAxis openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDrawCharts.NumberingFormat>();
    if (element != null)
      return DMXDrawsCharts.NumberingFormatConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpNumberingFormat(DXDrawCharts.ValueAxis openXmlElement, DMDrawsCharts.NumberingFormat? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsCharts.NumberingFormatConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDrawCharts.NumberingFormat>(), value, diffs, objName);
  }
  
  private static void SetNumberingFormat(DXDrawCharts.ValueAxis openXmlElement, DMDrawsCharts.NumberingFormat? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDrawCharts.NumberingFormat>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDrawsCharts.NumberingFormatConverter.CreateOpenXmlElement<DXDrawCharts.NumberingFormat>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Major Tick Mark.
  /// </summary>
  private static DMDrawsCharts.TickMarkKind? GetMajorTickMark(DXDrawCharts.ValueAxis openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.Charts.TickMarkValues, DMDrawsCharts.TickMarkKind>(openXmlElement.GetFirstChild<DXDrawCharts.MajorTickMark>()?.Val?.Value);
  }
  
  private static bool CmpMajorTickMark(DXDrawCharts.ValueAxis openXmlElement, DMDrawsCharts.TickMarkKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Drawing.Charts.TickMarkValues, DMDrawsCharts.TickMarkKind>(openXmlElement.GetFirstChild<DXDrawCharts.MajorTickMark>()?.Val?.Value, value, diffs, objName);
  }
  
  private static void SetMajorTickMark(DXDrawCharts.ValueAxis openXmlElement, DMDrawsCharts.TickMarkKind? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDrawCharts.MajorTickMark>();
    if (itemElement != null)
    {
      if (value != null)
        EnumValueConverter.UpdateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Charts.TickMarkValues, DMDrawsCharts.TickMarkKind>(itemElement, (DMDrawsCharts.TickMarkKind)value);
      else
        itemElement.Remove();
    }
    else
    if (value != null)
      openXmlElement.AddChild(EnumValueConverter.CreateOpenXmlElement<DXDrawCharts.MajorTickMark, DocumentFormat.OpenXml.Drawing.Charts.TickMarkValues, DMDrawsCharts.TickMarkKind>((DMDrawsCharts.TickMarkKind)value));
  }
  
  /// <summary>
  /// Minor Tick Mark.
  /// </summary>
  private static DMDrawsCharts.TickMarkKind? GetMinorTickMark(DXDrawCharts.ValueAxis openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.Charts.TickMarkValues, DMDrawsCharts.TickMarkKind>(openXmlElement.GetFirstChild<DXDrawCharts.MinorTickMark>()?.Val?.Value);
  }
  
  private static bool CmpMinorTickMark(DXDrawCharts.ValueAxis openXmlElement, DMDrawsCharts.TickMarkKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Drawing.Charts.TickMarkValues, DMDrawsCharts.TickMarkKind>(openXmlElement.GetFirstChild<DXDrawCharts.MinorTickMark>()?.Val?.Value, value, diffs, objName);
  }
  
  private static void SetMinorTickMark(DXDrawCharts.ValueAxis openXmlElement, DMDrawsCharts.TickMarkKind? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDrawCharts.MinorTickMark>();
    if (itemElement != null)
    {
      if (value != null)
        EnumValueConverter.UpdateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Charts.TickMarkValues, DMDrawsCharts.TickMarkKind>(itemElement, (DMDrawsCharts.TickMarkKind)value);
      else
        itemElement.Remove();
    }
    else
    if (value != null)
      openXmlElement.AddChild(EnumValueConverter.CreateOpenXmlElement<DXDrawCharts.MinorTickMark, DocumentFormat.OpenXml.Drawing.Charts.TickMarkValues, DMDrawsCharts.TickMarkKind>((DMDrawsCharts.TickMarkKind)value));
  }
  
  /// <summary>
  /// Tick Label Position.
  /// </summary>
  private static DMDrawsCharts.TickLabelPositionKind? GetTickLabelPosition(DXDrawCharts.ValueAxis openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.Charts.TickLabelPositionValues, DMDrawsCharts.TickLabelPositionKind>(openXmlElement.GetFirstChild<DXDrawCharts.TickLabelPosition>()?.Val?.Value);
  }
  
  private static bool CmpTickLabelPosition(DXDrawCharts.ValueAxis openXmlElement, DMDrawsCharts.TickLabelPositionKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Drawing.Charts.TickLabelPositionValues, DMDrawsCharts.TickLabelPositionKind>(openXmlElement.GetFirstChild<DXDrawCharts.TickLabelPosition>()?.Val?.Value, value, diffs, objName);
  }
  
  private static void SetTickLabelPosition(DXDrawCharts.ValueAxis openXmlElement, DMDrawsCharts.TickLabelPositionKind? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDrawCharts.TickLabelPosition>();
    if (itemElement != null)
    {
      if (value != null)
        EnumValueConverter.UpdateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Charts.TickLabelPositionValues, DMDrawsCharts.TickLabelPositionKind>(itemElement, (DMDrawsCharts.TickLabelPositionKind)value);
      else
        itemElement.Remove();
    }
    else
    if (value != null)
      openXmlElement.AddChild(EnumValueConverter.CreateOpenXmlElement<DXDrawCharts.TickLabelPosition, DocumentFormat.OpenXml.Drawing.Charts.TickLabelPositionValues, DMDrawsCharts.TickLabelPositionKind>((DMDrawsCharts.TickLabelPositionKind)value));
  }
  
  /// <summary>
  /// ChartShapeProperties.
  /// </summary>
  private static DMDrawsCharts.ChartShapeProperties? GetChartShapeProperties(DXDrawCharts.ValueAxis openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDrawCharts.ChartShapeProperties>();
    if (element != null)
      return DMXDrawsCharts.ChartShapePropertiesConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpChartShapeProperties(DXDrawCharts.ValueAxis openXmlElement, DMDrawsCharts.ChartShapeProperties? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsCharts.ChartShapePropertiesConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDrawCharts.ChartShapeProperties>(), value, diffs, objName);
  }
  
  private static void SetChartShapeProperties(DXDrawCharts.ValueAxis openXmlElement, DMDrawsCharts.ChartShapeProperties? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDrawCharts.ChartShapeProperties>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDrawsCharts.ChartShapePropertiesConverter.CreateOpenXmlElement<DXDrawCharts.ChartShapeProperties>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// TextProperties.
  /// </summary>
  private static DMDrawsCharts.TextProperties? GetTextProperties(DXDrawCharts.ValueAxis openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDrawCharts.TextProperties>();
    if (element != null)
      return DMXDrawsCharts.TextPropertiesConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpTextProperties(DXDrawCharts.ValueAxis openXmlElement, DMDrawsCharts.TextProperties? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsCharts.TextPropertiesConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDrawCharts.TextProperties>(), value, diffs, objName);
  }
  
  private static void SetTextProperties(DXDrawCharts.ValueAxis openXmlElement, DMDrawsCharts.TextProperties? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDrawCharts.TextProperties>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDrawsCharts.TextPropertiesConverter.CreateOpenXmlElement<DXDrawCharts.TextProperties>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Crossing Axis ID.
  /// </summary>
  private static UInt32? GetCrossingAxis(DXDrawCharts.ValueAxis openXmlElement)
  {
    return SimpleValueConverter.GetValue(openXmlElement?.GetFirstChild<DXDrawCharts.CrossingAxis>()?.Val);
  }
  
  private static bool CmpCrossingAxis(DXDrawCharts.ValueAxis openXmlElement, UInt32? value, DiffList? diffs, string? objName)
  {
    return SimpleValueConverter.CmpValue(openXmlElement?.GetFirstChild<DXDrawCharts.CrossingAxis>()?.Val, value, diffs, objName, "CrossingAxis");
  }
  
  private static void SetCrossingAxis(DXDrawCharts.ValueAxis openXmlElement, UInt32? value)
  {
    SimpleValueConverter.SetValue<DXDrawCharts.CrossingAxis,System.UInt32>(openXmlElement, value);
  }
  
  private static DMDrawsCharts.CrossesKind? GetCrosses(DXDrawCharts.ValueAxis openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.Charts.CrossesValues, DMDrawsCharts.CrossesKind>(openXmlElement.GetFirstChild<DXDrawCharts.Crosses>()?.Val?.Value);
  }
  
  private static bool CmpCrosses(DXDrawCharts.ValueAxis openXmlElement, DMDrawsCharts.CrossesKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Drawing.Charts.CrossesValues, DMDrawsCharts.CrossesKind>(openXmlElement.GetFirstChild<DXDrawCharts.Crosses>()?.Val?.Value, value, diffs, objName);
  }
  
  private static void SetCrosses(DXDrawCharts.ValueAxis openXmlElement, DMDrawsCharts.CrossesKind? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDrawCharts.Crosses>();
    if (itemElement != null)
    {
      if (value != null)
        EnumValueConverter.UpdateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Charts.CrossesValues, DMDrawsCharts.CrossesKind>(itemElement, (DMDrawsCharts.CrossesKind)value);
      else
        itemElement.Remove();
    }
    else
    if (value != null)
      openXmlElement.AddChild(EnumValueConverter.CreateOpenXmlElement<DXDrawCharts.Crosses, DocumentFormat.OpenXml.Drawing.Charts.CrossesValues, DMDrawsCharts.CrossesKind>((DMDrawsCharts.CrossesKind)value));
  }
  
  private static Double? GetCrossesAt(DXDrawCharts.ValueAxis openXmlElement)
  {
    return SimpleValueConverter.GetValue(openXmlElement?.GetFirstChild<DXDrawCharts.CrossesAt>()?.Val);
  }
  
  private static bool CmpCrossesAt(DXDrawCharts.ValueAxis openXmlElement, Double? value, DiffList? diffs, string? objName)
  {
    return SimpleValueConverter.CmpValue(openXmlElement?.GetFirstChild<DXDrawCharts.CrossesAt>()?.Val, value, diffs, objName, "CrossesAt");
  }
  
  private static void SetCrossesAt(DXDrawCharts.ValueAxis openXmlElement, Double? value)
  {
    SimpleValueConverter.SetValue<DXDrawCharts.CrossesAt,System.Double>(openXmlElement, value);
  }
  
  private static DMDrawsCharts.CrossBetweenKind? GetCrossBetween(DXDrawCharts.ValueAxis openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.Charts.CrossBetweenValues, DMDrawsCharts.CrossBetweenKind>(openXmlElement.GetFirstChild<DXDrawCharts.CrossBetween>()?.Val?.Value);
  }
  
  private static bool CmpCrossBetween(DXDrawCharts.ValueAxis openXmlElement, DMDrawsCharts.CrossBetweenKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Drawing.Charts.CrossBetweenValues, DMDrawsCharts.CrossBetweenKind>(openXmlElement.GetFirstChild<DXDrawCharts.CrossBetween>()?.Val?.Value, value, diffs, objName);
  }
  
  private static void SetCrossBetween(DXDrawCharts.ValueAxis openXmlElement, DMDrawsCharts.CrossBetweenKind? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDrawCharts.CrossBetween>();
    if (itemElement != null)
    {
      if (value != null)
        EnumValueConverter.UpdateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Charts.CrossBetweenValues, DMDrawsCharts.CrossBetweenKind>(itemElement, (DMDrawsCharts.CrossBetweenKind)value);
      else
        itemElement.Remove();
    }
    else
    if (value != null)
      openXmlElement.AddChild(EnumValueConverter.CreateOpenXmlElement<DXDrawCharts.CrossBetween, DocumentFormat.OpenXml.Drawing.Charts.CrossBetweenValues, DMDrawsCharts.CrossBetweenKind>((DMDrawsCharts.CrossBetweenKind)value));
  }
  
  private static Double? GetMajorUnit(DXDrawCharts.ValueAxis openXmlElement)
  {
    return SimpleValueConverter.GetValue(openXmlElement?.GetFirstChild<DXDrawCharts.MajorUnit>()?.Val);
  }
  
  private static bool CmpMajorUnit(DXDrawCharts.ValueAxis openXmlElement, Double? value, DiffList? diffs, string? objName)
  {
    return SimpleValueConverter.CmpValue(openXmlElement?.GetFirstChild<DXDrawCharts.MajorUnit>()?.Val, value, diffs, objName, "MajorUnit");
  }
  
  private static void SetMajorUnit(DXDrawCharts.ValueAxis openXmlElement, Double? value)
  {
    SimpleValueConverter.SetValue<DXDrawCharts.MajorUnit,System.Double>(openXmlElement, value);
  }
  
  private static Double? GetMinorUnit(DXDrawCharts.ValueAxis openXmlElement)
  {
    return SimpleValueConverter.GetValue(openXmlElement?.GetFirstChild<DXDrawCharts.MinorUnit>()?.Val);
  }
  
  private static bool CmpMinorUnit(DXDrawCharts.ValueAxis openXmlElement, Double? value, DiffList? diffs, string? objName)
  {
    return SimpleValueConverter.CmpValue(openXmlElement?.GetFirstChild<DXDrawCharts.MinorUnit>()?.Val, value, diffs, objName, "MinorUnit");
  }
  
  private static void SetMinorUnit(DXDrawCharts.ValueAxis openXmlElement, Double? value)
  {
    SimpleValueConverter.SetValue<DXDrawCharts.MinorUnit,System.Double>(openXmlElement, value);
  }
  
  private static DMDrawsCharts.DisplayUnits? GetDisplayUnits(DXDrawCharts.ValueAxis openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDrawCharts.DisplayUnits>();
    if (element != null)
      return DMXDrawsCharts.DisplayUnitsConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpDisplayUnits(DXDrawCharts.ValueAxis openXmlElement, DMDrawsCharts.DisplayUnits? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsCharts.DisplayUnitsConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDrawCharts.DisplayUnits>(), value, diffs, objName);
  }
  
  private static void SetDisplayUnits(DXDrawCharts.ValueAxis openXmlElement, DMDrawsCharts.DisplayUnits? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDrawCharts.DisplayUnits>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDrawsCharts.DisplayUnitsConverter.CreateOpenXmlElement<DXDrawCharts.DisplayUnits>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMDrawsCharts.ValAxExtensionList? GetValAxExtensionList(DXDrawCharts.ValueAxis openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDrawCharts.ValAxExtensionList>();
    if (element != null)
      return DMXDrawsCharts.ValAxExtensionListConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpValAxExtensionList(DXDrawCharts.ValueAxis openXmlElement, DMDrawsCharts.ValAxExtensionList? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsCharts.ValAxExtensionListConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDrawCharts.ValAxExtensionList>(), value, diffs, objName);
  }
  
  private static void SetValAxExtensionList(DXDrawCharts.ValueAxis openXmlElement, DMDrawsCharts.ValAxExtensionList? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDrawCharts.ValAxExtensionList>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDrawsCharts.ValAxExtensionListConverter.CreateOpenXmlElement<DXDrawCharts.ValAxExtensionList>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DocumentModel.Drawings.Charts.ValueAxis? CreateModelElement(DXDrawCharts.ValueAxis? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Charts.ValueAxis();
      value.AxisId = GetAxisId(openXmlElement);
      value.Scaling = GetScaling(openXmlElement);
      value.Delete = GetDelete(openXmlElement);
      value.AxisPosition = GetAxisPosition(openXmlElement);
      value.MajorGridlines = GetMajorGridlines(openXmlElement);
      value.MinorGridlines = GetMinorGridlines(openXmlElement);
      value.Title = GetTitle(openXmlElement);
      value.NumberingFormat = GetNumberingFormat(openXmlElement);
      value.MajorTickMark = GetMajorTickMark(openXmlElement);
      value.MinorTickMark = GetMinorTickMark(openXmlElement);
      value.TickLabelPosition = GetTickLabelPosition(openXmlElement);
      value.ChartShapeProperties = GetChartShapeProperties(openXmlElement);
      value.TextProperties = GetTextProperties(openXmlElement);
      value.CrossingAxis = GetCrossingAxis(openXmlElement);
      value.Crosses = GetCrosses(openXmlElement);
      value.CrossesAt = GetCrossesAt(openXmlElement);
      value.CrossBetween = GetCrossBetween(openXmlElement);
      value.MajorUnit = GetMajorUnit(openXmlElement);
      value.MinorUnit = GetMinorUnit(openXmlElement);
      value.DisplayUnits = GetDisplayUnits(openXmlElement);
      value.ValAxExtensionList = GetValAxExtensionList(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXDrawCharts.ValueAxis? openXmlElement, DMDrawsCharts.ValueAxis? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpAxisId(openXmlElement, value.AxisId, diffs, objName))
        ok = false;
      if (!CmpScaling(openXmlElement, value.Scaling, diffs, objName))
        ok = false;
      if (!CmpDelete(openXmlElement, value.Delete, diffs, objName))
        ok = false;
      if (!CmpAxisPosition(openXmlElement, value.AxisPosition, diffs, objName))
        ok = false;
      if (!CmpMajorGridlines(openXmlElement, value.MajorGridlines, diffs, objName))
        ok = false;
      if (!CmpMinorGridlines(openXmlElement, value.MinorGridlines, diffs, objName))
        ok = false;
      if (!CmpTitle(openXmlElement, value.Title, diffs, objName))
        ok = false;
      if (!CmpNumberingFormat(openXmlElement, value.NumberingFormat, diffs, objName))
        ok = false;
      if (!CmpMajorTickMark(openXmlElement, value.MajorTickMark, diffs, objName))
        ok = false;
      if (!CmpMinorTickMark(openXmlElement, value.MinorTickMark, diffs, objName))
        ok = false;
      if (!CmpTickLabelPosition(openXmlElement, value.TickLabelPosition, diffs, objName))
        ok = false;
      if (!CmpChartShapeProperties(openXmlElement, value.ChartShapeProperties, diffs, objName))
        ok = false;
      if (!CmpTextProperties(openXmlElement, value.TextProperties, diffs, objName))
        ok = false;
      if (!CmpCrossingAxis(openXmlElement, value.CrossingAxis, diffs, objName))
        ok = false;
      if (!CmpCrosses(openXmlElement, value.Crosses, diffs, objName))
        ok = false;
      if (!CmpCrossesAt(openXmlElement, value.CrossesAt, diffs, objName))
        ok = false;
      if (!CmpCrossBetween(openXmlElement, value.CrossBetween, diffs, objName))
        ok = false;
      if (!CmpMajorUnit(openXmlElement, value.MajorUnit, diffs, objName))
        ok = false;
      if (!CmpMinorUnit(openXmlElement, value.MinorUnit, diffs, objName))
        ok = false;
      if (!CmpDisplayUnits(openXmlElement, value.DisplayUnits, diffs, objName))
        ok = false;
      if (!CmpValAxExtensionList(openXmlElement, value.ValAxExtensionList, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDrawsCharts.ValueAxis value)
    where OpenXmlElementType: DXDrawCharts.ValueAxis, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXDrawCharts.ValueAxis openXmlElement, DMDrawsCharts.ValueAxis value)
  {
    SetAxisId(openXmlElement, value?.AxisId);
    SetScaling(openXmlElement, value?.Scaling);
    SetDelete(openXmlElement, value?.Delete);
    SetAxisPosition(openXmlElement, value?.AxisPosition);
    SetMajorGridlines(openXmlElement, value?.MajorGridlines);
    SetMinorGridlines(openXmlElement, value?.MinorGridlines);
    SetTitle(openXmlElement, value?.Title);
    SetNumberingFormat(openXmlElement, value?.NumberingFormat);
    SetMajorTickMark(openXmlElement, value?.MajorTickMark);
    SetMinorTickMark(openXmlElement, value?.MinorTickMark);
    SetTickLabelPosition(openXmlElement, value?.TickLabelPosition);
    SetChartShapeProperties(openXmlElement, value?.ChartShapeProperties);
    SetTextProperties(openXmlElement, value?.TextProperties);
    SetCrossingAxis(openXmlElement, value?.CrossingAxis);
    SetCrosses(openXmlElement, value?.Crosses);
    SetCrossesAt(openXmlElement, value?.CrossesAt);
    SetCrossBetween(openXmlElement, value?.CrossBetween);
    SetMajorUnit(openXmlElement, value?.MajorUnit);
    SetMinorUnit(openXmlElement, value?.MinorUnit);
    SetDisplayUnits(openXmlElement, value?.DisplayUnits);
    SetValAxExtensionList(openXmlElement, value?.ValAxExtensionList);
  }
}
