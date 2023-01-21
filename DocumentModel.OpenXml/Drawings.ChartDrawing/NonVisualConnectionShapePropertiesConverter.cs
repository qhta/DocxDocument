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
    var itemElement = openXmlElement?.GetFirstChild<DXDraw.ConnectionShapeLocks>();
    if (itemElement != null)
      return DMXDraws.ConnectionShapeLocksConverter.CreateModelElement(itemElement);
    return null;
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
    var itemElement = openXmlElement?.GetFirstChild<DXDraw.StartConnection>();
    if (itemElement != null)
      return DMXDraws.ConnectionTypeConverter.CreateModelElement(itemElement);
    return null;
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
    var itemElement = openXmlElement?.GetFirstChild<DXDraw.EndConnection>();
    if (itemElement != null)
      return DMXDraws.ConnectionTypeConverter.CreateModelElement(itemElement);
    return null;
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
    var itemElement = openXmlElement?.GetFirstChild<DXDraw.ExtensionList>();
    if (itemElement != null)
      return DMXDraws.ExtensionListConverter.CreateModelElement(itemElement);
    return null;
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
