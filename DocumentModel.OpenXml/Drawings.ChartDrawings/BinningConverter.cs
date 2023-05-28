namespace DocumentModel.OpenXml.Drawings.ChartDrawings;

/// <summary>
/// Defines the Binning Class.
/// </summary>
public static class BinningConverter
{
  /// <summary>
  /// intervalClosed, this property is only available in Office 2016 and later.
  /// </summary>
  private static DMDCDs.IntervalClosedSide? GetIntervalClosed(DXO16DCD.Binning openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.IntervalClosedSide, DMDCDs.IntervalClosedSide>(openXmlElement?.IntervalClosed?.Value);
  }
  
  private static bool CmpIntervalClosed(DXO16DCD.Binning openXmlElement, DMDCDs.IntervalClosedSide? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.IntervalClosedSide, DMDCDs.IntervalClosedSide>(openXmlElement?.IntervalClosed?.Value, value, diffs, objName, propName);
  }
  
  private static void SetIntervalClosed(DXO16DCD.Binning openXmlElement, DMDCDs.IntervalClosedSide? value)
  {
    openXmlElement.IntervalClosed = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.IntervalClosedSide, DMDCDs.IntervalClosedSide>(value);
  }
  
  /// <summary>
  /// underflow, this property is only available in Office 2016 and later.
  /// </summary>
  private static String? GetUnderflow(DXO16DCD.Binning openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Underflow);
  }
  
  private static bool CmpUnderflow(DXO16DCD.Binning openXmlElement, String? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Underflow, value, diffs, objName, "Underflow");
  }
  
  private static void SetUnderflow(DXO16DCD.Binning openXmlElement, String? value)
  {
    openXmlElement.Underflow = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// overflow, this property is only available in Office 2016 and later.
  /// </summary>
  private static String? GetOverflow(DXO16DCD.Binning openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Overflow);
  }
  
  private static bool CmpOverflow(DXO16DCD.Binning openXmlElement, String? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Overflow, value, diffs, objName, "Overflow");
  }
  
  private static void SetOverflow(DXO16DCD.Binning openXmlElement, String? value)
  {
    openXmlElement.Overflow = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// Xsddouble.
  /// </summary>
  private static String? GetXsddouble(DXO16DCD.Binning openXmlElement)
  {
      return openXmlElement?.GetFirstChild<DXO16DCD.Xsddouble>()?.Text;
  }
  
  private static bool CmpXsddouble(DXO16DCD.Binning openXmlElement, String? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
      return openXmlElement?.GetFirstChild<DXO16DCD.Xsddouble>()?.Text == value;
  }
  
  private static void SetXsddouble(DXO16DCD.Binning openXmlElement, String? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO16DCD.Xsddouble>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DXO16DCD.Xsddouble { Text = value };
      openXmlElement.AppendChild(itemElement);
    }
  }
  
  /// <summary>
  /// BinCountXsdunsignedInt.
  /// </summary>
  private static String? GetBinCountXsdunsignedInt(DXO16DCD.Binning openXmlElement)
  {
      return openXmlElement?.GetFirstChild<DXO16DCD.BinCountXsdunsignedInt>()?.Text;
  }
  
  private static bool CmpBinCountXsdunsignedInt(DXO16DCD.Binning openXmlElement, String? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
      return openXmlElement?.GetFirstChild<DXO16DCD.BinCountXsdunsignedInt>()?.Text == value;
  }
  
  private static void SetBinCountXsdunsignedInt(DXO16DCD.Binning openXmlElement, String? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO16DCD.BinCountXsdunsignedInt>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DXO16DCD.BinCountXsdunsignedInt { Text = value };
      openXmlElement.AppendChild(itemElement);
    }
  }
  
  public static DMDCDs.Binning? CreateModelElement(DXO16DCD.Binning? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDCDs.Binning();
      value.IntervalClosed = GetIntervalClosed(openXmlElement);
      value.Underflow = GetUnderflow(openXmlElement);
      value.Overflow = GetOverflow(openXmlElement);
      value.Xsddouble = GetXsddouble(openXmlElement);
      value.BinCountXsdunsignedInt = GetBinCountXsdunsignedInt(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXO16DCD.Binning? openXmlElement, DMDCDs.Binning? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpIntervalClosed(openXmlElement, value.IntervalClosed, diffs, objName, propName))
        ok = false;
      if (!CmpUnderflow(openXmlElement, value.Underflow, diffs, objName, propName))
        ok = false;
      if (!CmpOverflow(openXmlElement, value.Overflow, diffs, objName, propName))
        ok = false;
      if (!CmpXsddouble(openXmlElement, value.Xsddouble, diffs, objName, propName))
        ok = false;
      if (!CmpBinCountXsdunsignedInt(openXmlElement, value.BinCountXsdunsignedInt, diffs, objName, propName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDCDs.Binning value)
    where OpenXmlElementType: DXO16DCD.Binning, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXO16DCD.Binning openXmlElement, DMDCDs.Binning value)
  {
    SetIntervalClosed(openXmlElement, value?.IntervalClosed);
    SetUnderflow(openXmlElement, value?.Underflow);
    SetOverflow(openXmlElement, value?.Overflow);
    SetXsddouble(openXmlElement, value?.Xsddouble);
    SetBinCountXsdunsignedInt(openXmlElement, value?.BinCountXsdunsignedInt);
  }
}
