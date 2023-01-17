namespace DocumentModel.OpenXml.Drawings.Office;

/// <summary>
/// Defines the ShapeNonVisualProperties Class.
/// </summary>
public static class ShapeNonVisualPropertiesConverter
{
  /// <summary>
  /// NonVisualDrawingProperties.
  /// </summary>
  private static DocumentModel.Drawings.Office.NonVisualDrawingProperties? GetNonVisualDrawingProperties(DocumentFormat.OpenXml.Office.Drawing.ShapeNonVisualProperties openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office.Drawing.NonVisualDrawingProperties>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.Office.NonVisualDrawingPropertiesConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetNonVisualDrawingProperties(DocumentFormat.OpenXml.Office.Drawing.ShapeNonVisualProperties openXmlElement, DocumentModel.Drawings.Office.NonVisualDrawingProperties? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office.Drawing.NonVisualDrawingProperties>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Drawings.Office.NonVisualDrawingPropertiesConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office.Drawing.NonVisualDrawingProperties>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// NonVisualDrawingShapeProperties.
  /// </summary>
  private static DocumentModel.Drawings.Office.NonVisualDrawingShapeProperties? GetNonVisualDrawingShapeProperties(DocumentFormat.OpenXml.Office.Drawing.ShapeNonVisualProperties openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office.Drawing.NonVisualDrawingShapeProperties>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.Office.NonVisualDrawingShapePropertiesConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetNonVisualDrawingShapeProperties(DocumentFormat.OpenXml.Office.Drawing.ShapeNonVisualProperties openXmlElement, DocumentModel.Drawings.Office.NonVisualDrawingShapeProperties? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office.Drawing.NonVisualDrawingShapeProperties>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Drawings.Office.NonVisualDrawingShapePropertiesConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office.Drawing.NonVisualDrawingShapeProperties>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DocumentModel.Drawings.Office.ShapeNonVisualProperties? CreateModelElement(DocumentFormat.OpenXml.Office.Drawing.ShapeNonVisualProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Office.ShapeNonVisualProperties();
      value.NonVisualDrawingProperties = GetNonVisualDrawingProperties(openXmlElement);
      value.NonVisualDrawingShapeProperties = GetNonVisualDrawingShapeProperties(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.Office.ShapeNonVisualProperties? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Office.Drawing.ShapeNonVisualProperties, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetNonVisualDrawingProperties(openXmlElement, value?.NonVisualDrawingProperties);
      SetNonVisualDrawingShapeProperties(openXmlElement, value?.NonVisualDrawingShapeProperties);
      return openXmlElement;
    }
    return default;
  }
}
