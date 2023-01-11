namespace DocumentModel.OpenXml.Drawings.ChartDrawing;

/// <summary>
/// Connection Shape.
/// </summary>
public static class ConnectionShapeConverter
{
  /// <summary>
  /// Reference to Custom Function
  /// </summary>
  public static String? GetMacro(DocumentFormat.OpenXml.Drawing.ChartDrawing.ConnectionShape? openXmlElement)
  {
    return openXmlElement?.Macro?.Value;
  }
  
  public static void SetMacro(DocumentFormat.OpenXml.Drawing.ChartDrawing.ConnectionShape? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Macro = new StringValue { Value = value };
      else
        openXmlElement.Macro = null;
  }
  
  /// <summary>
  /// Publish to Server
  /// </summary>
  public static Boolean? GetPublished(DocumentFormat.OpenXml.Drawing.ChartDrawing.ConnectionShape? openXmlElement)
  {
    return openXmlElement?.Published?.Value;
  }
  
  public static void SetPublished(DocumentFormat.OpenXml.Drawing.ChartDrawing.ConnectionShape? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Published = new BooleanValue { Value = (Boolean)value };
      else
        openXmlElement.Published = null;
  }
  
  /// <summary>
  /// Connector Non Visual Properties.
  /// </summary>
  public static DocumentModel.Drawings.ChartDrawing.NonVisualConnectorShapeDrawingProperties? GetNonVisualConnectorShapeDrawingProperties(DocumentFormat.OpenXml.Drawing.ChartDrawing.ConnectionShape? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.ChartDrawing.NonVisualConnectorShapeDrawingProperties>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.ChartDrawing.NonVisualConnectorShapeDrawingPropertiesConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetNonVisualConnectorShapeDrawingProperties(DocumentFormat.OpenXml.Drawing.ChartDrawing.ConnectionShape? openXmlElement, DocumentModel.Drawings.ChartDrawing.NonVisualConnectorShapeDrawingProperties? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.ChartDrawing.NonVisualConnectorShapeDrawingProperties>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Drawings.ChartDrawing.NonVisualConnectorShapeDrawingPropertiesConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.ChartDrawing.NonVisualConnectorShapeDrawingProperties>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  /// <summary>
  /// Shape Properties.
  /// </summary>
  public static DocumentModel.Drawings.ChartDrawing.ShapeProperties? GetShapeProperties(DocumentFormat.OpenXml.Drawing.ChartDrawing.ConnectionShape? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.ChartDrawing.ShapeProperties>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.ChartDrawing.ShapePropertiesConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetShapeProperties(DocumentFormat.OpenXml.Drawing.ChartDrawing.ConnectionShape? openXmlElement, DocumentModel.Drawings.ChartDrawing.ShapeProperties? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.ChartDrawing.ShapeProperties>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Drawings.ChartDrawing.ShapePropertiesConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.ChartDrawing.ShapeProperties>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  /// <summary>
  /// Connection Shape Style.
  /// </summary>
  public static DocumentModel.Drawings.ChartDrawing.Style? GetStyle(DocumentFormat.OpenXml.Drawing.ChartDrawing.ConnectionShape? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.ChartDrawing.Style>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.ChartDrawing.StyleConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetStyle(DocumentFormat.OpenXml.Drawing.ChartDrawing.ConnectionShape? openXmlElement, DocumentModel.Drawings.ChartDrawing.Style? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.ChartDrawing.Style>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Drawings.ChartDrawing.StyleConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.ChartDrawing.Style>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static DocumentModel.Drawings.ChartDrawing.ConnectionShape? CreateModelElement(DocumentFormat.OpenXml.Drawing.ChartDrawing.ConnectionShape? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.ChartDrawing.ConnectionShape();
      value.Macro = GetMacro(openXmlElement);
      value.Published = GetPublished(openXmlElement);
      value.NonVisualConnectorShapeDrawingProperties = GetNonVisualConnectorShapeDrawingProperties(openXmlElement);
      value.ShapeProperties = GetShapeProperties(openXmlElement);
      value.Style = GetStyle(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.ChartDrawing.ConnectionShape? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Drawing.ChartDrawing.ConnectionShape, new()
  {
  throw new NotImplementedException("Not implemented in GenerateCreateOpenXmlElementMethod: 1");
  }
}
