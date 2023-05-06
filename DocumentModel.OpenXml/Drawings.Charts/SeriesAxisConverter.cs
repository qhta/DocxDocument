namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
/// Series Axis.
/// </summary>
public static class SeriesAxisConverter
{
  /// <summary>
  /// Axis ID.
  /// </summary>
  private static UInt32? GetAxisId(DXDC.SeriesAxis openXmlElement)
  {
    return SimpleValueConverter.GetValue(openXmlElement?.GetFirstChild<DXDC.AxisId>()?.Val);
  }
  
  private static bool CmpAxisId(DXDC.SeriesAxis openXmlElement, UInt32? value, DiffList? diffs, string? objName)
  {
    return SimpleValueConverter.CmpValue(openXmlElement?.GetFirstChild<DXDC.AxisId>()?.Val, value, diffs, objName, "AxisId");
  }
  
  private static void SetAxisId(DXDC.SeriesAxis openXmlElement, UInt32? value)
  {
    SimpleValueConverter.SetValue<DXDC.AxisId,System.UInt32>(openXmlElement, value);
  }
  
  /// <summary>
  /// Scaling.
  /// </summary>
  private static DMDC.Scaling? GetScaling(DXDC.SeriesAxis openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDC.Scaling>();
    if (element != null)
      return DMXDC.ScalingConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpScaling(DXDC.SeriesAxis openXmlElement, DMDC.Scaling? value, DiffList? diffs, string? objName)
  {
    return DMXDC.ScalingConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDC.Scaling>(), value, diffs, objName);
  }
  
