namespace DocumentModel.OpenXml.Drawings.Office;

/// <summary>
/// Defines the GroupShape Class.
/// </summary>
public static class GroupShapeConverter
{
  private static DMDrawsO.GroupShapeNonVisualProperties? GetGroupShapeNonVisualProperties(DXODraw.GroupShape openXmlElement)
  {
    return DMXDrawsO.GroupShapeNonVisualPropertiesConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXODraw.GroupShapeNonVisualProperties>());
  }
  
  private static bool CmpGroupShapeNonVisualProperties(DXODraw.GroupShape openXmlElement, DMDrawsO.GroupShapeNonVisualProperties? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsO.GroupShapeNonVisualPropertiesConverter.CompareModelElement(openXmlElement.GetFirstChild<DXODraw.GroupShapeNonVisualProperties>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetGroupShapeNonVisualProperties(DXODraw.GroupShape openXmlElement, DMDrawsO.GroupShapeNonVisualProperties? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXODraw.GroupShapeNonVisualProperties>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDrawsO.GroupShapeNonVisualPropertiesConverter.CreateOpenXmlElement<DXODraw.GroupShapeNonVisualProperties>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMDrawsO.GroupShapeProperties? GetGroupShapeProperties(DXODraw.GroupShape openXmlElement)
  {
    return DMXDrawsO.GroupShapePropertiesConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXODraw.GroupShapeProperties>());
  }
  
  private static bool CmpGroupShapeProperties(DXODraw.GroupShape openXmlElement, DMDrawsO.GroupShapeProperties? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsO.GroupShapePropertiesConverter.CompareModelElement(openXmlElement.GetFirstChild<DXODraw.GroupShapeProperties>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetGroupShapeProperties(DXODraw.GroupShape openXmlElement, DMDrawsO.GroupShapeProperties? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXODraw.GroupShapeProperties>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDrawsO.GroupShapePropertiesConverter.CreateOpenXmlElement<DXODraw.GroupShapeProperties>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMDrawsO.Shape? GetShape(DXODraw.GroupShape openXmlElement)
  {
    return DMXDrawsO.ShapeConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXODraw.Shape>());
  }
  
  private static bool CmpShape(DXODraw.GroupShape openXmlElement, DMDrawsO.Shape? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsO.ShapeConverter.CompareModelElement(openXmlElement.GetFirstChild<DXODraw.Shape>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetShape(DXODraw.GroupShape openXmlElement, DMDrawsO.Shape? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXODraw.Shape>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDrawsO.ShapeConverter.CreateOpenXmlElement<DXODraw.Shape>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMDrawsO.GroupShape? GetChildGroupShape(DXODraw.GroupShape openXmlElement)
  {
    return DMXDrawsO.GroupShapeConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXODraw.GroupShape>());
  }
  
  private static bool CmpChildGroupShape(DXODraw.GroupShape openXmlElement, DMDrawsO.GroupShape? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsO.GroupShapeConverter.CompareModelElement(openXmlElement.GetFirstChild<DXODraw.GroupShape>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetChildGroupShape(DXODraw.GroupShape openXmlElement, DMDrawsO.GroupShape? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXODraw.GroupShape>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDrawsO.GroupShapeConverter.CreateOpenXmlElement<DXODraw.GroupShape>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMDrawsO.OfficeArtExtensionList? GetOfficeArtExtensionList(DXODraw.GroupShape openXmlElement)
  {
    return DMXDrawsO.OfficeArtExtensionListConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXODraw.OfficeArtExtensionList>());
  }
  
  private static bool CmpOfficeArtExtensionList(DXODraw.GroupShape openXmlElement, DMDrawsO.OfficeArtExtensionList? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsO.OfficeArtExtensionListConverter.CompareModelElement(openXmlElement.GetFirstChild<DXODraw.OfficeArtExtensionList>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetOfficeArtExtensionList(DXODraw.GroupShape openXmlElement, DMDrawsO.OfficeArtExtensionList? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXODraw.OfficeArtExtensionList>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDrawsO.OfficeArtExtensionListConverter.CreateOpenXmlElement<DXODraw.OfficeArtExtensionList>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DMDrawsO.GroupShape? CreateModelElement(DXODraw.GroupShape? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDrawsO.GroupShape();
      value.GroupShapeNonVisualProperties = GetGroupShapeNonVisualProperties(openXmlElement);
      value.GroupShapeProperties = GetGroupShapeProperties(openXmlElement);
      value.Shape = GetShape(openXmlElement);
      value.ChildGroupShape = GetChildGroupShape(openXmlElement);
      value.OfficeArtExtensionList = GetOfficeArtExtensionList(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXODraw.GroupShape? openXmlElement, DMDrawsO.GroupShape? value, DiffList? diffs, string? objName)
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
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDrawsO.GroupShape? value)
    where OpenXmlElementType: DXODraw.GroupShape, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetGroupShapeNonVisualProperties(openXmlElement, value?.GroupShapeNonVisualProperties);
      SetGroupShapeProperties(openXmlElement, value?.GroupShapeProperties);
      SetShape(openXmlElement, value?.Shape);
      SetChildGroupShape(openXmlElement, value?.ChildGroupShape);
      SetOfficeArtExtensionList(openXmlElement, value?.OfficeArtExtensionList);
      return openXmlElement;
    }
    return default;
  }
}
