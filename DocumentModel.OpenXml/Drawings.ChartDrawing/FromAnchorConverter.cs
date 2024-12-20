namespace DocumentModel.OpenXml.Drawings.ChartDrawing;

/// <summary>
/// Starting Anchor Point.
/// </summary>
public static class FromAnchorConverter
{
  private static String? GetXPosition(DXDCD.FromAnchor openXmlElement)
  {
      return openXmlElement?.GetFirstChild<DXDCD.XPosition>()?.Text;
  }
  
  private static bool CmpXPosition(DXDCD.FromAnchor openXmlElement, String? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
      return openXmlElement?.GetFirstChild<DXDCD.XPosition>()?.Text == value;
  }
  
  private static void SetXPosition(DXDCD.FromAnchor openXmlElement, String? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDCD.XPosition>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DXDCD.XPosition { Text = value };
      openXmlElement.AppendChild(itemElement);
    }
  }
  
  private static String? GetYPosition(DXDCD.FromAnchor openXmlElement)
  {
      return openXmlElement?.GetFirstChild<DXDCD.YPosition>()?.Text;
  }
  
  private static bool CmpYPosition(DXDCD.FromAnchor openXmlElement, String? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
      return openXmlElement?.GetFirstChild<DXDCD.YPosition>()?.Text == value;
  }
  
  private static void SetYPosition(DXDCD.FromAnchor openXmlElement, String? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDCD.YPosition>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DXDCD.YPosition { Text = value };
      openXmlElement.AppendChild(itemElement);
    }
  }
  
  public static DMD.ChartDrawing.FromAnchor? CreateModelElement(DXDCD.FromAnchor? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMD.ChartDrawing.FromAnchor();
      value.XPosition = GetXPosition(openXmlElement);
      value.YPosition = GetYPosition(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXDCD.FromAnchor? openXmlElement, DMDCD.FromAnchor? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpXPosition(openXmlElement, value.XPosition, diffs, objName, propName))
        ok = false;
      if (!CmpYPosition(openXmlElement, value.YPosition, diffs, objName, propName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDCD.FromAnchor value)
    where OpenXmlElementType: DXDCD.FromAnchor, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXDCD.FromAnchor openXmlElement, DMDCD.FromAnchor value)
  {
    SetXPosition(openXmlElement, value?.XPosition);
    SetYPosition(openXmlElement, value?.YPosition);
  }
}
