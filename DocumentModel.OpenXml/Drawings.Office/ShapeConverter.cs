namespace DocumentModel.OpenXml.Drawings.Office;

/// <summary>
/// Defines the Shape Class converter from/to OpenXml.
///</summary>
public static class ShapeConverter
{
  /// <summary>
  /// modelId, this property is only available in Office 2010 and later.
  /// </summary>
  private static String? GetModelId(DXODraw.Shape openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.ModelId);
  }
  
  private static bool CmpModelId(DXODraw.Shape openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.ModelId, value, diffs, objName, "ModelId");
  }
  
  private static void SetModelId(DXODraw.Shape openXmlElement, String? value)
  {
    openXmlElement.ModelId = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// ShapeNonVisualProperties.
  /// </summary>
  private static DMDrawsO.ShapeNonVisualProperties? GetShapeNonVisualProperties(DXODraw.Shape openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXODraw.ShapeNonVisualProperties>();
    if (element != null)
      return DMXDrawsO.ShapeNonVisualPropertiesConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpShapeNonVisualProperties(DXODraw.Shape openXmlElement, DMDrawsO.ShapeNonVisualProperties? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsO.ShapeNonVisualPropertiesConverter.CompareModelElement(openXmlElement.GetFirstChild<DXODraw.ShapeNonVisualProperties>(), value, diffs, objName);
  }
  
  private static void SetShapeNonVisualProperties(DXODraw.Shape openXmlElement, DMDrawsO.ShapeNonVisualProperties? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXODraw.ShapeNonVisualProperties>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDrawsO.ShapeNonVisualPropertiesConverter.CreateOpenXmlElement<DXODraw.ShapeNonVisualProperties>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// ShapeProperties.
  /// </summary>
  private static DMDrawsO.ShapeProperties? GetShapeProperties(DXODraw.Shape openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXODraw.ShapeProperties>();
    if (element != null)
      return DMXDrawsO.ShapePropertiesConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpShapeProperties(DXODraw.Shape openXmlElement, DMDrawsO.ShapeProperties? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsO.ShapePropertiesConverter.CompareModelElement(openXmlElement.GetFirstChild<DXODraw.ShapeProperties>(), value, diffs, objName);
  }
  
  private static void SetShapeProperties(DXODraw.Shape openXmlElement, DMDrawsO.ShapeProperties? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXODraw.ShapeProperties>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDrawsO.ShapePropertiesConverter.CreateOpenXmlElement<DXODraw.ShapeProperties>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// ShapeStyle.
  /// </summary>
  private static DMDrawsO.ShapeStyle? GetShapeStyle(DXODraw.Shape openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXODraw.ShapeStyle>();
    if (element != null)
      return DMXDrawsO.ShapeStyleConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpShapeStyle(DXODraw.Shape openXmlElement, DMDrawsO.ShapeStyle? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsO.ShapeStyleConverter.CompareModelElement(openXmlElement.GetFirstChild<DXODraw.ShapeStyle>(), value, diffs, objName);
  }
  
  private static void SetShapeStyle(DXODraw.Shape openXmlElement, DMDrawsO.ShapeStyle? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXODraw.ShapeStyle>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDrawsO.ShapeStyleConverter.CreateOpenXmlElement<DXODraw.ShapeStyle>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// TextBody.
  /// </summary>
  private static DMDrawsO.TextBody? GetTextBody(DXODraw.Shape openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXODraw.TextBody>();
    if (element != null)
      return DMXDrawsO.TextBodyConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpTextBody(DXODraw.Shape openXmlElement, DMDrawsO.TextBody? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsO.TextBodyConverter.CompareModelElement(openXmlElement.GetFirstChild<DXODraw.TextBody>(), value, diffs, objName);
  }
  
  private static void SetTextBody(DXODraw.Shape openXmlElement, DMDrawsO.TextBody? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXODraw.TextBody>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDrawsO.TextBodyConverter.CreateOpenXmlElement<DXODraw.TextBody>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Transform2D.
  /// </summary>
  private static DMDrawsO.Transform2D? GetTransform2D(DXODraw.Shape openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXODraw.Transform2D>();
    if (element != null)
      return DMXDrawsO.Transform2DConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpTransform2D(DXODraw.Shape openXmlElement, DMDrawsO.Transform2D? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsO.Transform2DConverter.CompareModelElement(openXmlElement.GetFirstChild<DXODraw.Transform2D>(), value, diffs, objName);
  }
  
  private static void SetTransform2D(DXODraw.Shape openXmlElement, DMDrawsO.Transform2D? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXODraw.Transform2D>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDrawsO.Transform2DConverter.CreateOpenXmlElement<DXODraw.Transform2D>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// OfficeArtExtensionList.
  /// </summary>
  private static DMDrawsO.OfficeArtExtensionList? GetOfficeArtExtensionList(DXODraw.Shape openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXODraw.OfficeArtExtensionList>();
    if (element != null)
      return DMXDrawsO.OfficeArtExtensionListConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpOfficeArtExtensionList(DXODraw.Shape openXmlElement, DMDrawsO.OfficeArtExtensionList? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsO.OfficeArtExtensionListConverter.CompareModelElement(openXmlElement.GetFirstChild<DXODraw.OfficeArtExtensionList>(), value, diffs, objName);
  }
  
  private static void SetOfficeArtExtensionList(DXODraw.Shape openXmlElement, DMDrawsO.OfficeArtExtensionList? value)
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
  
  public static DocumentModel.Drawings.Office.Shape? CreateModelElement(DXODraw.Shape? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Office.Shape();
      value.ModelId = GetModelId(openXmlElement);
      value.ShapeNonVisualProperties = GetShapeNonVisualProperties(openXmlElement);
      value.ShapeProperties = GetShapeProperties(openXmlElement);
      value.ShapeStyle = GetShapeStyle(openXmlElement);
      value.TextBody = GetTextBody(openXmlElement);
      value.Transform2D = GetTransform2D(openXmlElement);
      value.OfficeArtExtensionList = GetOfficeArtExtensionList(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXODraw.Shape? openXmlElement, DMDrawsO.Shape? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpModelId(openXmlElement, value.ModelId, diffs, objName))
        ok = false;
      if (!CmpShapeNonVisualProperties(openXmlElement, value.ShapeNonVisualProperties, diffs, objName))
        ok = false;
      if (!CmpShapeProperties(openXmlElement, value.ShapeProperties, diffs, objName))
        ok = false;
      if (!CmpShapeStyle(openXmlElement, value.ShapeStyle, diffs, objName))
        ok = false;
      if (!CmpTextBody(openXmlElement, value.TextBody, diffs, objName))
        ok = false;
      if (!CmpTransform2D(openXmlElement, value.Transform2D, diffs, objName))
        ok = false;
      if (!CmpOfficeArtExtensionList(openXmlElement, value.OfficeArtExtensionList, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDrawsO.Shape value)
    where OpenXmlElementType: DXODraw.Shape, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXODraw.Shape openXmlElement, DMDrawsO.Shape value)
  {
    SetModelId(openXmlElement, value?.ModelId);
    SetShapeNonVisualProperties(openXmlElement, value?.ShapeNonVisualProperties);
    SetShapeProperties(openXmlElement, value?.ShapeProperties);
    SetShapeStyle(openXmlElement, value?.ShapeStyle);
    SetTextBody(openXmlElement, value?.TextBody);
    SetTransform2D(openXmlElement, value?.Transform2D);
    SetOfficeArtExtensionList(openXmlElement, value?.OfficeArtExtensionList);
  }
}
