namespace DocumentModel.OpenXml.Drawings.Office;

/// <summary>
/// Defines the Shape Class.
/// </summary>
public static class ShapeConverter
{
  /// <summary>
  /// modelId, this property is only available in Office 2010 and later.
  /// </summary>
  private static String? GetModelId(DXODraw.Shape openXmlElement)
  {
    return openXmlElement?.ModelId?.Value;
  }
  
  private static bool CmpModelId(DXODraw.Shape openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.ModelId?.Value == value;
  }
  
  private static void SetModelId(DXODraw.Shape openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.ModelId = new StringValue { Value = value };
    else
      openXmlElement.ModelId = null;
  }
  
  /// <summary>
  /// ShapeNonVisualProperties.
  /// </summary>
  private static DMDrawsO.ShapeNonVisualProperties? GetShapeNonVisualProperties(DXODraw.Shape openXmlElement)
  {
    return DMXDrawsO.ShapeNonVisualPropertiesConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXODraw.ShapeNonVisualProperties>());
  }
  
  private static bool CmpShapeNonVisualProperties(DXODraw.Shape openXmlElement, DMDrawsO.ShapeNonVisualProperties? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsO.ShapeNonVisualPropertiesConverter.CompareModelElement(openXmlElement.GetFirstChild<DXODraw.ShapeNonVisualProperties>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
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
    return DMXDrawsO.ShapePropertiesConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXODraw.ShapeProperties>());
  }
  
  private static bool CmpShapeProperties(DXODraw.Shape openXmlElement, DMDrawsO.ShapeProperties? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsO.ShapePropertiesConverter.CompareModelElement(openXmlElement.GetFirstChild<DXODraw.ShapeProperties>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
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
    return DMXDrawsO.ShapeStyleConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXODraw.ShapeStyle>());
  }
  
  private static bool CmpShapeStyle(DXODraw.Shape openXmlElement, DMDrawsO.ShapeStyle? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsO.ShapeStyleConverter.CompareModelElement(openXmlElement.GetFirstChild<DXODraw.ShapeStyle>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
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
    return DMXDrawsO.TextBodyConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXODraw.TextBody>());
  }
  
  private static bool CmpTextBody(DXODraw.Shape openXmlElement, DMDrawsO.TextBody? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsO.TextBodyConverter.CompareModelElement(openXmlElement.GetFirstChild<DXODraw.TextBody>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
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
    return DMXDrawsO.Transform2DConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXODraw.Transform2D>());
  }
  
  private static bool CmpTransform2D(DXODraw.Shape openXmlElement, DMDrawsO.Transform2D? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsO.Transform2DConverter.CompareModelElement(openXmlElement.GetFirstChild<DXODraw.Transform2D>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
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
    return DMXDrawsO.OfficeArtExtensionListConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXODraw.OfficeArtExtensionList>());
  }
  
  private static bool CmpOfficeArtExtensionList(DXODraw.Shape openXmlElement, DMDrawsO.OfficeArtExtensionList? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsO.OfficeArtExtensionListConverter.CompareModelElement(openXmlElement.GetFirstChild<DXODraw.OfficeArtExtensionList>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
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
  
  public static DMDrawsO.Shape? CreateModelElement(DXODraw.Shape? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDrawsO.Shape();
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
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDrawsO.Shape? value)
    where OpenXmlElementType: DXODraw.Shape, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetModelId(openXmlElement, value?.ModelId);
      SetShapeNonVisualProperties(openXmlElement, value?.ShapeNonVisualProperties);
      SetShapeProperties(openXmlElement, value?.ShapeProperties);
      SetShapeStyle(openXmlElement, value?.ShapeStyle);
      SetTextBody(openXmlElement, value?.TextBody);
      SetTransform2D(openXmlElement, value?.Transform2D);
      SetOfficeArtExtensionList(openXmlElement, value?.OfficeArtExtensionList);
      return openXmlElement;
    }
    return default;
  }
}
