namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Gradient Stop List.
/// </summary>
public static class GradientStopListConverter
{
  private static DMD.GradientStop? GetGradientStop(DXD.GradientStopList openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXD.GradientStop>();
    if (element != null)
      return DMXD.GradientStopConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpGradientStop(DXD.GradientStopList openXmlElement, DMD.GradientStop? value, DiffList? diffs, string? objName)
  {
    return DMXD.GradientStopConverter.CompareModelElement(openXmlElement.GetFirstChild<DXD.GradientStop>(), value, diffs, objName);
  }
  
  private static void SetGradientStop(DXD.GradientStopList openXmlElement, DMD.GradientStop? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXD.GradientStop>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXD.GradientStopConverter.CreateOpenXmlElement<DXD.GradientStop>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DocumentModel.Drawings.GradientStopList? CreateModelElement(DXD.GradientStopList? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.GradientStopList();
      value.GradientStop = GetGradientStop(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXD.GradientStopList? openXmlElement, DMD.GradientStopList? value, DiffList? diffs, string? objName)
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
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMD.GradientStopList value)
    where OpenXmlElementType: DXD.GradientStopList, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXD.GradientStopList openXmlElement, DMD.GradientStopList value)
  {
    SetGradientStop(openXmlElement, value?.GradientStop);
  }
}