  private static void SetScaling(DXDC.SeriesAxis openXmlElement, DMDC.Scaling? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDC.Scaling>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDC.ScalingConverter.CreateOpenXmlElement<DXDC.Scaling>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  /// <summary>
  /// Delete.
  /// </summary>
  private static Boolean? GetDelete(DXDC.SeriesAxis openXmlElement)
  {
    return openXmlElement.GetFirstChild<DXDC.Delete>() != null;
  }
  
  private static bool CmpDelete(DXDC.SeriesAxis openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    var val = openXmlElement.GetFirstChild<DXDC.Delete>() != null;
    if (val == value) return true;
    diffs?.Add(objName, "DXDC.Delete", val, value);
    return false;
  }
  
  private static void SetDelete(DXDC.SeriesAxis openXmlElement, Boolean? value)
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
  
  /// <summary>
  /// Axis Position.
  /// </summary>
  private static DMDC.AxisPositionKind? GetAxisPosition(DXDC.SeriesAxis openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.Charts.AxisPositionValues, DMDC.AxisPositionKind>(openXmlElement.GetFirstChild<DXDC.AxisPosition>()?.Val?.Value);
  }
  
  private static bool CmpAxisPosition(DXDC.SeriesAxis openXmlElement, DMDC.AxisPositionKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Drawing.Charts.AxisPositionValues, DMDC.AxisPositionKind>(openXmlElement.GetFirstChild<DXDC.AxisPosition>()?.Val?.Value, value, diffs, objName);
  }
  
  private static void SetAxisPosition(DXDC.SeriesAxis openXmlElement, DMDC.AxisPositionKind? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDC.AxisPosition>();
    if (itemElement != null)
    {
      if (value != null)
        EnumValueConverter.UpdateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Charts.AxisPositionValues, DMDC.AxisPositionKind>(itemElement, (DMDC.AxisPositionKind)value);
      else
        itemElement.Remove();
    }
    else
    if (value != null)
      openXmlElement.AppendChild(EnumValueConverter.CreateOpenXmlElement<DXDC.AxisPosition, DocumentFormat.OpenXml.Drawing.Charts.AxisPositionValues, DMDC.AxisPositionKind>((DMDC.AxisPositionKind)value));
  }
  
  /// <summary>
  /// Major Gridlines.
  /// </summary>
  private static DMDC.MajorGridlines? GetMajorGridlines(DXDC.SeriesAxis openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDC.MajorGridlines>();
    if (element != null)
      return DMXDC.MajorGridlinesConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpMajorGridlines(DXDC.SeriesAxis openXmlElement, DMDC.MajorGridlines? value, DiffList? diffs, string? objName)
  {
    return DMXDC.MajorGridlinesConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDC.MajorGridlines>(), value, diffs, objName);
  }
  
  private static void SetMajorGridlines(DXDC.SeriesAxis openXmlElement, DMDC.MajorGridlines? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDC.MajorGridlines>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDC.MajorGridlinesConverter.CreateOpenXmlElement<DXDC.MajorGridlines>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  /// <summary>
  /// Minor Gridlines.
  /// </summary>
  private static DMDC.MinorGridlines? GetMinorGridlines(DXDC.SeriesAxis openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDC.MinorGridlines>();
    if (element != null)
      return DMXDC.MinorGridlinesConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpMinorGridlines(DXDC.SeriesAxis openXmlElement, DMDC.MinorGridlines? value, DiffList? diffs, string? objName)
  {
    return DMXDC.MinorGridlinesConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDC.MinorGridlines>(), value, diffs, objName);
  }
  
  private static void SetMinorGridlines(DXDC.SeriesAxis openXmlElement, DMDC.MinorGridlines? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDC.MinorGridlines>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDC.MinorGridlinesConverter.CreateOpenXmlElement<DXDC.MinorGridlines>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  /// <summary>
  /// Title.
  /// </summary>
  private static DMDC.Title? GetTitle(DXDC.SeriesAxis openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDC.Title>();
    if (element != null)
      return DMXDC.TitleConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpTitle(DXDC.SeriesAxis openXmlElement, DMDC.Title? value, DiffList? diffs, string? objName)
  {
    return DMXDC.TitleConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDC.Title>(), value, diffs, objName);
  }
  
  private static void SetTitle(DXDC.SeriesAxis openXmlElement, DMDC.Title? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDC.Title>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDC.TitleConverter.CreateOpenXmlElement<DXDC.Title>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  /// <summary>
  /// Number Format.
  /// </summary>
  private static DMDC.NumberingFormat? GetNumberingFormat(DXDC.SeriesAxis openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDC.NumberingFormat>();
    if (element != null)
      return DMXDC.NumberingFormatConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpNumberingFormat(DXDC.SeriesAxis openXmlElement, DMDC.NumberingFormat? value, DiffList? diffs, string? objName)
  {
    return DMXDC.NumberingFormatConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDC.NumberingFormat>(), value, diffs, objName);
  }
  
  private static void SetNumberingFormat(DXDC.SeriesAxis openXmlElement, DMDC.NumberingFormat? value)
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
  
  /// <summary>
  /// Major Tick Mark.
  /// </summary>
  private static DMDC.TickMarkKind? GetMajorTickMark(DXDC.SeriesAxis openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.Charts.TickMarkValues, DMDC.TickMarkKind>(openXmlElement.GetFirstChild<DXDC.MajorTickMark>()?.Val?.Value);
  }
  
  private static bool CmpMajorTickMark(DXDC.SeriesAxis openXmlElement, DMDC.TickMarkKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Drawing.Charts.TickMarkValues, DMDC.TickMarkKind>(openXmlElement.GetFirstChild<DXDC.MajorTickMark>()?.Val?.Value, value, diffs, objName);
  }
  
  private static void SetMajorTickMark(DXDC.SeriesAxis openXmlElement, DMDC.TickMarkKind? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDC.MajorTickMark>();
    if (itemElement != null)
    {
      if (value != null)
        EnumValueConverter.UpdateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Charts.TickMarkValues, DMDC.TickMarkKind>(itemElement, (DMDC.TickMarkKind)value);
      else
        itemElement.Remove();
    }
    else
    if (value != null)
      openXmlElement.AppendChild(EnumValueConverter.CreateOpenXmlElement<DXDC.MajorTickMark, DocumentFormat.OpenXml.Drawing.Charts.TickMarkValues, DMDC.TickMarkKind>((DMDC.TickMarkKind)value));
  }
  
  /// <summary>
  /// Minor Tick Mark.
  /// </summary>
  private static DMDC.TickMarkKind? GetMinorTickMark(DXDC.SeriesAxis openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.Charts.TickMarkValues, DMDC.TickMarkKind>(openXmlElement.GetFirstChild<DXDC.MinorTickMark>()?.Val?.Value);
  }
  
  private static bool CmpMinorTickMark(DXDC.SeriesAxis openXmlElement, DMDC.TickMarkKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Drawing.Charts.TickMarkValues, DMDC.TickMarkKind>(openXmlElement.GetFirstChild<DXDC.MinorTickMark>()?.Val?.Value, value, diffs, objName);
  }
  
  private static void SetMinorTickMark(DXDC.SeriesAxis openXmlElement, DMDC.TickMarkKind? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDC.MinorTickMark>();
    if (itemElement != null)
    {
      if (value != null)
        EnumValueConverter.UpdateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Charts.TickMarkValues, DMDC.TickMarkKind>(itemElement, (DMDC.TickMarkKind)value);
      else
        itemElement.Remove();
    }
    else
    if (value != null)
      openXmlElement.AppendChild(EnumValueConverter.CreateOpenXmlElement<DXDC.MinorTickMark, DocumentFormat.OpenXml.Drawing.Charts.TickMarkValues, DMDC.TickMarkKind>((DMDC.TickMarkKind)value));
  }
  
  /// <summary>
  /// Tick Label Position.
  /// </summary>
  private static DMDC.TickLabelPositionKind? GetTickLabelPosition(DXDC.SeriesAxis openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.Charts.TickLabelPositionValues, DMDC.TickLabelPositionKind>(openXmlElement.GetFirstChild<DXDC.TickLabelPosition>()?.Val?.Value);
  }
  
  private static bool CmpTickLabelPosition(DXDC.SeriesAxis openXmlElement, DMDC.TickLabelPositionKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Drawing.Charts.TickLabelPositionValues, DMDC.TickLabelPositionKind>(openXmlElement.GetFirstChild<DXDC.TickLabelPosition>()?.Val?.Value, value, diffs, objName);
  }
  
  private static void SetTickLabelPosition(DXDC.SeriesAxis openXmlElement, DMDC.TickLabelPositionKind? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDC.TickLabelPosition>();
    if (itemElement != null)
    {
      if (value != null)
        EnumValueConverter.UpdateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Charts.TickLabelPositionValues, DMDC.TickLabelPositionKind>(itemElement, (DMDC.TickLabelPositionKind)value);
      else
        itemElement.Remove();
    }
    else
    if (value != null)
      openXmlElement.AppendChild(EnumValueConverter.CreateOpenXmlElement<DXDC.TickLabelPosition, DocumentFormat.OpenXml.Drawing.Charts.TickLabelPositionValues, DMDC.TickLabelPositionKind>((DMDC.TickLabelPositionKind)value));
  }
  
  /// <summary>
  /// ChartShapeProperties.
  /// </summary>
  private static DMDC.ChartShapeProperties? GetChartShapeProperties(DXDC.SeriesAxis openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDC.ChartShapeProperties>();
    if (element != null)
      return DMXDC.ChartShapePropertiesConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpChartShapeProperties(DXDC.SeriesAxis openXmlElement, DMDC.ChartShapeProperties? value, DiffList? diffs, string? objName)
  {
    return DMXDC.ChartShapePropertiesConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDC.ChartShapeProperties>(), value, diffs, objName);
  }
  
  private static void SetChartShapeProperties(DXDC.SeriesAxis openXmlElement, DMDC.ChartShapeProperties? value)
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
  
  /// <summary>
  /// TextProperties.
  /// </summary>
  private static DMDC.TextProperties? GetTextProperties(DXDC.SeriesAxis openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDC.TextProperties>();
    if (element != null)
      return DMXDC.TextPropertiesConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpTextProperties(DXDC.SeriesAxis openXmlElement, DMDC.TextProperties? value, DiffList? diffs, string? objName)
  {
    return DMXDC.TextPropertiesConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDC.TextProperties>(), value, diffs, objName);
  }
  
  private static void SetTextProperties(DXDC.SeriesAxis openXmlElement, DMDC.TextProperties? value)
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
  
  /// <summary>
  /// Crossing Axis ID.
  /// </summary>
  private static UInt32? GetCrossingAxis(DXDC.SeriesAxis openXmlElement)
  {
    return SimpleValueConverter.GetValue(openXmlElement?.GetFirstChild<DXDC.CrossingAxis>()?.Val);
  }
  
  private static bool CmpCrossingAxis(DXDC.SeriesAxis openXmlElement, UInt32? value, DiffList? diffs, string? objName)
  {
    return SimpleValueConverter.CmpValue(openXmlElement?.GetFirstChild<DXDC.CrossingAxis>()?.Val, value, diffs, objName, "CrossingAxis");
  }
  
  private static void SetCrossingAxis(DXDC.SeriesAxis openXmlElement, UInt32? value)
  {
    SimpleValueConverter.SetValue<DXDC.CrossingAxis,System.UInt32>(openXmlElement, value);
  }
  
  private static DMDC.CrossesKind? GetCrosses(DXDC.SeriesAxis openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.Charts.CrossesValues, DMDC.CrossesKind>(openXmlElement.GetFirstChild<DXDC.Crosses>()?.Val?.Value);
  }
  
  private static bool CmpCrosses(DXDC.SeriesAxis openXmlElement, DMDC.CrossesKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Drawing.Charts.CrossesValues, DMDC.CrossesKind>(openXmlElement.GetFirstChild<DXDC.Crosses>()?.Val?.Value, value, diffs, objName);
  }
  
  private static void SetCrosses(DXDC.SeriesAxis openXmlElement, DMDC.CrossesKind? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDC.Crosses>();
    if (itemElement != null)
    {
      if (value != null)
        EnumValueConverter.UpdateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Charts.CrossesValues, DMDC.CrossesKind>(itemElement, (DMDC.CrossesKind)value);
      else
        itemElement.Remove();
    }
    else
    if (value != null)
      openXmlElement.AppendChild(EnumValueConverter.CreateOpenXmlElement<DXDC.Crosses, DocumentFormat.OpenXml.Drawing.Charts.CrossesValues, DMDC.CrossesKind>((DMDC.CrossesKind)value));
  }
  
  private static Double? GetCrossesAt(DXDC.SeriesAxis openXmlElement)
  {
    return SimpleValueConverter.GetValue(openXmlElement?.GetFirstChild<DXDC.CrossesAt>()?.Val);
  }
  
  private static bool CmpCrossesAt(DXDC.SeriesAxis openXmlElement, Double? value, DiffList? diffs, string? objName)
  {
    return SimpleValueConverter.CmpValue(openXmlElement?.GetFirstChild<DXDC.CrossesAt>()?.Val, value, diffs, objName, "CrossesAt");
  }
  
  private static void SetCrossesAt(DXDC.SeriesAxis openXmlElement, Double? value)
  {
    SimpleValueConverter.SetValue<DXDC.CrossesAt,System.Double>(openXmlElement, value);
  }
  
  private static Int32? GetTickLabelSkip(DXDC.SeriesAxis openXmlElement)
  {
    return SimpleValueConverter.GetValue(openXmlElement?.GetFirstChild<DXDC.TickLabelSkip>()?.Val);
  }
  
  private static bool CmpTickLabelSkip(DXDC.SeriesAxis openXmlElement, Int32? value, DiffList? diffs, string? objName)
  {
    return SimpleValueConverter.CmpValue(openXmlElement?.GetFirstChild<DXDC.TickLabelSkip>()?.Val, value, diffs, objName, "TickLabelSkip");
  }
  
  private static void SetTickLabelSkip(DXDC.SeriesAxis openXmlElement, Int32? value)
  {
    SimpleValueConverter.SetValue<DXDC.TickLabelSkip,System.Int32>(openXmlElement, value);
  }
  
  private static Int32? GetTickMarkSkip(DXDC.SeriesAxis openXmlElement)
  {
    return SimpleValueConverter.GetValue(openXmlElement?.GetFirstChild<DXDC.TickMarkSkip>()?.Val);
  }
  
  private static bool CmpTickMarkSkip(DXDC.SeriesAxis openXmlElement, Int32? value, DiffList? diffs, string? objName)
  {
    return SimpleValueConverter.CmpValue(openXmlElement?.GetFirstChild<DXDC.TickMarkSkip>()?.Val, value, diffs, objName, "TickMarkSkip");
  }
  
  private static void SetTickMarkSkip(DXDC.SeriesAxis openXmlElement, Int32? value)
  {
    SimpleValueConverter.SetValue<DXDC.TickMarkSkip,System.Int32>(openXmlElement, value);
  }
  
  private static DMDC.SerAxExtensionList? GetSerAxExtensionList(DXDC.SeriesAxis openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDC.SerAxExtensionList>();
    if (element != null)
      return DMXDC.SerAxExtensionListConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpSerAxExtensionList(DXDC.SeriesAxis openXmlElement, DMDC.SerAxExtensionList? value, DiffList? diffs, string? objName)
  {
    return DMXDC.SerAxExtensionListConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDC.SerAxExtensionList>(), value, diffs, objName);
  }
  
  private static void SetSerAxExtensionList(DXDC.SeriesAxis openXmlElement, DMDC.SerAxExtensionList? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDC.SerAxExtensionList>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDC.SerAxExtensionListConverter.CreateOpenXmlElement<DXDC.SerAxExtensionList>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  public static DocumentModel.Drawings.Charts.SeriesAxis? CreateModelElement(DXDC.SeriesAxis? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Charts.SeriesAxis();
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
  
  public static bool CompareModelElement(DXDC.SeriesAxis? openXmlElement, DMDC.SeriesAxis? value, DiffList? diffs, string? objName)
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
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDC.SeriesAxis value)
    where OpenXmlElementType: DXDC.SeriesAxis, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXDC.SeriesAxis openXmlElement, DMDC.SeriesAxis value)
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
    SetTickLabelSkip(openXmlElement, value?.TickLabelSkip);
    SetTickMarkSkip(openXmlElement, value?.TickMarkSkip);
    SetSerAxExtensionList(openXmlElement, value?.SerAxExtensionList);
  }
}
