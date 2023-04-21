namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Shape Connection Site.
/// </summary>
public static class ConnectionSiteConverter
{
  /// <summary>
  /// Connection Site Angle
  /// </summary>
  private static String? GetAngle(DXD.ConnectionSite openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Angle);
  }
  
  private static bool CmpAngle(DXD.ConnectionSite openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Angle, value, diffs, objName, "Angle");
  }
  
  private static void SetAngle(DXD.ConnectionSite openXmlElement, String? value)
  {
    openXmlElement.Angle = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// Position.
  /// </summary>
  private static DMD.AdjustPoint2DType? GetPosition(DXD.ConnectionSite openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXD.Position>();
    if (element != null)
      return DMXD.AdjustPoint2DTypeConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpPosition(DXD.ConnectionSite openXmlElement, DMD.AdjustPoint2DType? value, DiffList? diffs, string? objName)
  {
    return DMXD.AdjustPoint2DTypeConverter.CompareModelElement(openXmlElement.GetFirstChild<DXD.Position>(), value, diffs, objName);
  }
  
  private static void SetPosition(DXD.ConnectionSite openXmlElement, DMD.AdjustPoint2DType? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXD.Position>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXD.AdjustPoint2DTypeConverter.CreateOpenXmlElement<DXD.Position>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DocumentModel.Drawings.ConnectionSite? CreateModelElement(DXD.ConnectionSite? openXmlElement)
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
  
  public static bool CompareModelElement(DXD.ConnectionSite? openXmlElement, DMD.ConnectionSite? value, DiffList? diffs, string? objName)
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
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMD.ConnectionSite value)
    where OpenXmlElementType: DXD.ConnectionSite, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXD.ConnectionSite openXmlElement, DMD.ConnectionSite value)
  {
    SetAngle(openXmlElement, value?.Angle);
    SetPosition(openXmlElement, value?.Position);
  }
}
