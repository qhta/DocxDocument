namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Revision Information for Table Cell Properties.
/// </summary>
public static class TableCellPropertiesChangeConverter
{
  /// <summary>
  /// author
  /// </summary>
  private static String? GetAuthor(DXW.TableCellPropertiesChange openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Author);
  }
  
  private static bool CmpAuthor(DXW.TableCellPropertiesChange openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Author, value, diffs, objName, "Author");
  }
  
  private static void SetAuthor(DXW.TableCellPropertiesChange openXmlElement, String? value)
  {
    openXmlElement.Author = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// date
  /// </summary>
  private static DateTime? GetDate(DXW.TableCellPropertiesChange openXmlElement)
  {
    return openXmlElement?.Date?.Value;
  }
  
  private static bool CmpDate(DXW.TableCellPropertiesChange openXmlElement, DateTime? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.Date?.Value == value) return true;
    diffs?.Add(objName, "Date", openXmlElement?.Date?.Value, value);
    return false;
  }
  
  private static void SetDate(DXW.TableCellPropertiesChange openXmlElement, DateTime? value)
  {
    openXmlElement.Date = value;
  }
  
  /// <summary>
  /// Annotation Identifier
  /// </summary>
  private static String? GetId(DXW.TableCellPropertiesChange openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Id);
  }
  
  private static bool CmpId(DXW.TableCellPropertiesChange openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Id, value, diffs, objName, "Id");
  }
  
  private static void SetId(DXW.TableCellPropertiesChange openXmlElement, String? value)
  {
    openXmlElement.Id = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// Previous Table Cell Properties.
  /// </summary>
  private static DMW.PreviousTableCellProperties? GetPreviousTableCellProperties(DXW.TableCellPropertiesChange openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXW.PreviousTableCellProperties>();
    if (element != null)
      return DMXW.PreviousTableCellPropertiesConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpPreviousTableCellProperties(DXW.TableCellPropertiesChange openXmlElement, DMW.PreviousTableCellProperties? value, DiffList? diffs, string? objName)
  {
    return DMXW.PreviousTableCellPropertiesConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.PreviousTableCellProperties>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetPreviousTableCellProperties(DXW.TableCellPropertiesChange openXmlElement, DMW.PreviousTableCellProperties? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.PreviousTableCellProperties>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.PreviousTableCellPropertiesConverter.CreateOpenXmlElement<DXW.PreviousTableCellProperties>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DocumentModel.Wordprocessing.TableCellPropertiesChange? CreateModelElement(DXW.TableCellPropertiesChange? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Wordprocessing.TableCellPropertiesChange();
      value.Author = GetAuthor(openXmlElement);
      value.Date = GetDate(openXmlElement);
      value.Id = GetId(openXmlElement);
      value.PreviousTableCellProperties = GetPreviousTableCellProperties(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXW.TableCellPropertiesChange? openXmlElement, DMW.TableCellPropertiesChange? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpAuthor(openXmlElement, value.Author, diffs, objName))
        ok = false;
      if (!CmpDate(openXmlElement, value.Date, diffs, objName))
        ok = false;
      if (!CmpId(openXmlElement, value.Id, diffs, objName))
        ok = false;
      if (!CmpPreviousTableCellProperties(openXmlElement, value.PreviousTableCellProperties, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMW.TableCellPropertiesChange value)
    where OpenXmlElementType: DXW.TableCellPropertiesChange, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXW.TableCellPropertiesChange openXmlElement, DMW.TableCellPropertiesChange value)
  {
    SetAuthor(openXmlElement, value?.Author);
    SetDate(openXmlElement, value?.Date);
    SetId(openXmlElement, value?.Id);
    SetPreviousTableCellProperties(openXmlElement, value?.PreviousTableCellProperties);
  }
}
