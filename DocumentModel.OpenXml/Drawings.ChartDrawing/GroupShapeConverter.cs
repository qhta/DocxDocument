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
    return DMXDrawsChartDraw.NonVisualGroupShapePropertiesConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXDrawChartDraw.NonVisualGroupShapeProperties>());
  }
  
  private static bool CmpNonVisualGroupShapeProperties(DXDrawChartDraw.GroupShape openXmlElement, DMDrawsChartDraw.NonVisualGroupShapeProperties? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsChartDraw.NonVisualGroupShapePropertiesConverter.CompareModelElement(openXmlElement?.GetFirstChild<DXDrawChartDraw.NonVisualGroupShapeProperties>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
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
    return DMXDrawsChartDraw.GroupShapePropertiesConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXDrawChartDraw.GroupShapeProperties>());
  }
  
  private static bool CmpGroupShapeProperties(DXDrawChartDraw.GroupShape openXmlElement, DMDrawsChartDraw.GroupShapeProperties? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsChartDraw.GroupShapePropertiesConverter.CompareModelElement(openXmlElement?.GetFirstChild<DXDrawChartDraw.GroupShapeProperties>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
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
    return DMXDrawsChartDraw.ShapeConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXDrawChartDraw.Shape>());
  }
  
  private static bool CmpShape(DXDrawChartDraw.GroupShape openXmlElement, DMDrawsChartDraw.Shape? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsChartDraw.ShapeConverter.CompareModelElement(openXmlElement?.GetFirstChild<DXDrawChartDraw.Shape>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
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
    return DMXDrawsChartDraw.GroupShapeConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXDrawChartDraw.GroupShape>());
  }
  
  private static bool CmpChildGroupShape(DXDrawChartDraw.GroupShape openXmlElement, DMDrawsChartDraw.GroupShape? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsChartDraw.GroupShapeConverter.CompareModelElement(openXmlElement?.GetFirstChild<DXDrawChartDraw.GroupShape>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
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
    return DMXDrawsChartDraw.GraphicFrameConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXDrawChartDraw.GraphicFrame>());
  }
  
  private static bool CmpGraphicFrame(DXDrawChartDraw.GroupShape openXmlElement, DMDrawsChartDraw.GraphicFrame? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsChartDraw.GraphicFrameConverter.CompareModelElement(openXmlElement?.GetFirstChild<DXDrawChartDraw.GraphicFrame>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
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
    return DMXDrawsChartDraw.ConnectionShapeConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXDrawChartDraw.ConnectionShape>());
  }
  
  private static bool CmpConnectionShape(DXDrawChartDraw.GroupShape openXmlElement, DMDrawsChartDraw.ConnectionShape? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsChartDraw.ConnectionShapeConverter.CompareModelElement(openXmlElement?.GetFirstChild<DXDrawChartDraw.ConnectionShape>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
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
    return DMXDrawsChartDraw.PictureConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXDrawChartDraw.Picture>());
  }
  
  private static bool CmpPicture(DXDrawChartDraw.GroupShape openXmlElement, DMDrawsChartDraw.Picture? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsChartDraw.PictureConverter.CompareModelElement(openXmlElement?.GetFirstChild<DXDrawChartDraw.Picture>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
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
  
  public static bool CompareModelElement(DXDrawChartDraw.GroupShape? openXmlElement, DMDrawsChartDraw.GroupShape? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpNonVisualGroupShapeProperties(openXmlElement, value.NonVisualGroupShapeProperties, diffs, objName))
        ok = false;
      if (!CmpGroupShapeProperties(openXmlElement, value.GroupShapeProperties, diffs, objName))
        ok = false;
      if (!CmpShape(openXmlElement, value.Shape, diffs, objName))
        ok = false;
      if (!CmpChildGroupShape(openXmlElement, value.ChildGroupShape, diffs, objName))
        ok = false;
      if (!CmpGraphicFrame(openXmlElement, value.GraphicFrame, diffs, objName))
        ok = false;
      if (!CmpConnectionShape(openXmlElement, value.ConnectionShape, diffs, objName))
        ok = false;
      if (!CmpPicture(openXmlElement, value.Picture, diffs, objName))
        ok = false;
      return ok;
    }
    return openXmlElement == null && value == null;
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
