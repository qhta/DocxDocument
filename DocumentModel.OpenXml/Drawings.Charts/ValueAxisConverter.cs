namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
/// Value Axis.
/// </summary>
public static class ValueAxisConverter
{
  /// <summary>
  /// Axis ID.
  /// </summary>
  private static UInt32? GetAxisId(DXDC.ValueAxis openXmlElement)
  {
    return SimpleValueConverter.GetValue(openXmlElement?.GetFirstChild<DXDC.AxisId>()?.Val);
  }
  
  private static bool CmpAxisId(DXDC.ValueAxis openXmlElement, UInt32? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return SimpleValueConverter.CmpValue(openXmlElement?.GetFirstChild<DXDC.AxisId>()?.Val, value, diffs, objName, "AxisId");
  }
  
  private static void SetAxisId(DXDC.ValueAxis openXmlElement, UInt32? value)
  {
    SimpleValueConverter.SetValue<DXDC.AxisId,System.UInt32>(openXmlElement, value);
  }
  
  /// <summary>
  /// Scaling.
  /// </summary>
  private static DMDC.Scaling? GetScaling(DXDC.ValueAxis openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDC.Scaling>();
    if (element != null)
      return DMXDC.ScalingConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpScaling(DXDC.ValueAxis openXmlElement, DMDC.Scaling? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXDC.ScalingConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDC.Scaling>(), value, diffs, objName, propName);
  }
  
  private static void SetScaling(DXDC.ValueAxis openXmlElement, DMDC.Scaling? value)
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
  private static Boolean? GetDelete(DXDC.ValueAxis openXmlElement)
  {
    return openXmlElement.GetFirstChild<DXDC.Delete>() != null;
  }
  
  private static bool CmpDelete(DXDC.ValueAxis openXmlElement, Boolean? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    var val = openXmlElement.GetFirstChild<DXDC.Delete>() != null;
    if (val == value) return true;
    diffs?.Add(objName, "DXDC.Delete", val, value);
    return false;
  }
  
  private static void SetDelete(DXDC.ValueAxis openXmlElement, Boolean? value)
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
  private static DMDC.AxisPositionKind? GetAxisPosition(DXDC.ValueAxis openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.Charts.AxisPositionValues, DMDC.AxisPositionKind>(openXmlElement.GetFirstChild<DXDC.AxisPosition>()?.Val?.Value);
  }
  
  private static bool CmpAxisPosition(DXDC.ValueAxis openXmlElement, DMDC.AxisPositionKind? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Drawing.Charts.AxisPositionValues, DMDC.AxisPositionKind>(openXmlElement.GetFirstChild<DXDC.AxisPosition>()?.Val?.Value, value, diffs, objName, propName);
  }
  
  private static void SetAxisPosition(DXDC.ValueAxis openXmlElement, DMDC.AxisPositionKind? value)
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
  private static DMDC.MajorGridlines? GetMajorGridlines(DXDC.ValueAxis openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDC.MajorGridlines>();
    if (element != null)
      return DMXDC.MajorGridlinesConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpMajorGridlines(DXDC.ValueAxis openXmlElement, DMDC.MajorGridlines? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXDC.MajorGridlinesConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDC.MajorGridlines>(), value, diffs, objName, propName);
  }
  
  private static void SetMajorGridlines(DXDC.ValueAxis openXmlElement, DMDC.MajorGridlines? value)
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
  private static DMDC.MinorGridlines? GetMinorGridlines(DXDC.ValueAxis openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDC.MinorGridlines>();
    if (element != null)
      return DMXDC.MinorGridlinesConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpMinorGridlines(DXDC.ValueAxis openXmlElement, DMDC.MinorGridlines? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXDC.MinorGridlinesConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDC.MinorGridlines>(), value, diffs, objName, propName);
  }
  
  private static void SetMinorGridlines(DXDC.ValueAxis openXmlElement, DMDC.MinorGridlines? value)
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
  private static DMDC.Title? GetTitle(DXDC.ValueAxis openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDC.Title>();
    if (element != null)
      return DMXDC.TitleConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpTitle(DXDC.ValueAxis openXmlElement, DMDC.Title? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXDC.TitleConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDC.Title>(), value, diffs, objName, propName);
  }
  
