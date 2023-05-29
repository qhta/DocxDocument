namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Shape Connection Site.
/// </summary>
public static class ConnectionSiteConverter
{
  /// <summary>
  /// Connection Site Angle
  /// </summary>
  private static String? GetAngle(DXDraw.ConnectionSite openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Angle);
  }
  
  private static bool CmpAngle(DXDraw.ConnectionSite openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Angle, value, diffs, objName, "Angle");
  }
  
  private static void SetAngle(DXDraw.ConnectionSite openXmlElement, String? value)
  {
    openXmlElement.Angle = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// Position.
  /// </summary>
  private static DMDraws.AdjustPoint2DType? GetPosition(DXDraw.ConnectionSite openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDraw.Position>();
    if (element != null)
      return DMXDraws.AdjustPoint2DTypeConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpPosition(DXDraw.ConnectionSite openXmlElement, DMDraws.AdjustPoint2DType? value, DiffList? diffs, string? objName)
  {
    return DMXDraws.AdjustPoint2DTypeConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDraw.Position>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetPosition(DXDraw.ConnectionSite openXmlElement, DMDraws.AdjustPoint2DType? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDraw.Position>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDraws.AdjustPoint2DTypeConverter.CreateOpenXmlElement<DXDraw.Position>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DocumentModel.Drawings.ConnectionSite? CreateModelElement(DXDraw.ConnectionSite? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.ConnectionSite();
      value.Angle = GetAngle(openXmlElement);
      value.Position = GetPosition(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXDraw.ConnectionSite? openXmlElement, DMDraws.ConnectionSite? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpAngle(openXmlElement, value.Angle, diffs, objName))
        ok = false;
      if (!CmpPosition(openXmlElement, value.Position, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDraws.ConnectionSite value)
    where OpenXmlElementType: DXDraw.ConnectionSite, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXDraw.ConnectionSite openXmlElement, DMDraws.ConnectionSite value)
  {
    SetAngle(openXmlElement, value?.Angle);
    SetPosition(openXmlElement, value?.Position);
  }
}
