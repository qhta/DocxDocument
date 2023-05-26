namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
/// Category Axis Data.
/// </summary>
public static class CategoryAxisConverter
{
  /// <summary>
  /// Axis ID.
  /// </summary>
  private static UInt32? GetAxisId(DXDC.CategoryAxis openXmlElement)
  {
    return SimpleValueConverter.GetValue(openXmlElement?.GetFirstChild<DXDC.AxisId>()?.Val);
  }
  
  private static bool CmpAxisId(DXDC.CategoryAxis openXmlElement, UInt32? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return SimpleValueConverter.CmpValue(openXmlElement?.GetFirstChild<DXDC.AxisId>()?.Val, value, diffs, objName, "AxisId");
  }
  
  private static void SetAxisId(DXDC.CategoryAxis openXmlElement, UInt32? value)
  {
    SimpleValueConverter.SetValue<DXDC.AxisId,System.UInt32>(openXmlElement, value);
  }
  
  /// <summary>
  /// Scaling.
  /// </summary>
  private static DMDC.Scaling? GetScaling(DXDC.CategoryAxis openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDC.Scaling>();
    if (element != null)
      return DMXDC.ScalingConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpScaling(DXDC.CategoryAxis openXmlElement, DMDC.Scaling? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXDC.ScalingConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDC.Scaling>(), value, diffs, objName, propName);
  }
  
  private static void SetScaling(DXDC.CategoryAxis openXmlElement, DMDC.Scaling? value)
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
  private static Boolean? GetDelete(DXDC.CategoryAxis openXmlElement)
  {
    return openXmlElement.GetFirstChild<DXDC.Delete>() != null;
  }
  
  private static bool CmpDelete(DXDC.CategoryAxis openXmlElement, Boolean? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    var val = openXmlElement.GetFirstChild<DXDC.Delete>() != null;
    if (val == value) return true;
    diffs?.Add(objName, "DXDC.Delete", val, value);
    return false;
  }
  
  private static void SetDelete(DXDC.CategoryAxis openXmlElement, Boolean? value)
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
  private static DMDC.AxisPositionKind? GetAxisPosition(DXDC.CategoryAxis openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.Charts.AxisPositionValues, DMDC.AxisPositionKind>(openXmlElement.GetFirstChild<DXDC.AxisPosition>()?.Val?.Value);
  }
  
  private static bool CmpAxisPosition(DXDC.CategoryAxis openXmlElement, DMDC.AxisPositionKind? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Drawing.Charts.AxisPositionValues, DMDC.AxisPositionKind>(openXmlElement.GetFirstChild<DXDC.AxisPosition>()?.Val?.Value, value, diffs, objName, propName);
  }
  
  private static void SetAxisPosition(DXDC.CategoryAxis openXmlElement, DMDC.AxisPositionKind? value)
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
  private static DMDC.MajorGridlines? GetMajorGridlines(DXDC.CategoryAxis openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDC.MajorGridlines>();
    if (element != null)
      return DMXDC.MajorGridlinesConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpMajorGridlines(DXDC.CategoryAxis openXmlElement, DMDC.MajorGridlines? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXDC.MajorGridlinesConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDC.MajorGridlines>(), value, diffs, objName, propName);
  }
  
  private static void SetMajorGridlines(DXDC.CategoryAxis openXmlElement, DMDC.MajorGridlines? value)
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
  private static DMDC.MinorGridlines? GetMinorGridlines(DXDC.CategoryAxis openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDC.MinorGridlines>();
    if (element != null)
      return DMXDC.MinorGridlinesConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpMinorGridlines(DXDC.CategoryAxis openXmlElement, DMDC.MinorGridlines? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXDC.MinorGridlinesConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDC.MinorGridlines>(), value, diffs, objName, propName);
  }
  
  private static void SetMinorGridlines(DXDC.CategoryAxis openXmlElement, DMDC.MinorGridlines? value)
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
  private static DMDC.Title? GetTitle(DXDC.CategoryAxis openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDC.Title>();
    if (element != null)
      return DMXDC.TitleConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpTitle(DXDC.CategoryAxis openXmlElement, DMDC.Title? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXDC.TitleConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDC.Title>(), value, diffs, objName, propName);
  }
  
  private static void SetTitle(DXDC.CategoryAxis openXmlElement, DMDC.Title? value)
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
  private static DMDC.NumberingFormat? GetNumberingFormat(DXDC.CategoryAxis openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDC.NumberingFormat>();
    if (element != null)
      return DMXDC.NumberingFormatConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpNumberingFormat(DXDC.CategoryAxis openXmlElement, DMDC.NumberingFormat? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXDC.NumberingFormatConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDC.NumberingFormat>(), value, diffs, objName, propName);
  }
  
