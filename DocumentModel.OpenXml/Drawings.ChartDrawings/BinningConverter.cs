namespace DocumentModel.OpenXml.Drawings.ChartDrawings;

/// <summary>
/// Defines the Binning Class.
/// </summary>
public static class BinningConverter
{
  /// <summary>
  /// intervalClosed, this property is only available in Office 2016 and later.
  /// </summary>
  private static DocumentModel.Drawings.ChartDrawings.IntervalClosedSide? GetIntervalClosed(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.Binning openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.IntervalClosedSide, DocumentModel.Drawings.ChartDrawings.IntervalClosedSide>(openXmlElement?.IntervalClosed?.Value);
  }
  
  private static void SetIntervalClosed(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.Binning openXmlElement, DocumentModel.Drawings.ChartDrawings.IntervalClosedSide? value)
  {
    openXmlElement.IntervalClosed = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.IntervalClosedSide, DocumentModel.Drawings.ChartDrawings.IntervalClosedSide>(value);
  }
  
  /// <summary>
  /// underflow, this property is only available in Office 2016 and later.
  /// </summary>
  private static String? GetUnderflow(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.Binning openXmlElement)
  {
    return openXmlElement?.Underflow?.Value;
  }
  
  private static void SetUnderflow(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.Binning openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Underflow = new StringValue { Value = value };
    else
      openXmlElement.Underflow = null;
  }
  
  /// <summary>
  /// overflow, this property is only available in Office 2016 and later.
  /// </summary>
  private static String? GetOverflow(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.Binning openXmlElement)
  {
    return openXmlElement?.Overflow?.Value;
  }
  
  private static void SetOverflow(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.Binning openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Overflow = new StringValue { Value = value };
    else
      openXmlElement.Overflow = null;
  }
  
  /// <summary>
  /// Xsddouble.
  /// </summary>
  private static String? GetXsddouble(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.Binning openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.Xsddouble>();
    if (itemElement != null)
      return itemElement.Text;
    return null;
  }
  
  private static void SetXsddouble(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.Binning openXmlElement, String? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.Xsddouble>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.Xsddouble { Text = value };
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// BinCountXsdunsignedInt.
  /// </summary>
  private static String? GetBinCountXsdunsignedInt(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.Binning openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.BinCountXsdunsignedInt>();
    if (itemElement != null)
      return itemElement.Text;
    return null;
  }
  
  private static void SetBinCountXsdunsignedInt(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.Binning openXmlElement, String? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.BinCountXsdunsignedInt>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.BinCountXsdunsignedInt { Text = value };
      openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DocumentModel.Drawings.ChartDrawings.Binning? CreateModelElement(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.Binning? openXmlElement)
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
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.ChartDrawings.Binning? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.Binning, new()
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
