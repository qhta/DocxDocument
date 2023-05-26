using DocumentModel.Drawings;

namespace DocumentModel.OpenXml.Drawings.ChartDrawing;

/// <summary>
/// Absolute Anchor Shape Size.
/// </summary>
public static class AbsoluteAnchorSizeConverter
{
  /// <summary>
  /// FromAnchor.
  /// </summary>
  private static DMDCD.FromAnchor? GetFromAnchor(DXDCD.AbsoluteAnchorSize openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDCD.FromAnchor>();
    if (element != null)
      return DMXDCD.FromAnchorConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpFromAnchor(DXDCD.AbsoluteAnchorSize openXmlElement, DMDCD.FromAnchor? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXDCD.FromAnchorConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDCD.FromAnchor>(), value, diffs, objName, propName);
  }
  
  private static void SetFromAnchor(DXDCD.AbsoluteAnchorSize openXmlElement, DMDCD.FromAnchor? value)
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
  /// Shape Extent.
  /// </summary>
  private static Extent? GetExtent(DXDCD.AbsoluteAnchorSize openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDCD.Extent>();
    if (element != null)
      return DMXDCD.ExtentConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpExtent(DXDCD.AbsoluteAnchorSize openXmlElement, Extent? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXDCD.ExtentConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDCD.Extent>(), value, diffs, objName, propName);
  }
  
  private static void SetExtent(DXDCD.AbsoluteAnchorSize openXmlElement, Extent? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDCD.Extent>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDCD.ExtentConverter.CreateOpenXmlElement<DXDCD.Extent>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  private static DMDCD.Shape? GetShape(DXDCD.AbsoluteAnchorSize openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDCD.Shape>();
    if (element != null)
      return DMXDCD.ShapeConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpShape(DXDCD.AbsoluteAnchorSize openXmlElement, DMDCD.Shape? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXDCD.ShapeConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDCD.Shape>(), value, diffs, objName, propName);
  }
  
  private static void SetShape(DXDCD.AbsoluteAnchorSize openXmlElement, DMDCD.Shape? value)
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
  
  private static DMDCD.GroupShape? GetGroupShape(DXDCD.AbsoluteAnchorSize openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDCD.GroupShape>();
    if (element != null)
      return DMXDCD.GroupShapeConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpGroupShape(DXDCD.AbsoluteAnchorSize openXmlElement, DMDCD.GroupShape? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXDCD.GroupShapeConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDCD.GroupShape>(), value, diffs, objName, propName);
  }
  
  private static void SetGroupShape(DXDCD.AbsoluteAnchorSize openXmlElement, DMDCD.GroupShape? value)
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
  
  private static DMDCD.GraphicFrame? GetGraphicFrame(DXDCD.AbsoluteAnchorSize openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDCD.GraphicFrame>();
    if (element != null)
      return DMXDCD.GraphicFrameConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpGraphicFrame(DXDCD.AbsoluteAnchorSize openXmlElement, DMDCD.GraphicFrame? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXDCD.GraphicFrameConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDCD.GraphicFrame>(), value, diffs, objName, propName);
  }
  
  private static void SetGraphicFrame(DXDCD.AbsoluteAnchorSize openXmlElement, DMDCD.GraphicFrame? value)
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
  
  private static DMDCD.ConnectionShape? GetConnectionShape(DXDCD.AbsoluteAnchorSize openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDCD.ConnectionShape>();
    if (element != null)
      return DMXDCD.ConnectionShapeConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpConnectionShape(DXDCD.AbsoluteAnchorSize openXmlElement, DMDCD.ConnectionShape? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXDCD.ConnectionShapeConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDCD.ConnectionShape>(), value, diffs, objName, propName);
  }
  
  private static void SetConnectionShape(DXDCD.AbsoluteAnchorSize openXmlElement, DMDCD.ConnectionShape? value)
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
  
  private static DMDCD.Picture? GetPicture(DXDCD.AbsoluteAnchorSize openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDCD.Picture>();
    if (element != null)
      return DMXDCD.PictureConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpPicture(DXDCD.AbsoluteAnchorSize openXmlElement, DMDCD.Picture? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXDCD.PictureConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDCD.Picture>(), value, diffs, objName, propName);
  }
  
  private static void SetPicture(DXDCD.AbsoluteAnchorSize openXmlElement, DMDCD.Picture? value)
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
  
  public static DocumentModel.Drawings.ChartDrawing.AbsoluteAnchorSize? CreateModelElement(DXDCD.AbsoluteAnchorSize? openXmlElement)
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
  
  public static bool CompareModelElement(DXDCD.AbsoluteAnchorSize? openXmlElement, DMDCD.AbsoluteAnchorSize? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpFromAnchor(openXmlElement, value.FromAnchor, diffs, objName, propName))
        ok = false;
      if (!CmpExtent(openXmlElement, value.Extent, diffs, objName, propName))
        ok = false;
      if (!CmpShape(openXmlElement, value.Shape, diffs, objName, propName))
        ok = false;
      if (!CmpGroupShape(openXmlElement, value.GroupShape, diffs, objName, propName))
        ok = false;
      if (!CmpGraphicFrame(openXmlElement, value.GraphicFrame, diffs, objName, propName))
        ok = false;
      if (!CmpConnectionShape(openXmlElement, value.ConnectionShape, diffs, objName, propName))
        ok = false;
      if (!CmpPicture(openXmlElement, value.Picture, diffs, objName, propName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDCD.AbsoluteAnchorSize value)
    where OpenXmlElementType: DXDCD.AbsoluteAnchorSize, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXDCD.AbsoluteAnchorSize openXmlElement, DMDCD.AbsoluteAnchorSize value)
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
