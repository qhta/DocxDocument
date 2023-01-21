namespace DocumentModel.OpenXml.Drawings.Office;

/// <summary>
/// Defines the GroupShape Class.
/// </summary>
public static class GroupShapeConverter
{
  private static DMDrawsO.GroupShapeNonVisualProperties? GetGroupShapeNonVisualProperties(DXODraw.GroupShape openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXODraw.GroupShapeNonVisualProperties>();
    if (itemElement != null)
      return DMXDrawsO.GroupShapeNonVisualPropertiesConverter.CreateModelElement(itemElement);
    return null;
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
    var itemElement = openXmlElement?.GetFirstChild<DXODraw.GroupShapeProperties>();
    if (itemElement != null)
      return DMXDrawsO.GroupShapePropertiesConverter.CreateModelElement(itemElement);
    return null;
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
    var itemElement = openXmlElement?.GetFirstChild<DXODraw.Shape>();
    if (itemElement != null)
      return DMXDrawsO.ShapeConverter.CreateModelElement(itemElement);
    return null;
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
    var itemElement = openXmlElement?.GetFirstChild<DXODraw.GroupShape>();
    if (itemElement != null)
      return DMXDrawsO.GroupShapeConverter.CreateModelElement(itemElement);
    return null;
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
    var itemElement = openXmlElement?.GetFirstChild<DXODraw.OfficeArtExtensionList>();
    if (itemElement != null)
      return DMXDrawsO.OfficeArtExtensionListConverter.CreateModelElement(itemElement);
    return null;
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
