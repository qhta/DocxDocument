namespace DocumentModel.OpenXml.Drawings.Diagrams;

/// <summary>
/// Point.
/// </summary>
public static class PointConverter
{
  /// <summary>
  /// Model Identifier
  /// </summary>
  private static String? GetModelId(DXDrawDgms.Point openXmlElement)
  {
    return openXmlElement?.ModelId?.Value;
  }
  
  private static bool CmpModelId(DXDrawDgms.Point openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.ModelId?.Value == value;
  }
  
  private static void SetModelId(DXDrawDgms.Point openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.ModelId = new StringValue { Value = value };
    else
      openXmlElement.ModelId = null;
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
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Drawing.Diagrams.PointValues, DMDrawsDgms.PointKind>(openXmlElement?.Type?.Value, value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
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
    return openXmlElement?.ConnectionId?.Value;
  }
  
  private static bool CmpConnectionId(DXDrawDgms.Point openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.ConnectionId?.Value == value;
  }
  
  private static void SetConnectionId(DXDrawDgms.Point openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.ConnectionId = new StringValue { Value = value };
    else
      openXmlElement.ConnectionId = null;
  }
  
  /// <summary>
  /// Property Set.
  /// </summary>
  private static DMDrawsDgms.PropertySet? GetPropertySet(DXDrawDgms.Point openXmlElement)
  {
    return DMXDrawsDgms.PropertySetConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXDrawDgms.PropertySet>());
  }
  
  private static bool CmpPropertySet(DXDrawDgms.Point openXmlElement, DMDrawsDgms.PropertySet? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsDgms.PropertySetConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDrawDgms.PropertySet>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
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
    return DMXDrawsDgms.ShapePropertiesConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXDrawDgms.ShapeProperties>());
  }
  
  private static bool CmpShapeProperties(DXDrawDgms.Point openXmlElement, DMDrawsDgms.ShapeProperties? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsDgms.ShapePropertiesConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDrawDgms.ShapeProperties>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
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
    return DMXDrawsDgms.TextBodyConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXDrawDgms.TextBody>());
  }
  
  private static bool CmpTextBody(DXDrawDgms.Point openXmlElement, DMDrawsDgms.TextBody? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsDgms.TextBodyConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDrawDgms.TextBody>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
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
    return DMXDrawsDgms.PtExtensionListConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXDrawDgms.PtExtensionList>());
  }
  
  private static bool CmpPtExtensionList(DXDrawDgms.Point openXmlElement, DMDrawsDgms.PtExtensionList? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsDgms.PtExtensionListConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDrawDgms.PtExtensionList>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
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
  
  public static DMDrawsDgms.Point? CreateModelElement(DXDrawDgms.Point? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDrawsDgms.Point();
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
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDrawsDgms.Point? value)
    where OpenXmlElementType: DXDrawDgms.Point, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetModelId(openXmlElement, value?.ModelId);
      SetType(openXmlElement, value?.Type);
      SetConnectionId(openXmlElement, value?.ConnectionId);
      SetPropertySet(openXmlElement, value?.PropertySet);
      SetShapeProperties(openXmlElement, value?.ShapeProperties);
      SetTextBody(openXmlElement, value?.TextBody);
      SetPtExtensionList(openXmlElement, value?.PtExtensionList);
      return openXmlElement;
    }
    return default;
  }
}
