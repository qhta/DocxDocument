namespace DocumentModel.OpenXml.Drawings.ChartDrawing;

/// <summary>
/// Group Shape converter from/to OpenXml.
///</summary>
public static class GroupShapeConverter
{
  /// <summary>
  /// Non-Visual Group Shape Properties.
  /// </summary>
  private static DMDrawsChartDraw.NonVisualGroupShapeProperties? GetNonVisualGroupShapeProperties(DXDrawChartDraw.GroupShape openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDrawChartDraw.NonVisualGroupShapeProperties>();
    if (element != null)
      return DMXDrawsChartDraw.NonVisualGroupShapePropertiesConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpNonVisualGroupShapeProperties(DXDrawChartDraw.GroupShape openXmlElement, DMDrawsChartDraw.NonVisualGroupShapeProperties? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsChartDraw.NonVisualGroupShapePropertiesConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDrawChartDraw.NonVisualGroupShapeProperties>(), value, diffs, objName);
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
    var element = openXmlElement?.GetFirstChild<DXDrawChartDraw.GroupShapeProperties>();
    if (element != null)
      return DMXDrawsChartDraw.GroupShapePropertiesConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpGroupShapeProperties(DXDrawChartDraw.GroupShape openXmlElement, DMDrawsChartDraw.GroupShapeProperties? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsChartDraw.GroupShapePropertiesConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDrawChartDraw.GroupShapeProperties>(), value, diffs, objName);
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
    var element = openXmlElement?.GetFirstChild<DXDrawChartDraw.Shape>();
    if (element != null)
      return DMXDrawsChartDraw.ShapeConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpShape(DXDrawChartDraw.GroupShape openXmlElement, DMDrawsChartDraw.Shape? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsChartDraw.ShapeConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDrawChartDraw.Shape>(), value, diffs, objName);
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
    var element = openXmlElement?.GetFirstChild<DXDrawChartDraw.GroupShape>();
    if (element != null)
      return DMXDrawsChartDraw.GroupShapeConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpChildGroupShape(DXDrawChartDraw.GroupShape openXmlElement, DMDrawsChartDraw.GroupShape? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsChartDraw.GroupShapeConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDrawChartDraw.GroupShape>(), value, diffs, objName);
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
    var element = openXmlElement?.GetFirstChild<DXDrawChartDraw.GraphicFrame>();
    if (element != null)
      return DMXDrawsChartDraw.GraphicFrameConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpGraphicFrame(DXDrawChartDraw.GroupShape openXmlElement, DMDrawsChartDraw.GraphicFrame? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsChartDraw.GraphicFrameConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDrawChartDraw.GraphicFrame>(), value, diffs, objName);
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
    var element = openXmlElement?.GetFirstChild<DXDrawChartDraw.ConnectionShape>();
    if (element != null)
      return DMXDrawsChartDraw.ConnectionShapeConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpConnectionShape(DXDrawChartDraw.GroupShape openXmlElement, DMDrawsChartDraw.ConnectionShape? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsChartDraw.ConnectionShapeConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDrawChartDraw.ConnectionShape>(), value, diffs, objName);
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
    var element = openXmlElement?.GetFirstChild<DXDrawChartDraw.Picture>();
    if (element != null)
      return DMXDrawsChartDraw.PictureConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpPicture(DXDrawChartDraw.GroupShape openXmlElement, DMDrawsChartDraw.Picture? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsChartDraw.PictureConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDrawChartDraw.Picture>(), value, diffs, objName);
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
  
  public static DocumentModel.Drawings.ChartDrawing.GroupShape? CreateModelElement(DXDrawChartDraw.GroupShape? openXmlElement)
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
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDrawsChartDraw.GroupShape value)
    where OpenXmlElementType: DXDrawChartDraw.GroupShape, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXDrawChartDraw.GroupShape openXmlElement, DMDrawsChartDraw.GroupShape value)
  {
    SetNonVisualGroupShapeProperties(openXmlElement, value?.NonVisualGroupShapeProperties);
    SetGroupShapeProperties(openXmlElement, value?.GroupShapeProperties);
    SetShape(openXmlElement, value?.Shape);
    SetChildGroupShape(openXmlElement, value?.ChildGroupShape);
    SetGraphicFrame(openXmlElement, value?.GraphicFrame);
    SetConnectionShape(openXmlElement, value?.ConnectionShape);
    SetPicture(openXmlElement, value?.Picture);
  }
}
