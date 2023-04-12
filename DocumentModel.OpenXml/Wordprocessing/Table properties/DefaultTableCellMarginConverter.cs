namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// <see cref="DocumentModel.Wordprocessing.DefaultTableCellMargin"/> class from/to OpenXml converter.
/// </summary>
public static class DefaultTableCellMarginConverter
{
  #region TopMargin conversion.
  private static DMW.TableWidth? GetTopMargin(DXW.TableCellMarginDefault openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXW.TopMargin>();
    if (element != null)
      return DMXW.TableWidthTypeConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpTopMargin(DXW.TableCellMarginDefault openXmlElement, DMW.TableWidth? value, DiffList? diffs, string? objName)
  {
    return DMXW.TableWidthTypeConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.TopMargin>(), value, diffs, objName);
  }
  
  private static void SetTopMargin(DXW.TableCellMarginDefault openXmlElement, DMW.TableWidth? value)
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

  #region LeftMargin conversion.
  private static DMW.TableWidth? GetTableCellLeftMargin(DXW.TableCellMarginDefault openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXW.TableCellLeftMargin>();
    if (element != null)
      return DMXW.TableWidthDxaNilTypeConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpTableCellLeftMargin(DXW.TableCellMarginDefault openXmlElement, DMW.TableWidth? value, DiffList? diffs, string? objName)
  {
    return DMXW.TableWidthDxaNilTypeConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.TableCellLeftMargin>(), value, diffs, objName);
  }
  
  private static void SetTableCellLeftMargin(DXW.TableCellMarginDefault openXmlElement, DMW.TableWidth? value)
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
  #endregion

  #region StartMargin conversion.
  private static DMW.TableWidth? GetStartMargin(DXW.TableCellMarginDefault openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXW.StartMargin>();
    if (element != null)
      return DMXW.TableWidthTypeConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpStartMargin(DXW.TableCellMarginDefault openXmlElement, DMW.TableWidth? value, DiffList? diffs, string? objName)
  {
    return DMXW.TableWidthTypeConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.StartMargin>(), value, diffs, objName);
  }
  
  private static void SetStartMargin(DXW.TableCellMarginDefault openXmlElement, DMW.TableWidth? value)
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

  #region BottomMargin conversion.
  private static DMW.TableWidth? GetBottomMargin(DXW.TableCellMarginDefault openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXW.BottomMargin>();
    if (element != null)
      return DMXW.TableWidthTypeConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpBottomMargin(DXW.TableCellMarginDefault openXmlElement, DMW.TableWidth? value, DiffList? diffs, string? objName)
  {
    return DMXW.TableWidthTypeConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.BottomMargin>(), value, diffs, objName);
  }
  
  private static void SetBottomMargin(DXW.TableCellMarginDefault openXmlElement, DMW.TableWidth? value)
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

  #region RightMargin conversion.
  private static DMW.TableWidth? GetTableCellRightMargin(DXW.TableCellMarginDefault openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXW.TableCellRightMargin>();
    if (element != null)
      return DMXW.TableWidthDxaNilTypeConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpTableCellRightMargin(DXW.TableCellMarginDefault openXmlElement, DMW.TableWidth? value, DiffList? diffs, string? objName)
  {
    return DMXW.TableWidthDxaNilTypeConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.TableCellRightMargin>(), value, diffs, objName);
  }
  
  private static void SetTableCellRightMargin(DXW.TableCellMarginDefault openXmlElement, DMW.TableWidth? value)
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
  #endregion

  #region EndMargin conversion.
  private static DMW.TableWidth? GetEndMargin(DXW.TableCellMarginDefault openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXW.EndMargin>();
    if (element != null)
      return DMXW.TableWidthTypeConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpEndMargin(DXW.TableCellMarginDefault openXmlElement, DMW.TableWidth? value, DiffList? diffs, string? objName)
  {
    return DMXW.TableWidthTypeConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.EndMargin>(), value, diffs, objName);
  }
  
  private static void SetEndMargin(DXW.TableCellMarginDefault openXmlElement, DMW.TableWidth? value)
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
  #endregion

  #region DefaultTableCellMargin model conversion.
  public static DMW.DefaultTableCellMargin? CreateModelElement(DXW.TableCellMarginDefault? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var model = new DMW.DefaultTableCellMargin();
      model.TopMargin = GetTopMargin(openXmlElement);
      model.LeftMargin = GetTableCellLeftMargin(openXmlElement);
      model.StartMargin = GetStartMargin(openXmlElement);
      model.BottomMargin = GetBottomMargin(openXmlElement);
      model.RightMargin = GetTableCellRightMargin(openXmlElement);
      model.EndMargin = GetEndMargin(openXmlElement);
      return model;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXW.TableCellMarginDefault? openXmlElement, DMW.DefaultTableCellMargin? model, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && model != null)
    {
      var ok = true;
      if (!CmpTopMargin(openXmlElement, model.TopMargin, diffs, objName))
        ok = false;
      if (!CmpTableCellLeftMargin(openXmlElement, model.LeftMargin, diffs, objName))
        ok = false;
      if (!CmpStartMargin(openXmlElement, model.StartMargin, diffs, objName))
        ok = false;
      if (!CmpBottomMargin(openXmlElement, model.BottomMargin, diffs, objName))
        ok = false;
      if (!CmpTableCellRightMargin(openXmlElement, model.RightMargin, diffs, objName))
        ok = false;
      if (!CmpEndMargin(openXmlElement, model.EndMargin, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && model == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, model);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMW.DefaultTableCellMargin model)
    where OpenXmlElementType: DXW.TableCellMarginDefault, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, model);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXW.TableCellMarginDefault openXmlElement, DMW.DefaultTableCellMargin model)
  {
    SetTopMargin(openXmlElement, model?.TopMargin);
    SetTableCellLeftMargin(openXmlElement, model?.LeftMargin);
    SetStartMargin(openXmlElement, model?.StartMargin);
    SetBottomMargin(openXmlElement, model?.BottomMargin);
    SetTableCellRightMargin(openXmlElement, model?.RightMargin);
    SetEndMargin(openXmlElement, model?.EndMargin);
  }
  #endregion
}
