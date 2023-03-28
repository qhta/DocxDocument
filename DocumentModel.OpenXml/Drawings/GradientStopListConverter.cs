namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Gradient Stop List converter from/to OpenXml.
///</summary>
public static class GradientStopListConverter
{
  private static DMDraws.GradientStop? GetGradientStop(DXDraw.GradientStopList openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDraw.GradientStop>();
    if (element != null)
      return DMXDraws.GradientStopConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpGradientStop(DXDraw.GradientStopList openXmlElement, DMDraws.GradientStop? value, DiffList? diffs, string? objName)
  {
    return DMXDraws.GradientStopConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDraw.GradientStop>(), value, diffs, objName);
  }
  
  private static void SetGradientStop(DXDraw.GradientStopList openXmlElement, DMDraws.GradientStop? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDraw.GradientStop>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDraws.GradientStopConverter.CreateOpenXmlElement<DXDraw.GradientStop>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DocumentModel.Drawings.GradientStopList? CreateModelElement(DXDraw.GradientStopList? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.GradientStopList();
      value.GradientStop = GetGradientStop(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXDraw.GradientStopList? openXmlElement, DMDraws.GradientStopList? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpGradientStop(openXmlElement, value.GradientStop, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDraws.GradientStopList value)
    where OpenXmlElementType: DXDraw.GradientStopList, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXDraw.GradientStopList openXmlElement, DMDraws.GradientStopList value)
  {
    SetGradientStop(openXmlElement, value?.GradientStop);
  }
}
