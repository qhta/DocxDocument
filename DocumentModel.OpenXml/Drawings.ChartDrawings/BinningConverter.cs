namespace DocumentModel.OpenXml.Drawings.ChartDrawings;

/// <summary>
/// Defines the Binning Class.
/// </summary>
public static class BinningConverter
{
  /// <summary>
  /// intervalClosed, this property is only available in Office 2016 and later.
  /// </summary>
  public static DocumentModel.Drawings.ChartDrawings.IntervalClosedSide? GetIntervalClosed(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.Binning? openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.IntervalClosedSide, DocumentModel.Drawings.ChartDrawings.IntervalClosedSide>(openXmlElement?.IntervalClosed?.Value);
  }
  
  public static void SetIntervalClosed(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.Binning? openXmlElement, DocumentModel.Drawings.ChartDrawings.IntervalClosedSide? value)
  {
    if (openXmlElement != null)
      openXmlElement.IntervalClosed = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.IntervalClosedSide, DocumentModel.Drawings.ChartDrawings.IntervalClosedSide>(value);
  }
  
  /// <summary>
  /// underflow, this property is only available in Office 2016 and later.
  /// </summary>
  public static String? GetUnderflow(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.Binning? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in propertyType is DocumentFormat.OpenXml.StringValue");
  }
  
  public static void SetUnderflow(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.Binning? openXmlElement, String? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// overflow, this property is only available in Office 2016 and later.
  /// </summary>
  public static String? GetOverflow(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.Binning? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in propertyType is DocumentFormat.OpenXml.StringValue");
  }
  
  public static void SetOverflow(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.Binning? openXmlElement, String? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// Xsddouble.
  /// </summary>
  public static String? GetXsddouble(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.Binning? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in propertyType is DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.Xsddouble");
  }
  
  public static void SetXsddouble(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.Binning? openXmlElement, String? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// BinCountXsdunsignedInt.
  /// </summary>
  public static String? GetBinCountXsdunsignedInt(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.Binning? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in propertyType is DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.BinCountXsdunsignedInt");
  }
  
  public static void SetBinCountXsdunsignedInt(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.Binning? openXmlElement, String? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
}
