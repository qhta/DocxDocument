namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Custom geometry.
/// </summary>
public static class CustomGeometryConverter
{
  /// <summary>
  /// Adjust Value List.
  /// </summary>
  private static DMDraws.AdjustValueList? GetAdjustValueList(DXDraw.CustomGeometry openXmlElement)
  {
    return DMXDraws.AdjustValueListConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXDraw.AdjustValueList>());
  }
  
  private static bool CmpAdjustValueList(DXDraw.CustomGeometry openXmlElement, DMDraws.AdjustValueList? value, DiffList? diffs, string? objName)
  {
    return DMXDraws.AdjustValueListConverter.CompareModelElement(openXmlElement?.GetFirstChild<DXDraw.AdjustValueList>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetAdjustValueList(DXDraw.CustomGeometry openXmlElement, DMDraws.AdjustValueList? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDraw.AdjustValueList>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDraws.AdjustValueListConverter.CreateOpenXmlElement<DXDraw.AdjustValueList>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// List of Shape Guides.
  /// </summary>
  private static DMDraws.ShapeGuideList? GetShapeGuideList(DXDraw.CustomGeometry openXmlElement)
  {
    return DMXDraws.ShapeGuideListConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXDraw.ShapeGuideList>());
  }
  
  private static bool CmpShapeGuideList(DXDraw.CustomGeometry openXmlElement, DMDraws.ShapeGuideList? value, DiffList? diffs, string? objName)
  {
    return DMXDraws.ShapeGuideListConverter.CompareModelElement(openXmlElement?.GetFirstChild<DXDraw.ShapeGuideList>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetShapeGuideList(DXDraw.CustomGeometry openXmlElement, DMDraws.ShapeGuideList? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDraw.ShapeGuideList>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDraws.ShapeGuideListConverter.CreateOpenXmlElement<DXDraw.ShapeGuideList>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// List of Shape Adjust Handles.
  /// </summary>
  private static DMDraws.AdjustHandleList? GetAdjustHandleList(DXDraw.CustomGeometry openXmlElement)
  {
    return DMXDraws.AdjustHandleListConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXDraw.AdjustHandleList>());
  }
  
  private static bool CmpAdjustHandleList(DXDraw.CustomGeometry openXmlElement, DMDraws.AdjustHandleList? value, DiffList? diffs, string? objName)
  {
    return DMXDraws.AdjustHandleListConverter.CompareModelElement(openXmlElement?.GetFirstChild<DXDraw.AdjustHandleList>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetAdjustHandleList(DXDraw.CustomGeometry openXmlElement, DMDraws.AdjustHandleList? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDraw.AdjustHandleList>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDraws.AdjustHandleListConverter.CreateOpenXmlElement<DXDraw.AdjustHandleList>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// List of Shape Connection Sites.
  /// </summary>
  private static DMDraws.ConnectionSiteList? GetConnectionSiteList(DXDraw.CustomGeometry openXmlElement)
  {
    return DMXDraws.ConnectionSiteListConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXDraw.ConnectionSiteList>());
  }
  
  private static bool CmpConnectionSiteList(DXDraw.CustomGeometry openXmlElement, DMDraws.ConnectionSiteList? value, DiffList? diffs, string? objName)
  {
    return DMXDraws.ConnectionSiteListConverter.CompareModelElement(openXmlElement?.GetFirstChild<DXDraw.ConnectionSiteList>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetConnectionSiteList(DXDraw.CustomGeometry openXmlElement, DMDraws.ConnectionSiteList? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDraw.ConnectionSiteList>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDraws.ConnectionSiteListConverter.CreateOpenXmlElement<DXDraw.ConnectionSiteList>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Shape Text Rectangle.
  /// </summary>
  private static DMDraws.Rectangle? GetRectangle(DXDraw.CustomGeometry openXmlElement)
  {
    return DMXDraws.RectangleConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXDraw.Rectangle>());
  }
  
  private static bool CmpRectangle(DXDraw.CustomGeometry openXmlElement, DMDraws.Rectangle? value, DiffList? diffs, string? objName)
  {
    return DMXDraws.RectangleConverter.CompareModelElement(openXmlElement?.GetFirstChild<DXDraw.Rectangle>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetRectangle(DXDraw.CustomGeometry openXmlElement, DMDraws.Rectangle? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDraw.Rectangle>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDraws.RectangleConverter.CreateOpenXmlElement<DXDraw.Rectangle>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// List of Shape Paths.
  /// </summary>
  private static DMDraws.PathList? GetPathList(DXDraw.CustomGeometry openXmlElement)
  {
    return DMXDraws.PathListConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXDraw.PathList>());
  }
  
  private static bool CmpPathList(DXDraw.CustomGeometry openXmlElement, DMDraws.PathList? value, DiffList? diffs, string? objName)
  {
    return DMXDraws.PathListConverter.CompareModelElement(openXmlElement?.GetFirstChild<DXDraw.PathList>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetPathList(DXDraw.CustomGeometry openXmlElement, DMDraws.PathList? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDraw.PathList>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDraws.PathListConverter.CreateOpenXmlElement<DXDraw.PathList>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DMDraws.CustomGeometry? CreateModelElement(DXDraw.CustomGeometry? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDraws.CustomGeometry();
      value.AdjustValueList = GetAdjustValueList(openXmlElement);
      value.ShapeGuideList = GetShapeGuideList(openXmlElement);
      value.AdjustHandleList = GetAdjustHandleList(openXmlElement);
      value.ConnectionSiteList = GetConnectionSiteList(openXmlElement);
      value.Rectangle = GetRectangle(openXmlElement);
      value.PathList = GetPathList(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXDraw.CustomGeometry? openXmlElement, DMDraws.CustomGeometry? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpAdjustValueList(openXmlElement, value.AdjustValueList, diffs, objName))
        ok = false;
      if (!CmpShapeGuideList(openXmlElement, value.ShapeGuideList, diffs, objName))
        ok = false;
      if (!CmpAdjustHandleList(openXmlElement, value.AdjustHandleList, diffs, objName))
        ok = false;
      if (!CmpConnectionSiteList(openXmlElement, value.ConnectionSiteList, diffs, objName))
        ok = false;
      if (!CmpRectangle(openXmlElement, value.Rectangle, diffs, objName))
        ok = false;
      if (!CmpPathList(openXmlElement, value.PathList, diffs, objName))
        ok = false;
      return ok;
    }
    return openXmlElement == null && value == null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDraws.CustomGeometry? value)
    where OpenXmlElementType: DXDraw.CustomGeometry, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetAdjustValueList(openXmlElement, value?.AdjustValueList);
      SetShapeGuideList(openXmlElement, value?.ShapeGuideList);
      SetAdjustHandleList(openXmlElement, value?.AdjustHandleList);
      SetConnectionSiteList(openXmlElement, value?.ConnectionSiteList);
      SetRectangle(openXmlElement, value?.Rectangle);
      SetPathList(openXmlElement, value?.PathList);
      return openXmlElement;
    }
    return default;
  }
}
