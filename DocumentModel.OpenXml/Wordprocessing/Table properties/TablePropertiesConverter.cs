using DocumentModel.Wordprocessing;

namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// <see cref="DocumentModel.Wordprocessing.TableProperties"/> class from/to OpenXml converter.
/// </summary>
public static class TablePropertiesConverter
{
  #region Revision Information for Table Properties conversion.
  private static DMW.TablePropertiesChange? GetTablePropertiesChange(DXW.TableProperties openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXW.TablePropertiesChange>();
    if (element != null)
      return DMXW.TablePropertiesChangeConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpTablePropertiesChange(DXW.TableProperties openXmlElement, DMW.TablePropertiesChange? value, DiffList? diffs, string? objName)
  {
    return DMXW.TablePropertiesChangeConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.TablePropertiesChange>(), value, diffs, objName);
  }
  
  private static void SetTablePropertiesChange(DXW.TableProperties openXmlElement, DMW.TablePropertiesChange? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.TablePropertiesChange>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.TablePropertiesChangeConverter.CreateOpenXmlElement<DXW.TablePropertiesChange>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DMW.TableProperties? CreateModelElement(DXW.TableProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMW.TableProperties();
      ExtBaseTablePropertiesConverter.UpdateModelElement(value, openXmlElement);
      value.TablePropertiesChange = GetTablePropertiesChange(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXW.TableProperties? openXmlElement, DMW.TableProperties? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!ExtBaseTablePropertiesConverter.CompareModelElement(openXmlElement, value, diffs, objName))
        ok = false;
      if (!CmpTablePropertiesChange(openXmlElement, value.TablePropertiesChange, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMW.TableProperties value)
    where OpenXmlElementType: DXW.TableProperties, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXW.TableProperties openXmlElement, DMW.TableProperties value)
  {
    ExtBaseTablePropertiesConverter.UpdateOpenXmlElement(openXmlElement, value);
    SetTablePropertiesChange(openXmlElement, value?.TablePropertiesChange);
  }
  #endregion
}
