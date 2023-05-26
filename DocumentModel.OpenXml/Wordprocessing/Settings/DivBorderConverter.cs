namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Set of Borders for HTML div.
/// </summary>
public static class DivBorderConverter
{
  /// <summary>
  /// Top Border for HTML div.
  /// </summary>
  private static DMW.Border? GetTopBorder(DXW.DivBorder openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXW.TopBorder>();
    if (element != null)
      return DMXW.BorderConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpTopBorder(DXW.DivBorder openXmlElement, DMW.Border? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXW.BorderConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.TopBorder>(), value, diffs, objName, propName);
  }
  
  private static void SetTopBorder(DXW.DivBorder openXmlElement, DMW.Border? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.TopBorder>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.BorderConverter.CreateOpenXmlElement<DXW.TopBorder>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  /// <summary>
  /// Left Border for HTML div.
  /// </summary>
  private static DMW.Border? GetLeftBorder(DXW.DivBorder openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXW.LeftBorder>();
    if (element != null)
      return DMXW.BorderConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpLeftBorder(DXW.DivBorder openXmlElement, DMW.Border? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXW.BorderConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.LeftBorder>(), value, diffs, objName, propName);
  }
  
  private static void SetLeftBorder(DXW.DivBorder openXmlElement, DMW.Border? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.LeftBorder>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.BorderConverter.CreateOpenXmlElement<DXW.LeftBorder>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  /// <summary>
  /// Bottom Border for HTML div.
  /// </summary>
  private static DMW.Border? GetBottomBorder(DXW.DivBorder openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXW.BottomBorder>();
    if (element != null)
      return DMXW.BorderConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpBottomBorder(DXW.DivBorder openXmlElement, DMW.Border? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXW.BorderConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.BottomBorder>(), value, diffs, objName, propName);
  }
  
  private static void SetBottomBorder(DXW.DivBorder openXmlElement, DMW.Border? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.BottomBorder>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.BorderConverter.CreateOpenXmlElement<DXW.BottomBorder>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  /// <summary>
  /// Right Border for HTML div.
  /// </summary>
  private static DMW.Border? GetRightBorder(DXW.DivBorder openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXW.RightBorder>();
    if (element != null)
      return DMXW.BorderConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpRightBorder(DXW.DivBorder openXmlElement, DMW.Border? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXW.BorderConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.RightBorder>(), value, diffs, objName, propName);
  }
  
  private static void SetRightBorder(DXW.DivBorder openXmlElement, DMW.Border? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.RightBorder>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.BorderConverter.CreateOpenXmlElement<DXW.RightBorder>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  public static DMW.DivBorder? CreateModelElement(DXW.DivBorder? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMW.DivBorder();
      value.TopBorder = GetTopBorder(openXmlElement);
      value.LeftBorder = GetLeftBorder(openXmlElement);
      value.BottomBorder = GetBottomBorder(openXmlElement);
      value.RightBorder = GetRightBorder(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXW.DivBorder? openXmlElement, DMW.DivBorder? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpTopBorder(openXmlElement, value.TopBorder, diffs, objName, propName))
        ok = false;
      if (!CmpLeftBorder(openXmlElement, value.LeftBorder, diffs, objName, propName))
        ok = false;
      if (!CmpBottomBorder(openXmlElement, value.BottomBorder, diffs, objName, propName))
        ok = false;
      if (!CmpRightBorder(openXmlElement, value.RightBorder, diffs, objName, propName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMW.DivBorder value)
    where OpenXmlElementType: DXW.DivBorder, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXW.DivBorder openXmlElement, DMW.DivBorder value)
  {
    SetTopBorder(openXmlElement, value?.TopBorder);
    SetLeftBorder(openXmlElement, value?.LeftBorder);
    SetBottomBorder(openXmlElement, value?.BottomBorder);
    SetRightBorder(openXmlElement, value?.RightBorder);
  }
}
