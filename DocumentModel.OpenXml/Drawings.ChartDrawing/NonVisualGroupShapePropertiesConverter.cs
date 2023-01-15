using DocumentModel.Drawings.ChartDrawing;
using NonVisualGroupShapeProperties = DocumentFormat.OpenXml.Drawing.ChartDrawing.NonVisualGroupShapeProperties;

namespace DocumentModel.OpenXml.Drawings.ChartDrawing;

/// <summary>
///   Non-Visual Group Shape Properties.
/// </summary>
public static class NonVisualGroupShapePropertiesConverter
{
  /// <summary>
  ///   Chart Non Visual Properties.
  /// </summary>
  public static NonVisualDrawingProperties? GetNonVisualDrawingProperties(NonVisualGroupShapeProperties? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.ChartDrawing.NonVisualDrawingProperties>();
    if (itemElement != null)
      return NonVisualDrawingPropertiesConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetNonVisualDrawingProperties(NonVisualGroupShapeProperties? openXmlElement, NonVisualDrawingProperties? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.ChartDrawing.NonVisualDrawingProperties>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = NonVisualDrawingPropertiesConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.ChartDrawing.NonVisualDrawingProperties>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   Non-Visual Group Shape Drawing Properties.
  /// </summary>
  public static NonVisualGroupShapeDrawingProperties? GetNonVisualGroupShapeDrawingProperties(NonVisualGroupShapeProperties? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.ChartDrawing.NonVisualGroupShapeDrawingProperties>();
    if (itemElement != null)
      return NonVisualGroupShapeDrawingPropertiesConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetNonVisualGroupShapeDrawingProperties(NonVisualGroupShapeProperties? openXmlElement, NonVisualGroupShapeDrawingProperties? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.ChartDrawing.NonVisualGroupShapeDrawingProperties>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = NonVisualGroupShapeDrawingPropertiesConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.ChartDrawing.NonVisualGroupShapeDrawingProperties>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static DocumentModel.Drawings.ChartDrawing.NonVisualGroupShapeProperties? CreateModelElement(NonVisualGroupShapeProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.ChartDrawing.NonVisualGroupShapeProperties();
      value.NonVisualDrawingProperties = GetNonVisualDrawingProperties(openXmlElement);
      value.NonVisualGroupShapeDrawingProperties = GetNonVisualGroupShapeDrawingProperties(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.ChartDrawing.NonVisualGroupShapeProperties? value)
    where OpenXmlElementType : NonVisualGroupShapeProperties, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetNonVisualDrawingProperties(openXmlElement, value?.NonVisualDrawingProperties);
      SetNonVisualGroupShapeDrawingProperties(openXmlElement, value?.NonVisualGroupShapeDrawingProperties);
      return openXmlElement;
    }
    return default;
  }
}