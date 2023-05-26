namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// <see cref="DocumentModel.Wordprocessing.PreviousTableCellProperties"/> class from/to OpenXml converter.
/// </summary>
public static class TableCellPropertiesConverter
{
  #region TableCellPropertiesChange conversion.
  private static DMW.TableCellPropertiesChange? GetTableCellPropertiesChange(DXW.TableCellProperties openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXW.TableCellPropertiesChange>();
    if (element != null)
      return DMXW.TableCellPropertiesChangeConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpTableCellPropertiesChange(DXW.TableCellProperties openXmlElement, DMW.TableCellPropertiesChange? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXW.TableCellPropertiesChangeConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.TableCellPropertiesChange>(), value, diffs, objName, propName);
  }
  
  private static void SetTableCellPropertiesChange(DXW.TableCellProperties openXmlElement, DMW.TableCellPropertiesChange? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.TableCellPropertiesChange>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.TableCellPropertiesChangeConverter.CreateOpenXmlElement<DXW.TableCellPropertiesChange>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  #endregion

  #region TableCellProperties model conversion.
  public static DMW.TableCellProperties? CreateModelElement(DXW.TableCellProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var model = new DMW.TableCellProperties();
      CurrentTableCellPropertiesConverter.UpdateModelElement(model, openXmlElement);
      model.TableCellPropertiesChange = GetTableCellPropertiesChange(openXmlElement);
      return model;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXW.TableCellProperties? openXmlElement, DMW.TableCellProperties? model, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement != null && model != null)
    {
      var ok = true;
      if (! CurrentTableCellPropertiesConverter.CompareModelElement(openXmlElement, model, diffs, objName, propName))
        ok = false;
      if (!CmpTableCellPropertiesChange(openXmlElement, model.TableCellPropertiesChange, diffs, objName, propName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && model == null) return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement, model);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMW.TableCellProperties model)
    where OpenXmlElementType: DXW.TableCellProperties, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, model);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXW.TableCellProperties openXmlElement, DMW.TableCellProperties model)
  {
    CurrentTableCellPropertiesConverter.UpdateOpenXmlElement(openXmlElement, model);
    SetTableCellPropertiesChange(openXmlElement, model?.TableCellPropertiesChange);
  }
  #endregion
}