  private static void SetTitle(DXDC.ValueAxis openXmlElement, DMDC.Title? value)
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
  private static DMDC.NumberingFormat? GetNumberingFormat(DXDC.ValueAxis openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDC.NumberingFormat>();
    if (element != null)
      return DMXDC.NumberingFormatConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpNumberingFormat(DXDC.ValueAxis openXmlElement, DMDC.NumberingFormat? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXDC.NumberingFormatConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDC.NumberingFormat>(), value, diffs, objName, propName);
  }
  
  private static void SetNumberingFormat(DXDC.ValueAxis openXmlElement, DMDC.NumberingFormat? value)
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
  private static DMDC.TickMarkKind? GetMajorTickMark(DXDC.ValueAxis openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.Charts.TickMarkValues, DMDC.TickMarkKind>(openXmlElement.GetFirstChild<DXDC.MajorTickMark>()?.Val?.Value);
  }
  
  private static bool CmpMajorTickMark(DXDC.ValueAxis openXmlElement, DMDC.TickMarkKind? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Drawing.Charts.TickMarkValues, DMDC.TickMarkKind>(openXmlElement.GetFirstChild<DXDC.MajorTickMark>()?.Val?.Value, value, diffs, objName, propName);
  }
  
  private static void SetMajorTickMark(DXDC.ValueAxis openXmlElement, DMDC.TickMarkKind? value)
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
  private static DMDC.TickMarkKind? GetMinorTickMark(DXDC.ValueAxis openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.Charts.TickMarkValues, DMDC.TickMarkKind>(openXmlElement.GetFirstChild<DXDC.MinorTickMark>()?.Val?.Value);
  }
  
  private static bool CmpMinorTickMark(DXDC.ValueAxis openXmlElement, DMDC.TickMarkKind? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Drawing.Charts.TickMarkValues, DMDC.TickMarkKind>(openXmlElement.GetFirstChild<DXDC.MinorTickMark>()?.Val?.Value, value, diffs, objName, propName);
  }
  
  private static void SetMinorTickMark(DXDC.ValueAxis openXmlElement, DMDC.TickMarkKind? value)
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
  private static DMDC.TickLabelPositionKind? GetTickLabelPosition(DXDC.ValueAxis openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.Charts.TickLabelPositionValues, DMDC.TickLabelPositionKind>(openXmlElement.GetFirstChild<DXDC.TickLabelPosition>()?.Val?.Value);
  }
  
  private static bool CmpTickLabelPosition(DXDC.ValueAxis openXmlElement, DMDC.TickLabelPositionKind? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Drawing.Charts.TickLabelPositionValues, DMDC.TickLabelPositionKind>(openXmlElement.GetFirstChild<DXDC.TickLabelPosition>()?.Val?.Value, value, diffs, objName, propName);
  }
  
  private static void SetTickLabelPosition(DXDC.ValueAxis openXmlElement, DMDC.TickLabelPositionKind? value)
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
  private static DMDC.ChartShapeProperties? GetChartShapeProperties(DXDC.ValueAxis openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDC.ChartShapeProperties>();
    if (element != null)
      return DMXDC.ChartShapePropertiesConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpChartShapeProperties(DXDC.ValueAxis openXmlElement, DMDC.ChartShapeProperties? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXDC.ChartShapePropertiesConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDC.ChartShapeProperties>(), value, diffs, objName, propName);
  }
  
  private static void SetChartShapeProperties(DXDC.ValueAxis openXmlElement, DMDC.ChartShapeProperties? value)
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
  private static DMDC.TextProperties? GetTextProperties(DXDC.ValueAxis openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDC.TextProperties>();
    if (element != null)
      return DMXDC.TextPropertiesConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpTextProperties(DXDC.ValueAxis openXmlElement, DMDC.TextProperties? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXDC.TextPropertiesConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDC.TextProperties>(), value, diffs, objName, propName);
  }
  
  private static void SetTextProperties(DXDC.ValueAxis openXmlElement, DMDC.TextProperties? value)
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
  private static UInt32? GetCrossingAxis(DXDC.ValueAxis openXmlElement)
  {
    return SimpleValueConverter.GetValue(openXmlElement?.GetFirstChild<DXDC.CrossingAxis>()?.Val);
  }
  
  private static bool CmpCrossingAxis(DXDC.ValueAxis openXmlElement, UInt32? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return SimpleValueConverter.CmpValue(openXmlElement?.GetFirstChild<DXDC.CrossingAxis>()?.Val, value, diffs, objName, "CrossingAxis");
  }
  
