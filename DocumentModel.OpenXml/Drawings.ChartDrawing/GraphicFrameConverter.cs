namespace DocumentModel.OpenXml.Drawings.ChartDrawing;

/// <summary>
/// Graphic Frame.
/// </summary>
public static class GraphicFrameConverter
{
  /// <summary>
  /// Reference to Custom Function
  /// </summary>
  public static String? GetMacro(DocumentFormat.OpenXml.Drawing.ChartDrawing.GraphicFrame? openXmlElement)
  {
    return openXmlElement?.Macro?.Value;
  }
  
  public static void SetMacro(DocumentFormat.OpenXml.Drawing.ChartDrawing.GraphicFrame? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Macro = new StringValue { Value = value };
      else
        openXmlElement.Macro = null;
  }
  
  /// <summary>
  /// Publish To Server
  /// </summary>
  public static Boolean? GetPublished(DocumentFormat.OpenXml.Drawing.ChartDrawing.GraphicFrame? openXmlElement)
  {
    return openXmlElement?.Published?.Value;
  }
  
  public static void SetPublished(DocumentFormat.OpenXml.Drawing.ChartDrawing.GraphicFrame? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Published = new BooleanValue { Value = (Boolean)value };
      else
        openXmlElement.Published = null;
  }
  
  /// <summary>
  /// Non-Visual Graphic Frame Properties.
  /// </summary>
  public static DocumentModel.Drawings.ChartDrawing.NonVisualGraphicFrameProperties? GetNonVisualGraphicFrameProperties(DocumentFormat.OpenXml.Drawing.ChartDrawing.GraphicFrame? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.ChartDrawing.NonVisualGraphicFrameProperties>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.ChartDrawing.NonVisualGraphicFramePropertiesConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetNonVisualGraphicFrameProperties(DocumentFormat.OpenXml.Drawing.ChartDrawing.GraphicFrame? openXmlElement, DocumentModel.Drawings.ChartDrawing.NonVisualGraphicFrameProperties? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.ChartDrawing.NonVisualGraphicFrameProperties>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Drawings.ChartDrawing.NonVisualGraphicFramePropertiesConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.ChartDrawing.NonVisualGraphicFrameProperties>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  /// <summary>
  /// Graphic Frame Transform.
  /// </summary>
  public static DocumentModel.Drawings.ChartDrawing.Transform? GetTransform(DocumentFormat.OpenXml.Drawing.ChartDrawing.GraphicFrame? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.ChartDrawing.Transform>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.ChartDrawing.TransformConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetTransform(DocumentFormat.OpenXml.Drawing.ChartDrawing.GraphicFrame? openXmlElement, DocumentModel.Drawings.ChartDrawing.Transform? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.ChartDrawing.Transform>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Drawings.ChartDrawing.TransformConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.ChartDrawing.Transform>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  /// <summary>
  /// Graphical Object.
  /// </summary>
  public static DocumentModel.Drawings.Graphic? GetGraphic(DocumentFormat.OpenXml.Drawing.ChartDrawing.GraphicFrame? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Graphic>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.GraphicConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetGraphic(DocumentFormat.OpenXml.Drawing.ChartDrawing.GraphicFrame? openXmlElement, DocumentModel.Drawings.Graphic? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Graphic>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Drawings.GraphicConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Graphic>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static DocumentModel.Drawings.ChartDrawing.GraphicFrame? CreateModelElement(DocumentFormat.OpenXml.Drawing.ChartDrawing.GraphicFrame? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.ChartDrawing.GraphicFrame();
      value.Macro = GetMacro(openXmlElement);
      value.Published = GetPublished(openXmlElement);
      value.NonVisualGraphicFrameProperties = GetNonVisualGraphicFrameProperties(openXmlElement);
      value.Transform = GetTransform(openXmlElement);
      value.Graphic = GetGraphic(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.ChartDrawing.GraphicFrame? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Drawing.ChartDrawing.GraphicFrame, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetMacro(openXmlElement, value?.Macro);
      SetPublished(openXmlElement, value?.Published);
      SetNonVisualGraphicFrameProperties(openXmlElement, value?.NonVisualGraphicFrameProperties);
      SetTransform(openXmlElement, value?.Transform);
      SetGraphic(openXmlElement, value?.Graphic);
      return openXmlElement;
    }
    return default;
  }
}
