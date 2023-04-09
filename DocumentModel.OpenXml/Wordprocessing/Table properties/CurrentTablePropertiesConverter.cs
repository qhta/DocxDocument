using DocumentModel.Wordprocessing;

namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// <see cref="DocumentModel.Wordprocessing.CurrentTableProperties"/> class from/to OpenXml converter.
/// </summary>
public static class CurrentTablePropertiesConverter
{
  #region TableWidth conversion.
  public static DMW.TableWidth? GetTableWidth(DX.OpenXmlCompositeElement openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXW.TableWidth>();
    if (element != null)
      return DMXW.TableWidthTypeConverter.CreateModelElement(element);
    return null;
  }

  public static bool CmpTableWidth(DX.OpenXmlCompositeElement openXmlElement, DMW.TableWidth? value, DiffList? diffs, string? objName)
  {
    return DMXW.TableWidthTypeConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.TableWidth>(), value, diffs, objName);
  }

  public static void SetTableWidth(DX.OpenXmlCompositeElement openXmlElement, DMW.TableWidth? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.TableWidth>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.TableWidthTypeConverter.CreateOpenXmlElement<DXW.TableWidth>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  #endregion

  #region TableLayout conversion.
  public static DMW.TableLayoutKind? GetTableLayout(DX.OpenXmlCompositeElement openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXW.TableLayout>();
    if (element != null)
      return DMXW.TableLayoutConverter.CreateModelElement(element);
    return null;
  }

  public static bool CmpTableLayout(DX.OpenXmlCompositeElement openXmlElement, DMW.TableLayoutKind? value, DiffList? diffs, string? objName)
  {
    return DMXW.TableLayoutConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.TableLayout>(), value, diffs, objName);
  }

  public static void SetTableLayout(DX.OpenXmlCompositeElement openXmlElement, DMW.TableLayoutKind? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.TableLayout>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.TableLayoutConverter.CreateOpenXmlElement<DXW.TableLayout>((DMW.TableLayoutKind)value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  #endregion

  #region TableLook conversion.
  public static DMW.TableLookFlags? GetTableLook(DX.OpenXmlCompositeElement openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXW.TableLook>();
    if (element != null)
      return DMXW.TableLookConverter.CreateModelElement(element);
    return null;
  }

  public static bool CmpTableLook(DX.OpenXmlCompositeElement openXmlElement, DMW.TableLookFlags? value, DiffList? diffs, string? objName)
  {
    return DMXW.TableLookConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.TableLook>(), value, diffs, objName);
  }

  public static void SetTableLook(DX.OpenXmlCompositeElement openXmlElement, DMW.TableLookFlags? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.TableLook>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.TableLookConverter.CreateOpenXmlElement<DXW.TableLook>((DMW.TableLookFlags)value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  #endregion

  #region CurrentTableProperties model conversion.
  public static void UpdateModelElement(DMW.CurrentTableProperties model, DX.OpenXmlCompositeElement openXmlElement)
  {
    BaseTablePropertiesConverter.UpdateModelElement(model, openXmlElement);
    model.TableWidth = GetTableWidth(openXmlElement);
    model.TableLayout = GetTableLayout(openXmlElement);
    model.TableLook = GetTableLook(openXmlElement);
  }

  public static bool CompareModelElement(DX.OpenXmlCompositeElement? openXmlElement, DMW.CurrentTableProperties? model, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && model != null)
    {
      var ok = true;
      if (!BaseTablePropertiesConverter.CompareModelElement(openXmlElement, model, diffs, objName))
         ok = false;
      if (!CmpTableWidth(openXmlElement, model.TableWidth, diffs, objName))
        ok = false;
      if (!CmpTableLayout(openXmlElement, model.TableLayout, diffs, objName))
        ok = false;
      if (!CmpTableLook(openXmlElement, model.TableLook, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && model == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, model);
    return false;
  }

  public static void UpdateOpenXmlElement(DX.OpenXmlCompositeElement openXmlElement, DMW.CurrentTableProperties model)
  {
    BaseTablePropertiesConverter.UpdateOpenXmlElement(openXmlElement, model);
    SetTableWidth(openXmlElement, model?.TableWidth);
    SetTableLayout(openXmlElement, model?.TableLayout);
    SetTableLook(openXmlElement, model?.TableLook);
  }
  #endregion
}
