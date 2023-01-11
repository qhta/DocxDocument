namespace DocumentModel.OpenXml.Drawings.ChartDrawings;

/// <summary>
/// Defines the NonVisualContentPartProperties Class.
/// </summary>
public static class NonVisualContentPartPropertiesConverter
{
  /// <summary>
  /// NonVisualDrawingProperties.
  /// </summary>
  public static DocumentModel.Drawings.ChartDrawings.NonVisualDrawingProperties? GetNonVisualDrawingProperties(DocumentFormat.OpenXml.Office2010.Drawing.ChartDrawing.NonVisualContentPartProperties? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2010.Drawing.ChartDrawing.NonVisualDrawingProperties>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.ChartDrawings.NonVisualDrawingPropertiesConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetNonVisualDrawingProperties(DocumentFormat.OpenXml.Office2010.Drawing.ChartDrawing.NonVisualContentPartProperties? openXmlElement, DocumentModel.Drawings.ChartDrawings.NonVisualDrawingProperties? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.Drawing.ChartDrawing.NonVisualDrawingProperties>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Drawings.ChartDrawings.NonVisualDrawingPropertiesConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2010.Drawing.ChartDrawing.NonVisualDrawingProperties>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  /// <summary>
  /// NonVisualInkContentPartProperties.
  /// </summary>
  public static DocumentModel.Drawings.ChartDrawings.NonVisualInkContentPartProperties? GetNonVisualInkContentPartProperties(DocumentFormat.OpenXml.Office2010.Drawing.ChartDrawing.NonVisualContentPartProperties? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2010.Drawing.ChartDrawing.NonVisualInkContentPartProperties>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.ChartDrawings.NonVisualInkContentPartPropertiesConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetNonVisualInkContentPartProperties(DocumentFormat.OpenXml.Office2010.Drawing.ChartDrawing.NonVisualContentPartProperties? openXmlElement, DocumentModel.Drawings.ChartDrawings.NonVisualInkContentPartProperties? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.Drawing.ChartDrawing.NonVisualInkContentPartProperties>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Drawings.ChartDrawings.NonVisualInkContentPartPropertiesConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2010.Drawing.ChartDrawing.NonVisualInkContentPartProperties>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static DocumentModel.Drawings.ChartDrawings.NonVisualContentPartProperties? CreateModelElement(DocumentFormat.OpenXml.Office2010.Drawing.ChartDrawing.NonVisualContentPartProperties? openXmlElement)
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
    where OpenXmlElementType: DocumentFormat.OpenXml.Office2010.Drawing.ChartDrawing.NonVisualContentPartProperties, new()
  {
  throw new NotImplementedException("Not implemented in GenerateCreateOpenXmlElementMethod: 1");
  }
}
