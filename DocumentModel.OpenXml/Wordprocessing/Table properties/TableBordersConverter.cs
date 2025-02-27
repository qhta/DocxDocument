namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Defines the TableBorders Class.
/// </summary>
public static class TableBordersConverter
{
  /// <summary>
  /// Table Top Border.
  /// </summary>
  private static DMW.Border? GetTopBorder(DXW.TableBorders openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXW.TopBorder>();
    if (element != null)
      return DMXW.BorderConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpTopBorder(DXW.TableBorders openXmlElement, DMW.Border? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXW.BorderConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.TopBorder>(), value, diffs, objName, propName);
  }
  
  private static void SetTopBorder(DXW.TableBorders openXmlElement, DMW.Border? value)
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
  /// Table Left Border.
  /// </summary>
  private static DMW.Border? GetLeftBorder(DXW.TableBorders openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXW.LeftBorder>();
    if (element != null)
      return DMXW.BorderConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpLeftBorder(DXW.TableBorders openXmlElement, DMW.Border? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXW.BorderConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.LeftBorder>(), value, diffs, objName, propName);
  }
  
  private static void SetLeftBorder(DXW.TableBorders openXmlElement, DMW.Border? value)
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
  /// StartBorder, this property is only available in Office 2010 and later..
  /// </summary>
  private static DMW.Border? GetStartBorder(DXW.TableBorders openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXW.StartBorder>();
    if (element != null)
      return DMXW.BorderConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpStartBorder(DXW.TableBorders openXmlElement, DMW.Border? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXW.BorderConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.StartBorder>(), value, diffs, objName, propName);
  }
  
  private static void SetStartBorder(DXW.TableBorders openXmlElement, DMW.Border? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.StartBorder>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.BorderConverter.CreateOpenXmlElement<DXW.StartBorder>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  /// <summary>
  /// Table Bottom Border.
  /// </summary>
  private static DMW.Border? GetBottomBorder(DXW.TableBorders openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXW.BottomBorder>();
    if (element != null)
      return DMXW.BorderConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpBottomBorder(DXW.TableBorders openXmlElement, DMW.Border? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXW.BorderConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.BottomBorder>(), value, diffs, objName, propName);
  }
  
  private static void SetBottomBorder(DXW.TableBorders openXmlElement, DMW.Border? value)
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
  /// Table Right Border.
  /// </summary>
  private static DMW.Border? GetRightBorder(DXW.TableBorders openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXW.RightBorder>();
    if (element != null)
      return DMXW.BorderConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpRightBorder(DXW.TableBorders openXmlElement, DMW.Border? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXW.BorderConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.RightBorder>(), value, diffs, objName, propName);
  }
  
  private static void SetRightBorder(DXW.TableBorders openXmlElement, DMW.Border? value)
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
  
  /// <summary>
  /// EndBorder, this property is only available in Office 2010 and later..
  /// </summary>
  private static DMW.Border? GetEndBorder(DXW.TableBorders openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXW.EndBorder>();
    if (element != null)
      return DMXW.BorderConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpEndBorder(DXW.TableBorders openXmlElement, DMW.Border? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXW.BorderConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.EndBorder>(), value, diffs, objName, propName);
  }
  
  private static void SetEndBorder(DXW.TableBorders openXmlElement, DMW.Border? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.EndBorder>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.BorderConverter.CreateOpenXmlElement<DXW.EndBorder>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  /// <summary>
  /// Table Inside Horizontal Edges Border.
  /// </summary>
  private static DMW.Border? GetInsideHorizontalBorder(DXW.TableBorders openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXW.InsideHorizontalBorder>();
    if (element != null)
      return DMXW.BorderConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpInsideHorizontalBorder(DXW.TableBorders openXmlElement, DMW.Border? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXW.BorderConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.InsideHorizontalBorder>(), value, diffs, objName, propName);
  }
  
  private static void SetInsideHorizontalBorder(DXW.TableBorders openXmlElement, DMW.Border? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.InsideHorizontalBorder>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.BorderConverter.CreateOpenXmlElement<DXW.InsideHorizontalBorder>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  /// <summary>
  /// Table Inside Vertical Edges Border.
  /// </summary>
  private static DMW.Border? GetInsideVerticalBorder(DXW.TableBorders openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXW.InsideVerticalBorder>();
    if (element != null)
      return DMXW.BorderConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpInsideVerticalBorder(DXW.TableBorders openXmlElement, DMW.Border? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXW.BorderConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.InsideVerticalBorder>(), value, diffs, objName, propName);
  }
  
  private static void SetInsideVerticalBorder(DXW.TableBorders openXmlElement, DMW.Border? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.InsideVerticalBorder>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.BorderConverter.CreateOpenXmlElement<DXW.InsideVerticalBorder>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  public static DMW.TableBorders? CreateModelElement(DXW.TableBorders? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMW.TableBorders();
      value.TopBorder = GetTopBorder(openXmlElement);
      value.LeftBorder = GetLeftBorder(openXmlElement);
      value.StartBorder = GetStartBorder(openXmlElement);
      value.BottomBorder = GetBottomBorder(openXmlElement);
      value.RightBorder = GetRightBorder(openXmlElement);
      value.EndBorder = GetEndBorder(openXmlElement);
      value.InsideHorizontalBorder = GetInsideHorizontalBorder(openXmlElement);
      value.InsideVerticalBorder = GetInsideVerticalBorder(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXW.TableBorders? openXmlElement, DMW.TableBorders? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpTopBorder(openXmlElement, value.TopBorder, diffs, objName, propName))
        ok = false;
      if (!CmpLeftBorder(openXmlElement, value.LeftBorder, diffs, objName, propName))
        ok = false;
      if (!CmpStartBorder(openXmlElement, value.StartBorder, diffs, objName, propName))
        ok = false;
      if (!CmpBottomBorder(openXmlElement, value.BottomBorder, diffs, objName, propName))
        ok = false;
      if (!CmpRightBorder(openXmlElement, value.RightBorder, diffs, objName, propName))
        ok = false;
      if (!CmpEndBorder(openXmlElement, value.EndBorder, diffs, objName, propName))
        ok = false;
      if (!CmpInsideHorizontalBorder(openXmlElement, value.InsideHorizontalBorder, diffs, objName, propName))
        ok = false;
      if (!CmpInsideVerticalBorder(openXmlElement, value.InsideVerticalBorder, diffs, objName, propName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMW.TableBorders value)
    where OpenXmlElementType: DXW.TableBorders, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXW.TableBorders openXmlElement, DMW.TableBorders value)
  {
    SetTopBorder(openXmlElement, value?.TopBorder);
    SetLeftBorder(openXmlElement, value?.LeftBorder);
    SetStartBorder(openXmlElement, value?.StartBorder);
    SetBottomBorder(openXmlElement, value?.BottomBorder);
    SetRightBorder(openXmlElement, value?.RightBorder);
    SetEndBorder(openXmlElement, value?.EndBorder);
    SetInsideHorizontalBorder(openXmlElement, value?.InsideHorizontalBorder);
    SetInsideVerticalBorder(openXmlElement, value?.InsideVerticalBorder);
  }
}
