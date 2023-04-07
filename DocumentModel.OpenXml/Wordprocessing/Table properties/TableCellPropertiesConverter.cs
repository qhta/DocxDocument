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
  
  private static bool CmpTableCellPropertiesChange(DXW.TableCellProperties openXmlElement, DMW.TableCellPropertiesChange? value, DiffList? diffs, string? objName)
  {
    return DMXW.TableCellPropertiesChangeConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.TableCellPropertiesChange>(), value, diffs, objName);
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
        openXmlElement.AddChild(itemElement);
    }
  }
  #endregion

  #region TableCellProperties model conversion.
  public static DMW.TableCellProperties? CreateModelElement(DXW.TableCellProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMW.TableCellProperties();
      BaseTableCellPropertiesConverter.UpdateModelElement(value, openXmlElement);
      value.TableCellPropertiesChange = GetTableCellPropertiesChange(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXW.TableCellProperties? openXmlElement, DMW.TableCellProperties? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (! BaseTableCellPropertiesConverter.CompareModelElement(openXmlElement, value, diffs, objName))
        ok = false;
      if (!CmpTableCellPropertiesChange(openXmlElement, value.TableCellPropertiesChange, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMW.TableCellProperties value)
    where OpenXmlElementType: DXW.TableCellProperties, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXW.TableCellProperties openXmlElement, DMW.TableCellProperties value)
  {
    BaseTableCellPropertiesConverter.UpdateOpenXmlElement(openXmlElement, value);
    SetTableCellPropertiesChange(openXmlElement, value?.TableCellPropertiesChange);
  }
  #endregion
}