  private static void SetNumberingFormat(DXDC.CategoryAxis openXmlElement, DMDC.NumberingFormat? value)
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
  private static DMDC.TickMarkKind? GetMajorTickMark(DXDC.CategoryAxis openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.Charts.TickMarkValues, DMDC.TickMarkKind>(openXmlElement.GetFirstChild<DXDC.MajorTickMark>()?.Val?.Value);
  }
  
  private static bool CmpMajorTickMark(DXDC.CategoryAxis openXmlElement, DMDC.TickMarkKind? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Drawing.Charts.TickMarkValues, DMDC.TickMarkKind>(openXmlElement.GetFirstChild<DXDC.MajorTickMark>()?.Val?.Value, value, diffs, objName, propName);
  }
  
  private static void SetMajorTickMark(DXDC.CategoryAxis openXmlElement, DMDC.TickMarkKind? value)
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
  private static DMDC.TickMarkKind? GetMinorTickMark(DXDC.CategoryAxis openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.Charts.TickMarkValues, DMDC.TickMarkKind>(openXmlElement.GetFirstChild<DXDC.MinorTickMark>()?.Val?.Value);
  }
  
  private static bool CmpMinorTickMark(DXDC.CategoryAxis openXmlElement, DMDC.TickMarkKind? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Drawing.Charts.TickMarkValues, DMDC.TickMarkKind>(openXmlElement.GetFirstChild<DXDC.MinorTickMark>()?.Val?.Value, value, diffs, objName, propName);
  }
  
  private static void SetMinorTickMark(DXDC.CategoryAxis openXmlElement, DMDC.TickMarkKind? value)
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
  private static DMDC.TickLabelPositionKind? GetTickLabelPosition(DXDC.CategoryAxis openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.Charts.TickLabelPositionValues, DMDC.TickLabelPositionKind>(openXmlElement.GetFirstChild<DXDC.TickLabelPosition>()?.Val?.Value);
  }
  
  private static bool CmpTickLabelPosition(DXDC.CategoryAxis openXmlElement, DMDC.TickLabelPositionKind? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Drawing.Charts.TickLabelPositionValues, DMDC.TickLabelPositionKind>(openXmlElement.GetFirstChild<DXDC.TickLabelPosition>()?.Val?.Value, value, diffs, objName, propName);
  }
  
  private static void SetTickLabelPosition(DXDC.CategoryAxis openXmlElement, DMDC.TickLabelPositionKind? value)
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
  private static DMDC.ChartShapeProperties? GetChartShapeProperties(DXDC.CategoryAxis openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDC.ChartShapeProperties>();
    if (element != null)
      return DMXDC.ChartShapePropertiesConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpChartShapeProperties(DXDC.CategoryAxis openXmlElement, DMDC.ChartShapeProperties? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXDC.ChartShapePropertiesConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDC.ChartShapeProperties>(), value, diffs, objName, propName);
  }
  
  private static void SetChartShapeProperties(DXDC.CategoryAxis openXmlElement, DMDC.ChartShapeProperties? value)
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
  private static DMDC.TextProperties? GetTextProperties(DXDC.CategoryAxis openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDC.TextProperties>();
    if (element != null)
      return DMXDC.TextPropertiesConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpTextProperties(DXDC.CategoryAxis openXmlElement, DMDC.TextProperties? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXDC.TextPropertiesConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDC.TextProperties>(), value, diffs, objName, propName);
  }
  
  private static void SetTextProperties(DXDC.CategoryAxis openXmlElement, DMDC.TextProperties? value)
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
  private static UInt32? GetCrossingAxis(DXDC.CategoryAxis openXmlElement)
  {
    return SimpleValueConverter.GetValue(openXmlElement?.GetFirstChild<DXDC.CrossingAxis>()?.Val);
  }
  
  private static bool CmpCrossingAxis(DXDC.CategoryAxis openXmlElement, UInt32? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return SimpleValueConverter.CmpValue(openXmlElement?.GetFirstChild<DXDC.CrossingAxis>()?.Val, value, diffs, objName, "CrossingAxis");
  }
  
  private static void SetCrossingAxis(DXDC.CategoryAxis openXmlElement, UInt32? value)
  {
    SimpleValueConverter.SetValue<DXDC.CrossingAxis,System.UInt32>(openXmlElement, value);
  }
  
