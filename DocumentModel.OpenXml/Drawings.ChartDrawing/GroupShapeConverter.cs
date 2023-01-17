namespace DocumentModel.OpenXml.Drawings.ChartDrawing;

/// <summary>
/// Group Shape.
/// </summary>
public static class GroupShapeConverter
{
  /// <summary>
  /// Non-Visual Group Shape Properties.
  /// </summary>
  private static DocumentModel.Drawings.ChartDrawing.NonVisualGroupShapeProperties? GetNonVisualGroupShapeProperties(DocumentFormat.OpenXml.Drawing.ChartDrawing.GroupShape openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.ChartDrawing.NonVisualGroupShapeProperties>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.ChartDrawing.NonVisualGroupShapePropertiesConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetNonVisualGroupShapeProperties(DocumentFormat.OpenXml.Drawing.ChartDrawing.GroupShape openXmlElement, DocumentModel.Drawings.ChartDrawing.NonVisualGroupShapeProperties? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.ChartDrawing.NonVisualGroupShapeProperties>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Drawings.ChartDrawing.NonVisualGroupShapePropertiesConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.ChartDrawing.NonVisualGroupShapeProperties>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Group Shape Properties.
  /// </summary>
  private static DocumentModel.Drawings.ChartDrawing.GroupShapeProperties? GetGroupShapeProperties(DocumentFormat.OpenXml.Drawing.ChartDrawing.GroupShape openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.ChartDrawing.GroupShapeProperties>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.ChartDrawing.GroupShapePropertiesConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetGroupShapeProperties(DocumentFormat.OpenXml.Drawing.ChartDrawing.GroupShape openXmlElement, DocumentModel.Drawings.ChartDrawing.GroupShapeProperties? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.ChartDrawing.GroupShapeProperties>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Drawings.ChartDrawing.GroupShapePropertiesConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.ChartDrawing.GroupShapeProperties>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DocumentModel.Drawings.ChartDrawing.Shape? GetShape(DocumentFormat.OpenXml.Drawing.ChartDrawing.GroupShape openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.ChartDrawing.Shape>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.ChartDrawing.ShapeConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetShape(DocumentFormat.OpenXml.Drawing.ChartDrawing.GroupShape openXmlElement, DocumentModel.Drawings.ChartDrawing.Shape? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.ChartDrawing.Shape>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Drawings.ChartDrawing.ShapeConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.ChartDrawing.Shape>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DocumentModel.Drawings.ChartDrawing.GroupShape? GetChildGroupShape(DocumentFormat.OpenXml.Drawing.ChartDrawing.GroupShape openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.ChartDrawing.GroupShape>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.ChartDrawing.GroupShapeConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetChildGroupShape(DocumentFormat.OpenXml.Drawing.ChartDrawing.GroupShape openXmlElement, DocumentModel.Drawings.ChartDrawing.GroupShape? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.ChartDrawing.GroupShape>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Drawings.ChartDrawing.GroupShapeConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.ChartDrawing.GroupShape>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DocumentModel.Drawings.ChartDrawing.GraphicFrame? GetGraphicFrame(DocumentFormat.OpenXml.Drawing.ChartDrawing.GroupShape openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.ChartDrawing.GraphicFrame>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.ChartDrawing.GraphicFrameConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetGraphicFrame(DocumentFormat.OpenXml.Drawing.ChartDrawing.GroupShape openXmlElement, DocumentModel.Drawings.ChartDrawing.GraphicFrame? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.ChartDrawing.GraphicFrame>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Drawings.ChartDrawing.GraphicFrameConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.ChartDrawing.GraphicFrame>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DocumentModel.Drawings.ChartDrawing.ConnectionShape? GetConnectionShape(DocumentFormat.OpenXml.Drawing.ChartDrawing.GroupShape openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.ChartDrawing.ConnectionShape>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.ChartDrawing.ConnectionShapeConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetConnectionShape(DocumentFormat.OpenXml.Drawing.ChartDrawing.GroupShape openXmlElement, DocumentModel.Drawings.ChartDrawing.ConnectionShape? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.ChartDrawing.ConnectionShape>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Drawings.ChartDrawing.ConnectionShapeConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.ChartDrawing.ConnectionShape>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DocumentModel.Drawings.ChartDrawing.Picture? GetPicture(DocumentFormat.OpenXml.Drawing.ChartDrawing.GroupShape openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.ChartDrawing.Picture>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.ChartDrawing.PictureConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetPicture(DocumentFormat.OpenXml.Drawing.ChartDrawing.GroupShape openXmlElement, DocumentModel.Drawings.ChartDrawing.Picture? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.ChartDrawing.Picture>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Drawings.ChartDrawing.PictureConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.ChartDrawing.Picture>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DocumentModel.Drawings.ChartDrawing.GroupShape? CreateModelElement(DocumentFormat.OpenXml.Drawing.ChartDrawing.GroupShape? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.ChartDrawing.GroupShape();
      value.NonVisualGroupShapeProperties = GetNonVisualGroupShapeProperties(openXmlElement);
      value.GroupShapeProperties = GetGroupShapeProperties(openXmlElement);
      value.Shape = GetShape(openXmlElement);
      value.ChildGroupShape = GetChildGroupShape(openXmlElement);
      value.GraphicFrame = GetGraphicFrame(openXmlElement);
      value.ConnectionShape = GetConnectionShape(openXmlElement);
      value.Picture = GetPicture(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.ChartDrawing.GroupShape? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Drawing.ChartDrawing.GroupShape, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetNonVisualGroupShapeProperties(openXmlElement, value?.NonVisualGroupShapeProperties);
      SetGroupShapeProperties(openXmlElement, value?.GroupShapeProperties);
      SetShape(openXmlElement, value?.Shape);
      SetChildGroupShape(openXmlElement, value?.ChildGroupShape);
      SetGraphicFrame(openXmlElement, value?.GraphicFrame);
      SetConnectionShape(openXmlElement, value?.ConnectionShape);
      SetPicture(openXmlElement, value?.Picture);
      return openXmlElement;
    }
    return default;
  }
}
