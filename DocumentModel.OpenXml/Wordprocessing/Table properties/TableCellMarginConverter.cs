namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// <see cref="DocumentModel.Wordprocessing.TableCellMargin"/> class from/to OpenXml converter.
/// </summary>
public static class TableCellMarginConverter
{
  #region TableTopMargin conversion.
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
        openXmlElement.AppendChild(itemElement);
    }
  }
  #endregion

  #region TableLeftMargin conversion.
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
        openXmlElement.AppendChild(itemElement);
    }
  }
  #endregion

  #region StartMargin conversion.
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
        openXmlElement.AppendChild(itemElement);
    }
  }
  #endregion

  #region TableBottomMargin conversion.
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
        openXmlElement.AppendChild(itemElement);
    }
  }
  #endregion

  #region TableRightMargin conversion.
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
        openXmlElement.AppendChild(itemElement);
    }
  }
  #endregion

  #region TableEndMargin conversion.
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
        openXmlElement.AppendChild(itemElement);
    }
  }
  #endregion

  #region TableCellMargin model conversion.
  public static DMW.TableCellMargin? CreateModelElement(DXW.TableCellMargin? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var model = new DMW.TableCellMargin();
      model.TopMargin = GetTopMargin(openXmlElement);
      model.LeftMargin = GetLeftMargin(openXmlElement);
      model.StartMargin = GetStartMargin(openXmlElement);
      model.BottomMargin = GetBottomMargin(openXmlElement);
      model.RightMargin = GetRightMargin(openXmlElement);
      model.EndMargin = GetEndMargin(openXmlElement);
      return model;
    }
    return null;
  }

  public static bool CompareModelElement(DXW.TableCellMargin? openXmlElement, DMW.TableCellMargin? model, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && model != null)
    {
      var ok = true;
      if (!CmpTopMargin(openXmlElement, model.TopMargin, diffs, objName))
        ok = false;
      if (!CmpLeftMargin(openXmlElement, model.LeftMargin, diffs, objName))
        ok = false;
      if (!CmpStartMargin(openXmlElement, model.StartMargin, diffs, objName))
        ok = false;
      if (!CmpBottomMargin(openXmlElement, model.BottomMargin, diffs, objName))
        ok = false;
      if (!CmpRightMargin(openXmlElement, model.RightMargin, diffs, objName))
        ok = false;
      if (!CmpEndMargin(openXmlElement, model.EndMargin, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && model == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, model);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMW.TableCellMargin model)
    where OpenXmlElementType: DXW.TableCellMargin, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, model);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXW.TableCellMargin openXmlElement, DMW.TableCellMargin model)
  {
    SetTopMargin(openXmlElement, model?.TopMargin);
    SetLeftMargin(openXmlElement, model?.LeftMargin);
    SetStartMargin(openXmlElement, model?.StartMargin);
    SetBottomMargin(openXmlElement, model?.BottomMargin);
    SetRightMargin(openXmlElement, model?.RightMargin);
    SetEndMargin(openXmlElement, model?.EndMargin);
  }
  #endregion
}
