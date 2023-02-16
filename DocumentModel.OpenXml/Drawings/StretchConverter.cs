namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Stretch.
/// </summary>
public static class StretchConverter
{
  /// <summary>
  /// Fill Rectangle.
  /// </summary>
  private static DMDraws.RelativeRectangleType? GetFillRectangle(DXDraw.Stretch openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDraw.FillRectangle>();
    if (element != null)
      return DMXDraws.RelativeRectangleTypeConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpFillRectangle(DXDraw.Stretch openXmlElement, DMDraws.RelativeRectangleType? value, DiffList? diffs, string? objName)
  {
    return DMXDraws.RelativeRectangleTypeConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDraw.FillRectangle>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetFillRectangle(DXDraw.Stretch openXmlElement, DMDraws.RelativeRectangleType? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDraw.FillRectangle>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDraws.RelativeRectangleTypeConverter.CreateOpenXmlElement<DXDraw.FillRectangle>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DocumentModel.Drawings.Stretch? CreateModelElement(DXDraw.Stretch? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Stretch();
      value.FillRectangle = GetFillRectangle(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXDraw.Stretch? openXmlElement, DMDraws.Stretch? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpFillRectangle(openXmlElement, value.FillRectangle, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDraws.Stretch? value)
    where OpenXmlElementType: DXDraw.Stretch, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetFillRectangle(openXmlElement, value?.FillRectangle);
      return openXmlElement;
    }
    return default;
  }
}
