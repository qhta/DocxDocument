namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Move Path To.
/// </summary>
public static class MoveToConverter
{
  /// <summary>
  /// Move end point.
  /// </summary>
  private static DMD.AdjustPoint2DType? GetPoint(DXD.MoveTo openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXD.Point>();
    if (element != null)
      return DMXD.AdjustPoint2DTypeConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpPoint(DXD.MoveTo openXmlElement, DMD.AdjustPoint2DType? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXD.AdjustPoint2DTypeConverter.CompareModelElement(openXmlElement.GetFirstChild<DXD.Point>(), value, diffs, objName, propName);
  }
  
  private static void SetPoint(DXD.MoveTo openXmlElement, DMD.AdjustPoint2DType? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXD.Point>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXD.AdjustPoint2DTypeConverter.CreateOpenXmlElement<DXD.Point>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  public static DMD.MoveTo? CreateModelElement(DXD.MoveTo? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMD.MoveTo();
      value.Point = GetPoint(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXD.MoveTo? openXmlElement, DMD.MoveTo? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpPoint(openXmlElement, value.Point, diffs, objName, propName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMD.MoveTo value)
    where OpenXmlElementType: DXD.MoveTo, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXD.MoveTo openXmlElement, DMD.MoveTo value)
  {
    SetPoint(openXmlElement, value?.Point);
  }
}
