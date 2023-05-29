namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
/// Category Axis Data.
/// </summary>
public static class CategoryAxisConverter
{
  /// <summary>
  /// Axis ID.
  /// </summary>
  private static UInt32? GetAxisId(DXDrawCharts.CategoryAxis openXmlElement)
  {
    return SimpleValueConverter.GetValue(openXmlElement?.GetFirstChild<DXDrawCharts.AxisId>()?.Val);
  }
  
  private static bool CmpAxisId(DXDrawCharts.CategoryAxis openXmlElement, UInt32? value, DiffList? diffs, string? objName)
  {
    return SimpleValueConverter.CmpValue(openXmlElement?.GetFirstChild<DXDrawCharts.AxisId>()?.Val, value, diffs, objName, "AxisId");
  }
  
  private static void SetAxisId(DXDrawCharts.CategoryAxis openXmlElement, UInt32? value)
  {
    SimpleValueConverter.SetValue<DXDrawCharts.AxisId,System.UInt32>(openXmlElement, value);
  }
  
  /// <summary>
  /// Scaling.
  /// </summary>
  private static DMDrawsCharts.Scaling? GetScaling(DXDrawCharts.CategoryAxis openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDrawCharts.Scaling>();
    if (element != null)
      return DMXDrawsCharts.ScalingConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpScaling(DXDrawCharts.CategoryAxis openXmlElement, DMDrawsCharts.Scaling? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsCharts.ScalingConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDrawCharts.Scaling>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetScaling(DXDrawCharts.CategoryAxis openXmlElement, DMDrawsCharts.Scaling? value)
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
  private static Boolean? GetDelete(DXDrawCharts.CategoryAxis openXmlElement)
  {
    return openXmlElement.GetFirstChild<DXDrawCharts.Delete>() != null;
  }
  
  private static bool CmpDelete(DXDrawCharts.CategoryAxis openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    var val = openXmlElement.GetFirstChild<DXDrawCharts.Delete>() != null;
    if (val == value) return true;
    diffs?.Add(objName, "DXDrawCharts.Delete", val, value);
    return false;
  }
  
  private static void SetDelete(DXDrawCharts.CategoryAxis openXmlElement, Boolean? value)
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
  private static DMDrawsCharts.AxisPositionKind? GetAxisPosition(DXDrawCharts.CategoryAxis openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.Charts.AxisPositionValues, DMDrawsCharts.AxisPositionKind>(openXmlElement.GetFirstChild<DXDrawCharts.AxisPosition>()?.Val?.Value);
  }
  
  private static bool CmpAxisPosition(DXDrawCharts.CategoryAxis openXmlElement, DMDrawsCharts.AxisPositionKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Drawing.Charts.AxisPositionValues, DMDrawsCharts.AxisPositionKind>(openXmlElement.GetFirstChild<DXDrawCharts.AxisPosition>()?.Val?.Value, value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetAxisPosition(DXDrawCharts.CategoryAxis openXmlElement, DMDrawsCharts.AxisPositionKind? value)
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
  private static DMDrawsCharts.MajorGridlines? GetMajorGridlines(DXDrawCharts.CategoryAxis openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDrawCharts.MajorGridlines>();
    if (element != null)
      return DMXDrawsCharts.MajorGridlinesConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpMajorGridlines(DXDrawCharts.CategoryAxis openXmlElement, DMDrawsCharts.MajorGridlines? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsCharts.MajorGridlinesConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDrawCharts.MajorGridlines>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetMajorGridlines(DXDrawCharts.CategoryAxis openXmlElement, DMDrawsCharts.MajorGridlines? value)
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
  private static DMDrawsCharts.MinorGridlines? GetMinorGridlines(DXDrawCharts.CategoryAxis openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDrawCharts.MinorGridlines>();
    if (element != null)
      return DMXDrawsCharts.MinorGridlinesConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpMinorGridlines(DXDrawCharts.CategoryAxis openXmlElement, DMDrawsCharts.MinorGridlines? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsCharts.MinorGridlinesConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDrawCharts.MinorGridlines>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetMinorGridlines(DXDrawCharts.CategoryAxis openXmlElement, DMDrawsCharts.MinorGridlines? value)
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
  private static DMDrawsCharts.Title? GetTitle(DXDrawCharts.CategoryAxis openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDrawCharts.Title>();
    if (element != null)
      return DMXDrawsCharts.TitleConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpTitle(DXDrawCharts.CategoryAxis openXmlElement, DMDrawsCharts.Title? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsCharts.TitleConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDrawCharts.Title>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetTitle(DXDrawCharts.CategoryAxis openXmlElement, DMDrawsCharts.Title? value)
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
  private static DMDrawsCharts.NumberingFormat? GetNumberingFormat(DXDrawCharts.CategoryAxis openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDrawCharts.NumberingFormat>();
    if (element != null)
      return DMXDrawsCharts.NumberingFormatConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpNumberingFormat(DXDrawCharts.CategoryAxis openXmlElement, DMDrawsCharts.NumberingFormat? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsCharts.NumberingFormatConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDrawCharts.NumberingFormat>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetNumberingFormat(DXDrawCharts.CategoryAxis openXmlElement, DMDrawsCharts.NumberingFormat? value)
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
  private static DMDrawsCharts.TickMarkKind? GetMajorTickMark(DXDrawCharts.CategoryAxis openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.Charts.TickMarkValues, DMDrawsCharts.TickMarkKind>(openXmlElement.GetFirstChild<DXDrawCharts.MajorTickMark>()?.Val?.Value);
  }
  
  private static bool CmpMajorTickMark(DXDrawCharts.CategoryAxis openXmlElement, DMDrawsCharts.TickMarkKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Drawing.Charts.TickMarkValues, DMDrawsCharts.TickMarkKind>(openXmlElement.GetFirstChild<DXDrawCharts.MajorTickMark>()?.Val?.Value, value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetMajorTickMark(DXDrawCharts.CategoryAxis openXmlElement, DMDrawsCharts.TickMarkKind? value)
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
  private static DMDrawsCharts.TickMarkKind? GetMinorTickMark(DXDrawCharts.CategoryAxis openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.Charts.TickMarkValues, DMDrawsCharts.TickMarkKind>(openXmlElement.GetFirstChild<DXDrawCharts.MinorTickMark>()?.Val?.Value);
  }
  
  private static bool CmpMinorTickMark(DXDrawCharts.CategoryAxis openXmlElement, DMDrawsCharts.TickMarkKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Drawing.Charts.TickMarkValues, DMDrawsCharts.TickMarkKind>(openXmlElement.GetFirstChild<DXDrawCharts.MinorTickMark>()?.Val?.Value, value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetMinorTickMark(DXDrawCharts.CategoryAxis openXmlElement, DMDrawsCharts.TickMarkKind? value)
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
  private static DMDrawsCharts.TickLabelPositionKind? GetTickLabelPosition(DXDrawCharts.CategoryAxis openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.Charts.TickLabelPositionValues, DMDrawsCharts.TickLabelPositionKind>(openXmlElement.GetFirstChild<DXDrawCharts.TickLabelPosition>()?.Val?.Value);
  }
  
  private static bool CmpTickLabelPosition(DXDrawCharts.CategoryAxis openXmlElement, DMDrawsCharts.TickLabelPositionKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Drawing.Charts.TickLabelPositionValues, DMDrawsCharts.TickLabelPositionKind>(openXmlElement.GetFirstChild<DXDrawCharts.TickLabelPosition>()?.Val?.Value, value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetTickLabelPosition(DXDrawCharts.CategoryAxis openXmlElement, DMDrawsCharts.TickLabelPositionKind? value)
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
  private static DMDrawsCharts.ChartShapeProperties? GetChartShapeProperties(DXDrawCharts.CategoryAxis openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDrawCharts.ChartShapeProperties>();
    if (element != null)
      return DMXDrawsCharts.ChartShapePropertiesConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpChartShapeProperties(DXDrawCharts.CategoryAxis openXmlElement, DMDrawsCharts.ChartShapeProperties? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsCharts.ChartShapePropertiesConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDrawCharts.ChartShapeProperties>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetChartShapeProperties(DXDrawCharts.CategoryAxis openXmlElement, DMDrawsCharts.ChartShapeProperties? value)
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
  private static DMDrawsCharts.TextProperties? GetTextProperties(DXDrawCharts.CategoryAxis openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDrawCharts.TextProperties>();
    if (element != null)
      return DMXDrawsCharts.TextPropertiesConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpTextProperties(DXDrawCharts.CategoryAxis openXmlElement, DMDrawsCharts.TextProperties? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsCharts.TextPropertiesConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDrawCharts.TextProperties>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetTextProperties(DXDrawCharts.CategoryAxis openXmlElement, DMDrawsCharts.TextProperties? value)
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
  private static UInt32? GetCrossingAxis(DXDrawCharts.CategoryAxis openXmlElement)
  {
    return SimpleValueConverter.GetValue(openXmlElement?.GetFirstChild<DXDrawCharts.CrossingAxis>()?.Val);
  }
  
  private static bool CmpCrossingAxis(DXDrawCharts.CategoryAxis openXmlElement, UInt32? value, DiffList? diffs, string? objName)
  {
    return SimpleValueConverter.CmpValue(openXmlElement?.GetFirstChild<DXDrawCharts.CrossingAxis>()?.Val, value, diffs, objName, "CrossingAxis");
  }
  
  private static void SetCrossingAxis(DXDrawCharts.CategoryAxis openXmlElement, UInt32? value)
  {
    SimpleValueConverter.SetValue<DXDrawCharts.CrossingAxis,System.UInt32>(openXmlElement, value);
  }
  
  private static DMDrawsCharts.CrossesKind? GetCrosses(DXDrawCharts.CategoryAxis openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.Charts.CrossesValues, DMDrawsCharts.CrossesKind>(openXmlElement.GetFirstChild<DXDrawCharts.Crosses>()?.Val?.Value);
  }
  
  private static bool CmpCrosses(DXDrawCharts.CategoryAxis openXmlElement, DMDrawsCharts.CrossesKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Drawing.Charts.CrossesValues, DMDrawsCharts.CrossesKind>(openXmlElement.GetFirstChild<DXDrawCharts.Crosses>()?.Val?.Value, value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetCrosses(DXDrawCharts.CategoryAxis openXmlElement, DMDrawsCharts.CrossesKind? value)
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
  
  private static Double? GetCrossesAt(DXDrawCharts.CategoryAxis openXmlElement)
  {
    return SimpleValueConverter.GetValue(openXmlElement?.GetFirstChild<DXDrawCharts.CrossesAt>()?.Val);
  }
  
  private static bool CmpCrossesAt(DXDrawCharts.CategoryAxis openXmlElement, Double? value, DiffList? diffs, string? objName)
  {
    return SimpleValueConverter.CmpValue(openXmlElement?.GetFirstChild<DXDrawCharts.CrossesAt>()?.Val, value, diffs, objName, "CrossesAt");
  }
  
  private static void SetCrossesAt(DXDrawCharts.CategoryAxis openXmlElement, Double? value)
  {
    SimpleValueConverter.SetValue<DXDrawCharts.CrossesAt,System.Double>(openXmlElement, value);
  }
  
  private static Boolean? GetAutoLabeled(DXDrawCharts.CategoryAxis openXmlElement)
  {
    return openXmlElement.GetFirstChild<DXDrawCharts.AutoLabeled>() != null;
  }
  
  private static bool CmpAutoLabeled(DXDrawCharts.CategoryAxis openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    var val = openXmlElement.GetFirstChild<DXDrawCharts.AutoLabeled>() != null;
    if (val == value) return true;
    diffs?.Add(objName, "DXDrawCharts.AutoLabeled", val, value);
    return false;
  }
  
  private static void SetAutoLabeled(DXDrawCharts.CategoryAxis openXmlElement, Boolean? value)
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
  
  private static DMDrawsCharts.LabelAlignmentKind? GetLabelAlignment(DXDrawCharts.CategoryAxis openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.Charts.LabelAlignmentValues, DMDrawsCharts.LabelAlignmentKind>(openXmlElement.GetFirstChild<DXDrawCharts.LabelAlignment>()?.Val?.Value);
  }
  
  private static bool CmpLabelAlignment(DXDrawCharts.CategoryAxis openXmlElement, DMDrawsCharts.LabelAlignmentKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Drawing.Charts.LabelAlignmentValues, DMDrawsCharts.LabelAlignmentKind>(openXmlElement.GetFirstChild<DXDrawCharts.LabelAlignment>()?.Val?.Value, value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetLabelAlignment(DXDrawCharts.CategoryAxis openXmlElement, DMDrawsCharts.LabelAlignmentKind? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDrawCharts.LabelAlignment>();
    if (itemElement != null)
    {
      if (value != null)
        EnumValueConverter.UpdateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Charts.LabelAlignmentValues, DMDrawsCharts.LabelAlignmentKind>(itemElement, (DMDrawsCharts.LabelAlignmentKind)value);
      else
        itemElement.Remove();
    }
    else
    if (value != null)
      openXmlElement.AddChild(EnumValueConverter.CreateOpenXmlElement<DXDrawCharts.LabelAlignment, DocumentFormat.OpenXml.Drawing.Charts.LabelAlignmentValues, DMDrawsCharts.LabelAlignmentKind>((DMDrawsCharts.LabelAlignmentKind)value));
  }
  
  private static UInt16? GetLabelOffset(DXDrawCharts.CategoryAxis openXmlElement)
  {
    return SimpleValueConverter.GetValue(openXmlElement?.GetFirstChild<DXDrawCharts.LabelOffset>()?.Val);
  }
  
  private static bool CmpLabelOffset(DXDrawCharts.CategoryAxis openXmlElement, UInt16? value, DiffList? diffs, string? objName)
  {
    return SimpleValueConverter.CmpValue(openXmlElement?.GetFirstChild<DXDrawCharts.LabelOffset>()?.Val, value, diffs, objName, "LabelOffset");
  }
  
  private static void SetLabelOffset(DXDrawCharts.CategoryAxis openXmlElement, UInt16? value)
  {
    SimpleValueConverter.SetValue<DXDrawCharts.LabelOffset,System.UInt16>(openXmlElement, value);
  }
  
  private static Int32? GetTickLabelSkip(DXDrawCharts.CategoryAxis openXmlElement)
  {
    return SimpleValueConverter.GetValue(openXmlElement?.GetFirstChild<DXDrawCharts.TickLabelSkip>()?.Val);
  }
  
  private static bool CmpTickLabelSkip(DXDrawCharts.CategoryAxis openXmlElement, Int32? value, DiffList? diffs, string? objName)
  {
    return SimpleValueConverter.CmpValue(openXmlElement?.GetFirstChild<DXDrawCharts.TickLabelSkip>()?.Val, value, diffs, objName, "TickLabelSkip");
  }
  
  private static void SetTickLabelSkip(DXDrawCharts.CategoryAxis openXmlElement, Int32? value)
  {
    SimpleValueConverter.SetValue<DXDrawCharts.TickLabelSkip,System.Int32>(openXmlElement, value);
  }
  
  private static Int32? GetTickMarkSkip(DXDrawCharts.CategoryAxis openXmlElement)
  {
    return SimpleValueConverter.GetValue(openXmlElement?.GetFirstChild<DXDrawCharts.TickMarkSkip>()?.Val);
  }
  
  private static bool CmpTickMarkSkip(DXDrawCharts.CategoryAxis openXmlElement, Int32? value, DiffList? diffs, string? objName)
  {
    return SimpleValueConverter.CmpValue(openXmlElement?.GetFirstChild<DXDrawCharts.TickMarkSkip>()?.Val, value, diffs, objName, "TickMarkSkip");
  }
  
  private static void SetTickMarkSkip(DXDrawCharts.CategoryAxis openXmlElement, Int32? value)
  {
    SimpleValueConverter.SetValue<DXDrawCharts.TickMarkSkip,System.Int32>(openXmlElement, value);
  }
  
  private static Boolean? GetNoMultiLevelLabels(DXDrawCharts.CategoryAxis openXmlElement)
  {
    return openXmlElement.GetFirstChild<DXDrawCharts.NoMultiLevelLabels>() != null;
  }
  
  private static bool CmpNoMultiLevelLabels(DXDrawCharts.CategoryAxis openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    var val = openXmlElement.GetFirstChild<DXDrawCharts.NoMultiLevelLabels>() != null;
    if (val == value) return true;
    diffs?.Add(objName, "DXDrawCharts.NoMultiLevelLabels", val, value);
    return false;
  }
  
  private static void SetNoMultiLevelLabels(DXDrawCharts.CategoryAxis openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DXDrawCharts.NoMultiLevelLabels>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DXDrawCharts.NoMultiLevelLabels();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMDrawsCharts.CatAxExtensionList? GetCatAxExtensionList(DXDrawCharts.CategoryAxis openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDrawCharts.CatAxExtensionList>();
    if (element != null)
      return DMXDrawsCharts.CatAxExtensionListConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpCatAxExtensionList(DXDrawCharts.CategoryAxis openXmlElement, DMDrawsCharts.CatAxExtensionList? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsCharts.CatAxExtensionListConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDrawCharts.CatAxExtensionList>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetCatAxExtensionList(DXDrawCharts.CategoryAxis openXmlElement, DMDrawsCharts.CatAxExtensionList? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDrawCharts.CatAxExtensionList>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDrawsCharts.CatAxExtensionListConverter.CreateOpenXmlElement<DXDrawCharts.CatAxExtensionList>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DocumentModel.Drawings.Charts.CategoryAxis? CreateModelElement(DXDrawCharts.CategoryAxis? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Charts.CategoryAxis();
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
      value.LabelAlignment = GetLabelAlignment(openXmlElement);
      value.LabelOffset = GetLabelOffset(openXmlElement);
      value.TickLabelSkip = GetTickLabelSkip(openXmlElement);
      value.TickMarkSkip = GetTickMarkSkip(openXmlElement);
      value.NoMultiLevelLabels = GetNoMultiLevelLabels(openXmlElement);
      value.CatAxExtensionList = GetCatAxExtensionList(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXDrawCharts.CategoryAxis? openXmlElement, DMDrawsCharts.CategoryAxis? value, DiffList? diffs, string? objName)
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
      if (!CmpLabelAlignment(openXmlElement, value.LabelAlignment, diffs, objName))
        ok = false;
      if (!CmpLabelOffset(openXmlElement, value.LabelOffset, diffs, objName))
        ok = false;
      if (!CmpTickLabelSkip(openXmlElement, value.TickLabelSkip, diffs, objName))
        ok = false;
      if (!CmpTickMarkSkip(openXmlElement, value.TickMarkSkip, diffs, objName))
        ok = false;
      if (!CmpNoMultiLevelLabels(openXmlElement, value.NoMultiLevelLabels, diffs, objName))
        ok = false;
      if (!CmpCatAxExtensionList(openXmlElement, value.CatAxExtensionList, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDrawsCharts.CategoryAxis value)
    where OpenXmlElementType: DXDrawCharts.CategoryAxis, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXDrawCharts.CategoryAxis openXmlElement, DMDrawsCharts.CategoryAxis value)
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
    SetLabelAlignment(openXmlElement, value?.LabelAlignment);
    SetLabelOffset(openXmlElement, value?.LabelOffset);
    SetTickLabelSkip(openXmlElement, value?.TickLabelSkip);
    SetTickMarkSkip(openXmlElement, value?.TickMarkSkip);
    SetNoMultiLevelLabels(openXmlElement, value?.NoMultiLevelLabels);
    SetCatAxExtensionList(openXmlElement, value?.CatAxExtensionList);
  }
}
