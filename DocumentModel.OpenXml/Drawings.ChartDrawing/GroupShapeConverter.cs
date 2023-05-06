namespace DocumentModel.OpenXml.Drawings.ChartDrawing;

/// <summary>
/// Group Shape.
/// </summary>
public static class GroupShapeConverter
{
  /// <summary>
  /// Non-Visual Group Shape Properties.
  /// </summary>
  private static DMDCD.NonVisualGroupShapeProperties? GetNonVisualGroupShapeProperties(DXDCD.GroupShape openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDCD.NonVisualGroupShapeProperties>();
    if (element != null)
      return DMXDCD.NonVisualGroupShapePropertiesConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpNonVisualGroupShapeProperties(DXDCD.GroupShape openXmlElement, DMDCD.NonVisualGroupShapeProperties? value, DiffList? diffs, string? objName)
  {
    return DMXDCD.NonVisualGroupShapePropertiesConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDCD.NonVisualGroupShapeProperties>(), value, diffs, objName);
  }
  
  private static void SetNonVisualGroupShapeProperties(DXDCD.GroupShape openXmlElement, DMDCD.NonVisualGroupShapeProperties? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDCD.NonVisualGroupShapeProperties>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDCD.NonVisualGroupShapePropertiesConverter.CreateOpenXmlElement<DXDCD.NonVisualGroupShapeProperties>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  /// <summary>
  /// Group Shape Properties.
  /// </summary>
  private static DMDCD.GroupShapeProperties? GetGroupShapeProperties(DXDCD.GroupShape openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDCD.GroupShapeProperties>();
    if (element != null)
      return DMXDCD.GroupShapePropertiesConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpGroupShapeProperties(DXDCD.GroupShape openXmlElement, DMDCD.GroupShapeProperties? value, DiffList? diffs, string? objName)
  {
    return DMXDCD.GroupShapePropertiesConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDCD.GroupShapeProperties>(), value, diffs, objName);
  }
  
  private static void SetGroupShapeProperties(DXDCD.GroupShape openXmlElement, DMDCD.GroupShapeProperties? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDCD.GroupShapeProperties>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDCD.GroupShapePropertiesConverter.CreateOpenXmlElement<DXDCD.GroupShapeProperties>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  private static DMDCD.Shape? GetShape(DXDCD.GroupShape openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDCD.Shape>();
    if (element != null)
      return DMXDCD.ShapeConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpShape(DXDCD.GroupShape openXmlElement, DMDCD.Shape? value, DiffList? diffs, string? objName)
  {
    return DMXDCD.ShapeConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDCD.Shape>(), value, diffs, objName);
  }
  
  private static void SetShape(DXDCD.GroupShape openXmlElement, DMDCD.Shape? value)
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
  
  private static DMDCD.GroupShape? GetChildGroupShape(DXDCD.GroupShape openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDCD.GroupShape>();
    if (element != null)
      return DMXDCD.GroupShapeConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpChildGroupShape(DXDCD.GroupShape openXmlElement, DMDCD.GroupShape? value, DiffList? diffs, string? objName)
  {
    return DMXDCD.GroupShapeConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDCD.GroupShape>(), value, diffs, objName);
  }
  
  private static void SetChildGroupShape(DXDCD.GroupShape openXmlElement, DMDCD.GroupShape? value)
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
  
  private static DMDCD.GraphicFrame? GetGraphicFrame(DXDCD.GroupShape openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDCD.GraphicFrame>();
    if (element != null)
      return DMXDCD.GraphicFrameConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpGraphicFrame(DXDCD.GroupShape openXmlElement, DMDCD.GraphicFrame? value, DiffList? diffs, string? objName)
  {
    return DMXDCD.GraphicFrameConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDCD.GraphicFrame>(), value, diffs, objName);
  }
  
  private static void SetGraphicFrame(DXDCD.GroupShape openXmlElement, DMDCD.GraphicFrame? value)
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
  
  private static DMDCD.ConnectionShape? GetConnectionShape(DXDCD.GroupShape openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDCD.ConnectionShape>();
    if (element != null)
      return DMXDCD.ConnectionShapeConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpConnectionShape(DXDCD.GroupShape openXmlElement, DMDCD.ConnectionShape? value, DiffList? diffs, string? objName)
  {
    return DMXDCD.ConnectionShapeConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDCD.ConnectionShape>(), value, diffs, objName);
  }
  
  private static void SetConnectionShape(DXDCD.GroupShape openXmlElement, DMDCD.ConnectionShape? value)
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
  
  private static DMDCD.Picture? GetPicture(DXDCD.GroupShape openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDCD.Picture>();
    if (element != null)
      return DMXDCD.PictureConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpPicture(DXDCD.GroupShape openXmlElement, DMDCD.Picture? value, DiffList? diffs, string? objName)
  {
    return DMXDCD.PictureConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDCD.Picture>(), value, diffs, objName);
  }
  
  private static void SetPicture(DXDCD.GroupShape openXmlElement, DMDCD.Picture? value)
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
  
  public static DocumentModel.Drawings.ChartDrawing.GroupShape? CreateModelElement(DXDCD.GroupShape? openXmlElement)
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
  
  public static bool CompareModelElement(DXDCD.GroupShape? openXmlElement, DMDCD.GroupShape? value, DiffList? diffs, string? objName)
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
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDCD.GroupShape value)
    where OpenXmlElementType: DXDCD.GroupShape, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXDCD.GroupShape openXmlElement, DMDCD.GroupShape value)
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
