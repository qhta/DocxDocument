namespace DocumentModel.OpenXml.Drawings.ChartDrawing;

/// <summary>
/// Relative Anchor Shape Size.
/// </summary>
public static class RelativeAnchorSizeConverter
{
  /// <summary>
  /// Starting Anchor Point.
  /// </summary>
  private static DMDrawsChartDraw.FromAnchor? GetFromAnchor(DXDrawChartDraw.RelativeAnchorSize openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDrawChartDraw.FromAnchor>();
    if (itemElement != null)
      return DMXDrawsChartDraw.FromAnchorConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetFromAnchor(DXDrawChartDraw.RelativeAnchorSize openXmlElement, DMDrawsChartDraw.FromAnchor? value)
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
  /// Ending Anchor Point.
  /// </summary>
  private static DMDrawsChartDraw.ToAnchor? GetToAnchor(DXDrawChartDraw.RelativeAnchorSize openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDrawChartDraw.ToAnchor>();
    if (itemElement != null)
      return DMXDrawsChartDraw.ToAnchorConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetToAnchor(DXDrawChartDraw.RelativeAnchorSize openXmlElement, DMDrawsChartDraw.ToAnchor? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDrawChartDraw.ToAnchor>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDrawsChartDraw.ToAnchorConverter.CreateOpenXmlElement<DXDrawChartDraw.ToAnchor>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMDrawsChartDraw.Shape? GetShape(DXDrawChartDraw.RelativeAnchorSize openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDrawChartDraw.Shape>();
    if (itemElement != null)
      return DMXDrawsChartDraw.ShapeConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetShape(DXDrawChartDraw.RelativeAnchorSize openXmlElement, DMDrawsChartDraw.Shape? value)
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
  
  private static DMDrawsChartDraw.GroupShape? GetGroupShape(DXDrawChartDraw.RelativeAnchorSize openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDrawChartDraw.GroupShape>();
    if (itemElement != null)
      return DMXDrawsChartDraw.GroupShapeConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetGroupShape(DXDrawChartDraw.RelativeAnchorSize openXmlElement, DMDrawsChartDraw.GroupShape? value)
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
  
  private static DMDrawsChartDraw.GraphicFrame? GetGraphicFrame(DXDrawChartDraw.RelativeAnchorSize openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDrawChartDraw.GraphicFrame>();
    if (itemElement != null)
      return DMXDrawsChartDraw.GraphicFrameConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetGraphicFrame(DXDrawChartDraw.RelativeAnchorSize openXmlElement, DMDrawsChartDraw.GraphicFrame? value)
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
  
  private static DMDrawsChartDraw.ConnectionShape? GetConnectionShape(DXDrawChartDraw.RelativeAnchorSize openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDrawChartDraw.ConnectionShape>();
    if (itemElement != null)
      return DMXDrawsChartDraw.ConnectionShapeConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetConnectionShape(DXDrawChartDraw.RelativeAnchorSize openXmlElement, DMDrawsChartDraw.ConnectionShape? value)
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
  
  private static DMDrawsChartDraw.Picture? GetPicture(DXDrawChartDraw.RelativeAnchorSize openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDrawChartDraw.Picture>();
    if (itemElement != null)
      return DMXDrawsChartDraw.PictureConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetPicture(DXDrawChartDraw.RelativeAnchorSize openXmlElement, DMDrawsChartDraw.Picture? value)
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
  
  public static DMDrawsChartDraw.RelativeAnchorSize? CreateModelElement(DXDrawChartDraw.RelativeAnchorSize? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDrawsChartDraw.RelativeAnchorSize();
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
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDrawsChartDraw.RelativeAnchorSize? value)
    where OpenXmlElementType: DXDrawChartDraw.RelativeAnchorSize, new()
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
