namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
/// Date Axis converter from/to OpenXml.
///</summary>
public static class DateAxisConverter
{
  /// <summary>
  /// Axis ID.
  /// </summary>
  private static UInt32? GetAxisId(DXDrawCharts.DateAxis openXmlElement)
  {
    return SimpleValueConverter.GetValue(openXmlElement?.GetFirstChild<DXDrawCharts.AxisId>()?.Val);
  }
  
  private static bool CmpAxisId(DXDrawCharts.DateAxis openXmlElement, UInt32? value, DiffList? diffs, string? objName)
  {
    return SimpleValueConverter.CmpValue(openXmlElement?.GetFirstChild<DXDrawCharts.AxisId>()?.Val, value, diffs, objName, "AxisId");
  }
  
  private static void SetAxisId(DXDrawCharts.DateAxis openXmlElement, UInt32? value)
  {
    SimpleValueConverter.SetValue<DXDrawCharts.AxisId,System.UInt32>(openXmlElement, value);
  }
  
  /// <summary>
  /// Scaling.
  /// </summary>
  private static DMDrawsCharts.Scaling? GetScaling(DXDrawCharts.DateAxis openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDrawCharts.Scaling>();
    if (element != null)
      return DMXDrawsCharts.ScalingConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpScaling(DXDrawCharts.DateAxis openXmlElement, DMDrawsCharts.Scaling? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsCharts.ScalingConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDrawCharts.Scaling>(), value, diffs, objName);
  }
  
  private static void SetScaling(DXDrawCharts.DateAxis openXmlElement, DMDrawsCharts.Scaling? value)
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
  private static Boolean? GetDelete(DXDrawCharts.DateAxis openXmlElement)
  {
    return openXmlElement.GetFirstChild<DXDrawCharts.Delete>() != null;
  }
  
  private static bool CmpDelete(DXDrawCharts.DateAxis openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    var val = openXmlElement.GetFirstChild<DXDrawCharts.Delete>() != null;
    if (val == value) return true;
    diffs?.Add(objName, "DXDrawCharts.Delete", val, value);
    return false;
  }
  
  private static void SetDelete(DXDrawCharts.DateAxis openXmlElement, Boolean? value)
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
  private static DMDrawsCharts.AxisPositionKind? GetAxisPosition(DXDrawCharts.DateAxis openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.Charts.AxisPositionValues, DMDrawsCharts.AxisPositionKind>(openXmlElement.GetFirstChild<DXDrawCharts.AxisPosition>()?.Val?.Value);
  }
  
  private static bool CmpAxisPosition(DXDrawCharts.DateAxis openXmlElement, DMDrawsCharts.AxisPositionKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Drawing.Charts.AxisPositionValues, DMDrawsCharts.AxisPositionKind>(openXmlElement.GetFirstChild<DXDrawCharts.AxisPosition>()?.Val?.Value, value, diffs, objName);
  }
  
  private static void SetAxisPosition(DXDrawCharts.DateAxis openXmlElement, DMDrawsCharts.AxisPositionKind? value)
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
  private static DMDrawsCharts.MajorGridlines? GetMajorGridlines(DXDrawCharts.DateAxis openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDrawCharts.MajorGridlines>();
    if (element != null)
      return DMXDrawsCharts.MajorGridlinesConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpMajorGridlines(DXDrawCharts.DateAxis openXmlElement, DMDrawsCharts.MajorGridlines? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsCharts.MajorGridlinesConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDrawCharts.MajorGridlines>(), value, diffs, objName);
  }
  
  private static void SetMajorGridlines(DXDrawCharts.DateAxis openXmlElement, DMDrawsCharts.MajorGridlines? value)
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
  private static DMDrawsCharts.MinorGridlines? GetMinorGridlines(DXDrawCharts.DateAxis openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDrawCharts.MinorGridlines>();
    if (element != null)
      return DMXDrawsCharts.MinorGridlinesConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpMinorGridlines(DXDrawCharts.DateAxis openXmlElement, DMDrawsCharts.MinorGridlines? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsCharts.MinorGridlinesConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDrawCharts.MinorGridlines>(), value, diffs, objName);
  }
  
