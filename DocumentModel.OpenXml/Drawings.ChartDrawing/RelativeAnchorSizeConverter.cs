namespace DocumentModel.OpenXml.Drawings.ChartDrawing;

/// <summary>
/// Relative Anchor Shape Size.
/// </summary>
public static class RelativeAnchorSizeConverter
{
  /// <summary>
  /// Starting Anchor Point.
  /// </summary>
  public static DocumentModel.Drawings.ChartDrawing.FromAnchor? GetFromAnchor(DocumentFormat.OpenXml.Drawing.ChartDrawing.RelativeAnchorSize? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.ChartDrawing.FromAnchor>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.ChartDrawing.FromAnchorConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetFromAnchor(DocumentFormat.OpenXml.Drawing.ChartDrawing.RelativeAnchorSize? openXmlElement, DocumentModel.Drawings.ChartDrawing.FromAnchor? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.ChartDrawing.FromAnchor>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Drawings.ChartDrawing.FromAnchorConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.ChartDrawing.FromAnchor>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  /// <summary>
  /// Ending Anchor Point.
  /// </summary>
  public static DocumentModel.Drawings.ChartDrawing.ToAnchor? GetToAnchor(DocumentFormat.OpenXml.Drawing.ChartDrawing.RelativeAnchorSize? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.ChartDrawing.ToAnchor>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.ChartDrawing.ToAnchorConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetToAnchor(DocumentFormat.OpenXml.Drawing.ChartDrawing.RelativeAnchorSize? openXmlElement, DocumentModel.Drawings.ChartDrawing.ToAnchor? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.ChartDrawing.ToAnchor>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Drawings.ChartDrawing.ToAnchorConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.ChartDrawing.ToAnchor>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static DocumentModel.Drawings.ChartDrawing.Shape? GetShape(DocumentFormat.OpenXml.Drawing.ChartDrawing.RelativeAnchorSize? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.ChartDrawing.Shape>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.ChartDrawing.ShapeConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetShape(DocumentFormat.OpenXml.Drawing.ChartDrawing.RelativeAnchorSize? openXmlElement, DocumentModel.Drawings.ChartDrawing.Shape? value)
  {
    if (openXmlElement != null)
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
  }
  
  public static DocumentModel.Drawings.ChartDrawing.GroupShape? GetGroupShape(DocumentFormat.OpenXml.Drawing.ChartDrawing.RelativeAnchorSize? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.ChartDrawing.GroupShape>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.ChartDrawing.GroupShapeConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetGroupShape(DocumentFormat.OpenXml.Drawing.ChartDrawing.RelativeAnchorSize? openXmlElement, DocumentModel.Drawings.ChartDrawing.GroupShape? value)
  {
    if (openXmlElement != null)
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
  }
  
  public static DocumentModel.Drawings.ChartDrawing.GraphicFrame? GetGraphicFrame(DocumentFormat.OpenXml.Drawing.ChartDrawing.RelativeAnchorSize? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.ChartDrawing.GraphicFrame>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.ChartDrawing.GraphicFrameConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetGraphicFrame(DocumentFormat.OpenXml.Drawing.ChartDrawing.RelativeAnchorSize? openXmlElement, DocumentModel.Drawings.ChartDrawing.GraphicFrame? value)
  {
    if (openXmlElement != null)
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
  }
  
  public static DocumentModel.Drawings.ChartDrawing.ConnectionShape? GetConnectionShape(DocumentFormat.OpenXml.Drawing.ChartDrawing.RelativeAnchorSize? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.ChartDrawing.ConnectionShape>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.ChartDrawing.ConnectionShapeConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetConnectionShape(DocumentFormat.OpenXml.Drawing.ChartDrawing.RelativeAnchorSize? openXmlElement, DocumentModel.Drawings.ChartDrawing.ConnectionShape? value)
  {
    if (openXmlElement != null)
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
  }
  
  public static DocumentModel.Drawings.ChartDrawing.Picture? GetPicture(DocumentFormat.OpenXml.Drawing.ChartDrawing.RelativeAnchorSize? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.ChartDrawing.Picture>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.ChartDrawing.PictureConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetPicture(DocumentFormat.OpenXml.Drawing.ChartDrawing.RelativeAnchorSize? openXmlElement, DocumentModel.Drawings.ChartDrawing.Picture? value)
  {
    if (openXmlElement != null)
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
  }
  
  public static DocumentModel.Drawings.ChartDrawing.RelativeAnchorSize? CreateModelElement(DocumentFormat.OpenXml.Drawing.ChartDrawing.RelativeAnchorSize? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.ChartDrawing.RelativeAnchorSize();
      value.FromAnchor = GetFromAnchor(openXmlElement);
      value.ToAnchor = GetToAnchor(openXmlElement);
      value.Shape = GetShape(openXmlElement);
      value.GroupShape = GetGroupShape(openXmlElement);
      value.GraphicFrame = GetGraphicFrame(openXmlElement);
      value.ConnectionShape = GetConnectionShape(openXmlElement);
      value.Picture = GetPicture(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.ChartDrawing.RelativeAnchorSize? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Drawing.ChartDrawing.RelativeAnchorSize, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetFromAnchor(openXmlElement, value?.FromAnchor);
      SetToAnchor(openXmlElement, value?.ToAnchor);
      SetShape(openXmlElement, value?.Shape);
      SetGroupShape(openXmlElement, value?.GroupShape);
      SetGraphicFrame(openXmlElement, value?.GraphicFrame);
      SetConnectionShape(openXmlElement, value?.ConnectionShape);
      SetPicture(openXmlElement, value?.Picture);
      return openXmlElement;
    }
    return default;
  }
}