  private static void SetCrossingAxis(DXDC.ValueAxis openXmlElement, UInt32? value)
  {
    SimpleValueConverter.SetValue<DXDC.CrossingAxis,System.UInt32>(openXmlElement, value);
  }
  
  private static DMDC.CrossesKind? GetCrosses(DXDC.ValueAxis openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.Charts.CrossesValues, DMDC.CrossesKind>(openXmlElement.GetFirstChild<DXDC.Crosses>()?.Val?.Value);
  }
  
  private static bool CmpCrosses(DXDC.ValueAxis openXmlElement, DMDC.CrossesKind? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Drawing.Charts.CrossesValues, DMDC.CrossesKind>(openXmlElement.GetFirstChild<DXDC.Crosses>()?.Val?.Value, value, diffs, objName, propName);
  }
  
  private static void SetCrosses(DXDC.ValueAxis openXmlElement, DMDC.CrossesKind? value)
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
  
  private static Double? GetCrossesAt(DXDC.ValueAxis openXmlElement)
  {
    return SimpleValueConverter.GetValue(openXmlElement?.GetFirstChild<DXDC.CrossesAt>()?.Val);
  }
  
  private static bool CmpCrossesAt(DXDC.ValueAxis openXmlElement, Double? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return SimpleValueConverter.CmpValue(openXmlElement?.GetFirstChild<DXDC.CrossesAt>()?.Val, value, diffs, objName, "CrossesAt");
  }
  
  private static void SetCrossesAt(DXDC.ValueAxis openXmlElement, Double? value)
  {
    SimpleValueConverter.SetValue<DXDC.CrossesAt,System.Double>(openXmlElement, value);
  }
  
  private static DMDC.CrossBetweenKind? GetCrossBetween(DXDC.ValueAxis openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.Charts.CrossBetweenValues, DMDC.CrossBetweenKind>(openXmlElement.GetFirstChild<DXDC.CrossBetween>()?.Val?.Value);
  }
  
  private static bool CmpCrossBetween(DXDC.ValueAxis openXmlElement, DMDC.CrossBetweenKind? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Drawing.Charts.CrossBetweenValues, DMDC.CrossBetweenKind>(openXmlElement.GetFirstChild<DXDC.CrossBetween>()?.Val?.Value, value, diffs, objName, propName);
  }
  
  private static void SetCrossBetween(DXDC.ValueAxis openXmlElement, DMDC.CrossBetweenKind? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDC.CrossBetween>();
    if (itemElement != null)
    {
      if (value != null)
        EnumValueConverter.UpdateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Charts.CrossBetweenValues, DMDC.CrossBetweenKind>(itemElement, (DMDC.CrossBetweenKind)value);
      else
        itemElement.Remove();
    }
    else
    if (value != null)
      openXmlElement.AppendChild(EnumValueConverter.CreateOpenXmlElement<DXDC.CrossBetween, DocumentFormat.OpenXml.Drawing.Charts.CrossBetweenValues, DMDC.CrossBetweenKind>((DMDC.CrossBetweenKind)value));
  }
  
  private static Double? GetMajorUnit(DXDC.ValueAxis openXmlElement)
  {
    return SimpleValueConverter.GetValue(openXmlElement?.GetFirstChild<DXDC.MajorUnit>()?.Val);
  }
  
  private static bool CmpMajorUnit(DXDC.ValueAxis openXmlElement, Double? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return SimpleValueConverter.CmpValue(openXmlElement?.GetFirstChild<DXDC.MajorUnit>()?.Val, value, diffs, objName, "MajorUnit");
  }
  
  private static void SetMajorUnit(DXDC.ValueAxis openXmlElement, Double? value)
  {
    SimpleValueConverter.SetValue<DXDC.MajorUnit,System.Double>(openXmlElement, value);
  }
  
  private static Double? GetMinorUnit(DXDC.ValueAxis openXmlElement)
  {
    return SimpleValueConverter.GetValue(openXmlElement?.GetFirstChild<DXDC.MinorUnit>()?.Val);
  }
  
  private static bool CmpMinorUnit(DXDC.ValueAxis openXmlElement, Double? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return SimpleValueConverter.CmpValue(openXmlElement?.GetFirstChild<DXDC.MinorUnit>()?.Val, value, diffs, objName, "MinorUnit");
  }
  
  private static void SetMinorUnit(DXDC.ValueAxis openXmlElement, Double? value)
  {
    SimpleValueConverter.SetValue<DXDC.MinorUnit,System.Double>(openXmlElement, value);
  }
  