  private static void SetMinorGridlines(DXDrawCharts.DateAxis openXmlElement, DMDrawsCharts.MinorGridlines? value)
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
  private static DMDrawsCharts.Title? GetTitle(DXDrawCharts.DateAxis openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDrawCharts.Title>();
    if (element != null)
      return DMXDrawsCharts.TitleConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpTitle(DXDrawCharts.DateAxis openXmlElement, DMDrawsCharts.Title? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsCharts.TitleConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDrawCharts.Title>(), value, diffs, objName);
  }
  
  private static void SetTitle(DXDrawCharts.DateAxis openXmlElement, DMDrawsCharts.Title? value)
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
  private static DMDrawsCharts.NumberingFormat? GetNumberingFormat(DXDrawCharts.DateAxis openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDrawCharts.NumberingFormat>();
    if (element != null)
      return DMXDrawsCharts.NumberingFormatConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpNumberingFormat(DXDrawCharts.DateAxis openXmlElement, DMDrawsCharts.NumberingFormat? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsCharts.NumberingFormatConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDrawCharts.NumberingFormat>(), value, diffs, objName);
  }
  
  private static void SetNumberingFormat(DXDrawCharts.DateAxis openXmlElement, DMDrawsCharts.NumberingFormat? value)
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
  private static DMDrawsCharts.TickMarkKind? GetMajorTickMark(DXDrawCharts.DateAxis openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.Charts.TickMarkValues, DMDrawsCharts.TickMarkKind>(openXmlElement.GetFirstChild<DXDrawCharts.MajorTickMark>()?.Val?.Value);
  }
  
  private static bool CmpMajorTickMark(DXDrawCharts.DateAxis openXmlElement, DMDrawsCharts.TickMarkKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Drawing.Charts.TickMarkValues, DMDrawsCharts.TickMarkKind>(openXmlElement.GetFirstChild<DXDrawCharts.MajorTickMark>()?.Val?.Value, value, diffs, objName);
  }
  
  private static void SetMajorTickMark(DXDrawCharts.DateAxis openXmlElement, DMDrawsCharts.TickMarkKind? value)
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
  private static DMDrawsCharts.TickMarkKind? GetMinorTickMark(DXDrawCharts.DateAxis openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.Charts.TickMarkValues, DMDrawsCharts.TickMarkKind>(openXmlElement.GetFirstChild<DXDrawCharts.MinorTickMark>()?.Val?.Value);
  }
  
  private static bool CmpMinorTickMark(DXDrawCharts.DateAxis openXmlElement, DMDrawsCharts.TickMarkKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Drawing.Charts.TickMarkValues, DMDrawsCharts.TickMarkKind>(openXmlElement.GetFirstChild<DXDrawCharts.MinorTickMark>()?.Val?.Value, value, diffs, objName);
  }
  
  private static void SetMinorTickMark(DXDrawCharts.DateAxis openXmlElement, DMDrawsCharts.TickMarkKind? value)
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
  private static DMDrawsCharts.TickLabelPositionKind? GetTickLabelPosition(DXDrawCharts.DateAxis openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.Charts.TickLabelPositionValues, DMDrawsCharts.TickLabelPositionKind>(openXmlElement.GetFirstChild<DXDrawCharts.TickLabelPosition>()?.Val?.Value);
  }
  
  private static bool CmpTickLabelPosition(DXDrawCharts.DateAxis openXmlElement, DMDrawsCharts.TickLabelPositionKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Drawing.Charts.TickLabelPositionValues, DMDrawsCharts.TickLabelPositionKind>(openXmlElement.GetFirstChild<DXDrawCharts.TickLabelPosition>()?.Val?.Value, value, diffs, objName);
  }
  