  private static DMDC.CrossesKind? GetCrosses(DXDC.CategoryAxis openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.Charts.CrossesValues, DMDC.CrossesKind>(openXmlElement.GetFirstChild<DXDC.Crosses>()?.Val?.Value);
  }
  
  private static bool CmpCrosses(DXDC.CategoryAxis openXmlElement, DMDC.CrossesKind? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Drawing.Charts.CrossesValues, DMDC.CrossesKind>(openXmlElement.GetFirstChild<DXDC.Crosses>()?.Val?.Value, value, diffs, objName, propName);
  }
  
  private static void SetCrosses(DXDC.CategoryAxis openXmlElement, DMDC.CrossesKind? value)
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
  
  private static Double? GetCrossesAt(DXDC.CategoryAxis openXmlElement)
  {
    return SimpleValueConverter.GetValue(openXmlElement?.GetFirstChild<DXDC.CrossesAt>()?.Val);
  }
  
  private static bool CmpCrossesAt(DXDC.CategoryAxis openXmlElement, Double? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return SimpleValueConverter.CmpValue(openXmlElement?.GetFirstChild<DXDC.CrossesAt>()?.Val, value, diffs, objName, "CrossesAt");
  }
  
  private static void SetCrossesAt(DXDC.CategoryAxis openXmlElement, Double? value)
  {
    SimpleValueConverter.SetValue<DXDC.CrossesAt,System.Double>(openXmlElement, value);
  }
  
  private static Boolean? GetAutoLabeled(DXDC.CategoryAxis openXmlElement)
  {
    return openXmlElement.GetFirstChild<DXDC.AutoLabeled>() != null;
  }
  
  private static bool CmpAutoLabeled(DXDC.CategoryAxis openXmlElement, Boolean? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    var val = openXmlElement.GetFirstChild<DXDC.AutoLabeled>() != null;
    if (val == value) return true;
    diffs?.Add(objName, "DXDC.AutoLabeled", val, value);
    return false;
  }
  
