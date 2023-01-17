namespace DocumentModel.OpenXml.Drawings.ChartDrawings;

/// <summary>
/// Defines the ChartStringValue Class.
/// </summary>
public static class ChartStringValueConverter
{
  /// <summary>
  /// idx, this property is only available in Office 2016 and later.
  /// </summary>
  private static UInt32? GetIndex(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ChartStringValue openXmlElement)
  {
    return openXmlElement.Index?.Value;
  }
  
  private static void SetIndex(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ChartStringValue openXmlElement, UInt32? value)
  {
    openXmlElement.Index = value;
  }
  
  public static DocumentModel.Drawings.ChartDrawings.ChartStringValue? CreateModelElement(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ChartStringValue? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.ChartDrawings.ChartStringValue();
      value.Index = GetIndex(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.ChartDrawings.ChartStringValue? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ChartStringValue, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetIndex(openXmlElement, value?.Index);
      return openXmlElement;
    }
    return default;
  }
}
