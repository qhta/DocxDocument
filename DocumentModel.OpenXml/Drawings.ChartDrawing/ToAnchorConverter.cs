namespace DocumentModel.OpenXml.Drawings.ChartDrawing;

/// <summary>
/// Ending Anchor Point.
/// </summary>
public static class ToAnchorConverter
{
  private static String? GetXPosition(DXDCD.ToAnchor openXmlElement)
  {
      return openXmlElement?.GetFirstChild<DXDCD.XPosition>()?.Text;
  }
  
  private static bool CmpXPosition(DXDCD.ToAnchor openXmlElement, String? value, DiffList? diffs, string? objName)
  {
      return openXmlElement?.GetFirstChild<DXDCD.XPosition>()?.Text == value;
  }
  
  private static void SetXPosition(DXDCD.ToAnchor openXmlElement, String? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDCD.XPosition>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DXDCD.XPosition { Text = value };
      openXmlElement.AddChild(itemElement);
    }
  }
  
  private static String? GetYPosition(DXDCD.ToAnchor openXmlElement)
  {
      return openXmlElement?.GetFirstChild<DXDCD.YPosition>()?.Text;
  }
  
  private static bool CmpYPosition(DXDCD.ToAnchor openXmlElement, String? value, DiffList? diffs, string? objName)
  {
      return openXmlElement?.GetFirstChild<DXDCD.YPosition>()?.Text == value;
  }
  
  private static void SetYPosition(DXDCD.ToAnchor openXmlElement, String? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDCD.YPosition>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DXDCD.YPosition { Text = value };
      openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DocumentModel.Drawings.ChartDrawing.ToAnchor? CreateModelElement(DXDCD.ToAnchor? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.ChartDrawing.ToAnchor();
      value.XPosition = GetXPosition(openXmlElement);
      value.YPosition = GetYPosition(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXDCD.ToAnchor? openXmlElement, DMDCD.ToAnchor? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpXPosition(openXmlElement, value.XPosition, diffs, objName))
        ok = false;
      if (!CmpYPosition(openXmlElement, value.YPosition, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDCD.ToAnchor value)
    where OpenXmlElementType: DXDCD.ToAnchor, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXDCD.ToAnchor openXmlElement, DMDCD.ToAnchor value)
  {
    SetXPosition(openXmlElement, value?.XPosition);
    SetYPosition(openXmlElement, value?.YPosition);
  }
}
