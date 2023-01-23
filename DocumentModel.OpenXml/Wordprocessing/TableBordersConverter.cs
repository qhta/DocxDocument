namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Defines the TableBorders Class.
/// </summary>
public static class TableBordersConverter
{
  /// <summary>
  /// Table Top Border.
  /// </summary>
  private static DMW.BorderType? GetTopBorder(DXW.TableBorders openXmlElement)
  {
    return DMXW.BorderTypeConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXW.TopBorder>());
  }
  
  private static bool CmpTopBorder(DXW.TableBorders openXmlElement, DMW.BorderType? value, DiffList? diffs, string? objName)
  {
    return DMXW.BorderTypeConverter.CompareModelElement(openXmlElement?.GetFirstChild<DXW.TopBorder>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetTopBorder(DXW.TableBorders openXmlElement, DMW.BorderType? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.TopBorder>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.BorderTypeConverter.CreateOpenXmlElement<DXW.TopBorder>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Table Left Border.
  /// </summary>
  private static DMW.BorderType? GetLeftBorder(DXW.TableBorders openXmlElement)
  {
    return DMXW.BorderTypeConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXW.LeftBorder>());
  }
  
  private static bool CmpLeftBorder(DXW.TableBorders openXmlElement, DMW.BorderType? value, DiffList? diffs, string? objName)
  {
    return DMXW.BorderTypeConverter.CompareModelElement(openXmlElement?.GetFirstChild<DXW.LeftBorder>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetLeftBorder(DXW.TableBorders openXmlElement, DMW.BorderType? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.LeftBorder>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.BorderTypeConverter.CreateOpenXmlElement<DXW.LeftBorder>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// StartBorder, this property is only available in Office 2010 and later..
  /// </summary>
  private static DMW.BorderType? GetStartBorder(DXW.TableBorders openXmlElement)
  {
    return DMXW.BorderTypeConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXW.StartBorder>());
  }
  
  private static bool CmpStartBorder(DXW.TableBorders openXmlElement, DMW.BorderType? value, DiffList? diffs, string? objName)
  {
    return DMXW.BorderTypeConverter.CompareModelElement(openXmlElement?.GetFirstChild<DXW.StartBorder>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetStartBorder(DXW.TableBorders openXmlElement, DMW.BorderType? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.StartBorder>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.BorderTypeConverter.CreateOpenXmlElement<DXW.StartBorder>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Table Bottom Border.
  /// </summary>
  private static DMW.BorderType? GetBottomBorder(DXW.TableBorders openXmlElement)
  {
    return DMXW.BorderTypeConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXW.BottomBorder>());
  }
  
  private static bool CmpBottomBorder(DXW.TableBorders openXmlElement, DMW.BorderType? value, DiffList? diffs, string? objName)
  {
    return DMXW.BorderTypeConverter.CompareModelElement(openXmlElement?.GetFirstChild<DXW.BottomBorder>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetBottomBorder(DXW.TableBorders openXmlElement, DMW.BorderType? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.BottomBorder>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.BorderTypeConverter.CreateOpenXmlElement<DXW.BottomBorder>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Table Right Border.
  /// </summary>
  private static DMW.BorderType? GetRightBorder(DXW.TableBorders openXmlElement)
  {
    return DMXW.BorderTypeConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXW.RightBorder>());
  }
  
  private static bool CmpRightBorder(DXW.TableBorders openXmlElement, DMW.BorderType? value, DiffList? diffs, string? objName)
  {
    return DMXW.BorderTypeConverter.CompareModelElement(openXmlElement?.GetFirstChild<DXW.RightBorder>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetRightBorder(DXW.TableBorders openXmlElement, DMW.BorderType? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.RightBorder>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.BorderTypeConverter.CreateOpenXmlElement<DXW.RightBorder>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// EndBorder, this property is only available in Office 2010 and later..
  /// </summary>
  private static DMW.BorderType? GetEndBorder(DXW.TableBorders openXmlElement)
  {
    return DMXW.BorderTypeConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXW.EndBorder>());
  }
  
  private static bool CmpEndBorder(DXW.TableBorders openXmlElement, DMW.BorderType? value, DiffList? diffs, string? objName)
  {
    return DMXW.BorderTypeConverter.CompareModelElement(openXmlElement?.GetFirstChild<DXW.EndBorder>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetEndBorder(DXW.TableBorders openXmlElement, DMW.BorderType? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.EndBorder>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.BorderTypeConverter.CreateOpenXmlElement<DXW.EndBorder>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Table Inside Horizontal Edges Border.
  /// </summary>
  private static DMW.BorderType? GetInsideHorizontalBorder(DXW.TableBorders openXmlElement)
  {
    return DMXW.BorderTypeConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXW.InsideHorizontalBorder>());
  }
  
  private static bool CmpInsideHorizontalBorder(DXW.TableBorders openXmlElement, DMW.BorderType? value, DiffList? diffs, string? objName)
  {
    return DMXW.BorderTypeConverter.CompareModelElement(openXmlElement?.GetFirstChild<DXW.InsideHorizontalBorder>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetInsideHorizontalBorder(DXW.TableBorders openXmlElement, DMW.BorderType? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.InsideHorizontalBorder>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.BorderTypeConverter.CreateOpenXmlElement<DXW.InsideHorizontalBorder>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Table Inside Vertical Edges Border.
  /// </summary>
  private static DMW.BorderType? GetInsideVerticalBorder(DXW.TableBorders openXmlElement)
  {
    return DMXW.BorderTypeConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXW.InsideVerticalBorder>());
  }
  
  private static bool CmpInsideVerticalBorder(DXW.TableBorders openXmlElement, DMW.BorderType? value, DiffList? diffs, string? objName)
  {
    return DMXW.BorderTypeConverter.CompareModelElement(openXmlElement?.GetFirstChild<DXW.InsideVerticalBorder>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetInsideVerticalBorder(DXW.TableBorders openXmlElement, DMW.BorderType? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.InsideVerticalBorder>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.BorderTypeConverter.CreateOpenXmlElement<DXW.InsideVerticalBorder>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
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
  
  public static bool CompareModelElement(DXW.TableBorders? openXmlElement, DMW.TableBorders? value, DiffList? diffs, string? objName)
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
      return ok;
    }
    return openXmlElement == null && value == null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMW.TableBorders? value)
    where OpenXmlElementType: DXW.TableBorders, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetTopBorder(openXmlElement, value?.TopBorder);
      SetLeftBorder(openXmlElement, value?.LeftBorder);
      SetStartBorder(openXmlElement, value?.StartBorder);
      SetBottomBorder(openXmlElement, value?.BottomBorder);
      SetRightBorder(openXmlElement, value?.RightBorder);
      SetEndBorder(openXmlElement, value?.EndBorder);
      SetInsideHorizontalBorder(openXmlElement, value?.InsideHorizontalBorder);
      SetInsideVerticalBorder(openXmlElement, value?.InsideVerticalBorder);
      return openXmlElement;
    }
    return default;
  }
}
