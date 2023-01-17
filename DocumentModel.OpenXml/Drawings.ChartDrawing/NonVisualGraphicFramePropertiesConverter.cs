namespace DocumentModel.OpenXml.Drawings.ChartDrawing;

/// <summary>
/// Non-Visual Graphic Frame Properties.
/// </summary>
public static class NonVisualGraphicFramePropertiesConverter
{
  /// <summary>
  /// Non-Visual Drawing Properties.
  /// </summary>
  private static DocumentModel.Drawings.ChartDrawing.NonVisualDrawingProperties? GetNonVisualDrawingProperties(DocumentFormat.OpenXml.Drawing.ChartDrawing.NonVisualGraphicFrameProperties openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.ChartDrawing.NonVisualDrawingProperties>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.ChartDrawing.NonVisualDrawingPropertiesConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetNonVisualDrawingProperties(DocumentFormat.OpenXml.Drawing.ChartDrawing.NonVisualGraphicFrameProperties openXmlElement, DocumentModel.Drawings.ChartDrawing.NonVisualDrawingProperties? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.ChartDrawing.NonVisualDrawingProperties>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Drawings.ChartDrawing.NonVisualDrawingPropertiesConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.ChartDrawing.NonVisualDrawingProperties>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Non-Visual Graphic Frame Drawing Properties.
  /// </summary>
  private static DocumentModel.Drawings.ChartDrawing.NonVisualGraphicFrameDrawingProperties? GetNonVisualGraphicFrameDrawingProperties(DocumentFormat.OpenXml.Drawing.ChartDrawing.NonVisualGraphicFrameProperties openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.ChartDrawing.NonVisualGraphicFrameDrawingProperties>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.ChartDrawing.NonVisualGraphicFrameDrawingPropertiesConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetNonVisualGraphicFrameDrawingProperties(DocumentFormat.OpenXml.Drawing.ChartDrawing.NonVisualGraphicFrameProperties openXmlElement, DocumentModel.Drawings.ChartDrawing.NonVisualGraphicFrameDrawingProperties? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.ChartDrawing.NonVisualGraphicFrameDrawingProperties>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Drawings.ChartDrawing.NonVisualGraphicFrameDrawingPropertiesConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.ChartDrawing.NonVisualGraphicFrameDrawingProperties>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DocumentModel.Drawings.ChartDrawing.NonVisualGraphicFrameProperties? CreateModelElement(DocumentFormat.OpenXml.Drawing.ChartDrawing.NonVisualGraphicFrameProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.ChartDrawing.NonVisualGraphicFrameProperties();
      value.NonVisualDrawingProperties = GetNonVisualDrawingProperties(openXmlElement);
      value.NonVisualGraphicFrameDrawingProperties = GetNonVisualGraphicFrameDrawingProperties(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.ChartDrawing.NonVisualGraphicFrameProperties? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Drawing.ChartDrawing.NonVisualGraphicFrameProperties, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetNonVisualDrawingProperties(openXmlElement, value?.NonVisualDrawingProperties);
      SetNonVisualGraphicFrameDrawingProperties(openXmlElement, value?.NonVisualGraphicFrameDrawingProperties);
      return openXmlElement;
    }
    return default;
  }
}
