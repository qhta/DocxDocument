namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
/// Series Axis.
/// </summary>
public static class SeriesAxisConverter
{
  /// <summary>
  /// Axis ID.
  /// </summary>
  private static UInt32? GetAxisId(DXDrawCharts.SeriesAxis openXmlElement)
  {
    return openXmlElement?.GetFirstChild<DXDrawCharts.AxisId>()?.Val?.Value;
  }
  
  private static bool CmpAxisId(DXDrawCharts.SeriesAxis openXmlElement, UInt32? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.GetFirstChild<DXDrawCharts.AxisId>()?.Val?.Value == value;
  }
  
  private static void SetAxisId(DXDrawCharts.SeriesAxis openXmlElement, UInt32? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDrawCharts.AxisId>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DXDrawCharts.AxisId{ Val = value };
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Scaling.
  /// </summary>
  private static DMDrawsCharts.Scaling? GetScaling(DXDrawCharts.SeriesAxis openXmlElement)
  {
    return DMXDrawsCharts.ScalingConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXDrawCharts.Scaling>());
  }
  
  private static bool CmpScaling(DXDrawCharts.SeriesAxis openXmlElement, DMDrawsCharts.Scaling? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsCharts.ScalingConverter.CompareModelElement(openXmlElement?.GetFirstChild<DXDrawCharts.Scaling>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetScaling(DXDrawCharts.SeriesAxis openXmlElement, DMDrawsCharts.Scaling? value)
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
  private static Boolean? GetDelete(DXDrawCharts.SeriesAxis openXmlElement)
  {
    return openXmlElement.GetFirstChild<DXDrawCharts.Delete>() != null;
  }
  
  private static bool CmpDelete(DXDrawCharts.SeriesAxis openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return openXmlElement.GetFirstChild<DXDrawCharts.Delete>() != null == value;
  }
  
  private static void SetDelete(DXDrawCharts.SeriesAxis openXmlElement, Boolean? value)
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
  private static DMDrawsCharts.AxisPositionKind? GetAxisPosition(DXDrawCharts.SeriesAxis openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.Charts.AxisPositionValues, DMDrawsCharts.AxisPositionKind>(openXmlElement.GetFirstChild<DXDrawCharts.AxisPosition>()?.Val?.Value);
  }
  
  private static bool CmpAxisPosition(DXDrawCharts.SeriesAxis openXmlElement, DMDrawsCharts.AxisPositionKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Drawing.Charts.AxisPositionValues, DMDrawsCharts.AxisPositionKind>(openXmlElement.GetFirstChild<DXDrawCharts.AxisPosition>()?.Val?.Value, value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetAxisPosition(DXDrawCharts.SeriesAxis openXmlElement, DMDrawsCharts.AxisPositionKind? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDrawCharts.AxisPosition>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = EnumValueConverter.CreateOpenXmlElement<DXDrawCharts.AxisPosition, DocumentFormat.OpenXml.Drawing.Charts.AxisPositionValues, DMDrawsCharts.AxisPositionKind>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Major Gridlines.
  /// </summary>
  private static DMDrawsCharts.MajorGridlines? GetMajorGridlines(DXDrawCharts.SeriesAxis openXmlElement)
  {
    return DMXDrawsCharts.MajorGridlinesConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXDrawCharts.MajorGridlines>());
  }
  
  private static bool CmpMajorGridlines(DXDrawCharts.SeriesAxis openXmlElement, DMDrawsCharts.MajorGridlines? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsCharts.MajorGridlinesConverter.CompareModelElement(openXmlElement?.GetFirstChild<DXDrawCharts.MajorGridlines>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetMajorGridlines(DXDrawCharts.SeriesAxis openXmlElement, DMDrawsCharts.MajorGridlines? value)
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
  private static DMDrawsCharts.MinorGridlines? GetMinorGridlines(DXDrawCharts.SeriesAxis openXmlElement)
  {
    return DMXDrawsCharts.MinorGridlinesConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXDrawCharts.MinorGridlines>());
  }
  
  private static bool CmpMinorGridlines(DXDrawCharts.SeriesAxis openXmlElement, DMDrawsCharts.MinorGridlines? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsCharts.MinorGridlinesConverter.CompareModelElement(openXmlElement?.GetFirstChild<DXDrawCharts.MinorGridlines>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetMinorGridlines(DXDrawCharts.SeriesAxis openXmlElement, DMDrawsCharts.MinorGridlines? value)
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
  private static DMDrawsCharts.Title? GetTitle(DXDrawCharts.SeriesAxis openXmlElement)
  {
    return DMXDrawsCharts.TitleConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXDrawCharts.Title>());
  }
  
  private static bool CmpTitle(DXDrawCharts.SeriesAxis openXmlElement, DMDrawsCharts.Title? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsCharts.TitleConverter.CompareModelElement(openXmlElement?.GetFirstChild<DXDrawCharts.Title>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetTitle(DXDrawCharts.SeriesAxis openXmlElement, DMDrawsCharts.Title? value)
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
  private static DMDrawsCharts.NumberingFormat? GetNumberingFormat(DXDrawCharts.SeriesAxis openXmlElement)
  {
    return DMXDrawsCharts.NumberingFormatConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXDrawCharts.NumberingFormat>());
  }
  
  private static bool CmpNumberingFormat(DXDrawCharts.SeriesAxis openXmlElement, DMDrawsCharts.NumberingFormat? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsCharts.NumberingFormatConverter.CompareModelElement(openXmlElement?.GetFirstChild<DXDrawCharts.NumberingFormat>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetNumberingFormat(DXDrawCharts.SeriesAxis openXmlElement, DMDrawsCharts.NumberingFormat? value)
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
  private static DMDrawsCharts.TickMarkKind? GetMajorTickMark(DXDrawCharts.SeriesAxis openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.Charts.TickMarkValues, DMDrawsCharts.TickMarkKind>(openXmlElement.GetFirstChild<DXDrawCharts.MajorTickMark>()?.Val?.Value);
  }
  
  private static bool CmpMajorTickMark(DXDrawCharts.SeriesAxis openXmlElement, DMDrawsCharts.TickMarkKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Drawing.Charts.TickMarkValues, DMDrawsCharts.TickMarkKind>(openXmlElement.GetFirstChild<DXDrawCharts.MajorTickMark>()?.Val?.Value, value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetMajorTickMark(DXDrawCharts.SeriesAxis openXmlElement, DMDrawsCharts.TickMarkKind? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDrawCharts.MajorTickMark>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = EnumValueConverter.CreateOpenXmlElement<DXDrawCharts.MajorTickMark, DocumentFormat.OpenXml.Drawing.Charts.TickMarkValues, DMDrawsCharts.TickMarkKind>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Minor Tick Mark.
  /// </summary>
  private static DMDrawsCharts.TickMarkKind? GetMinorTickMark(DXDrawCharts.SeriesAxis openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.Charts.TickMarkValues, DMDrawsCharts.TickMarkKind>(openXmlElement.GetFirstChild<DXDrawCharts.MinorTickMark>()?.Val?.Value);
  }
  
  private static bool CmpMinorTickMark(DXDrawCharts.SeriesAxis openXmlElement, DMDrawsCharts.TickMarkKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Drawing.Charts.TickMarkValues, DMDrawsCharts.TickMarkKind>(openXmlElement.GetFirstChild<DXDrawCharts.MinorTickMark>()?.Val?.Value, value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetMinorTickMark(DXDrawCharts.SeriesAxis openXmlElement, DMDrawsCharts.TickMarkKind? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDrawCharts.MinorTickMark>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = EnumValueConverter.CreateOpenXmlElement<DXDrawCharts.MinorTickMark, DocumentFormat.OpenXml.Drawing.Charts.TickMarkValues, DMDrawsCharts.TickMarkKind>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Tick Label Position.
  /// </summary>
  private static DMDrawsCharts.TickLabelPositionKind? GetTickLabelPosition(DXDrawCharts.SeriesAxis openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.Charts.TickLabelPositionValues, DMDrawsCharts.TickLabelPositionKind>(openXmlElement.GetFirstChild<DXDrawCharts.TickLabelPosition>()?.Val?.Value);
  }
  
  private static bool CmpTickLabelPosition(DXDrawCharts.SeriesAxis openXmlElement, DMDrawsCharts.TickLabelPositionKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Drawing.Charts.TickLabelPositionValues, DMDrawsCharts.TickLabelPositionKind>(openXmlElement.GetFirstChild<DXDrawCharts.TickLabelPosition>()?.Val?.Value, value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetTickLabelPosition(DXDrawCharts.SeriesAxis openXmlElement, DMDrawsCharts.TickLabelPositionKind? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDrawCharts.TickLabelPosition>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = EnumValueConverter.CreateOpenXmlElement<DXDrawCharts.TickLabelPosition, DocumentFormat.OpenXml.Drawing.Charts.TickLabelPositionValues, DMDrawsCharts.TickLabelPositionKind>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// ChartShapeProperties.
  /// </summary>
  private static DMDrawsCharts.ChartShapeProperties? GetChartShapeProperties(DXDrawCharts.SeriesAxis openXmlElement)
  {
    return DMXDrawsCharts.ChartShapePropertiesConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXDrawCharts.ChartShapeProperties>());
  }
  
  private static bool CmpChartShapeProperties(DXDrawCharts.SeriesAxis openXmlElement, DMDrawsCharts.ChartShapeProperties? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsCharts.ChartShapePropertiesConverter.CompareModelElement(openXmlElement?.GetFirstChild<DXDrawCharts.ChartShapeProperties>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetChartShapeProperties(DXDrawCharts.SeriesAxis openXmlElement, DMDrawsCharts.ChartShapeProperties? value)
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
  private static DMDrawsCharts.TextProperties? GetTextProperties(DXDrawCharts.SeriesAxis openXmlElement)
  {
    return DMXDrawsCharts.TextPropertiesConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXDrawCharts.TextProperties>());
  }
  
  private static bool CmpTextProperties(DXDrawCharts.SeriesAxis openXmlElement, DMDrawsCharts.TextProperties? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsCharts.TextPropertiesConverter.CompareModelElement(openXmlElement?.GetFirstChild<DXDrawCharts.TextProperties>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetTextProperties(DXDrawCharts.SeriesAxis openXmlElement, DMDrawsCharts.TextProperties? value)
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
  private static UInt32? GetCrossingAxis(DXDrawCharts.SeriesAxis openXmlElement)
  {
    return openXmlElement?.GetFirstChild<DXDrawCharts.CrossingAxis>()?.Val?.Value;
  }
  
  private static bool CmpCrossingAxis(DXDrawCharts.SeriesAxis openXmlElement, UInt32? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.GetFirstChild<DXDrawCharts.CrossingAxis>()?.Val?.Value == value;
  }
  
  private static void SetCrossingAxis(DXDrawCharts.SeriesAxis openXmlElement, UInt32? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDrawCharts.CrossingAxis>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DXDrawCharts.CrossingAxis{ Val = value };
      openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMDrawsCharts.CrossesKind? GetCrosses(DXDrawCharts.SeriesAxis openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.Charts.CrossesValues, DMDrawsCharts.CrossesKind>(openXmlElement.GetFirstChild<DXDrawCharts.Crosses>()?.Val?.Value);
  }
  
  private static bool CmpCrosses(DXDrawCharts.SeriesAxis openXmlElement, DMDrawsCharts.CrossesKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Drawing.Charts.CrossesValues, DMDrawsCharts.CrossesKind>(openXmlElement.GetFirstChild<DXDrawCharts.Crosses>()?.Val?.Value, value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetCrosses(DXDrawCharts.SeriesAxis openXmlElement, DMDrawsCharts.CrossesKind? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDrawCharts.Crosses>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = EnumValueConverter.CreateOpenXmlElement<DXDrawCharts.Crosses, DocumentFormat.OpenXml.Drawing.Charts.CrossesValues, DMDrawsCharts.CrossesKind>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static Double? GetCrossesAt(DXDrawCharts.SeriesAxis openXmlElement)
  {
    return openXmlElement?.GetFirstChild<DXDrawCharts.CrossesAt>()?.Val?.Value;
  }
  
  private static bool CmpCrossesAt(DXDrawCharts.SeriesAxis openXmlElement, Double? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.GetFirstChild<DXDrawCharts.CrossesAt>()?.Val?.Value == value;
  }
  
  private static void SetCrossesAt(DXDrawCharts.SeriesAxis openXmlElement, Double? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDrawCharts.CrossesAt>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DXDrawCharts.CrossesAt{ Val = value };
      openXmlElement.AddChild(itemElement);
    }
  }
  
  private static Int32? GetTickLabelSkip(DXDrawCharts.SeriesAxis openXmlElement)
  {
    return openXmlElement?.GetFirstChild<DXDrawCharts.TickLabelSkip>()?.Val?.Value;
  }
  
  private static bool CmpTickLabelSkip(DXDrawCharts.SeriesAxis openXmlElement, Int32? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.GetFirstChild<DXDrawCharts.TickLabelSkip>()?.Val?.Value == value;
  }
  
  private static void SetTickLabelSkip(DXDrawCharts.SeriesAxis openXmlElement, Int32? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDrawCharts.TickLabelSkip>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DXDrawCharts.TickLabelSkip{ Val = value };
      openXmlElement.AddChild(itemElement);
    }
  }
  
  private static Int32? GetTickMarkSkip(DXDrawCharts.SeriesAxis openXmlElement)
  {
    return openXmlElement?.GetFirstChild<DXDrawCharts.TickMarkSkip>()?.Val?.Value;
  }
  
  private static bool CmpTickMarkSkip(DXDrawCharts.SeriesAxis openXmlElement, Int32? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.GetFirstChild<DXDrawCharts.TickMarkSkip>()?.Val?.Value == value;
  }
  
  private static void SetTickMarkSkip(DXDrawCharts.SeriesAxis openXmlElement, Int32? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDrawCharts.TickMarkSkip>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DXDrawCharts.TickMarkSkip{ Val = value };
      openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMDrawsCharts.SerAxExtensionList? GetSerAxExtensionList(DXDrawCharts.SeriesAxis openXmlElement)
  {
    return DMXDrawsCharts.SerAxExtensionListConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXDrawCharts.SerAxExtensionList>());
  }
  
  private static bool CmpSerAxExtensionList(DXDrawCharts.SeriesAxis openXmlElement, DMDrawsCharts.SerAxExtensionList? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsCharts.SerAxExtensionListConverter.CompareModelElement(openXmlElement?.GetFirstChild<DXDrawCharts.SerAxExtensionList>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetSerAxExtensionList(DXDrawCharts.SeriesAxis openXmlElement, DMDrawsCharts.SerAxExtensionList? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDrawCharts.SerAxExtensionList>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDrawsCharts.SerAxExtensionListConverter.CreateOpenXmlElement<DXDrawCharts.SerAxExtensionList>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DMDrawsCharts.SeriesAxis? CreateModelElement(DXDrawCharts.SeriesAxis? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDrawsCharts.SeriesAxis();
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
      value.TickLabelSkip = GetTickLabelSkip(openXmlElement);
      value.TickMarkSkip = GetTickMarkSkip(openXmlElement);
      value.SerAxExtensionList = GetSerAxExtensionList(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXDrawCharts.SeriesAxis? openXmlElement, DMDrawsCharts.SeriesAxis? value, DiffList? diffs, string? objName)
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
      if (!CmpTickLabelSkip(openXmlElement, value.TickLabelSkip, diffs, objName))
        ok = false;
      if (!CmpTickMarkSkip(openXmlElement, value.TickMarkSkip, diffs, objName))
        ok = false;
      if (!CmpSerAxExtensionList(openXmlElement, value.SerAxExtensionList, diffs, objName))
        ok = false;
      return ok;
    }
    return openXmlElement == null && value == null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDrawsCharts.SeriesAxis? value)
    where OpenXmlElementType: DXDrawCharts.SeriesAxis, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
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
      SetTickLabelSkip(openXmlElement, value?.TickLabelSkip);
      SetTickMarkSkip(openXmlElement, value?.TickMarkSkip);
      SetSerAxExtensionList(openXmlElement, value?.SerAxExtensionList);
      return openXmlElement;
    }
    return default;
  }
}
