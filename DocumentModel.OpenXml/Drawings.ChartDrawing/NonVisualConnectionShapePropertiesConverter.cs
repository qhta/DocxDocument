namespace DocumentModel.OpenXml.Drawings.ChartDrawing;

/// <summary>
/// Non-Visual Connection Shape Drawing Properties.
/// </summary>
public static class NonVisualConnectionShapePropertiesConverter
{
  /// <summary>
  /// Connection Shape Locks.
  /// </summary>
  private static DMD.ConnectionShapeLocks? GetConnectionShapeLocks(DXDCD.NonVisualConnectionShapeProperties openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXD.ConnectionShapeLocks>();
    if (element != null)
      return DMXD.ConnectionShapeLocksConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpConnectionShapeLocks(DXDCD.NonVisualConnectionShapeProperties openXmlElement, DMD.ConnectionShapeLocks? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXD.ConnectionShapeLocksConverter.CompareModelElement(openXmlElement.GetFirstChild<DXD.ConnectionShapeLocks>(), value, diffs, objName, propName);
  }
  
  private static void SetConnectionShapeLocks(DXDCD.NonVisualConnectionShapeProperties openXmlElement, DMD.ConnectionShapeLocks? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXD.ConnectionShapeLocks>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXD.ConnectionShapeLocksConverter.CreateOpenXmlElement<DXD.ConnectionShapeLocks>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  /// <summary>
  /// Connection Start.
  /// </summary>
  private static DMD.ConnectionType? GetStartConnection(DXDCD.NonVisualConnectionShapeProperties openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXD.StartConnection>();
    if (element != null)
      return DMXD.ConnectionTypeConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpStartConnection(DXDCD.NonVisualConnectionShapeProperties openXmlElement, DMD.ConnectionType? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXD.ConnectionTypeConverter.CompareModelElement(openXmlElement.GetFirstChild<DXD.StartConnection>(), value, diffs, objName, propName);
  }
  
  private static void SetStartConnection(DXDCD.NonVisualConnectionShapeProperties openXmlElement, DMD.ConnectionType? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXD.StartConnection>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXD.ConnectionTypeConverter.CreateOpenXmlElement<DXD.StartConnection>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  /// <summary>
  /// Connection End.
  /// </summary>
  private static DMD.ConnectionType? GetEndConnection(DXDCD.NonVisualConnectionShapeProperties openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXD.EndConnection>();
    if (element != null)
      return DMXD.ConnectionTypeConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpEndConnection(DXDCD.NonVisualConnectionShapeProperties openXmlElement, DMD.ConnectionType? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXD.ConnectionTypeConverter.CompareModelElement(openXmlElement.GetFirstChild<DXD.EndConnection>(), value, diffs, objName, propName);
  }
  
  private static void SetEndConnection(DXDCD.NonVisualConnectionShapeProperties openXmlElement, DMD.ConnectionType? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXD.EndConnection>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXD.ConnectionTypeConverter.CreateOpenXmlElement<DXD.EndConnection>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  /// <summary>
  /// ExtensionList.
  /// </summary>
  private static DMD.ExtensionList? GetExtensionList(DXDCD.NonVisualConnectionShapeProperties openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXD.ExtensionList>();
    if (element != null)
      return DMXD.ExtensionListConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpExtensionList(DXDCD.NonVisualConnectionShapeProperties openXmlElement, DMD.ExtensionList? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXD.ExtensionListConverter.CompareModelElement(openXmlElement.GetFirstChild<DXD.ExtensionList>(), value, diffs, objName, propName);
  }
  
  private static void SetExtensionList(DXDCD.NonVisualConnectionShapeProperties openXmlElement, DMD.ExtensionList? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXD.ExtensionList>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXD.ExtensionListConverter.CreateOpenXmlElement<DXD.ExtensionList>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  public static DocumentModel.Drawings.ChartDrawing.NonVisualConnectionShapeProperties? CreateModelElement(DXDCD.NonVisualConnectionShapeProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.ChartDrawing.NonVisualConnectionShapeProperties();
      value.ConnectionShapeLocks = GetConnectionShapeLocks(openXmlElement);
      value.StartConnection = GetStartConnection(openXmlElement);
      value.EndConnection = GetEndConnection(openXmlElement);
      value.ExtensionList = GetExtensionList(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXDCD.NonVisualConnectionShapeProperties? openXmlElement, DMDCD.NonVisualConnectionShapeProperties? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpConnectionShapeLocks(openXmlElement, value.ConnectionShapeLocks, diffs, objName, propName))
        ok = false;
      if (!CmpStartConnection(openXmlElement, value.StartConnection, diffs, objName, propName))
        ok = false;
      if (!CmpEndConnection(openXmlElement, value.EndConnection, diffs, objName, propName))
        ok = false;
      if (!CmpExtensionList(openXmlElement, value.ExtensionList, diffs, objName, propName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDCD.NonVisualConnectionShapeProperties value)
    where OpenXmlElementType: DXDCD.NonVisualConnectionShapeProperties, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXDCD.NonVisualConnectionShapeProperties openXmlElement, DMDCD.NonVisualConnectionShapeProperties value)
  {
    SetConnectionShapeLocks(openXmlElement, value?.ConnectionShapeLocks);
    SetStartConnection(openXmlElement, value?.StartConnection);
    SetEndConnection(openXmlElement, value?.EndConnection);
    SetExtensionList(openXmlElement, value?.ExtensionList);
  }
}
