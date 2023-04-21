namespace DocumentModel.OpenXml.Drawings.Office;

/// <summary>
/// Defines the GroupShape Class.
/// </summary>
public static class GroupShapeConverter
{
  private static DMDO.GroupShapeNonVisualProperties? GetGroupShapeNonVisualProperties(DXOD.GroupShape openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXOD.GroupShapeNonVisualProperties>();
    if (element != null)
      return DMXDO.GroupShapeNonVisualPropertiesConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpGroupShapeNonVisualProperties(DXOD.GroupShape openXmlElement, DMDO.GroupShapeNonVisualProperties? value, DiffList? diffs, string? objName)
  {
    return DMXDO.GroupShapeNonVisualPropertiesConverter.CompareModelElement(openXmlElement.GetFirstChild<DXOD.GroupShapeNonVisualProperties>(), value, diffs, objName);
  }
  
  private static void SetGroupShapeNonVisualProperties(DXOD.GroupShape openXmlElement, DMDO.GroupShapeNonVisualProperties? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXOD.GroupShapeNonVisualProperties>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDO.GroupShapeNonVisualPropertiesConverter.CreateOpenXmlElement<DXOD.GroupShapeNonVisualProperties>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMDO.GroupShapeProperties? GetGroupShapeProperties(DXOD.GroupShape openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXOD.GroupShapeProperties>();
    if (element != null)
      return DMXDO.GroupShapePropertiesConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpGroupShapeProperties(DXOD.GroupShape openXmlElement, DMDO.GroupShapeProperties? value, DiffList? diffs, string? objName)
  {
    return DMXDO.GroupShapePropertiesConverter.CompareModelElement(openXmlElement.GetFirstChild<DXOD.GroupShapeProperties>(), value, diffs, objName);
  }
  
  private static void SetGroupShapeProperties(DXOD.GroupShape openXmlElement, DMDO.GroupShapeProperties? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXOD.GroupShapeProperties>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDO.GroupShapePropertiesConverter.CreateOpenXmlElement<DXOD.GroupShapeProperties>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMDO.Shape? GetShape(DXOD.GroupShape openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXOD.Shape>();
    if (element != null)
      return DMXDO.ShapeConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpShape(DXOD.GroupShape openXmlElement, DMDO.Shape? value, DiffList? diffs, string? objName)
  {
    return DMXDO.ShapeConverter.CompareModelElement(openXmlElement.GetFirstChild<DXOD.Shape>(), value, diffs, objName);
  }
  
  private static void SetShape(DXOD.GroupShape openXmlElement, DMDO.Shape? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXOD.Shape>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDO.ShapeConverter.CreateOpenXmlElement<DXOD.Shape>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMDO.GroupShape? GetChildGroupShape(DXOD.GroupShape openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXOD.GroupShape>();
    if (element != null)
      return DMXDO.GroupShapeConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpChildGroupShape(DXOD.GroupShape openXmlElement, DMDO.GroupShape? value, DiffList? diffs, string? objName)
  {
    return DMXDO.GroupShapeConverter.CompareModelElement(openXmlElement.GetFirstChild<DXOD.GroupShape>(), value, diffs, objName);
  }
  
  private static void SetChildGroupShape(DXOD.GroupShape openXmlElement, DMDO.GroupShape? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXOD.GroupShape>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDO.GroupShapeConverter.CreateOpenXmlElement<DXOD.GroupShape>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMDO.OfficeArtExtensionList? GetOfficeArtExtensionList(DXOD.GroupShape openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXOD.OfficeArtExtensionList>();
    if (element != null)
      return DMXDO.OfficeArtExtensionListConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpOfficeArtExtensionList(DXOD.GroupShape openXmlElement, DMDO.OfficeArtExtensionList? value, DiffList? diffs, string? objName)
  {
    return DMXDO.OfficeArtExtensionListConverter.CompareModelElement(openXmlElement.GetFirstChild<DXOD.OfficeArtExtensionList>(), value, diffs, objName);
  }
  
  private static void SetOfficeArtExtensionList(DXOD.GroupShape openXmlElement, DMDO.OfficeArtExtensionList? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXOD.OfficeArtExtensionList>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDO.OfficeArtExtensionListConverter.CreateOpenXmlElement<DXOD.OfficeArtExtensionList>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DocumentModel.Drawings.Office.GroupShape? CreateModelElement(DXOD.GroupShape? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Office.GroupShape();
      value.GroupShapeNonVisualProperties = GetGroupShapeNonVisualProperties(openXmlElement);
      value.GroupShapeProperties = GetGroupShapeProperties(openXmlElement);
      value.Shape = GetShape(openXmlElement);
      value.ChildGroupShape = GetChildGroupShape(openXmlElement);
      value.OfficeArtExtensionList = GetOfficeArtExtensionList(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXOD.GroupShape? openXmlElement, DMDO.GroupShape? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpGroupShapeNonVisualProperties(openXmlElement, value.GroupShapeNonVisualProperties, diffs, objName))
        ok = false;
      if (!CmpGroupShapeProperties(openXmlElement, value.GroupShapeProperties, diffs, objName))
        ok = false;
      if (!CmpShape(openXmlElement, value.Shape, diffs, objName))
        ok = false;
      if (!CmpChildGroupShape(openXmlElement, value.ChildGroupShape, diffs, objName))
        ok = false;
      if (!CmpOfficeArtExtensionList(openXmlElement, value.OfficeArtExtensionList, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDO.GroupShape value)
    where OpenXmlElementType: DXOD.GroupShape, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXOD.GroupShape openXmlElement, DMDO.GroupShape value)
  {
    SetGroupShapeNonVisualProperties(openXmlElement, value?.GroupShapeNonVisualProperties);
    SetGroupShapeProperties(openXmlElement, value?.GroupShapeProperties);
    SetShape(openXmlElement, value?.Shape);
    SetChildGroupShape(openXmlElement, value?.ChildGroupShape);
    SetOfficeArtExtensionList(openXmlElement, value?.OfficeArtExtensionList);
  }
}
