namespace DocumentModel.OpenXml.Drawings.ChartDrawing;

/// <summary>
/// Non-Visual Shape Properties.
/// </summary>
public static class NonVisualShapePropertiesConverter
{
  /// <summary>
  /// Chart Non Visual Properties.
  /// </summary>
  private static DocumentModel.Drawings.ChartDrawing.NonVisualDrawingProperties? GetNonVisualDrawingProperties(DocumentFormat.OpenXml.Drawing.ChartDrawing.NonVisualShapeProperties openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.ChartDrawing.NonVisualDrawingProperties>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.ChartDrawing.NonVisualDrawingPropertiesConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetNonVisualDrawingProperties(DocumentFormat.OpenXml.Drawing.ChartDrawing.NonVisualShapeProperties openXmlElement, DocumentModel.Drawings.ChartDrawing.NonVisualDrawingProperties? value)
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
  /// Non-Visual Shape Drawing Properties.
  /// </summary>
  private static DocumentModel.Drawings.ChartDrawing.NonVisualShapeDrawingProperties? GetNonVisualShapeDrawingProperties(DocumentFormat.OpenXml.Drawing.ChartDrawing.NonVisualShapeProperties openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.ChartDrawing.NonVisualShapeDrawingProperties>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.ChartDrawing.NonVisualShapeDrawingPropertiesConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetNonVisualShapeDrawingProperties(DocumentFormat.OpenXml.Drawing.ChartDrawing.NonVisualShapeProperties openXmlElement, DocumentModel.Drawings.ChartDrawing.NonVisualShapeDrawingProperties? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.ChartDrawing.NonVisualShapeDrawingProperties>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Drawings.ChartDrawing.NonVisualShapeDrawingPropertiesConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.ChartDrawing.NonVisualShapeDrawingProperties>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DocumentModel.Drawings.ChartDrawing.NonVisualShapeProperties? CreateModelElement(DocumentFormat.OpenXml.Drawing.ChartDrawing.NonVisualShapeProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.ChartDrawing.NonVisualShapeProperties();
      value.NonVisualDrawingProperties = GetNonVisualDrawingProperties(openXmlElement);
      value.NonVisualShapeDrawingProperties = GetNonVisualShapeDrawingProperties(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.ChartDrawing.NonVisualShapeProperties? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Drawing.ChartDrawing.NonVisualShapeProperties, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetNonVisualDrawingProperties(openXmlElement, value?.NonVisualDrawingProperties);
      SetNonVisualShapeDrawingProperties(openXmlElement, value?.NonVisualShapeDrawingProperties);
      return openXmlElement;
    }
    return default;
  }
}
