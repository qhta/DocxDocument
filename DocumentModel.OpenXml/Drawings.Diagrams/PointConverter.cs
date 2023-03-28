namespace DocumentModel.OpenXml.Drawings.Diagrams;

/// <summary>
/// Point converter from/to OpenXml.
///</summary>
public static class PointConverter
{
  /// <summary>
  /// Model Identifier
  /// </summary>
  private static String? GetModelId(DXDrawDgms.Point openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.ModelId);
  }
  
  private static bool CmpModelId(DXDrawDgms.Point openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.ModelId, value, diffs, objName, "ModelId");
  }
  
  private static void SetModelId(DXDrawDgms.Point openXmlElement, String? value)
  {
    openXmlElement.ModelId = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// Point Type
  /// </summary>
  private static DMDrawsDgms.PointKind? GetType(DXDrawDgms.Point openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.Diagrams.PointValues, DMDrawsDgms.PointKind>(openXmlElement?.Type?.Value);
  }
  
  private static bool CmpType(DXDrawDgms.Point openXmlElement, DMDrawsDgms.PointKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Drawing.Diagrams.PointValues, DMDrawsDgms.PointKind>(openXmlElement?.Type?.Value, value, diffs, objName);
  }
  
  private static void SetType(DXDrawDgms.Point openXmlElement, DMDrawsDgms.PointKind? value)
  {
    openXmlElement.Type = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Drawing.Diagrams.PointValues, DMDrawsDgms.PointKind>(value);
  }
  
  /// <summary>
  /// Connection Identifier
  /// </summary>
  private static String? GetConnectionId(DXDrawDgms.Point openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.ConnectionId);
  }
  
  private static bool CmpConnectionId(DXDrawDgms.Point openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.ConnectionId, value, diffs, objName, "ConnectionId");
  }
  
  private static void SetConnectionId(DXDrawDgms.Point openXmlElement, String? value)
  {
    openXmlElement.ConnectionId = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// Property Set.
  /// </summary>
  private static DMDrawsDgms.PropertySet? GetPropertySet(DXDrawDgms.Point openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDrawDgms.PropertySet>();
    if (element != null)
      return DMXDrawsDgms.PropertySetConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpPropertySet(DXDrawDgms.Point openXmlElement, DMDrawsDgms.PropertySet? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsDgms.PropertySetConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDrawDgms.PropertySet>(), value, diffs, objName);
  }
  
  private static void SetPropertySet(DXDrawDgms.Point openXmlElement, DMDrawsDgms.PropertySet? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDrawDgms.PropertySet>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDrawsDgms.PropertySetConverter.CreateOpenXmlElement<DXDrawDgms.PropertySet>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Shape Properties.
  /// </summary>
  private static DMDrawsDgms.ShapeProperties? GetShapeProperties(DXDrawDgms.Point openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDrawDgms.ShapeProperties>();
    if (element != null)
      return DMXDrawsDgms.ShapePropertiesConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpShapeProperties(DXDrawDgms.Point openXmlElement, DMDrawsDgms.ShapeProperties? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsDgms.ShapePropertiesConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDrawDgms.ShapeProperties>(), value, diffs, objName);
  }
  
  private static void SetShapeProperties(DXDrawDgms.Point openXmlElement, DMDrawsDgms.ShapeProperties? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDrawDgms.ShapeProperties>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDrawsDgms.ShapePropertiesConverter.CreateOpenXmlElement<DXDrawDgms.ShapeProperties>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Text Body.
  /// </summary>
  private static DMDrawsDgms.TextBody? GetTextBody(DXDrawDgms.Point openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDrawDgms.TextBody>();
    if (element != null)
      return DMXDrawsDgms.TextBodyConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpTextBody(DXDrawDgms.Point openXmlElement, DMDrawsDgms.TextBody? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsDgms.TextBodyConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDrawDgms.TextBody>(), value, diffs, objName);
  }
  
  private static void SetTextBody(DXDrawDgms.Point openXmlElement, DMDrawsDgms.TextBody? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDrawDgms.TextBody>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDrawsDgms.TextBodyConverter.CreateOpenXmlElement<DXDrawDgms.TextBody>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// PtExtensionList.
  /// </summary>
  private static DMDrawsDgms.PtExtensionList? GetPtExtensionList(DXDrawDgms.Point openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDrawDgms.PtExtensionList>();
    if (element != null)
      return DMXDrawsDgms.PtExtensionListConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpPtExtensionList(DXDrawDgms.Point openXmlElement, DMDrawsDgms.PtExtensionList? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsDgms.PtExtensionListConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDrawDgms.PtExtensionList>(), value, diffs, objName);
  }
  
  private static void SetPtExtensionList(DXDrawDgms.Point openXmlElement, DMDrawsDgms.PtExtensionList? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDrawDgms.PtExtensionList>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDrawsDgms.PtExtensionListConverter.CreateOpenXmlElement<DXDrawDgms.PtExtensionList>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DocumentModel.Drawings.Diagrams.Point? CreateModelElement(DXDrawDgms.Point? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Diagrams.Point();
      value.ModelId = GetModelId(openXmlElement);
      value.Type = GetType(openXmlElement);
      value.ConnectionId = GetConnectionId(openXmlElement);
      value.PropertySet = GetPropertySet(openXmlElement);
      value.ShapeProperties = GetShapeProperties(openXmlElement);
      value.TextBody = GetTextBody(openXmlElement);
      value.PtExtensionList = GetPtExtensionList(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXDrawDgms.Point? openXmlElement, DMDrawsDgms.Point? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpModelId(openXmlElement, value.ModelId, diffs, objName))
        ok = false;
      if (!CmpType(openXmlElement, value.Type, diffs, objName))
        ok = false;
      if (!CmpConnectionId(openXmlElement, value.ConnectionId, diffs, objName))
        ok = false;
      if (!CmpPropertySet(openXmlElement, value.PropertySet, diffs, objName))
        ok = false;
      if (!CmpShapeProperties(openXmlElement, value.ShapeProperties, diffs, objName))
        ok = false;
      if (!CmpTextBody(openXmlElement, value.TextBody, diffs, objName))
        ok = false;
      if (!CmpPtExtensionList(openXmlElement, value.PtExtensionList, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDrawsDgms.Point value)
    where OpenXmlElementType: DXDrawDgms.Point, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXDrawDgms.Point openXmlElement, DMDrawsDgms.Point value)
  {
    SetModelId(openXmlElement, value?.ModelId);
    SetType(openXmlElement, value?.Type);
    SetConnectionId(openXmlElement, value?.ConnectionId);
    SetPropertySet(openXmlElement, value?.PropertySet);
    SetShapeProperties(openXmlElement, value?.ShapeProperties);
    SetTextBody(openXmlElement, value?.TextBody);
    SetPtExtensionList(openXmlElement, value?.PtExtensionList);
  }
}
