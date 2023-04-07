namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Defines the TableCellMargin Class.
/// </summary>
public static class TableCellMarginConverter
{
  #region Table Cell Top Margin Exception conversion.
  private static DMW.TableWidth? GetTopMargin(DXW.TableCellMargin openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXW.TopMargin>();
    if (element != null)
      return DMXW.TableWidthTypeConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpTopMargin(DXW.TableCellMargin openXmlElement, DMW.TableWidth? value, DiffList? diffs, string? objName)
  {
    return DMXW.TableWidthTypeConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.TopMargin>(), value, diffs, objName);
  }
  
  private static void SetTopMargin(DXW.TableCellMargin openXmlElement, DMW.TableWidth? value)
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
  #endregion

  #region Table Cell Left Margin Exception conversion.
  private static DMW.TableWidth? GetLeftMargin(DXW.TableCellMargin openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXW.LeftMargin>();
    if (element != null)
      return DMXW.TableWidthTypeConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpLeftMargin(DXW.TableCellMargin openXmlElement, DMW.TableWidth? value, DiffList? diffs, string? objName)
  {
    return DMXW.TableWidthTypeConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.LeftMargin>(), value, diffs, objName);
  }
  
  private static void SetLeftMargin(DXW.TableCellMargin openXmlElement, DMW.TableWidth? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.LeftMargin>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.TableWidthTypeConverter.CreateOpenXmlElement<DXW.LeftMargin>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// StartMargin, this property is only available in Office 2010 and later..
  private static DMW.TableWidth? GetStartMargin(DXW.TableCellMargin openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXW.StartMargin>();
    if (element != null)
      return DMXW.TableWidthTypeConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpStartMargin(DXW.TableCellMargin openXmlElement, DMW.TableWidth? value, DiffList? diffs, string? objName)
  {
    return DMXW.TableWidthTypeConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.StartMargin>(), value, diffs, objName);
  }
  
  private static void SetStartMargin(DXW.TableCellMargin openXmlElement, DMW.TableWidth? value)
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
  #endregion

  #region Table Cell Bottom Margin Exception conversion.
  private static DMW.TableWidth? GetBottomMargin(DXW.TableCellMargin openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXW.BottomMargin>();
    if (element != null)
      return DMXW.TableWidthTypeConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpBottomMargin(DXW.TableCellMargin openXmlElement, DMW.TableWidth? value, DiffList? diffs, string? objName)
  {
    return DMXW.TableWidthTypeConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.BottomMargin>(), value, diffs, objName);
  }
  
  private static void SetBottomMargin(DXW.TableCellMargin openXmlElement, DMW.TableWidth? value)
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
  #endregion

  #region Table Cell Right Margin Exception conversion.
  private static DMW.TableWidth? GetRightMargin(DXW.TableCellMargin openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXW.RightMargin>();
    if (element != null)
      return DMXW.TableWidthTypeConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpRightMargin(DXW.TableCellMargin openXmlElement, DMW.TableWidth? value, DiffList? diffs, string? objName)
  {
    return DMXW.TableWidthTypeConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.RightMargin>(), value, diffs, objName);
  }
  
  private static void SetRightMargin(DXW.TableCellMargin openXmlElement, DMW.TableWidth? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.RightMargin>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.TableWidthTypeConverter.CreateOpenXmlElement<DXW.RightMargin>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// EndMargin, this property is only available in Office 2010 and later..
  private static DMW.TableWidth? GetEndMargin(DXW.TableCellMargin openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXW.EndMargin>();
    if (element != null)
      return DMXW.TableWidthTypeConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpEndMargin(DXW.TableCellMargin openXmlElement, DMW.TableWidth? value, DiffList? diffs, string? objName)
  {
    return DMXW.TableWidthTypeConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.EndMargin>(), value, diffs, objName);
  }
  
  private static void SetEndMargin(DXW.TableCellMargin openXmlElement, DMW.TableWidth? value)
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
  
  public static DMW.TableCellMargin? CreateModelElement(DXW.TableCellMargin? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMW.TableCellMargin();
      value.TopMargin = GetTopMargin(openXmlElement);
      value.LeftMargin = GetLeftMargin(openXmlElement);
      value.StartMargin = GetStartMargin(openXmlElement);
      value.BottomMargin = GetBottomMargin(openXmlElement);
      value.RightMargin = GetRightMargin(openXmlElement);
      value.EndMargin = GetEndMargin(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXW.TableCellMargin? openXmlElement, DMW.TableCellMargin? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpTopMargin(openXmlElement, value.TopMargin, diffs, objName))
        ok = false;
      if (!CmpLeftMargin(openXmlElement, value.LeftMargin, diffs, objName))
        ok = false;
      if (!CmpStartMargin(openXmlElement, value.StartMargin, diffs, objName))
        ok = false;
      if (!CmpBottomMargin(openXmlElement, value.BottomMargin, diffs, objName))
        ok = false;
      if (!CmpRightMargin(openXmlElement, value.RightMargin, diffs, objName))
        ok = false;
      if (!CmpEndMargin(openXmlElement, value.EndMargin, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMW.TableCellMargin value)
    where OpenXmlElementType: DXW.TableCellMargin, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXW.TableCellMargin openXmlElement, DMW.TableCellMargin value)
  {
    SetTopMargin(openXmlElement, value?.TopMargin);
    SetLeftMargin(openXmlElement, value?.LeftMargin);
    SetStartMargin(openXmlElement, value?.StartMargin);
    SetBottomMargin(openXmlElement, value?.BottomMargin);
    SetRightMargin(openXmlElement, value?.RightMargin);
    SetEndMargin(openXmlElement, value?.EndMargin);
  }
  #endregion
}
