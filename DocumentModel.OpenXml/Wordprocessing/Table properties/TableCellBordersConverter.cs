namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Defines the TableCellBorders Class.
/// </summary>
public static class TableCellBordersConverter
{
  /// <summary>
  /// Table Cell Top Border.
  /// </summary>
  private static DMW.Border? GetTopBorder(DXW.TableCellBorders openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXW.TopBorder>();
    if (element != null)
      return DMXW.BorderConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpTopBorder(DXW.TableCellBorders openXmlElement, DMW.Border? value, DiffList? diffs, string? objName)
  {
    return DMXW.BorderConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.TopBorder>(), value, diffs, objName);
  }
  
  private static void SetTopBorder(DXW.TableCellBorders openXmlElement, DMW.Border? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.TopBorder>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.BorderConverter.CreateOpenXmlElement<DXW.TopBorder>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Table Cell Left Border.
  /// </summary>
  private static DMW.Border? GetLeftBorder(DXW.TableCellBorders openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXW.LeftBorder>();
    if (element != null)
      return DMXW.BorderConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpLeftBorder(DXW.TableCellBorders openXmlElement, DMW.Border? value, DiffList? diffs, string? objName)
  {
    return DMXW.BorderConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.LeftBorder>(), value, diffs, objName);
  }
  
  private static void SetLeftBorder(DXW.TableCellBorders openXmlElement, DMW.Border? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.LeftBorder>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.BorderConverter.CreateOpenXmlElement<DXW.LeftBorder>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// StartBorder, this property is only available in Office 2010 and later..
  /// </summary>
  private static DMW.Border? GetStartBorder(DXW.TableCellBorders openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXW.StartBorder>();
    if (element != null)
      return DMXW.BorderConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpStartBorder(DXW.TableCellBorders openXmlElement, DMW.Border? value, DiffList? diffs, string? objName)
  {
    return DMXW.BorderConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.StartBorder>(), value, diffs, objName);
  }
  
  private static void SetStartBorder(DXW.TableCellBorders openXmlElement, DMW.Border? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.StartBorder>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.BorderConverter.CreateOpenXmlElement<DXW.StartBorder>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Table Cell Bottom Border.
  /// </summary>
  private static DMW.Border? GetBottomBorder(DXW.TableCellBorders openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXW.BottomBorder>();
    if (element != null)
      return DMXW.BorderConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpBottomBorder(DXW.TableCellBorders openXmlElement, DMW.Border? value, DiffList? diffs, string? objName)
  {
    return DMXW.BorderConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.BottomBorder>(), value, diffs, objName);
  }
  
  private static void SetBottomBorder(DXW.TableCellBorders openXmlElement, DMW.Border? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.BottomBorder>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.BorderConverter.CreateOpenXmlElement<DXW.BottomBorder>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Table Cell Right Border.
  /// </summary>
  private static DMW.Border? GetRightBorder(DXW.TableCellBorders openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXW.RightBorder>();
    if (element != null)
      return DMXW.BorderConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpRightBorder(DXW.TableCellBorders openXmlElement, DMW.Border? value, DiffList? diffs, string? objName)
  {
    return DMXW.BorderConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.RightBorder>(), value, diffs, objName);
  }
  
  private static void SetRightBorder(DXW.TableCellBorders openXmlElement, DMW.Border? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.RightBorder>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.BorderConverter.CreateOpenXmlElement<DXW.RightBorder>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// EndBorder, this property is only available in Office 2010 and later..
  /// </summary>
  private static DMW.Border? GetEndBorder(DXW.TableCellBorders openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXW.EndBorder>();
    if (element != null)
      return DMXW.BorderConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpEndBorder(DXW.TableCellBorders openXmlElement, DMW.Border? value, DiffList? diffs, string? objName)
  {
    return DMXW.BorderConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.EndBorder>(), value, diffs, objName);
  }
  
  private static void SetEndBorder(DXW.TableCellBorders openXmlElement, DMW.Border? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.EndBorder>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.BorderConverter.CreateOpenXmlElement<DXW.EndBorder>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Table Cell Inside Horizontal Edges Border.
  /// </summary>
  private static DMW.Border? GetInsideHorizontalBorder(DXW.TableCellBorders openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXW.InsideHorizontalBorder>();
    if (element != null)
      return DMXW.BorderConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpInsideHorizontalBorder(DXW.TableCellBorders openXmlElement, DMW.Border? value, DiffList? diffs, string? objName)
  {
    return DMXW.BorderConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.InsideHorizontalBorder>(), value, diffs, objName);
  }
  
  private static void SetInsideHorizontalBorder(DXW.TableCellBorders openXmlElement, DMW.Border? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.InsideHorizontalBorder>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.BorderConverter.CreateOpenXmlElement<DXW.InsideHorizontalBorder>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Table Cell Inside Vertical Edges Border.
  /// </summary>
  private static DMW.Border? GetInsideVerticalBorder(DXW.TableCellBorders openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXW.InsideVerticalBorder>();
    if (element != null)
      return DMXW.BorderConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpInsideVerticalBorder(DXW.TableCellBorders openXmlElement, DMW.Border? value, DiffList? diffs, string? objName)
  {
    return DMXW.BorderConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.InsideVerticalBorder>(), value, diffs, objName);
  }
  
  private static void SetInsideVerticalBorder(DXW.TableCellBorders openXmlElement, DMW.Border? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.InsideVerticalBorder>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.BorderConverter.CreateOpenXmlElement<DXW.InsideVerticalBorder>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Table Cell Top Left to Bottom Right Diagonal Border.
  /// </summary>
  private static DMW.Border? GetTopLeftToBottomRightCellBorder(DXW.TableCellBorders openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXW.TopLeftToBottomRightCellBorder>();
    if (element != null)
      return DMXW.BorderConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpTopLeftToBottomRightCellBorder(DXW.TableCellBorders openXmlElement, DMW.Border? value, DiffList? diffs, string? objName)
  {
    return DMXW.BorderConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.TopLeftToBottomRightCellBorder>(), value, diffs, objName);
  }
  
  private static void SetTopLeftToBottomRightCellBorder(DXW.TableCellBorders openXmlElement, DMW.Border? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.TopLeftToBottomRightCellBorder>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.BorderConverter.CreateOpenXmlElement<DXW.TopLeftToBottomRightCellBorder>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Table Cell Top Right to Bottom Left Diagonal Border.
  /// </summary>
  private static DMW.Border? GetTopRightToBottomLeftCellBorder(DXW.TableCellBorders openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXW.TopRightToBottomLeftCellBorder>();
    if (element != null)
      return DMXW.BorderConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpTopRightToBottomLeftCellBorder(DXW.TableCellBorders openXmlElement, DMW.Border? value, DiffList? diffs, string? objName)
  {
    return DMXW.BorderConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.TopRightToBottomLeftCellBorder>(), value, diffs, objName);
  }
  
  private static void SetTopRightToBottomLeftCellBorder(DXW.TableCellBorders openXmlElement, DMW.Border? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.TopRightToBottomLeftCellBorder>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.BorderConverter.CreateOpenXmlElement<DXW.TopRightToBottomLeftCellBorder>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DMW.TableCellBorders? CreateModelElement(DXW.TableCellBorders? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMW.TableCellBorders();
      value.TopBorder = GetTopBorder(openXmlElement);
      value.LeftBorder = GetLeftBorder(openXmlElement);
      value.StartBorder = GetStartBorder(openXmlElement);
      value.BottomBorder = GetBottomBorder(openXmlElement);
      value.RightBorder = GetRightBorder(openXmlElement);
      value.EndBorder = GetEndBorder(openXmlElement);
      value.InsideHorizontalBorder = GetInsideHorizontalBorder(openXmlElement);
      value.InsideVerticalBorder = GetInsideVerticalBorder(openXmlElement);
      value.TopLeftToBottomRightCellBorder = GetTopLeftToBottomRightCellBorder(openXmlElement);
      value.TopRightToBottomLeftCellBorder = GetTopRightToBottomLeftCellBorder(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXW.TableCellBorders? openXmlElement, DMW.TableCellBorders? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpTopBorder(openXmlElement, value.TopBorder, diffs, objName))
        ok = false;
      if (!CmpLeftBorder(openXmlElement, value.LeftBorder, diffs, objName))
        ok = false;
      if (!CmpStartBorder(openXmlElement, value.StartBorder, diffs, objName))
        ok = false;
      if (!CmpBottomBorder(openXmlElement, value.BottomBorder, diffs, objName))
        ok = false;
      if (!CmpRightBorder(openXmlElement, value.RightBorder, diffs, objName))
        ok = false;
      if (!CmpEndBorder(openXmlElement, value.EndBorder, diffs, objName))
        ok = false;
      if (!CmpInsideHorizontalBorder(openXmlElement, value.InsideHorizontalBorder, diffs, objName))
        ok = false;
      if (!CmpInsideVerticalBorder(openXmlElement, value.InsideVerticalBorder, diffs, objName))
        ok = false;
      if (!CmpTopLeftToBottomRightCellBorder(openXmlElement, value.TopLeftToBottomRightCellBorder, diffs, objName))
        ok = false;
      if (!CmpTopRightToBottomLeftCellBorder(openXmlElement, value.TopRightToBottomLeftCellBorder, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMW.TableCellBorders value)
    where OpenXmlElementType: DXW.TableCellBorders, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXW.TableCellBorders openXmlElement, DMW.TableCellBorders value)
  {
    SetTopBorder(openXmlElement, value?.TopBorder);
    SetLeftBorder(openXmlElement, value?.LeftBorder);
    SetStartBorder(openXmlElement, value?.StartBorder);
    SetBottomBorder(openXmlElement, value?.BottomBorder);
    SetRightBorder(openXmlElement, value?.RightBorder);
    SetEndBorder(openXmlElement, value?.EndBorder);
    SetInsideHorizontalBorder(openXmlElement, value?.InsideHorizontalBorder);
    SetInsideVerticalBorder(openXmlElement, value?.InsideVerticalBorder);
    SetTopLeftToBottomRightCellBorder(openXmlElement, value?.TopLeftToBottomRightCellBorder);
    SetTopRightToBottomLeftCellBorder(openXmlElement, value?.TopRightToBottomLeftCellBorder);
  }
}
