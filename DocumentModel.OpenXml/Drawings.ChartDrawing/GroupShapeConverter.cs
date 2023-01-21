namespace DocumentModel.OpenXml.Drawings.ChartDrawing;

/// <summary>
/// Group Shape.
/// </summary>
public static class GroupShapeConverter
{
  /// <summary>
  /// Non-Visual Group Shape Properties.
  /// </summary>
  private static DMDrawsChartDraw.NonVisualGroupShapeProperties? GetNonVisualGroupShapeProperties(DXDrawChartDraw.GroupShape openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDrawChartDraw.NonVisualGroupShapeProperties>();
    if (itemElement != null)
      return DMXDrawsChartDraw.NonVisualGroupShapePropertiesConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetNonVisualGroupShapeProperties(DXDrawChartDraw.GroupShape openXmlElement, DMDrawsChartDraw.NonVisualGroupShapeProperties? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDrawChartDraw.NonVisualGroupShapeProperties>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDrawsChartDraw.NonVisualGroupShapePropertiesConverter.CreateOpenXmlElement<DXDrawChartDraw.NonVisualGroupShapeProperties>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Group Shape Properties.
  /// </summary>
  private static DMDrawsChartDraw.GroupShapeProperties? GetGroupShapeProperties(DXDrawChartDraw.GroupShape openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDrawChartDraw.GroupShapeProperties>();
    if (itemElement != null)
      return DMXDrawsChartDraw.GroupShapePropertiesConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetGroupShapeProperties(DXDrawChartDraw.GroupShape openXmlElement, DMDrawsChartDraw.GroupShapeProperties? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDrawChartDraw.GroupShapeProperties>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDrawsChartDraw.GroupShapePropertiesConverter.CreateOpenXmlElement<DXDrawChartDraw.GroupShapeProperties>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMDrawsChartDraw.Shape? GetShape(DXDrawChartDraw.GroupShape openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDrawChartDraw.Shape>();
    if (itemElement != null)
      return DMXDrawsChartDraw.ShapeConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetShape(DXDrawChartDraw.GroupShape openXmlElement, DMDrawsChartDraw.Shape? value)
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
  
  private static DMDrawsChartDraw.GroupShape? GetChildGroupShape(DXDrawChartDraw.GroupShape openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDrawChartDraw.GroupShape>();
    if (itemElement != null)
      return DMXDrawsChartDraw.GroupShapeConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetChildGroupShape(DXDrawChartDraw.GroupShape openXmlElement, DMDrawsChartDraw.GroupShape? value)
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
  
  private static DMDrawsChartDraw.GraphicFrame? GetGraphicFrame(DXDrawChartDraw.GroupShape openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDrawChartDraw.GraphicFrame>();
    if (itemElement != null)
      return DMXDrawsChartDraw.GraphicFrameConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetGraphicFrame(DXDrawChartDraw.GroupShape openXmlElement, DMDrawsChartDraw.GraphicFrame? value)
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
  
  private static DMDrawsChartDraw.ConnectionShape? GetConnectionShape(DXDrawChartDraw.GroupShape openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDrawChartDraw.ConnectionShape>();
    if (itemElement != null)
      return DMXDrawsChartDraw.ConnectionShapeConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetConnectionShape(DXDrawChartDraw.GroupShape openXmlElement, DMDrawsChartDraw.ConnectionShape? value)
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
  
  private static DMDrawsChartDraw.Picture? GetPicture(DXDrawChartDraw.GroupShape openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDrawChartDraw.Picture>();
    if (itemElement != null)
      return DMXDrawsChartDraw.PictureConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetPicture(DXDrawChartDraw.GroupShape openXmlElement, DMDrawsChartDraw.Picture? value)
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
  
  public static DMDrawsChartDraw.GroupShape? CreateModelElement(DXDrawChartDraw.GroupShape? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDrawsChartDraw.GroupShape();
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
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDrawsChartDraw.GroupShape? value)
    where OpenXmlElementType: DXDrawChartDraw.GroupShape, new()
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