  private static void SetAutoLabeled(DXDC.CategoryAxis openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DXDC.AutoLabeled>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DXDC.AutoLabeled();
      openXmlElement.AppendChild(itemElement);
    }
  }
  
  private static DMDC.LabelAlignmentKind? GetLabelAlignment(DXDC.CategoryAxis openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.Charts.LabelAlignmentValues, DMDC.LabelAlignmentKind>(openXmlElement.GetFirstChild<DXDC.LabelAlignment>()?.Val?.Value);
  }
  
  private static bool CmpLabelAlignment(DXDC.CategoryAxis openXmlElement, DMDC.LabelAlignmentKind? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Drawing.Charts.LabelAlignmentValues, DMDC.LabelAlignmentKind>(openXmlElement.GetFirstChild<DXDC.LabelAlignment>()?.Val?.Value, value, diffs, objName, propName);
  }
  
  private static void SetLabelAlignment(DXDC.CategoryAxis openXmlElement, DMDC.LabelAlignmentKind? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDC.LabelAlignment>();
    if (itemElement != null)
    {
      if (value != null)
        EnumValueConverter.UpdateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Charts.LabelAlignmentValues, DMDC.LabelAlignmentKind>(itemElement, (DMDC.LabelAlignmentKind)value);
      else
        itemElement.Remove();
    }
    else
    if (value != null)
      openXmlElement.AppendChild(EnumValueConverter.CreateOpenXmlElement<DXDC.LabelAlignment, DocumentFormat.OpenXml.Drawing.Charts.LabelAlignmentValues, DMDC.LabelAlignmentKind>((DMDC.LabelAlignmentKind)value));
  }
  
  private static UInt16? GetLabelOffset(DXDC.CategoryAxis openXmlElement)
  {
    return SimpleValueConverter.GetValue(openXmlElement?.GetFirstChild<DXDC.LabelOffset>()?.Val);
  }
  
  private static bool CmpLabelOffset(DXDC.CategoryAxis openXmlElement, UInt16? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return SimpleValueConverter.CmpValue(openXmlElement?.GetFirstChild<DXDC.LabelOffset>()?.Val, value, diffs, objName, "LabelOffset");
  }
  
  private static void SetLabelOffset(DXDC.CategoryAxis openXmlElement, UInt16? value)
  {
    SimpleValueConverter.SetValue<DXDC.LabelOffset,System.UInt16>(openXmlElement, value);
  }
  
  private static Int32? GetTickLabelSkip(DXDC.CategoryAxis openXmlElement)
  {
    return SimpleValueConverter.GetValue(openXmlElement?.GetFirstChild<DXDC.TickLabelSkip>()?.Val);
  }
  
  private static bool CmpTickLabelSkip(DXDC.CategoryAxis openXmlElement, Int32? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return SimpleValueConverter.CmpValue(openXmlElement?.GetFirstChild<DXDC.TickLabelSkip>()?.Val, value, diffs, objName, "TickLabelSkip");
  }
  
  private static void SetTickLabelSkip(DXDC.CategoryAxis openXmlElement, Int32? value)
  {
    SimpleValueConverter.SetValue<DXDC.TickLabelSkip,System.Int32>(openXmlElement, value);
  }
  
  private static Int32? GetTickMarkSkip(DXDC.CategoryAxis openXmlElement)
  {
    return SimpleValueConverter.GetValue(openXmlElement?.GetFirstChild<DXDC.TickMarkSkip>()?.Val);
  }
  
  private static bool CmpTickMarkSkip(DXDC.CategoryAxis openXmlElement, Int32? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return SimpleValueConverter.CmpValue(openXmlElement?.GetFirstChild<DXDC.TickMarkSkip>()?.Val, value, diffs, objName, "TickMarkSkip");
  }
  
  private static void SetTickMarkSkip(DXDC.CategoryAxis openXmlElement, Int32? value)
  {
    SimpleValueConverter.SetValue<DXDC.TickMarkSkip,System.Int32>(openXmlElement, value);
  }
  
  private static Boolean? GetNoMultiLevelLabels(DXDC.CategoryAxis openXmlElement)
  {
    return openXmlElement.GetFirstChild<DXDC.NoMultiLevelLabels>() != null;
  }
  
  private static bool CmpNoMultiLevelLabels(DXDC.CategoryAxis openXmlElement, Boolean? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    var val = openXmlElement.GetFirstChild<DXDC.NoMultiLevelLabels>() != null;
    if (val == value) return true;
    diffs?.Add(objName, "DXDC.NoMultiLevelLabels", val, value);
    return false;
  }
  
  private static void SetNoMultiLevelLabels(DXDC.CategoryAxis openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DXDC.NoMultiLevelLabels>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DXDC.NoMultiLevelLabels();
      openXmlElement.AppendChild(itemElement);
    }
  }
  
  private static DMDC.CatAxExtensionList? GetCatAxExtensionList(DXDC.CategoryAxis openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDC.CatAxExtensionList>();
    if (element != null)
      return DMXDC.CatAxExtensionListConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpCatAxExtensionList(DXDC.CategoryAxis openXmlElement, DMDC.CatAxExtensionList? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXDC.CatAxExtensionListConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDC.CatAxExtensionList>(), value, diffs, objName, propName);
  }
  
  private static void SetCatAxExtensionList(DXDC.CategoryAxis openXmlElement, DMDC.CatAxExtensionList? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDC.CatAxExtensionList>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDC.CatAxExtensionListConverter.CreateOpenXmlElement<DXDC.CatAxExtensionList>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  public static DocumentModel.Drawings.Charts.CategoryAxis? CreateModelElement(DXDC.CategoryAxis? openXmlElement)
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
  
  public static bool CompareModelElement(DXDC.CategoryAxis? openXmlElement, DMDC.CategoryAxis? value, DiffList? diffs = null, string? objName = null, string? propName = null)
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
      if (!CmpAutoLabeled(openXmlElement, value.AutoLabeled, diffs, objName, propName))
        ok = false;
      if (!CmpLabelAlignment(openXmlElement, value.LabelAlignment, diffs, objName, propName))
        ok = false;
      if (!CmpLabelOffset(openXmlElement, value.LabelOffset, diffs, objName, propName))
        ok = false;
      if (!CmpTickLabelSkip(openXmlElement, value.TickLabelSkip, diffs, objName, propName))
        ok = false;
      if (!CmpTickMarkSkip(openXmlElement, value.TickMarkSkip, diffs, objName, propName))
        ok = false;
      if (!CmpNoMultiLevelLabels(openXmlElement, value.NoMultiLevelLabels, diffs, objName, propName))
        ok = false;
      if (!CmpCatAxExtensionList(openXmlElement, value.CatAxExtensionList, diffs, objName, propName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDC.CategoryAxis value)
    where OpenXmlElementType: DXDC.CategoryAxis, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXDC.CategoryAxis openXmlElement, DMDC.CategoryAxis value)
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
