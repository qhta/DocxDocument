namespace DocumentModel.OpenXml.Drawings.ChartDrawing;

/// <summary>
/// Absolute Anchor Shape Size.
/// </summary>
public static class AbsoluteAnchorSizeConverter
{
  /// <summary>
  /// FromAnchor.
  /// </summary>
  private static DMDrawsChartDraw.FromAnchor? GetFromAnchor(DXDrawChartDraw.AbsoluteAnchorSize openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDrawChartDraw.FromAnchor>();
    if (itemElement != null)
      return DMXDrawsChartDraw.FromAnchorConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetFromAnchor(DXDrawChartDraw.AbsoluteAnchorSize openXmlElement, DMDrawsChartDraw.FromAnchor? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDrawChartDraw.FromAnchor>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDrawsChartDraw.FromAnchorConverter.CreateOpenXmlElement<DXDrawChartDraw.FromAnchor>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Shape Extent.
  /// </summary>
  private static DMDrawsChartDraw.Extent? GetExtent(DXDrawChartDraw.AbsoluteAnchorSize openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDrawChartDraw.Extent>();
    if (itemElement != null)
      return DMXDrawsChartDraw.ExtentConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetExtent(DXDrawChartDraw.AbsoluteAnchorSize openXmlElement, DMDrawsChartDraw.Extent? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDrawChartDraw.Extent>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDrawsChartDraw.ExtentConverter.CreateOpenXmlElement<DXDrawChartDraw.Extent>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMDrawsChartDraw.Shape? GetShape(DXDrawChartDraw.AbsoluteAnchorSize openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDrawChartDraw.Shape>();
    if (itemElement != null)
      return DMXDrawsChartDraw.ShapeConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetShape(DXDrawChartDraw.AbsoluteAnchorSize openXmlElement, DMDrawsChartDraw.Shape? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDrawChartDraw.Shape>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDrawsChartDraw.ShapeConverter.CreateOpenXmlElement<DXDrawChartDraw.Shape>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMDrawsChartDraw.GroupShape? GetGroupShape(DXDrawChartDraw.AbsoluteAnchorSize openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDrawChartDraw.GroupShape>();
    if (itemElement != null)
      return DMXDrawsChartDraw.GroupShapeConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetGroupShape(DXDrawChartDraw.AbsoluteAnchorSize openXmlElement, DMDrawsChartDraw.GroupShape? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDrawChartDraw.GroupShape>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDrawsChartDraw.GroupShapeConverter.CreateOpenXmlElement<DXDrawChartDraw.GroupShape>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMDrawsChartDraw.GraphicFrame? GetGraphicFrame(DXDrawChartDraw.AbsoluteAnchorSize openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDrawChartDraw.GraphicFrame>();
    if (itemElement != null)
      return DMXDrawsChartDraw.GraphicFrameConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetGraphicFrame(DXDrawChartDraw.AbsoluteAnchorSize openXmlElement, DMDrawsChartDraw.GraphicFrame? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDrawChartDraw.GraphicFrame>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDrawsChartDraw.GraphicFrameConverter.CreateOpenXmlElement<DXDrawChartDraw.GraphicFrame>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMDrawsChartDraw.ConnectionShape? GetConnectionShape(DXDrawChartDraw.AbsoluteAnchorSize openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDrawChartDraw.ConnectionShape>();
    if (itemElement != null)
      return DMXDrawsChartDraw.ConnectionShapeConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetConnectionShape(DXDrawChartDraw.AbsoluteAnchorSize openXmlElement, DMDrawsChartDraw.ConnectionShape? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDrawChartDraw.ConnectionShape>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDrawsChartDraw.ConnectionShapeConverter.CreateOpenXmlElement<DXDrawChartDraw.ConnectionShape>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMDrawsChartDraw.Picture? GetPicture(DXDrawChartDraw.AbsoluteAnchorSize openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDrawChartDraw.Picture>();
    if (itemElement != null)
      return DMXDrawsChartDraw.PictureConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetPicture(DXDrawChartDraw.AbsoluteAnchorSize openXmlElement, DMDrawsChartDraw.Picture? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDrawChartDraw.Picture>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDrawsChartDraw.PictureConverter.CreateOpenXmlElement<DXDrawChartDraw.Picture>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DMDrawsChartDraw.AbsoluteAnchorSize? CreateModelElement(DXDrawChartDraw.AbsoluteAnchorSize? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDrawsChartDraw.AbsoluteAnchorSize();
      value.FromAnchor = GetFromAnchor(openXmlElement);
      value.Extent = GetExtent(openXmlElement);
      value.Shape = GetShape(openXmlElement);
      value.GroupShape = GetGroupShape(openXmlElement);
      value.GraphicFrame = GetGraphicFrame(openXmlElement);
      value.ConnectionShape = GetConnectionShape(openXmlElement);
      value.Picture = GetPicture(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDrawsChartDraw.AbsoluteAnchorSize? value)
    where OpenXmlElementType: DXDrawChartDraw.AbsoluteAnchorSize, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetFromAnchor(openXmlElement, value?.FromAnchor);
      SetExtent(openXmlElement, value?.Extent);
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
