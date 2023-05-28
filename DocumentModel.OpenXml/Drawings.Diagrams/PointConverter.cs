namespace DocumentModel.OpenXml.Drawings.Diagrams;

/// <summary>
/// Point.
/// </summary>
public static class PointConverter
{
  /// <summary>
  /// Model Identifier
  /// </summary>
  private static String? GetModelId(DXDD.Point openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.ModelId);
  }
  
  private static bool CmpModelId(DXDD.Point openXmlElement, String? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return StringValueConverter.CmpValue(openXmlElement?.ModelId, value, diffs, objName, "ModelId");
  }
  
  private static void SetModelId(DXDD.Point openXmlElement, String? value)
  {
    openXmlElement.ModelId = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// Point Type
  /// </summary>
  private static DMDD.PointKind? GetType(DXDD.Point openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.Diagrams.PointValues, DMDD.PointKind>(openXmlElement?.Type?.Value);
  }
  
  private static bool CmpType(DXDD.Point openXmlElement, DMDD.PointKind? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Drawing.Diagrams.PointValues, DMDD.PointKind>(openXmlElement?.Type?.Value, value, diffs, objName, propName);
  }
  
  private static void SetType(DXDD.Point openXmlElement, DMDD.PointKind? value)
  {
    openXmlElement.Type = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Drawing.Diagrams.PointValues, DMDD.PointKind>(value);
  }
  
  /// <summary>
  /// Connection Identifier
  /// </summary>
  private static String? GetConnectionId(DXDD.Point openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.ConnectionId);
  }
  
  private static bool CmpConnectionId(DXDD.Point openXmlElement, String? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return StringValueConverter.CmpValue(openXmlElement?.ConnectionId, value, diffs, objName, "ConnectionId");
  }
  
  private static void SetConnectionId(DXDD.Point openXmlElement, String? value)
  {
    openXmlElement.ConnectionId = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// Property Set.
  /// </summary>
  private static DMDD.PropertySet? GetPropertySet(DXDD.Point openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDD.PropertySet>();
    if (element != null)
      return DMXDD.PropertySetConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpPropertySet(DXDD.Point openXmlElement, DMDD.PropertySet? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXDD.PropertySetConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDD.PropertySet>(), value, diffs, objName, propName);
  }
  
  private static void SetPropertySet(DXDD.Point openXmlElement, DMDD.PropertySet? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDD.PropertySet>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDD.PropertySetConverter.CreateOpenXmlElement<DXDD.PropertySet>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  /// <summary>
  /// Shape Properties.
  /// </summary>
  private static DMDD.ShapeProperties? GetShapeProperties(DXDD.Point openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDD.ShapeProperties>();
    if (element != null)
      return DMXDD.ShapePropertiesConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpShapeProperties(DXDD.Point openXmlElement, DMDD.ShapeProperties? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXDD.ShapePropertiesConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDD.ShapeProperties>(), value, diffs, objName, propName);
  }
  
  private static void SetShapeProperties(DXDD.Point openXmlElement, DMDD.ShapeProperties? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDD.ShapeProperties>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDD.ShapePropertiesConverter.CreateOpenXmlElement<DXDD.ShapeProperties>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  /// <summary>
  /// Text Body.
  /// </summary>
  private static DMDD.TextBody? GetTextBody(DXDD.Point openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDD.TextBody>();
    if (element != null)
      return DMXDD.TextBodyConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpTextBody(DXDD.Point openXmlElement, DMDD.TextBody? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXDD.TextBodyConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDD.TextBody>(), value, diffs, objName, propName);
  }
  
  private static void SetTextBody(DXDD.Point openXmlElement, DMDD.TextBody? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDD.TextBody>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDD.TextBodyConverter.CreateOpenXmlElement<DXDD.TextBody>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  /// <summary>
  /// PtExtensionList.
  /// </summary>
  private static DMDD.PtExtensionList? GetPtExtensionList(DXDD.Point openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDD.PtExtensionList>();
    if (element != null)
      return DMXDD.PtExtensionListConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpPtExtensionList(DXDD.Point openXmlElement, DMDD.PtExtensionList? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXDD.PtExtensionListConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDD.PtExtensionList>(), value, diffs, objName, propName);
  }
  
  private static void SetPtExtensionList(DXDD.Point openXmlElement, DMDD.PtExtensionList? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDD.PtExtensionList>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDD.PtExtensionListConverter.CreateOpenXmlElement<DXDD.PtExtensionList>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  public static DMDD.Point? CreateModelElement(DXDD.Point? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDD.Point();
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
  
  public static bool CompareModelElement(DXDD.Point? openXmlElement, DMDD.Point? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpModelId(openXmlElement, value.ModelId, diffs, objName, propName))
        ok = false;
      if (!CmpType(openXmlElement, value.Type, diffs, objName, propName))
        ok = false;
      if (!CmpConnectionId(openXmlElement, value.ConnectionId, diffs, objName, propName))
        ok = false;
      if (!CmpPropertySet(openXmlElement, value.PropertySet, diffs, objName, propName))
        ok = false;
      if (!CmpShapeProperties(openXmlElement, value.ShapeProperties, diffs, objName, propName))
        ok = false;
      if (!CmpTextBody(openXmlElement, value.TextBody, diffs, objName, propName))
        ok = false;
      if (!CmpPtExtensionList(openXmlElement, value.PtExtensionList, diffs, objName, propName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDD.Point value)
    where OpenXmlElementType: DXDD.Point, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXDD.Point openXmlElement, DMDD.Point value)
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
