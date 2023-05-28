namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Custom geometry.
/// </summary>
public static class CustomGeometryConverter
{
  /// <summary>
  /// Adjust Value List.
  /// </summary>
  private static DMD.AdjustValueList? GetAdjustValueList(DXD.CustomGeometry openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXD.AdjustValueList>();
    if (element != null)
      return DMXD.AdjustValueListConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpAdjustValueList(DXD.CustomGeometry openXmlElement, DMD.AdjustValueList? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXD.AdjustValueListConverter.CompareModelElement(openXmlElement.GetFirstChild<DXD.AdjustValueList>(), value, diffs, objName, propName);
  }
  
  private static void SetAdjustValueList(DXD.CustomGeometry openXmlElement, DMD.AdjustValueList? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXD.AdjustValueList>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXD.AdjustValueListConverter.CreateOpenXmlElement<DXD.AdjustValueList>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  /// <summary>
  /// List of Shape Guides.
  /// </summary>
  private static DMD.ShapeGuideList? GetShapeGuideList(DXD.CustomGeometry openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXD.ShapeGuideList>();
    if (element != null)
      return DMXD.ShapeGuideListConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpShapeGuideList(DXD.CustomGeometry openXmlElement, DMD.ShapeGuideList? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXD.ShapeGuideListConverter.CompareModelElement(openXmlElement.GetFirstChild<DXD.ShapeGuideList>(), value, diffs, objName, propName);
  }
  
  private static void SetShapeGuideList(DXD.CustomGeometry openXmlElement, DMD.ShapeGuideList? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXD.ShapeGuideList>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXD.ShapeGuideListConverter.CreateOpenXmlElement<DXD.ShapeGuideList>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  /// <summary>
  /// List of Shape Adjust Handles.
  /// </summary>
  private static DMD.AdjustHandleList? GetAdjustHandleList(DXD.CustomGeometry openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXD.AdjustHandleList>();
    if (element != null)
      return DMXD.AdjustHandleListConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpAdjustHandleList(DXD.CustomGeometry openXmlElement, DMD.AdjustHandleList? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXD.AdjustHandleListConverter.CompareModelElement(openXmlElement.GetFirstChild<DXD.AdjustHandleList>(), value, diffs, objName, propName);
  }
  
  private static void SetAdjustHandleList(DXD.CustomGeometry openXmlElement, DMD.AdjustHandleList? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXD.AdjustHandleList>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXD.AdjustHandleListConverter.CreateOpenXmlElement<DXD.AdjustHandleList>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  /// <summary>
  /// List of Shape Connection Sites.
  /// </summary>
  private static DMD.ConnectionSiteList? GetConnectionSiteList(DXD.CustomGeometry openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXD.ConnectionSiteList>();
    if (element != null)
      return DMXD.ConnectionSiteListConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpConnectionSiteList(DXD.CustomGeometry openXmlElement, DMD.ConnectionSiteList? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXD.ConnectionSiteListConverter.CompareModelElement(openXmlElement.GetFirstChild<DXD.ConnectionSiteList>(), value, diffs, objName, propName);
  }
  
  private static void SetConnectionSiteList(DXD.CustomGeometry openXmlElement, DMD.ConnectionSiteList? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXD.ConnectionSiteList>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXD.ConnectionSiteListConverter.CreateOpenXmlElement<DXD.ConnectionSiteList>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  /// <summary>
  /// Shape Text Rectangle.
  /// </summary>
  private static DMD.Rectangle? GetRectangle(DXD.CustomGeometry openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXD.Rectangle>();
    if (element != null)
      return DMXD.RectangleConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpRectangle(DXD.CustomGeometry openXmlElement, DMD.Rectangle? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXD.RectangleConverter.CompareModelElement(openXmlElement.GetFirstChild<DXD.Rectangle>(), value, diffs, objName, propName);
  }
  
  private static void SetRectangle(DXD.CustomGeometry openXmlElement, DMD.Rectangle? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXD.Rectangle>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXD.RectangleConverter.CreateOpenXmlElement<DXD.Rectangle>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  /// <summary>
  /// List of Shape Paths.
  /// </summary>
  private static DMD.PathList? GetPathList(DXD.CustomGeometry openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXD.PathList>();
    if (element != null)
      return DMXD.PathListConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpPathList(DXD.CustomGeometry openXmlElement, DMD.PathList? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXD.PathListConverter.CompareModelElement(openXmlElement.GetFirstChild<DXD.PathList>(), value, diffs, objName, propName);
  }
  
  private static void SetPathList(DXD.CustomGeometry openXmlElement, DMD.PathList? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXD.PathList>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXD.PathListConverter.CreateOpenXmlElement<DXD.PathList>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  public static DMD.CustomGeometry? CreateModelElement(DXD.CustomGeometry? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMD.CustomGeometry();
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
  
  public static bool CompareModelElement(DXD.CustomGeometry? openXmlElement, DMD.CustomGeometry? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpAdjustValueList(openXmlElement, value.AdjustValueList, diffs, objName, propName))
        ok = false;
      if (!CmpShapeGuideList(openXmlElement, value.ShapeGuideList, diffs, objName, propName))
        ok = false;
      if (!CmpAdjustHandleList(openXmlElement, value.AdjustHandleList, diffs, objName, propName))
        ok = false;
      if (!CmpConnectionSiteList(openXmlElement, value.ConnectionSiteList, diffs, objName, propName))
        ok = false;
      if (!CmpRectangle(openXmlElement, value.Rectangle, diffs, objName, propName))
        ok = false;
      if (!CmpPathList(openXmlElement, value.PathList, diffs, objName, propName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMD.CustomGeometry value)
    where OpenXmlElementType: DXD.CustomGeometry, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXD.CustomGeometry openXmlElement, DMD.CustomGeometry value)
  {
    SetAdjustValueList(openXmlElement, value?.AdjustValueList);
    SetShapeGuideList(openXmlElement, value?.ShapeGuideList);
    SetAdjustHandleList(openXmlElement, value?.AdjustHandleList);
    SetConnectionSiteList(openXmlElement, value?.ConnectionSiteList);
    SetRectangle(openXmlElement, value?.Rectangle);
    SetPathList(openXmlElement, value?.PathList);
  }
}
