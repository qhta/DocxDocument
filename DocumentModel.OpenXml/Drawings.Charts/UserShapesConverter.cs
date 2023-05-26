namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
/// User Shapes.
/// </summary>
public static class UserShapesConverter
{
  private static DMDCD.RelativeAnchorSize? GetRelativeAnchorSize(DXDC.UserShapes openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDCD.RelativeAnchorSize>();
    if (element != null)
      return DMXDCD.RelativeAnchorSizeConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpRelativeAnchorSize(DXDC.UserShapes openXmlElement, DMDCD.RelativeAnchorSize? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXDCD.RelativeAnchorSizeConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDCD.RelativeAnchorSize>(), value, diffs, objName, propName);
  }
  
  private static void SetRelativeAnchorSize(DXDC.UserShapes openXmlElement, DMDCD.RelativeAnchorSize? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDCD.RelativeAnchorSize>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDCD.RelativeAnchorSizeConverter.CreateOpenXmlElement<DXDCD.RelativeAnchorSize>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  private static DMDCD.AbsoluteAnchorSize? GetAbsoluteAnchorSize(DXDC.UserShapes openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDCD.AbsoluteAnchorSize>();
    if (element != null)
      return DMXDCD.AbsoluteAnchorSizeConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpAbsoluteAnchorSize(DXDC.UserShapes openXmlElement, DMDCD.AbsoluteAnchorSize? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXDCD.AbsoluteAnchorSizeConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDCD.AbsoluteAnchorSize>(), value, diffs, objName, propName);
  }
  
  private static void SetAbsoluteAnchorSize(DXDC.UserShapes openXmlElement, DMDCD.AbsoluteAnchorSize? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDCD.AbsoluteAnchorSize>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDCD.AbsoluteAnchorSizeConverter.CreateOpenXmlElement<DXDCD.AbsoluteAnchorSize>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  public static DocumentModel.Drawings.Charts.UserShapes? CreateModelElement(DXDC.UserShapes? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Charts.UserShapes();
      value.RelativeAnchorSize = GetRelativeAnchorSize(openXmlElement);
      value.AbsoluteAnchorSize = GetAbsoluteAnchorSize(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXDC.UserShapes? openXmlElement, DMDC.UserShapes? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpRelativeAnchorSize(openXmlElement, value.RelativeAnchorSize, diffs, objName, propName))
        ok = false;
      if (!CmpAbsoluteAnchorSize(openXmlElement, value.AbsoluteAnchorSize, diffs, objName, propName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDC.UserShapes value)
    where OpenXmlElementType: DXDC.UserShapes, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXDC.UserShapes openXmlElement, DMDC.UserShapes value)
  {
    SetRelativeAnchorSize(openXmlElement, value?.RelativeAnchorSize);
    SetAbsoluteAnchorSize(openXmlElement, value?.AbsoluteAnchorSize);
  }
}