  private static void SetTickLabelPosition(DXDrawCharts.DateAxis openXmlElement, DMDrawsCharts.TickLabelPositionKind? value)
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
  private static DMDrawsCharts.ChartShapeProperties? GetChartShapeProperties(DXDrawCharts.DateAxis openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDrawCharts.ChartShapeProperties>();
    if (element != null)
      return DMXDrawsCharts.ChartShapePropertiesConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpChartShapeProperties(DXDrawCharts.DateAxis openXmlElement, DMDrawsCharts.ChartShapeProperties? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsCharts.ChartShapePropertiesConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDrawCharts.ChartShapeProperties>(), value, diffs, objName);
  }
  
  private static void SetChartShapeProperties(DXDrawCharts.DateAxis openXmlElement, DMDrawsCharts.ChartShapeProperties? value)
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
  private static DMDrawsCharts.TextProperties? GetTextProperties(DXDrawCharts.DateAxis openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDrawCharts.TextProperties>();
    if (element != null)
      return DMXDrawsCharts.TextPropertiesConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpTextProperties(DXDrawCharts.DateAxis openXmlElement, DMDrawsCharts.TextProperties? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsCharts.TextPropertiesConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDrawCharts.TextProperties>(), value, diffs, objName);
  }
  
  private static void SetTextProperties(DXDrawCharts.DateAxis openXmlElement, DMDrawsCharts.TextProperties? value)
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
  private static UInt32? GetCrossingAxis(DXDrawCharts.DateAxis openXmlElement)
  {
    return SimpleValueConverter.GetValue(openXmlElement?.GetFirstChild<DXDrawCharts.CrossingAxis>()?.Val);
  }
  
  private static bool CmpCrossingAxis(DXDrawCharts.DateAxis openXmlElement, UInt32? value, DiffList? diffs, string? objName)
  {
    return SimpleValueConverter.CmpValue(openXmlElement?.GetFirstChild<DXDrawCharts.CrossingAxis>()?.Val, value, diffs, objName, "CrossingAxis");
  }
  
  private static void SetCrossingAxis(DXDrawCharts.DateAxis openXmlElement, UInt32? value)
  {
    SimpleValueConverter.SetValue<DXDrawCharts.CrossingAxis,System.UInt32>(openXmlElement, value);
  }
  
  private static DMDrawsCharts.CrossesKind? GetCrosses(DXDrawCharts.DateAxis openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.Charts.CrossesValues, DMDrawsCharts.CrossesKind>(openXmlElement.GetFirstChild<DXDrawCharts.Crosses>()?.Val?.Value);
  }
  
  private static bool CmpCrosses(DXDrawCharts.DateAxis openXmlElement, DMDrawsCharts.CrossesKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Drawing.Charts.CrossesValues, DMDrawsCharts.CrossesKind>(openXmlElement.GetFirstChild<DXDrawCharts.Crosses>()?.Val?.Value, value, diffs, objName);
  }
  
  private static void SetCrosses(DXDrawCharts.DateAxis openXmlElement, DMDrawsCharts.CrossesKind? value)
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
  
  private static Double? GetCrossesAt(DXDrawCharts.DateAxis openXmlElement)
  {
    return SimpleValueConverter.GetValue(openXmlElement?.GetFirstChild<DXDrawCharts.CrossesAt>()?.Val);
  }
  
  private static bool CmpCrossesAt(DXDrawCharts.DateAxis openXmlElement, Double? value, DiffList? diffs, string? objName)
  {
    return SimpleValueConverter.CmpValue(openXmlElement?.GetFirstChild<DXDrawCharts.CrossesAt>()?.Val, value, diffs, objName, "CrossesAt");
  }
  
