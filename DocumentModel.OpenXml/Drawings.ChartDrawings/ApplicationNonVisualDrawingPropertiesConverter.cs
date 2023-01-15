using DocumentFormat.OpenXml.Office2010.Drawing.ChartDrawing;

namespace DocumentModel.OpenXml.Drawings.ChartDrawings;

/// <summary>
///   Defines the ApplicationNonVisualDrawingProperties Class.
/// </summary>
public static class ApplicationNonVisualDrawingPropertiesConverter
{
  /// <summary>
  ///   macro, this property is only available in Office 2010 and later.
  /// </summary>
  public static String? GetMacro(ApplicationNonVisualDrawingProperties? openXmlElement)
  {
    return openXmlElement?.Macro?.Value;
  }

  public static void SetMacro(ApplicationNonVisualDrawingProperties? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Macro = new StringValue { Value = value };
      else
        openXmlElement.Macro = null;
  }

  /// <summary>
  ///   fPublished, this property is only available in Office 2010 and later.
  /// </summary>
  public static Boolean? GetPublished(ApplicationNonVisualDrawingProperties? openXmlElement)
  {
    return openXmlElement?.Published?.Value;
  }

  public static void SetPublished(ApplicationNonVisualDrawingProperties? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Published = new BooleanValue { Value = (Boolean)value };
      else
        openXmlElement.Published = null;
  }

  public static DocumentModel.Drawings.ChartDrawings.ApplicationNonVisualDrawingProperties? CreateModelElement(ApplicationNonVisualDrawingProperties? openXmlElement)
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
    where OpenXmlElementType : ApplicationNonVisualDrawingProperties, new()
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