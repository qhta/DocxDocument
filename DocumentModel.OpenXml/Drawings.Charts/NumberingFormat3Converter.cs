namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
/// Defines the NumberingFormat Class.
/// </summary>
public static class NumberingFormat3Converter
{
  /// <summary>
  /// Number Format Code
  /// </summary>
  public static String? GetFormatCode(DocumentFormat.OpenXml.Office2013.Drawing.Chart.NumberingFormat? openXmlElement)
  {
    return openXmlElement?.FormatCode?.Value;
  }
  
  public static void SetFormatCode(DocumentFormat.OpenXml.Office2013.Drawing.Chart.NumberingFormat? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.FormatCode = new StringValue { Value = value };
      else
        openXmlElement.FormatCode = null;
  }
  
  /// <summary>
  /// Linked to Source
  /// </summary>
  public static Boolean? GetSourceLinked(DocumentFormat.OpenXml.Office2013.Drawing.Chart.NumberingFormat? openXmlElement)
  {
    return openXmlElement?.SourceLinked?.Value;
  }
  
  public static void SetSourceLinked(DocumentFormat.OpenXml.Office2013.Drawing.Chart.NumberingFormat? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.SourceLinked = new BooleanValue { Value = (Boolean)value };
      else
        openXmlElement.SourceLinked = null;
  }
  
  public static DocumentModel.Drawings.Charts.NumberingFormat3? CreateModelElement(DocumentFormat.OpenXml.Office2013.Drawing.Chart.NumberingFormat? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Charts.NumberingFormat3();
      value.FormatCode = GetFormatCode(openXmlElement);
      value.SourceLinked = GetSourceLinked(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.Charts.NumberingFormat3? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Office2013.Drawing.Chart.NumberingFormat, new()
  {
  throw new NotImplementedException("Not implemented in GenerateCreateOpenXmlElementMethod: 1");
  }
}
