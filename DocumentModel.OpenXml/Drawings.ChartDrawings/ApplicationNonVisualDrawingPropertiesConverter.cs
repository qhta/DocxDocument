namespace DocumentModel.OpenXml.Drawings.ChartDrawings;

/// <summary>
/// Defines the ApplicationNonVisualDrawingProperties Class.
/// </summary>
public static class ApplicationNonVisualDrawingPropertiesConverter
{
  /// <summary>
  /// macro, this property is only available in Office 2010 and later.
  /// </summary>
  private static String? GetMacro(DXO10DCD.ApplicationNonVisualDrawingProperties openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Macro);
  }
  
  private static bool CmpMacro(DXO10DCD.ApplicationNonVisualDrawingProperties openXmlElement, String? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Macro, value, diffs, objName, "Macro");
  }
  
  private static void SetMacro(DXO10DCD.ApplicationNonVisualDrawingProperties openXmlElement, String? value)
  {
    openXmlElement.Macro = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// fPublished, this property is only available in Office 2010 and later.
  /// </summary>
  private static Boolean? GetPublished(DXO10DCD.ApplicationNonVisualDrawingProperties openXmlElement)
  {
    return openXmlElement?.Published?.Value;
  }
  
  private static bool CmpPublished(DXO10DCD.ApplicationNonVisualDrawingProperties openXmlElement, Boolean? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement?.Published?.Value == value) return true;
    diffs?.Add(objName, "Published", openXmlElement?.Published?.Value, value);
    return false;
  }
  
  private static void SetPublished(DXO10DCD.ApplicationNonVisualDrawingProperties openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.Published = new BooleanValue { Value = (Boolean)value };
    else
      openXmlElement.Published = null;
  }
  
  public static DMDCDs.ApplicationNonVisualDrawingProperties? CreateModelElement(DXO10DCD.ApplicationNonVisualDrawingProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDCDs.ApplicationNonVisualDrawingProperties();
      value.Macro = GetMacro(openXmlElement);
      value.Published = GetPublished(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXO10DCD.ApplicationNonVisualDrawingProperties? openXmlElement, DMDCDs.ApplicationNonVisualDrawingProperties? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpMacro(openXmlElement, value.Macro, diffs, objName, propName))
        ok = false;
      if (!CmpPublished(openXmlElement, value.Published, diffs, objName, propName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDCDs.ApplicationNonVisualDrawingProperties value)
    where OpenXmlElementType: DXO10DCD.ApplicationNonVisualDrawingProperties, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXO10DCD.ApplicationNonVisualDrawingProperties openXmlElement, DMDCDs.ApplicationNonVisualDrawingProperties value)
  {
    SetMacro(openXmlElement, value?.Macro);
    SetPublished(openXmlElement, value?.Published);
  }
}
