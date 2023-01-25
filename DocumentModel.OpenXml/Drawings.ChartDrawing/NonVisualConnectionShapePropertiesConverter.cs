namespace DocumentModel.OpenXml.Drawings.ChartDrawing;

/// <summary>
/// Non-Visual Connection Shape Drawing Properties.
/// </summary>
public static class NonVisualConnectionShapePropertiesConverter
{
  /// <summary>
  /// Connection Shape Locks.
  /// </summary>
  private static DMDraws.ConnectionShapeLocks? GetConnectionShapeLocks(DXDrawChartDraw.NonVisualConnectionShapeProperties openXmlElement)
  {
    return DMXDraws.ConnectionShapeLocksConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXDraw.ConnectionShapeLocks>());
  }
  
  private static bool CmpConnectionShapeLocks(DXDrawChartDraw.NonVisualConnectionShapeProperties openXmlElement, DMDraws.ConnectionShapeLocks? value, DiffList? diffs, string? objName)
  {
    return DMXDraws.ConnectionShapeLocksConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDraw.ConnectionShapeLocks>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetConnectionShapeLocks(DXDrawChartDraw.NonVisualConnectionShapeProperties openXmlElement, DMDraws.ConnectionShapeLocks? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDraw.ConnectionShapeLocks>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDraws.ConnectionShapeLocksConverter.CreateOpenXmlElement<DXDraw.ConnectionShapeLocks>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Connection Start.
  /// </summary>
  private static DMDraws.ConnectionType? GetStartConnection(DXDrawChartDraw.NonVisualConnectionShapeProperties openXmlElement)
  {
    return DMXDraws.ConnectionTypeConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXDraw.StartConnection>());
  }
  
  private static bool CmpStartConnection(DXDrawChartDraw.NonVisualConnectionShapeProperties openXmlElement, DMDraws.ConnectionType? value, DiffList? diffs, string? objName)
  {
    return DMXDraws.ConnectionTypeConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDraw.StartConnection>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetStartConnection(DXDrawChartDraw.NonVisualConnectionShapeProperties openXmlElement, DMDraws.ConnectionType? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDraw.StartConnection>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDraws.ConnectionTypeConverter.CreateOpenXmlElement<DXDraw.StartConnection>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Connection End.
  /// </summary>
  private static DMDraws.ConnectionType? GetEndConnection(DXDrawChartDraw.NonVisualConnectionShapeProperties openXmlElement)
  {
    return DMXDraws.ConnectionTypeConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXDraw.EndConnection>());
  }
  
  private static bool CmpEndConnection(DXDrawChartDraw.NonVisualConnectionShapeProperties openXmlElement, DMDraws.ConnectionType? value, DiffList? diffs, string? objName)
  {
    return DMXDraws.ConnectionTypeConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDraw.EndConnection>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetEndConnection(DXDrawChartDraw.NonVisualConnectionShapeProperties openXmlElement, DMDraws.ConnectionType? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDraw.EndConnection>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDraws.ConnectionTypeConverter.CreateOpenXmlElement<DXDraw.EndConnection>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// ExtensionList.
  /// </summary>
  private static DMDraws.ExtensionList? GetExtensionList(DXDrawChartDraw.NonVisualConnectionShapeProperties openXmlElement)
  {
    return DMXDraws.ExtensionListConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXDraw.ExtensionList>());
  }
  
  private static bool CmpExtensionList(DXDrawChartDraw.NonVisualConnectionShapeProperties openXmlElement, DMDraws.ExtensionList? value, DiffList? diffs, string? objName)
  {
    return DMXDraws.ExtensionListConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDraw.ExtensionList>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetExtensionList(DXDrawChartDraw.NonVisualConnectionShapeProperties openXmlElement, DMDraws.ExtensionList? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDraw.ExtensionList>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDraws.ExtensionListConverter.CreateOpenXmlElement<DXDraw.ExtensionList>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DMDrawsChartDraw.NonVisualConnectionShapeProperties? CreateModelElement(DXDrawChartDraw.NonVisualConnectionShapeProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDrawsChartDraw.NonVisualConnectionShapeProperties();
      value.ConnectionShapeLocks = GetConnectionShapeLocks(openXmlElement);
      value.StartConnection = GetStartConnection(openXmlElement);
      value.EndConnection = GetEndConnection(openXmlElement);
      value.ExtensionList = GetExtensionList(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXDrawChartDraw.NonVisualConnectionShapeProperties? openXmlElement, DMDrawsChartDraw.NonVisualConnectionShapeProperties? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpConnectionShapeLocks(openXmlElement, value.ConnectionShapeLocks, diffs, objName))
        ok = false;
      if (!CmpStartConnection(openXmlElement, value.StartConnection, diffs, objName))
        ok = false;
      if (!CmpEndConnection(openXmlElement, value.EndConnection, diffs, objName))
        ok = false;
      if (!CmpExtensionList(openXmlElement, value.ExtensionList, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDrawsChartDraw.NonVisualConnectionShapeProperties? value)
    where OpenXmlElementType: DXDrawChartDraw.NonVisualConnectionShapeProperties, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetConnectionShapeLocks(openXmlElement, value?.ConnectionShapeLocks);
      SetStartConnection(openXmlElement, value?.StartConnection);
      SetEndConnection(openXmlElement, value?.EndConnection);
      SetExtensionList(openXmlElement, value?.ExtensionList);
      return openXmlElement;
    }
    return default;
  }
}
