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
  
  private static void SetIntervalClosed(DXO2016DrawChartDraw.Binning openXmlElement, DMDrawsChartDraws.IntervalClosedSide? value)
  {
    openXmlElement.IntervalClosed = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.IntervalClosedSide, DMDrawsChartDraws.IntervalClosedSide>(value);
  }
  
  /// <summary>
  /// underflow, this property is only available in Office 2016 and later.
  /// </summary>
  private static String? GetUnderflow(DXO2016DrawChartDraw.Binning openXmlElement)
  {
    return openXmlElement?.Underflow?.Value;
  }
  
  private static void SetUnderflow(DXO2016DrawChartDraw.Binning openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Underflow = new StringValue { Value = value };
    else
      openXmlElement.Underflow = null;
  }
  
  /// <summary>
  /// overflow, this property is only available in Office 2016 and later.
  /// </summary>
  private static String? GetOverflow(DXO2016DrawChartDraw.Binning openXmlElement)
  {
    return openXmlElement?.Overflow?.Value;
  }
  
  private static void SetOverflow(DXO2016DrawChartDraw.Binning openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Overflow = new StringValue { Value = value };
    else
      openXmlElement.Overflow = null;
  }
  
  /// <summary>
  /// Xsddouble.
  /// </summary>
  private static String? GetXsddouble(DXO2016DrawChartDraw.Binning openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXO2016DrawChartDraw.Xsddouble>();
    if (itemElement != null)
      return itemElement.Text;
    return null;
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
    var itemElement = openXmlElement?.GetFirstChild<DXO2016DrawChartDraw.BinCountXsdunsignedInt>();
    if (itemElement != null)
      return itemElement.Text;
    return null;
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
  
  public static DMDrawsChartDraws.Binning? CreateModelElement(DXO2016DrawChartDraw.Binning? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDrawsChartDraws.Binning();
      value.IntervalClosed = GetIntervalClosed(openXmlElement);
      value.Underflow = GetUnderflow(openXmlElement);
      value.Overflow = GetOverflow(openXmlElement);
      value.Xsddouble = GetXsddouble(openXmlElement);
      value.BinCountXsdunsignedInt = GetBinCountXsdunsignedInt(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDrawsChartDraws.Binning? value)
    where OpenXmlElementType: DXO2016DrawChartDraw.Binning, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetIntervalClosed(openXmlElement, value?.IntervalClosed);
      SetUnderflow(openXmlElement, value?.Underflow);
      SetOverflow(openXmlElement, value?.Overflow);
      SetXsddouble(openXmlElement, value?.Xsddouble);
      SetBinCountXsdunsignedInt(openXmlElement, value?.BinCountXsdunsignedInt);
      return openXmlElement;
    }
    return default;
  }
}
