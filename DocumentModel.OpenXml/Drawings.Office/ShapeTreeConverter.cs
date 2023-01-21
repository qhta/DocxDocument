namespace DocumentModel.OpenXml.Drawings.Office;

/// <summary>
/// Defines the ShapeTree Class.
/// </summary>
public static class ShapeTreeConverter
{
  private static DMDrawsO.GroupShapeNonVisualProperties? GetGroupShapeNonVisualProperties(DXODraw.ShapeTree openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXODraw.GroupShapeNonVisualProperties>();
    if (itemElement != null)
      return DMXDrawsO.GroupShapeNonVisualPropertiesConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetGroupShapeNonVisualProperties(DXODraw.ShapeTree openXmlElement, DMDrawsO.GroupShapeNonVisualProperties? value)
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
  
  private static DMDrawsO.GroupShapeProperties? GetGroupShapeProperties(DXODraw.ShapeTree openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXODraw.GroupShapeProperties>();
    if (itemElement != null)
      return DMXDrawsO.GroupShapePropertiesConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetGroupShapeProperties(DXODraw.ShapeTree openXmlElement, DMDrawsO.GroupShapeProperties? value)
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
  
  private static DMDrawsO.Shape? GetShape(DXODraw.ShapeTree openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXODraw.Shape>();
    if (itemElement != null)
      return DMXDrawsO.ShapeConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetShape(DXODraw.ShapeTree openXmlElement, DMDrawsO.Shape? value)
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
  
  private static DMDrawsO.GroupShape? GetGroupShape(DXODraw.ShapeTree openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXODraw.GroupShape>();
    if (itemElement != null)
      return DMXDrawsO.GroupShapeConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetGroupShape(DXODraw.ShapeTree openXmlElement, DMDrawsO.GroupShape? value)
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
  
  private static DMDrawsO.OfficeArtExtensionList? GetOfficeArtExtensionList(DXODraw.ShapeTree openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXODraw.OfficeArtExtensionList>();
    if (itemElement != null)
      return DMXDrawsO.OfficeArtExtensionListConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetOfficeArtExtensionList(DXODraw.ShapeTree openXmlElement, DMDrawsO.OfficeArtExtensionList? value)
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
  
  public static DMDrawsO.ShapeTree? CreateModelElement(DXODraw.ShapeTree? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDrawsO.ShapeTree();
      value.GroupShapeNonVisualProperties = GetGroupShapeNonVisualProperties(openXmlElement);
      value.GroupShapeProperties = GetGroupShapeProperties(openXmlElement);
      value.Shape = GetShape(openXmlElement);
      value.GroupShape = GetGroupShape(openXmlElement);
      value.OfficeArtExtensionList = GetOfficeArtExtensionList(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDrawsO.ShapeTree? value)
    where OpenXmlElementType: DXODraw.ShapeTree, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetGroupShapeNonVisualProperties(openXmlElement, value?.GroupShapeNonVisualProperties);
      SetGroupShapeProperties(openXmlElement, value?.GroupShapeProperties);
      SetShape(openXmlElement, value?.Shape);
      SetGroupShape(openXmlElement, value?.GroupShape);
      SetOfficeArtExtensionList(openXmlElement, value?.OfficeArtExtensionList);
      return openXmlElement;
    }
    return default;
  }
}
