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
    var element = openXmlElement?.GetFirstChild<DXDrawChartDraw.FromAnchor>();
    if (element != null)
      return DMXDrawsChartDraw.FromAnchorConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpFromAnchor(DXDrawChartDraw.AbsoluteAnchorSize openXmlElement, DMDrawsChartDraw.FromAnchor? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsChartDraw.FromAnchorConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDrawChartDraw.FromAnchor>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
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
    var element = openXmlElement?.GetFirstChild<DXDrawChartDraw.Extent>();
    if (element != null)
      return DMXDrawsChartDraw.ExtentConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpExtent(DXDrawChartDraw.AbsoluteAnchorSize openXmlElement, DMDrawsChartDraw.Extent? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsChartDraw.ExtentConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDrawChartDraw.Extent>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
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
    var element = openXmlElement?.GetFirstChild<DXDrawChartDraw.Shape>();
    if (element != null)
      return DMXDrawsChartDraw.ShapeConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpShape(DXDrawChartDraw.AbsoluteAnchorSize openXmlElement, DMDrawsChartDraw.Shape? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsChartDraw.ShapeConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDrawChartDraw.Shape>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
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
    var element = openXmlElement?.GetFirstChild<DXDrawChartDraw.GroupShape>();
    if (element != null)
      return DMXDrawsChartDraw.GroupShapeConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpGroupShape(DXDrawChartDraw.AbsoluteAnchorSize openXmlElement, DMDrawsChartDraw.GroupShape? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsChartDraw.GroupShapeConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDrawChartDraw.GroupShape>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
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
    var element = openXmlElement?.GetFirstChild<DXDrawChartDraw.GraphicFrame>();
    if (element != null)
      return DMXDrawsChartDraw.GraphicFrameConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpGraphicFrame(DXDrawChartDraw.AbsoluteAnchorSize openXmlElement, DMDrawsChartDraw.GraphicFrame? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsChartDraw.GraphicFrameConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDrawChartDraw.GraphicFrame>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
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
    var element = openXmlElement?.GetFirstChild<DXDrawChartDraw.ConnectionShape>();
    if (element != null)
      return DMXDrawsChartDraw.ConnectionShapeConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpConnectionShape(DXDrawChartDraw.AbsoluteAnchorSize openXmlElement, DMDrawsChartDraw.ConnectionShape? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsChartDraw.ConnectionShapeConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDrawChartDraw.ConnectionShape>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
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
    var element = openXmlElement?.GetFirstChild<DXDrawChartDraw.Picture>();
    if (element != null)
      return DMXDrawsChartDraw.PictureConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpPicture(DXDrawChartDraw.AbsoluteAnchorSize openXmlElement, DMDrawsChartDraw.Picture? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsChartDraw.PictureConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDrawChartDraw.Picture>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
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
  
  public static DocumentModel.Drawings.ChartDrawing.AbsoluteAnchorSize? CreateModelElement(DXDrawChartDraw.AbsoluteAnchorSize? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.ChartDrawing.AbsoluteAnchorSize();
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
  
  public static bool CompareModelElement(DXDrawChartDraw.AbsoluteAnchorSize? openXmlElement, DMDrawsChartDraw.AbsoluteAnchorSize? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpFromAnchor(openXmlElement, value.FromAnchor, diffs, objName))
        ok = false;
      if (!CmpExtent(openXmlElement, value.Extent, diffs, objName))
        ok = false;
      if (!CmpShape(openXmlElement, value.Shape, diffs, objName))
        ok = false;
      if (!CmpGroupShape(openXmlElement, value.GroupShape, diffs, objName))
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
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDrawsChartDraw.AbsoluteAnchorSize value)
    where OpenXmlElementType: DXDrawChartDraw.AbsoluteAnchorSize, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXDrawChartDraw.AbsoluteAnchorSize openXmlElement, DMDrawsChartDraw.AbsoluteAnchorSize value)
  {
    SetFromAnchor(openXmlElement, value?.FromAnchor);
    SetExtent(openXmlElement, value?.Extent);
    SetShape(openXmlElement, value?.Shape);
    SetGroupShape(openXmlElement, value?.GroupShape);
    SetGraphicFrame(openXmlElement, value?.GraphicFrame);
    SetConnectionShape(openXmlElement, value?.ConnectionShape);
    SetPicture(openXmlElement, value?.Picture);
  }
}
