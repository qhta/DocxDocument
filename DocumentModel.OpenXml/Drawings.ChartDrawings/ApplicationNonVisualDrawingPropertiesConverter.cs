namespace DocumentModel.OpenXml.Drawings.ChartDrawings;

/// <summary>
/// Defines the ApplicationNonVisualDrawingProperties Class.
/// </summary>
public static class ApplicationNonVisualDrawingPropertiesConverter
{
  /// <summary>
  /// macro, this property is only available in Office 2010 and later.
  /// </summary>
  private static String? GetMacro(DXO2010DrawChartDraw.ApplicationNonVisualDrawingProperties openXmlElement)
  {
    return openXmlElement?.Macro?.Value;
  }
  
  private static void SetMacro(DXO2010DrawChartDraw.ApplicationNonVisualDrawingProperties openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Macro = new StringValue { Value = value };
    else
      openXmlElement.Macro = null;
  }
  
  /// <summary>
  /// fPublished, this property is only available in Office 2010 and later.
  /// </summary>
  private static Boolean? GetPublished(DXO2010DrawChartDraw.ApplicationNonVisualDrawingProperties openXmlElement)
  {
    return openXmlElement?.Published?.Value;
  }
  
  private static void SetPublished(DXO2010DrawChartDraw.ApplicationNonVisualDrawingProperties openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.Published = new BooleanValue { Value = (Boolean)value };
    else
      openXmlElement.Published = null;
  }
  
  public static DMDrawsChartDraws.ApplicationNonVisualDrawingProperties? CreateModelElement(DXO2010DrawChartDraw.ApplicationNonVisualDrawingProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDrawsChartDraws.ApplicationNonVisualDrawingProperties();
      value.Macro = GetMacro(openXmlElement);
      value.Published = GetPublished(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDrawsChartDraws.ApplicationNonVisualDrawingProperties? value)
    where OpenXmlElementType: DXO2010DrawChartDraw.ApplicationNonVisualDrawingProperties, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetMacro(openXmlElement, value?.Macro);
      SetPublished(openXmlElement, value?.Published);
      return openXmlElement;
    }
    return default;
  }
}
