namespace DocumentModel.OpenXml.Drawings.ChartDrawing;

/// <summary>
/// Relative Anchor Shape Size.
/// </summary>
public static class RelativeAnchorSizeConverter
{
  /// <summary>
  /// Starting Anchor Point.
  /// </summary>
  private static DMDCD.FromAnchor? GetFromAnchor(DXDCD.RelativeAnchorSize openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDCD.FromAnchor>();
    if (element != null)
      return DMXDCD.FromAnchorConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpFromAnchor(DXDCD.RelativeAnchorSize openXmlElement, DMDCD.FromAnchor? value, DiffList? diffs, string? objName)
  {
    return DMXDCD.FromAnchorConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDCD.FromAnchor>(), value, diffs, objName);
  }
  
  private static void SetFromAnchor(DXDCD.RelativeAnchorSize openXmlElement, DMDCD.FromAnchor? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDCD.FromAnchor>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDCD.FromAnchorConverter.CreateOpenXmlElement<DXDCD.FromAnchor>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  /// <summary>
  /// Ending Anchor Point.
  /// </summary>
  private static DMDCD.ToAnchor? GetToAnchor(DXDCD.RelativeAnchorSize openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDCD.ToAnchor>();
    if (element != null)
      return DMXDCD.ToAnchorConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpToAnchor(DXDCD.RelativeAnchorSize openXmlElement, DMDCD.ToAnchor? value, DiffList? diffs, string? objName)
  {
    return DMXDCD.ToAnchorConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDCD.ToAnchor>(), value, diffs, objName);
  }
  
  private static void SetToAnchor(DXDCD.RelativeAnchorSize openXmlElement, DMDCD.ToAnchor? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDCD.ToAnchor>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDCD.ToAnchorConverter.CreateOpenXmlElement<DXDCD.ToAnchor>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  private static DMDCD.Shape? GetShape(DXDCD.RelativeAnchorSize openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDCD.Shape>();
    if (element != null)
      return DMXDCD.ShapeConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpShape(DXDCD.RelativeAnchorSize openXmlElement, DMDCD.Shape? value, DiffList? diffs, string? objName)
  {
    return DMXDCD.ShapeConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDCD.Shape>(), value, diffs, objName);
  }
  
  private static void SetShape(DXDCD.RelativeAnchorSize openXmlElement, DMDCD.Shape? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDCD.Shape>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDCD.ShapeConverter.CreateOpenXmlElement<DXDCD.Shape>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  private static DMDCD.GroupShape? GetGroupShape(DXDCD.RelativeAnchorSize openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDCD.GroupShape>();
    if (element != null)
      return DMXDCD.GroupShapeConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpGroupShape(DXDCD.RelativeAnchorSize openXmlElement, DMDCD.GroupShape? value, DiffList? diffs, string? objName)
  {
    return DMXDCD.GroupShapeConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDCD.GroupShape>(), value, diffs, objName);
  }
  
  private static void SetGroupShape(DXDCD.RelativeAnchorSize openXmlElement, DMDCD.GroupShape? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDCD.GroupShape>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDCD.GroupShapeConverter.CreateOpenXmlElement<DXDCD.GroupShape>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  private static DMDCD.GraphicFrame? GetGraphicFrame(DXDCD.RelativeAnchorSize openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDCD.GraphicFrame>();
    if (element != null)
      return DMXDCD.GraphicFrameConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpGraphicFrame(DXDCD.RelativeAnchorSize openXmlElement, DMDCD.GraphicFrame? value, DiffList? diffs, string? objName)
  {
    return DMXDCD.GraphicFrameConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDCD.GraphicFrame>(), value, diffs, objName);
  }
  
  private static void SetGraphicFrame(DXDCD.RelativeAnchorSize openXmlElement, DMDCD.GraphicFrame? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDCD.GraphicFrame>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDCD.GraphicFrameConverter.CreateOpenXmlElement<DXDCD.GraphicFrame>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  private static DMDCD.ConnectionShape? GetConnectionShape(DXDCD.RelativeAnchorSize openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDCD.ConnectionShape>();
    if (element != null)
      return DMXDCD.ConnectionShapeConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpConnectionShape(DXDCD.RelativeAnchorSize openXmlElement, DMDCD.ConnectionShape? value, DiffList? diffs, string? objName)
  {
    return DMXDCD.ConnectionShapeConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDCD.ConnectionShape>(), value, diffs, objName);
  }
  
  private static void SetConnectionShape(DXDCD.RelativeAnchorSize openXmlElement, DMDCD.ConnectionShape? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDCD.ConnectionShape>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDCD.ConnectionShapeConverter.CreateOpenXmlElement<DXDCD.ConnectionShape>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  private static DMDCD.Picture? GetPicture(DXDCD.RelativeAnchorSize openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDCD.Picture>();
    if (element != null)
      return DMXDCD.PictureConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpPicture(DXDCD.RelativeAnchorSize openXmlElement, DMDCD.Picture? value, DiffList? diffs, string? objName)
  {
    return DMXDCD.PictureConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDCD.Picture>(), value, diffs, objName);
  }
  
  private static void SetPicture(DXDCD.RelativeAnchorSize openXmlElement, DMDCD.Picture? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDCD.Picture>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDCD.PictureConverter.CreateOpenXmlElement<DXDCD.Picture>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  public static DocumentModel.Drawings.ChartDrawing.RelativeAnchorSize? CreateModelElement(DXDCD.RelativeAnchorSize? openXmlElement)
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
  
  public static bool CompareModelElement(DXDCD.RelativeAnchorSize? openXmlElement, DMDCD.RelativeAnchorSize? value, DiffList? diffs, string? objName)
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
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDCD.RelativeAnchorSize value)
    where OpenXmlElementType: DXDCD.RelativeAnchorSize, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXDCD.RelativeAnchorSize openXmlElement, DMDCD.RelativeAnchorSize value)
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
