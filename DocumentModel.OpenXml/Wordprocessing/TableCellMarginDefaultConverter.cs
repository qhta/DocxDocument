namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Defines the TableCellMarginDefault Class.
/// </summary>
public static class TableCellMarginDefaultConverter
{
  /// <summary>
  /// Table Cell Top Margin Default.
  /// </summary>
  private static DMW.TableWidthType? GetTopMargin(DXW.TableCellMarginDefault openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXW.TopMargin>();
    if (element != null)
      return DMXW.TableWidthTypeConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpTopMargin(DXW.TableCellMarginDefault openXmlElement, DMW.TableWidthType? value, DiffList? diffs, string? objName)
  {
    return DMXW.TableWidthTypeConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.TopMargin>(), value, diffs, objName);
  }
  
  private static void SetTopMargin(DXW.TableCellMarginDefault openXmlElement, DMW.TableWidthType? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.TopMargin>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.TableWidthTypeConverter.CreateOpenXmlElement<DXW.TopMargin>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Table Cell Left Margin Default.
  /// </summary>
  private static DMW.TableWidthDxaNilType? GetTableCellLeftMargin(DXW.TableCellMarginDefault openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXW.TableCellLeftMargin>();
    if (element != null)
      return DMXW.TableWidthDxaNilTypeConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpTableCellLeftMargin(DXW.TableCellMarginDefault openXmlElement, DMW.TableWidthDxaNilType? value, DiffList? diffs, string? objName)
  {
    return DMXW.TableWidthDxaNilTypeConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.TableCellLeftMargin>(), value, diffs, objName);
  }
  
  private static void SetTableCellLeftMargin(DXW.TableCellMarginDefault openXmlElement, DMW.TableWidthDxaNilType? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.TableCellLeftMargin>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.TableWidthDxaNilTypeConverter.CreateOpenXmlElement<DXW.TableCellLeftMargin>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// StartMargin, this property is only available in Office 2010 and later..
  /// </summary>
  private static DMW.TableWidthType? GetStartMargin(DXW.TableCellMarginDefault openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXW.StartMargin>();
    if (element != null)
      return DMXW.TableWidthTypeConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpStartMargin(DXW.TableCellMarginDefault openXmlElement, DMW.TableWidthType? value, DiffList? diffs, string? objName)
  {
    return DMXW.TableWidthTypeConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.StartMargin>(), value, diffs, objName);
  }
  
  private static void SetStartMargin(DXW.TableCellMarginDefault openXmlElement, DMW.TableWidthType? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.StartMargin>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.TableWidthTypeConverter.CreateOpenXmlElement<DXW.StartMargin>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Table Cell Bottom Margin Default.
  /// </summary>
  private static DMW.TableWidthType? GetBottomMargin(DXW.TableCellMarginDefault openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXW.BottomMargin>();
    if (element != null)
      return DMXW.TableWidthTypeConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpBottomMargin(DXW.TableCellMarginDefault openXmlElement, DMW.TableWidthType? value, DiffList? diffs, string? objName)
  {
    return DMXW.TableWidthTypeConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.BottomMargin>(), value, diffs, objName);
  }
  
  private static void SetBottomMargin(DXW.TableCellMarginDefault openXmlElement, DMW.TableWidthType? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.BottomMargin>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.TableWidthTypeConverter.CreateOpenXmlElement<DXW.BottomMargin>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Table Cell Right Margin Default.
  /// </summary>
  private static DMW.TableWidthDxaNilType? GetTableCellRightMargin(DXW.TableCellMarginDefault openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXW.TableCellRightMargin>();
    if (element != null)
      return DMXW.TableWidthDxaNilTypeConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpTableCellRightMargin(DXW.TableCellMarginDefault openXmlElement, DMW.TableWidthDxaNilType? value, DiffList? diffs, string? objName)
  {
    return DMXW.TableWidthDxaNilTypeConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.TableCellRightMargin>(), value, diffs, objName);
  }
  
  private static void SetTableCellRightMargin(DXW.TableCellMarginDefault openXmlElement, DMW.TableWidthDxaNilType? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.TableCellRightMargin>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.TableWidthDxaNilTypeConverter.CreateOpenXmlElement<DXW.TableCellRightMargin>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// EndMargin, this property is only available in Office 2010 and later..
  /// </summary>
  private static DMW.TableWidthType? GetEndMargin(DXW.TableCellMarginDefault openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXW.EndMargin>();
    if (element != null)
      return DMXW.TableWidthTypeConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpEndMargin(DXW.TableCellMarginDefault openXmlElement, DMW.TableWidthType? value, DiffList? diffs, string? objName)
  {
    return DMXW.TableWidthTypeConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.EndMargin>(), value, diffs, objName);
  }
  
  private static void SetEndMargin(DXW.TableCellMarginDefault openXmlElement, DMW.TableWidthType? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.EndMargin>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.TableWidthTypeConverter.CreateOpenXmlElement<DXW.EndMargin>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DMW.TableCellMarginDefault? CreateModelElement(DXW.TableCellMarginDefault? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMW.TableCellMarginDefault();
      value.TopMargin = GetTopMargin(openXmlElement);
      value.TableCellLeftMargin = GetTableCellLeftMargin(openXmlElement);
      value.StartMargin = GetStartMargin(openXmlElement);
      value.BottomMargin = GetBottomMargin(openXmlElement);
      value.TableCellRightMargin = GetTableCellRightMargin(openXmlElement);
      value.EndMargin = GetEndMargin(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXW.TableCellMarginDefault? openXmlElement, DMW.TableCellMarginDefault? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpTopMargin(openXmlElement, value.TopMargin, diffs, objName))
        ok = false;
      if (!CmpTableCellLeftMargin(openXmlElement, value.TableCellLeftMargin, diffs, objName))
        ok = false;
      if (!CmpStartMargin(openXmlElement, value.StartMargin, diffs, objName))
        ok = false;
      if (!CmpBottomMargin(openXmlElement, value.BottomMargin, diffs, objName))
        ok = false;
      if (!CmpTableCellRightMargin(openXmlElement, value.TableCellRightMargin, diffs, objName))
        ok = false;
      if (!CmpEndMargin(openXmlElement, value.EndMargin, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMW.TableCellMarginDefault value)
    where OpenXmlElementType: DXW.TableCellMarginDefault, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXW.TableCellMarginDefault openXmlElement, DMW.TableCellMarginDefault value)
  {
    SetTopMargin(openXmlElement, value?.TopMargin);
    SetTableCellLeftMargin(openXmlElement, value?.TableCellLeftMargin);
    SetStartMargin(openXmlElement, value?.StartMargin);
    SetBottomMargin(openXmlElement, value?.BottomMargin);
    SetTableCellRightMargin(openXmlElement, value?.TableCellRightMargin);
    SetEndMargin(openXmlElement, value?.EndMargin);
  }
}
