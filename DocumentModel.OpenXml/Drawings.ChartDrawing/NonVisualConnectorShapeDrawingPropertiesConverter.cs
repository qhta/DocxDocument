namespace DocumentModel.OpenXml.Drawings.ChartDrawing;

/// <summary>
/// Connector Non Visual Properties.
/// </summary>
public static class NonVisualConnectorShapeDrawingPropertiesConverter
{
  /// <summary>
  /// Chart Non Visual Properties.
  /// </summary>
  private static DocumentModel.Drawings.ChartDrawing.NonVisualDrawingProperties? GetNonVisualDrawingProperties(DocumentFormat.OpenXml.Drawing.ChartDrawing.NonVisualConnectorShapeDrawingProperties openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.ChartDrawing.NonVisualDrawingProperties>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.ChartDrawing.NonVisualDrawingPropertiesConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetNonVisualDrawingProperties(DocumentFormat.OpenXml.Drawing.ChartDrawing.NonVisualConnectorShapeDrawingProperties openXmlElement, DocumentModel.Drawings.ChartDrawing.NonVisualDrawingProperties? value)
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
  /// Non-Visual Connection Shape Drawing Properties.
  /// </summary>
  private static DocumentModel.Drawings.ChartDrawing.NonVisualConnectionShapeProperties? GetNonVisualConnectionShapeProperties(DocumentFormat.OpenXml.Drawing.ChartDrawing.NonVisualConnectorShapeDrawingProperties openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.ChartDrawing.NonVisualConnectionShapeProperties>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.ChartDrawing.NonVisualConnectionShapePropertiesConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetNonVisualConnectionShapeProperties(DocumentFormat.OpenXml.Drawing.ChartDrawing.NonVisualConnectorShapeDrawingProperties openXmlElement, DocumentModel.Drawings.ChartDrawing.NonVisualConnectionShapeProperties? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.ChartDrawing.NonVisualConnectionShapeProperties>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Drawings.ChartDrawing.NonVisualConnectionShapePropertiesConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.ChartDrawing.NonVisualConnectionShapeProperties>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DocumentModel.Drawings.ChartDrawing.NonVisualConnectorShapeDrawingProperties? CreateModelElement(DocumentFormat.OpenXml.Drawing.ChartDrawing.NonVisualConnectorShapeDrawingProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.ChartDrawing.NonVisualConnectorShapeDrawingProperties();
      value.NonVisualDrawingProperties = GetNonVisualDrawingProperties(openXmlElement);
      value.NonVisualConnectionShapeProperties = GetNonVisualConnectionShapeProperties(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.ChartDrawing.NonVisualConnectorShapeDrawingProperties? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Drawing.ChartDrawing.NonVisualConnectorShapeDrawingProperties, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetNonVisualDrawingProperties(openXmlElement, value?.NonVisualDrawingProperties);
      SetNonVisualConnectionShapeProperties(openXmlElement, value?.NonVisualConnectionShapeProperties);
      return openXmlElement;
    }
    return default;
  }
}
