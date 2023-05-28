namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Stretch.
/// </summary>
public static class StretchConverter
{
  /// <summary>
  /// Fill Rectangle.
  /// </summary>
  private static DMD.RelativeRectangleType? GetFillRectangle(DXD.Stretch openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXD.FillRectangle>();
    if (element != null)
      return DMXD.RelativeRectangleTypeConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpFillRectangle(DXD.Stretch openXmlElement, DMD.RelativeRectangleType? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXD.RelativeRectangleTypeConverter.CompareModelElement(openXmlElement.GetFirstChild<DXD.FillRectangle>(), value, diffs, objName, propName);
  }
  
  private static void SetFillRectangle(DXD.Stretch openXmlElement, DMD.RelativeRectangleType? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXD.FillRectangle>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXD.RelativeRectangleTypeConverter.CreateOpenXmlElement<DXD.FillRectangle>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  public static DMD.Stretch? CreateModelElement(DXD.Stretch? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMD.Stretch();
      value.FillRectangle = GetFillRectangle(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXD.Stretch? openXmlElement, DMD.Stretch? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpFillRectangle(openXmlElement, value.FillRectangle, diffs, objName, propName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMD.Stretch value)
    where OpenXmlElementType: DXD.Stretch, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXD.Stretch openXmlElement, DMD.Stretch value)
  {
    SetFillRectangle(openXmlElement, value?.FillRectangle);
  }
}
