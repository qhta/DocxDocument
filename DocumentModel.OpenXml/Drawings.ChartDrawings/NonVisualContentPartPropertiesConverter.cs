using DocumentModel.Drawings.ChartDrawings;
using NonVisualContentPartProperties = DocumentFormat.OpenXml.Office2010.Drawing.ChartDrawing.NonVisualContentPartProperties;

namespace DocumentModel.OpenXml.Drawings.ChartDrawings;

/// <summary>
///   Defines the NonVisualContentPartProperties Class.
/// </summary>
public static class NonVisualContentPartPropertiesConverter
{
  /// <summary>
  ///   NonVisualDrawingProperties.
  /// </summary>
  public static NonVisualDrawingProperties? GetNonVisualDrawingProperties(NonVisualContentPartProperties? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2010.Drawing.ChartDrawing.NonVisualDrawingProperties>();
    if (itemElement != null)
      return NonVisualDrawingPropertiesConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetNonVisualDrawingProperties(NonVisualContentPartProperties? openXmlElement, NonVisualDrawingProperties? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.Drawing.ChartDrawing.NonVisualDrawingProperties>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = NonVisualDrawingPropertiesConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2010.Drawing.ChartDrawing.NonVisualDrawingProperties>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   NonVisualInkContentPartProperties.
  /// </summary>
  public static NonVisualInkContentPartProperties? GetNonVisualInkContentPartProperties(NonVisualContentPartProperties? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2010.Drawing.ChartDrawing.NonVisualInkContentPartProperties>();
    if (itemElement != null)
      return NonVisualInkContentPartPropertiesConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetNonVisualInkContentPartProperties(NonVisualContentPartProperties? openXmlElement, NonVisualInkContentPartProperties? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.Drawing.ChartDrawing.NonVisualInkContentPartProperties>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = NonVisualInkContentPartPropertiesConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2010.Drawing.ChartDrawing.NonVisualInkContentPartProperties>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static DocumentModel.Drawings.ChartDrawings.NonVisualContentPartProperties? CreateModelElement(NonVisualContentPartProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.ChartDrawings.NonVisualContentPartProperties();
      value.NonVisualDrawingProperties = GetNonVisualDrawingProperties(openXmlElement);
      value.NonVisualInkContentPartProperties = GetNonVisualInkContentPartProperties(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.ChartDrawings.NonVisualContentPartProperties? value)
    where OpenXmlElementType : NonVisualContentPartProperties, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetNonVisualDrawingProperties(openXmlElement, value?.NonVisualDrawingProperties);
      SetNonVisualInkContentPartProperties(openXmlElement, value?.NonVisualInkContentPartProperties);
      return openXmlElement;
    }
    return default;
  }
}