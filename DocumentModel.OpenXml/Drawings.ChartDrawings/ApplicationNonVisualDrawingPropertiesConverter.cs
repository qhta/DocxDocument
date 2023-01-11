namespace DocumentModel.OpenXml.Drawings.ChartDrawings;

/// <summary>
/// Defines the ApplicationNonVisualDrawingProperties Class.
/// </summary>
public static class ApplicationNonVisualDrawingPropertiesConverter
{
  /// <summary>
  /// macro, this property is only available in Office 2010 and later.
  /// </summary>
  public static String? GetMacro(DocumentFormat.OpenXml.Office2010.Drawing.ChartDrawing.ApplicationNonVisualDrawingProperties? openXmlElement)
  {
    return openXmlElement?.Macro?.Value;
  }
  
  public static void SetMacro(DocumentFormat.OpenXml.Office2010.Drawing.ChartDrawing.ApplicationNonVisualDrawingProperties? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Macro = new StringValue { Value = value };
      else
        openXmlElement.Macro = null;
  }
  
  /// <summary>
  /// fPublished, this property is only available in Office 2010 and later.
  /// </summary>
  public static Boolean? GetPublished(DocumentFormat.OpenXml.Office2010.Drawing.ChartDrawing.ApplicationNonVisualDrawingProperties? openXmlElement)
  {
    return openXmlElement?.Published?.Value;
  }
  
  public static void SetPublished(DocumentFormat.OpenXml.Office2010.Drawing.ChartDrawing.ApplicationNonVisualDrawingProperties? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Published = new BooleanValue { Value = (Boolean)value };
      else
        openXmlElement.Published = null;
  }
  
  public static DocumentModel.Drawings.ChartDrawings.ApplicationNonVisualDrawingProperties? CreateModelElement(DocumentFormat.OpenXml.Office2010.Drawing.ChartDrawing.ApplicationNonVisualDrawingProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.ChartDrawings.ApplicationNonVisualDrawingProperties();
      value.Macro = GetMacro(openXmlElement);
      value.Published = GetPublished(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.ChartDrawings.ApplicationNonVisualDrawingProperties? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Office2010.Drawing.ChartDrawing.ApplicationNonVisualDrawingProperties, new()
  {
  throw new NotImplementedException("Not implemented in GenerateCreateOpenXmlElementMethod: 1");
  }
}
