namespace DocumentModel.OpenXml.Drawings.Office;

/// <summary>
/// Defines the Shape Class.
/// </summary>
public static class ShapeConverter
{
  /// <summary>
  /// modelId, this property is only available in Office 2010 and later.
  /// </summary>
  private static String? GetModelId(DXOD.Shape openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.ModelId);
  }
  
  private static bool CmpModelId(DXOD.Shape openXmlElement, String? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return StringValueConverter.CmpValue(openXmlElement?.ModelId, value, diffs, objName, "ModelId");
  }
  
  private static void SetModelId(DXOD.Shape openXmlElement, String? value)
  {
    openXmlElement.ModelId = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// ShapeNonVisualProperties.
  /// </summary>
  private static DMDO.ShapeNonVisualProperties? GetShapeNonVisualProperties(DXOD.Shape openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXOD.ShapeNonVisualProperties>();
    if (element != null)
      return DMXDO.ShapeNonVisualPropertiesConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpShapeNonVisualProperties(DXOD.Shape openXmlElement, DMDO.ShapeNonVisualProperties? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXDO.ShapeNonVisualPropertiesConverter.CompareModelElement(openXmlElement.GetFirstChild<DXOD.ShapeNonVisualProperties>(), value, diffs, objName, propName);
  }
  
  private static void SetShapeNonVisualProperties(DXOD.Shape openXmlElement, DMDO.ShapeNonVisualProperties? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXOD.ShapeNonVisualProperties>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDO.ShapeNonVisualPropertiesConverter.CreateOpenXmlElement<DXOD.ShapeNonVisualProperties>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  /// <summary>
  /// ShapeProperties.
  /// </summary>
  private static DMDO.ShapeProperties? GetShapeProperties(DXOD.Shape openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXOD.ShapeProperties>();
    if (element != null)
      return DMXDO.ShapePropertiesConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpShapeProperties(DXOD.Shape openXmlElement, DMDO.ShapeProperties? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXDO.ShapePropertiesConverter.CompareModelElement(openXmlElement.GetFirstChild<DXOD.ShapeProperties>(), value, diffs, objName, propName);
  }
  
  private static void SetShapeProperties(DXOD.Shape openXmlElement, DMDO.ShapeProperties? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXOD.ShapeProperties>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDO.ShapePropertiesConverter.CreateOpenXmlElement<DXOD.ShapeProperties>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  /// <summary>
  /// ShapeStyle.
  /// </summary>
  private static DMDO.ShapeStyle? GetShapeStyle(DXOD.Shape openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXOD.ShapeStyle>();
    if (element != null)
      return DMXDO.ShapeStyleConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpShapeStyle(DXOD.Shape openXmlElement, DMDO.ShapeStyle? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXDO.ShapeStyleConverter.CompareModelElement(openXmlElement.GetFirstChild<DXOD.ShapeStyle>(), value, diffs, objName, propName);
  }
  
  private static void SetShapeStyle(DXOD.Shape openXmlElement, DMDO.ShapeStyle? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXOD.ShapeStyle>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDO.ShapeStyleConverter.CreateOpenXmlElement<DXOD.ShapeStyle>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  /// <summary>
  /// TextBody.
  /// </summary>
  private static DMDO.TextBody? GetTextBody(DXOD.Shape openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXOD.TextBody>();
    if (element != null)
      return DMXDO.TextBodyConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpTextBody(DXOD.Shape openXmlElement, DMDO.TextBody? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXDO.TextBodyConverter.CompareModelElement(openXmlElement.GetFirstChild<DXOD.TextBody>(), value, diffs, objName, propName);
  }
  
  private static void SetTextBody(DXOD.Shape openXmlElement, DMDO.TextBody? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXOD.TextBody>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDO.TextBodyConverter.CreateOpenXmlElement<DXOD.TextBody>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  /// <summary>
  /// Transform2D.
  /// </summary>
  private static DMDO.Transform2D? GetTransform2D(DXOD.Shape openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXOD.Transform2D>();
    if (element != null)
      return DMXDO.Transform2DConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpTransform2D(DXOD.Shape openXmlElement, DMDO.Transform2D? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXDO.Transform2DConverter.CompareModelElement(openXmlElement.GetFirstChild<DXOD.Transform2D>(), value, diffs, objName, propName);
  }
  
  private static void SetTransform2D(DXOD.Shape openXmlElement, DMDO.Transform2D? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXOD.Transform2D>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDO.Transform2DConverter.CreateOpenXmlElement<DXOD.Transform2D>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  /// <summary>
  /// OfficeArtExtensionList.
  /// </summary>
  private static DMDO.OfficeArtExtensionList? GetOfficeArtExtensionList(DXOD.Shape openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXOD.OfficeArtExtensionList>();
    if (element != null)
      return DMXDO.OfficeArtExtensionListConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpOfficeArtExtensionList(DXOD.Shape openXmlElement, DMDO.OfficeArtExtensionList? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXDO.OfficeArtExtensionListConverter.CompareModelElement(openXmlElement.GetFirstChild<DXOD.OfficeArtExtensionList>(), value, diffs, objName, propName);
  }
  
  private static void SetOfficeArtExtensionList(DXOD.Shape openXmlElement, DMDO.OfficeArtExtensionList? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXOD.OfficeArtExtensionList>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDO.OfficeArtExtensionListConverter.CreateOpenXmlElement<DXOD.OfficeArtExtensionList>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  public static DMDO.Shape? CreateModelElement(DXOD.Shape? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDO.Shape();
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
  
  public static bool CompareModelElement(DXOD.Shape? openXmlElement, DMDO.Shape? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpModelId(openXmlElement, value.ModelId, diffs, objName, propName))
        ok = false;
      if (!CmpShapeNonVisualProperties(openXmlElement, value.ShapeNonVisualProperties, diffs, objName, propName))
        ok = false;
      if (!CmpShapeProperties(openXmlElement, value.ShapeProperties, diffs, objName, propName))
        ok = false;
      if (!CmpShapeStyle(openXmlElement, value.ShapeStyle, diffs, objName, propName))
        ok = false;
      if (!CmpTextBody(openXmlElement, value.TextBody, diffs, objName, propName))
        ok = false;
      if (!CmpTransform2D(openXmlElement, value.Transform2D, diffs, objName, propName))
        ok = false;
      if (!CmpOfficeArtExtensionList(openXmlElement, value.OfficeArtExtensionList, diffs, objName, propName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDO.Shape value)
    where OpenXmlElementType: DXOD.Shape, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXOD.Shape openXmlElement, DMDO.Shape value)
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
