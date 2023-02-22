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
    var element = openXmlElement?.GetFirstChild<DXDrawChartDraw.FromAnchor>();
    if (element != null)
      return DMXDrawsChartDraw.FromAnchorConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpFromAnchor(DXDrawChartDraw.RelativeAnchorSize openXmlElement, DMDrawsChartDraw.FromAnchor? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsChartDraw.FromAnchorConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDrawChartDraw.FromAnchor>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
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
    var element = openXmlElement?.GetFirstChild<DXDrawChartDraw.ToAnchor>();
    if (element != null)
      return DMXDrawsChartDraw.ToAnchorConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpToAnchor(DXDrawChartDraw.RelativeAnchorSize openXmlElement, DMDrawsChartDraw.ToAnchor? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsChartDraw.ToAnchorConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDrawChartDraw.ToAnchor>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
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
    var element = openXmlElement?.GetFirstChild<DXDrawChartDraw.Shape>();
    if (element != null)
      return DMXDrawsChartDraw.ShapeConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpShape(DXDrawChartDraw.RelativeAnchorSize openXmlElement, DMDrawsChartDraw.Shape? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsChartDraw.ShapeConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDrawChartDraw.Shape>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
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
    var element = openXmlElement?.GetFirstChild<DXDrawChartDraw.GroupShape>();
    if (element != null)
      return DMXDrawsChartDraw.GroupShapeConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpGroupShape(DXDrawChartDraw.RelativeAnchorSize openXmlElement, DMDrawsChartDraw.GroupShape? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsChartDraw.GroupShapeConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDrawChartDraw.GroupShape>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
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
    var element = openXmlElement?.GetFirstChild<DXDrawChartDraw.GraphicFrame>();
    if (element != null)
      return DMXDrawsChartDraw.GraphicFrameConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpGraphicFrame(DXDrawChartDraw.RelativeAnchorSize openXmlElement, DMDrawsChartDraw.GraphicFrame? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsChartDraw.GraphicFrameConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDrawChartDraw.GraphicFrame>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
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
    var element = openXmlElement?.GetFirstChild<DXDrawChartDraw.ConnectionShape>();
    if (element != null)
      return DMXDrawsChartDraw.ConnectionShapeConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpConnectionShape(DXDrawChartDraw.RelativeAnchorSize openXmlElement, DMDrawsChartDraw.ConnectionShape? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsChartDraw.ConnectionShapeConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDrawChartDraw.ConnectionShape>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
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
    var element = openXmlElement?.GetFirstChild<DXDrawChartDraw.Picture>();
    if (element != null)
      return DMXDrawsChartDraw.PictureConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpPicture(DXDrawChartDraw.RelativeAnchorSize openXmlElement, DMDrawsChartDraw.Picture? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsChartDraw.PictureConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDrawChartDraw.Picture>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
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
  
  public static DocumentModel.Drawings.ChartDrawing.RelativeAnchorSize? CreateModelElement(DXDrawChartDraw.RelativeAnchorSize? openXmlElement)
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
  
  public static bool CompareModelElement(DXDrawChartDraw.RelativeAnchorSize? openXmlElement, DMDrawsChartDraw.RelativeAnchorSize? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpFromAnchor(openXmlElement, value.FromAnchor, diffs, objName))
        ok = false;
      if (!CmpToAnchor(openXmlElement, value.ToAnchor, diffs, objName))
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
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDrawsChartDraw.RelativeAnchorSize value)
    where OpenXmlElementType: DXDrawChartDraw.RelativeAnchorSize, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXDrawChartDraw.RelativeAnchorSize openXmlElement, DMDrawsChartDraw.RelativeAnchorSize value)
  {
    SetFromAnchor(openXmlElement, value?.FromAnchor);
    SetToAnchor(openXmlElement, value?.ToAnchor);
    SetShape(openXmlElement, value?.Shape);
    SetGroupShape(openXmlElement, value?.GroupShape);
    SetGraphicFrame(openXmlElement, value?.GraphicFrame);
    SetConnectionShape(openXmlElement, value?.ConnectionShape);
    SetPicture(openXmlElement, value?.Picture);
    }
  }