  private static DMDC.DisplayUnits? GetDisplayUnits(DXDC.ValueAxis openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDC.DisplayUnits>();
    if (element != null)
      return DMXDC.DisplayUnitsConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpDisplayUnits(DXDC.ValueAxis openXmlElement, DMDC.DisplayUnits? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXDC.DisplayUnitsConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDC.DisplayUnits>(), value, diffs, objName, propName);
  }
  
  private static void SetDisplayUnits(DXDC.ValueAxis openXmlElement, DMDC.DisplayUnits? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDC.DisplayUnits>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDC.DisplayUnitsConverter.CreateOpenXmlElement<DXDC.DisplayUnits>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  private static DMDC.ValAxExtensionList? GetValAxExtensionList(DXDC.ValueAxis openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDC.ValAxExtensionList>();
    if (element != null)
      return DMXDC.ValAxExtensionListConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpValAxExtensionList(DXDC.ValueAxis openXmlElement, DMDC.ValAxExtensionList? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXDC.ValAxExtensionListConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDC.ValAxExtensionList>(), value, diffs, objName, propName);
  }
  
  private static void SetValAxExtensionList(DXDC.ValueAxis openXmlElement, DMDC.ValAxExtensionList? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDC.ValAxExtensionList>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDC.ValAxExtensionListConverter.CreateOpenXmlElement<DXDC.ValAxExtensionList>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  public static DMD.Charts.ValueAxis? CreateModelElement(DXDC.ValueAxis? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMD.Charts.ValueAxis();
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
  
  public static bool CompareModelElement(DXDC.ValueAxis? openXmlElement, DMDC.ValueAxis? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpAxisId(openXmlElement, value.AxisId, diffs, objName, propName))
        ok = false;
      if (!CmpScaling(openXmlElement, value.Scaling, diffs, objName, propName))
        ok = false;
      if (!CmpDelete(openXmlElement, value.Delete, diffs, objName, propName))
        ok = false;
      if (!CmpAxisPosition(openXmlElement, value.AxisPosition, diffs, objName, propName))
        ok = false;
      if (!CmpMajorGridlines(openXmlElement, value.MajorGridlines, diffs, objName, propName))
        ok = false;
      if (!CmpMinorGridlines(openXmlElement, value.MinorGridlines, diffs, objName, propName))
        ok = false;
      if (!CmpTitle(openXmlElement, value.Title, diffs, objName, propName))
        ok = false;
      if (!CmpNumberingFormat(openXmlElement, value.NumberingFormat, diffs, objName, propName))
        ok = false;
      if (!CmpMajorTickMark(openXmlElement, value.MajorTickMark, diffs, objName, propName))
        ok = false;
      if (!CmpMinorTickMark(openXmlElement, value.MinorTickMark, diffs, objName, propName))
        ok = false;
      if (!CmpTickLabelPosition(openXmlElement, value.TickLabelPosition, diffs, objName, propName))
        ok = false;
      if (!CmpChartShapeProperties(openXmlElement, value.ChartShapeProperties, diffs, objName, propName))
        ok = false;
      if (!CmpTextProperties(openXmlElement, value.TextProperties, diffs, objName, propName))
        ok = false;
      if (!CmpCrossingAxis(openXmlElement, value.CrossingAxis, diffs, objName, propName))
        ok = false;
      if (!CmpCrosses(openXmlElement, value.Crosses, diffs, objName, propName))
        ok = false;
      if (!CmpCrossesAt(openXmlElement, value.CrossesAt, diffs, objName, propName))
        ok = false;
      if (!CmpCrossBetween(openXmlElement, value.CrossBetween, diffs, objName, propName))
        ok = false;
      if (!CmpMajorUnit(openXmlElement, value.MajorUnit, diffs, objName, propName))
        ok = false;
      if (!CmpMinorUnit(openXmlElement, value.MinorUnit, diffs, objName, propName))
        ok = false;
      if (!CmpDisplayUnits(openXmlElement, value.DisplayUnits, diffs, objName, propName))
        ok = false;
      if (!CmpValAxExtensionList(openXmlElement, value.ValAxExtensionList, diffs, objName, propName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDC.ValueAxis value)
    where OpenXmlElementType: DXDC.ValueAxis, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXDC.ValueAxis openXmlElement, DMDC.ValueAxis value)
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
