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
  
  private static bool CmpMacro(DXO2010DrawChartDraw.ApplicationNonVisualDrawingProperties openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.Macro?.Value == value) return true;
    diffs?.Add(objName, "Macro", openXmlElement?.Macro?.Value, value);
    return false;
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
  
  private static bool CmpPublished(DXO2010DrawChartDraw.ApplicationNonVisualDrawingProperties openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.Published?.Value == value) return true;
    diffs?.Add(objName, "Published", openXmlElement?.Published?.Value, value);
    return false;
  }
  
  private static void SetPublished(DXO2010DrawChartDraw.ApplicationNonVisualDrawingProperties openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.Published = new BooleanValue { Value = (Boolean)value };
    else
      openXmlElement.Published = null;
  }
  
  public static DocumentModel.Drawings.ChartDrawings.ApplicationNonVisualDrawingProperties? CreateModelElement(DXO2010DrawChartDraw.ApplicationNonVisualDrawingProperties? openXmlElement)
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
  
  public static bool CompareModelElement(DXO2010DrawChartDraw.ApplicationNonVisualDrawingProperties? openXmlElement, DMDrawsChartDraws.ApplicationNonVisualDrawingProperties? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpMacro(openXmlElement, value.Macro, diffs, objName))
        ok = false;
      if (!CmpPublished(openXmlElement, value.Published, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
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
