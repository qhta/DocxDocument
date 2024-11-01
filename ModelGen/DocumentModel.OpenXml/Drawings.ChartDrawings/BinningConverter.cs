namespace DocumentModel.OpenXml.Drawings.ChartDrawings;

/// <summary>
/// Defines the Binning Class.
/// </summary>
public static class BinningConverter
{
  /// <summary>
  /// intervalClosed, this property is only available in Office 2016 and later.
  /// </summary>
  private static DMDrawsChartDraws.IntervalClosedSide? GetIntervalClosed(DXO2016DrawChartDraw.Binning openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.IntervalClosedSide, DMDrawsChartDraws.IntervalClosedSide>(openXmlElement?.IntervalClosed?.Value);
  }
  
  private static bool CmpIntervalClosed(DXO2016DrawChartDraw.Binning openXmlElement, DMDrawsChartDraws.IntervalClosedSide? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.IntervalClosedSide, DMDrawsChartDraws.IntervalClosedSide>(openXmlElement?.IntervalClosed?.Value, value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetIntervalClosed(DXO2016DrawChartDraw.Binning openXmlElement, DMDrawsChartDraws.IntervalClosedSide? value)
  {
    openXmlElement.IntervalClosed = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.IntervalClosedSide, DMDrawsChartDraws.IntervalClosedSide>(value);
  }
  
  /// <summary>
  /// underflow, this property is only available in Office 2016 and later.
  /// </summary>
  private static String? GetUnderflow(DXO2016DrawChartDraw.Binning openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Underflow);
  }
  
  private static bool CmpUnderflow(DXO2016DrawChartDraw.Binning openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Underflow, value, diffs, objName, "Underflow");
  }
  
  private static void SetUnderflow(DXO2016DrawChartDraw.Binning openXmlElement, String? value)
  {
    openXmlElement.Underflow = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// overflow, this property is only available in Office 2016 and later.
  /// </summary>
  private static String? GetOverflow(DXO2016DrawChartDraw.Binning openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Overflow);
  }
  
  private static bool CmpOverflow(DXO2016DrawChartDraw.Binning openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Overflow, value, diffs, objName, "Overflow");
  }
  
  private static void SetOverflow(DXO2016DrawChartDraw.Binning openXmlElement, String? value)
  {
    openXmlElement.Overflow = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// Xsddouble.
  /// </summary>
  private static String? GetXsddouble(DXO2016DrawChartDraw.Binning openXmlElement)
  {
      return openXmlElement?.GetFirstChild<DXO2016DrawChartDraw.Xsddouble>()?.Text;
  }
  
  private static bool CmpXsddouble(DXO2016DrawChartDraw.Binning openXmlElement, String? value, DiffList? diffs, string? objName)
  {
      return openXmlElement?.GetFirstChild<DXO2016DrawChartDraw.Xsddouble>()?.Text == value;
  }
  
  private static void SetXsddouble(DXO2016DrawChartDraw.Binning openXmlElement, String? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO2016DrawChartDraw.Xsddouble>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DXO2016DrawChartDraw.Xsddouble { Text = value };
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// BinCountXsdunsignedInt.
  /// </summary>
  private static String? GetBinCountXsdunsignedInt(DXO2016DrawChartDraw.Binning openXmlElement)
  {
      return openXmlElement?.GetFirstChild<DXO2016DrawChartDraw.BinCountXsdunsignedInt>()?.Text;
  }
  
  private static bool CmpBinCountXsdunsignedInt(DXO2016DrawChartDraw.Binning openXmlElement, String? value, DiffList? diffs, string? objName)
  {
      return openXmlElement?.GetFirstChild<DXO2016DrawChartDraw.BinCountXsdunsignedInt>()?.Text == value;
  }
  
  private static void SetBinCountXsdunsignedInt(DXO2016DrawChartDraw.Binning openXmlElement, String? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO2016DrawChartDraw.BinCountXsdunsignedInt>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DXO2016DrawChartDraw.BinCountXsdunsignedInt { Text = value };
      openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DocumentModel.Drawings.ChartDrawings.Binning? CreateModelElement(DXO2016DrawChartDraw.Binning? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.ChartDrawings.Binning();
      value.IntervalClosed = GetIntervalClosed(openXmlElement);
      value.Underflow = GetUnderflow(openXmlElement);
      value.Overflow = GetOverflow(openXmlElement);
      value.Xsddouble = GetXsddouble(openXmlElement);
      value.BinCountXsdunsignedInt = GetBinCountXsdunsignedInt(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXO2016DrawChartDraw.Binning? openXmlElement, DMDrawsChartDraws.Binning? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpIntervalClosed(openXmlElement, value.IntervalClosed, diffs, objName))
        ok = false;
      if (!CmpUnderflow(openXmlElement, value.Underflow, diffs, objName))
        ok = false;
      if (!CmpOverflow(openXmlElement, value.Overflow, diffs, objName))
        ok = false;
      if (!CmpXsddouble(openXmlElement, value.Xsddouble, diffs, objName))
        ok = false;
      if (!CmpBinCountXsdunsignedInt(openXmlElement, value.BinCountXsdunsignedInt, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDrawsChartDraws.Binning value)
    where OpenXmlElementType: DXO2016DrawChartDraw.Binning, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXO2016DrawChartDraw.Binning openXmlElement, DMDrawsChartDraws.Binning value)
  {
    SetIntervalClosed(openXmlElement, value?.IntervalClosed);
    SetUnderflow(openXmlElement, value?.Underflow);
    SetOverflow(openXmlElement, value?.Overflow);
    SetXsddouble(openXmlElement, value?.Xsddouble);
    SetBinCountXsdunsignedInt(openXmlElement, value?.BinCountXsdunsignedInt);
  }
}