  private static void SetCrossesAt(DXDrawCharts.DateAxis openXmlElement, Double? value)
  {
    SimpleValueConverter.SetValue<DXDrawCharts.CrossesAt,System.Double>(openXmlElement, value);
  }
  
  private static Boolean? GetAutoLabeled(DXDrawCharts.DateAxis openXmlElement)
  {
    return openXmlElement.GetFirstChild<DXDrawCharts.AutoLabeled>() != null;
  }
  
  private static bool CmpAutoLabeled(DXDrawCharts.DateAxis openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    var val = openXmlElement.GetFirstChild<DXDrawCharts.AutoLabeled>() != null;
    if (val == value) return true;
    diffs?.Add(objName, "DXDrawCharts.AutoLabeled", val, value);
    return false;
  }
  
  private static void SetAutoLabeled(DXDrawCharts.DateAxis openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DXDrawCharts.AutoLabeled>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DXDrawCharts.AutoLabeled();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  private static UInt16? GetLabelOffset(DXDrawCharts.DateAxis openXmlElement)
  {
    return SimpleValueConverter.GetValue(openXmlElement?.GetFirstChild<DXDrawCharts.LabelOffset>()?.Val);
  }
  
  private static bool CmpLabelOffset(DXDrawCharts.DateAxis openXmlElement, UInt16? value, DiffList? diffs, string? objName)
  {
    return SimpleValueConverter.CmpValue(openXmlElement?.GetFirstChild<DXDrawCharts.LabelOffset>()?.Val, value, diffs, objName, "LabelOffset");
  }
  
  private static void SetLabelOffset(DXDrawCharts.DateAxis openXmlElement, UInt16? value)
  {
    SimpleValueConverter.SetValue<DXDrawCharts.LabelOffset,System.UInt16>(openXmlElement, value);
  }
  
  private static DMDrawsCharts.TimeUnitKind? GetBaseTimeUnit(DXDrawCharts.DateAxis openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.Charts.TimeUnitValues, DMDrawsCharts.TimeUnitKind>(openXmlElement.GetFirstChild<DXDrawCharts.BaseTimeUnit>()?.Val?.Value);
  }
  
  private static bool CmpBaseTimeUnit(DXDrawCharts.DateAxis openXmlElement, DMDrawsCharts.TimeUnitKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Drawing.Charts.TimeUnitValues, DMDrawsCharts.TimeUnitKind>(openXmlElement.GetFirstChild<DXDrawCharts.BaseTimeUnit>()?.Val?.Value, value, diffs, objName);
  }
  
  private static void SetBaseTimeUnit(DXDrawCharts.DateAxis openXmlElement, DMDrawsCharts.TimeUnitKind? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDrawCharts.BaseTimeUnit>();
    if (itemElement != null)
    {
      if (value != null)
        EnumValueConverter.UpdateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Charts.TimeUnitValues, DMDrawsCharts.TimeUnitKind>(itemElement, (DMDrawsCharts.TimeUnitKind)value);
      else
        itemElement.Remove();
    }
    else
    if (value != null)
      openXmlElement.AddChild(EnumValueConverter.CreateOpenXmlElement<DXDrawCharts.BaseTimeUnit, DocumentFormat.OpenXml.Drawing.Charts.TimeUnitValues, DMDrawsCharts.TimeUnitKind>((DMDrawsCharts.TimeUnitKind)value));
  }
  
  private static Double? GetMajorUnit(DXDrawCharts.DateAxis openXmlElement)
  {
    return SimpleValueConverter.GetValue(openXmlElement?.GetFirstChild<DXDrawCharts.MajorUnit>()?.Val);
  }
  
  private static bool CmpMajorUnit(DXDrawCharts.DateAxis openXmlElement, Double? value, DiffList? diffs, string? objName)
  {
    return SimpleValueConverter.CmpValue(openXmlElement?.GetFirstChild<DXDrawCharts.MajorUnit>()?.Val, value, diffs, objName, "MajorUnit");
  }
  
  private static void SetMajorUnit(DXDrawCharts.DateAxis openXmlElement, Double? value)
  {
    SimpleValueConverter.SetValue<DXDrawCharts.MajorUnit,System.Double>(openXmlElement, value);
  }
  
  private static DMDrawsCharts.TimeUnitKind? GetMajorTimeUnit(DXDrawCharts.DateAxis openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.Charts.TimeUnitValues, DMDrawsCharts.TimeUnitKind>(openXmlElement.GetFirstChild<DXDrawCharts.MajorTimeUnit>()?.Val?.Value);
  }
  
  private static bool CmpMajorTimeUnit(DXDrawCharts.DateAxis openXmlElement, DMDrawsCharts.TimeUnitKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Drawing.Charts.TimeUnitValues, DMDrawsCharts.TimeUnitKind>(openXmlElement.GetFirstChild<DXDrawCharts.MajorTimeUnit>()?.Val?.Value, value, diffs, objName);
  }
  
  private static void SetMajorTimeUnit(DXDrawCharts.DateAxis openXmlElement, DMDrawsCharts.TimeUnitKind? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDrawCharts.MajorTimeUnit>();
    if (itemElement != null)
    {
      if (value != null)
        EnumValueConverter.UpdateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Charts.TimeUnitValues, DMDrawsCharts.TimeUnitKind>(itemElement, (DMDrawsCharts.TimeUnitKind)value);
      else
        itemElement.Remove();
    }
    else
    if (value != null)
      openXmlElement.AddChild(EnumValueConverter.CreateOpenXmlElement<DXDrawCharts.MajorTimeUnit, DocumentFormat.OpenXml.Drawing.Charts.TimeUnitValues, DMDrawsCharts.TimeUnitKind>((DMDrawsCharts.TimeUnitKind)value));
  }
  
  private static Double? GetMinorUnit(DXDrawCharts.DateAxis openXmlElement)
  {
    return SimpleValueConverter.GetValue(openXmlElement?.GetFirstChild<DXDrawCharts.MinorUnit>()?.Val);
  }
  
  private static bool CmpMinorUnit(DXDrawCharts.DateAxis openXmlElement, Double? value, DiffList? diffs, string? objName)
  {
    return SimpleValueConverter.CmpValue(openXmlElement?.GetFirstChild<DXDrawCharts.MinorUnit>()?.Val, value, diffs, objName, "MinorUnit");
  }
  
  private static void SetMinorUnit(DXDrawCharts.DateAxis openXmlElement, Double? value)
  {
    SimpleValueConverter.SetValue<DXDrawCharts.MinorUnit,System.Double>(openXmlElement, value);
  }
  
  private static DMDrawsCharts.TimeUnitKind? GetMinorTimeUnit(DXDrawCharts.DateAxis openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.Charts.TimeUnitValues, DMDrawsCharts.TimeUnitKind>(openXmlElement.GetFirstChild<DXDrawCharts.MinorTimeUnit>()?.Val?.Value);
  }
  
  private static bool CmpMinorTimeUnit(DXDrawCharts.DateAxis openXmlElement, DMDrawsCharts.TimeUnitKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Drawing.Charts.TimeUnitValues, DMDrawsCharts.TimeUnitKind>(openXmlElement.GetFirstChild<DXDrawCharts.MinorTimeUnit>()?.Val?.Value, value, diffs, objName);
  }
  
  private static void SetMinorTimeUnit(DXDrawCharts.DateAxis openXmlElement, DMDrawsCharts.TimeUnitKind? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDrawCharts.MinorTimeUnit>();
    if (itemElement != null)
    {
      if (value != null)
        EnumValueConverter.UpdateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Charts.TimeUnitValues, DMDrawsCharts.TimeUnitKind>(itemElement, (DMDrawsCharts.TimeUnitKind)value);
      else
        itemElement.Remove();
    }
    else
    if (value != null)
      openXmlElement.AddChild(EnumValueConverter.CreateOpenXmlElement<DXDrawCharts.MinorTimeUnit, DocumentFormat.OpenXml.Drawing.Charts.TimeUnitValues, DMDrawsCharts.TimeUnitKind>((DMDrawsCharts.TimeUnitKind)value));
  }
  
  private static DMDrawsCharts.DateAxExtensionList? GetDateAxExtensionList(DXDrawCharts.DateAxis openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDrawCharts.DateAxExtensionList>();
    if (element != null)
      return DMXDrawsCharts.DateAxExtensionListConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpDateAxExtensionList(DXDrawCharts.DateAxis openXmlElement, DMDrawsCharts.DateAxExtensionList? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsCharts.DateAxExtensionListConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDrawCharts.DateAxExtensionList>(), value, diffs, objName);
  }
  
  private static void SetDateAxExtensionList(DXDrawCharts.DateAxis openXmlElement, DMDrawsCharts.DateAxExtensionList? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDrawCharts.DateAxExtensionList>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDrawsCharts.DateAxExtensionListConverter.CreateOpenXmlElement<DXDrawCharts.DateAxExtensionList>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DocumentModel.Drawings.Charts.DateAxis? CreateModelElement(DXDrawCharts.DateAxis? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Charts.DateAxis();
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
      value.AutoLabeled = GetAutoLabeled(openXmlElement);
      value.LabelOffset = GetLabelOffset(openXmlElement);
      value.BaseTimeUnit = GetBaseTimeUnit(openXmlElement);
      value.MajorUnit = GetMajorUnit(openXmlElement);
      value.MajorTimeUnit = GetMajorTimeUnit(openXmlElement);
      value.MinorUnit = GetMinorUnit(openXmlElement);
      value.MinorTimeUnit = GetMinorTimeUnit(openXmlElement);
      value.DateAxExtensionList = GetDateAxExtensionList(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXDrawCharts.DateAxis? openXmlElement, DMDrawsCharts.DateAxis? value, DiffList? diffs, string? objName)
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
      if (!CmpAutoLabeled(openXmlElement, value.AutoLabeled, diffs, objName))
        ok = false;
      if (!CmpLabelOffset(openXmlElement, value.LabelOffset, diffs, objName))
        ok = false;
      if (!CmpBaseTimeUnit(openXmlElement, value.BaseTimeUnit, diffs, objName))
        ok = false;
      if (!CmpMajorUnit(openXmlElement, value.MajorUnit, diffs, objName))
        ok = false;
      if (!CmpMajorTimeUnit(openXmlElement, value.MajorTimeUnit, diffs, objName))
        ok = false;
      if (!CmpMinorUnit(openXmlElement, value.MinorUnit, diffs, objName))
        ok = false;
      if (!CmpMinorTimeUnit(openXmlElement, value.MinorTimeUnit, diffs, objName))
        ok = false;
      if (!CmpDateAxExtensionList(openXmlElement, value.DateAxExtensionList, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDrawsCharts.DateAxis value)
    where OpenXmlElementType: DXDrawCharts.DateAxis, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXDrawCharts.DateAxis openXmlElement, DMDrawsCharts.DateAxis value)
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
    SetAutoLabeled(openXmlElement, value?.AutoLabeled);
    SetLabelOffset(openXmlElement, value?.LabelOffset);
    SetBaseTimeUnit(openXmlElement, value?.BaseTimeUnit);
    SetMajorUnit(openXmlElement, value?.MajorUnit);
    SetMajorTimeUnit(openXmlElement, value?.MajorTimeUnit);
    SetMinorUnit(openXmlElement, value?.MinorUnit);
    SetMinorTimeUnit(openXmlElement, value?.MinorTimeUnit);
    SetDateAxExtensionList(openXmlElement, value?.DateAxExtensionList);
  }
}
